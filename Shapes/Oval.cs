using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Transformations;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class Oval : Curvas
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }
        public double AnguloRotacion { get; set; }
        public double FactorEscala { get; set; }

        public Oval(Point position, Color color, double majorAxis, double minorAxis)
            : base(position, color)
        {
            MajorAxis = majorAxis;
            MinorAxis = minorAxis;
            AnguloRotacion = 0;
            FactorEscala = 1.0;
        }

        public override void Draw(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(111, 171, 129)))
            using (Pen pen = new Pen(Color.FromArgb(9, 77, 29), 3))
            using (GraphicsPath path = new GraphicsPath())
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                float height = (float)(MajorAxis * 10 * FactorEscala) * 2f;
                float width = (float)(MinorAxis * 10 * FactorEscala) * 2f * 0.75f;

                float x = -width / 2;
                float y = -height / 2;

                // CLAVE DEL HUEVO
                float topHeight = height * 1.05f;     // parte superior más larga (suave)
                float bottomHeight = height * 0.45f;  // parte inferior más redonda
                float bottomY = y + height - bottomHeight;

                path.StartFigure();
                // Parte superior (más estrecha)
                path.AddArc(new RectangleF(x, y, width, topHeight), 180f, 180f);
                // Parte inferior (más ancha)
                path.AddArc(new RectangleF(x, bottomY, width, bottomHeight), 0f, 180f);
                path.CloseFigure();

                // Guardar el estado del gráfico
                var state = g.Save();

                // Aplicar transformación: trasladar al centro y rotar
                g.TranslateTransform(Position.X, Position.Y);
                g.RotateTransform((float)AnguloRotacion);

                g.FillPath(brush, path);
                g.DrawPath(pen, path);

                // Restaurar el estado del gráfico
                g.Restore(state);
            }
        }

        public override double GetArea()
        {
            double a = MinorAxis;
            double bTop = MajorAxis * 1.05;
            double bBottom = MajorAxis * 0.45;

            return Math.PI * a * (bTop + bBottom) / 2.0;
        }
        private double EllipsePerimeter(double a, double b)
        {
            double h = Math.Pow((a - b) / (a + b), 2);
            return Math.PI * (a + b) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }

        public override double GetPerimeter()
        {
            double a = MinorAxis;

            double bTop = MajorAxis * 1.05;
            double bBottom = MajorAxis * 0.45;

            double topArc = EllipsePerimeter(a, bTop) / 2.0;
            double bottomArc = EllipsePerimeter(a, bBottom) / 2.0;

            return topArc + bottomArc;
        }

        // Métodos de transformación

        public void Trasladar(int dx, int dy)
        {
            Position = Traslacion.TrasladarPunto(Position, dx, dy);
        }

        public void Escalar(double factor)
        {
            if (factor > 0)
            {
                FactorEscala *= factor;
            }
        }

        public void Rotar(double grados)
        {
            AnguloRotacion += grados;
        }
    }
}

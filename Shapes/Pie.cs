using System;
using System.Drawing;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Transformations;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Pie : Figure2D
    {
        public double Radius { get; set; }
        public double AngleDegrees { get; set; }
        public double AnguloRotacion { get; set; }
        public double FactorEscala { get; set; }

        public Pie(double radius, double angleDegrees, Point position, Color color)
            : base(position, color)
        {
            Radius = radius;
            AngleDegrees = angleDegrees;
            AnguloRotacion = 0;
            FactorEscala = 1.0;
        }

        public override double GetArea()
        {
            return (AngleDegrees / 360.0) * Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            double arc = (AngleDegrees / 360.0) * 2.0 * Math.PI * Radius;
            return arc + 2.0 * Radius;
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            float r = (float)(Radius * FactorEscala);

            using (Brush brush = new SolidBrush(Color))
            using (Pen pen = new Pen(Color.Black, 2))
            {
                var state = g.Save();

                g.TranslateTransform(Position.X, Position.Y);
                g.RotateTransform((float)AnguloRotacion);

                g.FillPie(brush, -r, -r, r * 2, r * 2, 0f, (float)AngleDegrees);
                g.DrawPie(pen, -r, -r, r * 2, r * 2, 0f, (float)AngleDegrees);

                g.Restore(state);
            }
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
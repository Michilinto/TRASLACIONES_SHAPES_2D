using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Transformations;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    public class Crescent : Figure2D
    {
        public double Radius { get; set; }
        public double AnguloRotacion { get; set; }
        public double FactorEscala { get; set; }

        public Crescent(double radius, Point position, Color color)
            : base(position, color)
        {
            Radius = radius;
            AnguloRotacion = 0;
            FactorEscala = 1.0;
        }

        public override double GetArea()
        {
            double innerR = Radius * 0.85;
            return Math.PI * Radius * Radius - Math.PI * innerR * innerR;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius + 2 * Math.PI * (Radius * 0.85);
        }

        public override void Draw(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float r = (float)(Radius * FactorEscala);
            float offset = r * 0.40f;

            // Proporciones para un corte estético
            float ir = r * 0.90f;

            // Definimos los rectángulos de los dos círculos
            RectangleF outerRect = new RectangleF(-r, -r, r * 2, r * 2);
            RectangleF innerRect = new RectangleF(offset - r, -ir, ir * 2, ir * 2);

            using (GraphicsPath path = new GraphicsPath())
            {
                // 1. Añadimos el arco exterior (la parte de atrás de la luna)
                // De 90 a 270 grados en sentido horario
                path.AddArc(outerRect, 65, 230);

                // 2. Añadimos el arco interior (el corte)
                // Se añade en sentido contrario para cerrar la silueta correctamente
                path.AddArc(innerRect, 275, -190);

                path.CloseFigure();

                GraphicsState state = g.Save();

                g.TranslateTransform(Position.X, Position.Y);
                g.RotateTransform((float)AnguloRotacion);

                using (Brush brush = new SolidBrush(Color))
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    // Rellenamos la silueta combinada
                    g.FillPath(brush, path);

                    // Dibujamos el borde SOLO de la silueta
                    g.DrawPath(pen, path);
                }

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
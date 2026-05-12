using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Transformations;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes
{
    class CCircle : Curvas
    {
        public double Radius { get; set; }
        public double AnguloRotacion { get; set; }
        public double FactorEscala { get; set; }

        public CCircle(Point position, Color color, double radius)
            : base(position, color)
        {
            Radius = radius;
            AnguloRotacion = 0;
            FactorEscala = 1.0;
        }

        public override void Draw(Graphics g)
        {
            double scale = 10;
            double radioEscalado = Radius * scale * FactorEscala;

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(111, 171, 129)))
            using (Pen pen = new Pen(Color.FromArgb(9, 77, 29), 3))
            {
                // Guardar el estado del gráfico
                var state = g.Save();

                // Aplicar transformación: trasladar al centro, rotar, y dibujar
                g.TranslateTransform(Position.X, Position.Y);
                g.RotateTransform((float)AnguloRotacion);

                // Dibujar desde el centro negativo (porque ya estamos trasladados)
                g.FillEllipse(brush, (float)(-radioEscalado), (float)(-radioEscalado), 
                    (float)(radioEscalado * 2), (float)(radioEscalado * 2));
                g.DrawEllipse(pen, (float)(-radioEscalado), (float)(-radioEscalado), 
                    (float)(radioEscalado * 2), (float)(radioEscalado * 2));

                // Restaurar el estado del gráfico
                g.Restore(state);
            }
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
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

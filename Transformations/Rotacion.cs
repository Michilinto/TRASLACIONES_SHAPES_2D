using System;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Transformations
{
    // Clase para rotar figuras
    // Fórmula (antihoraria): x' = x*cos(ángulo) - y*sin(ángulo)
    //                        y' = x*sin(ángulo) + y*cos(ángulo)
    public static class Rotacion
    {
        // Convierte grados a radianes
        public static double GradosARadianes(double grados)
        {
            return grados * Math.PI / 180.0;
        }

        // Rota un punto alrededor del origen
        public static Point RotarPunto(Point punto, double grados)
        {
            double radianes = GradosARadianes(grados);
            double cos = Math.Cos(radianes);
            double sin = Math.Sin(radianes);

            int nuevoX = (int)Math.Round(punto.X * cos - punto.Y * sin);
            int nuevoY = (int)Math.Round(punto.X * sin + punto.Y * cos);

            return new Point(nuevoX, nuevoY);
        }

        // Rota un arreglo de puntos alrededor del origen
        public static Point[] RotarPuntos(Point[] puntos, double grados)
        {
            Point[] puntosRotados = new Point[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosRotados[i] = RotarPunto(puntos[i], grados);
            }
            return puntosRotados;
        }

        // Rota un punto alrededor de un centro
        public static Point RotarPuntoDesdecentro(Point punto, Point centro, double grados)
        {
            double radianes = GradosARadianes(grados);
            double cos = Math.Cos(radianes);
            double sin = Math.Sin(radianes);

            // Trasladar al origen
            int relativeX = punto.X - centro.X;
            int relativeY = punto.Y - centro.Y;

            // Aplicar rotación
            int rotadoX = (int)Math.Round(relativeX * cos - relativeY * sin);
            int rotadoY = (int)Math.Round(relativeX * sin + relativeY * cos);

            // Trasladar de vuelta
            return new Point(rotadoX + centro.X, rotadoY + centro.Y);
        }

        // Rota un arreglo de puntos alrededor de un centro
        public static Point[] RotarPuntosDesdecentro(Point[] puntos, Point centro, double grados)
        {
            Point[] puntosRotados = new Point[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosRotados[i] = RotarPuntoDesdecentro(puntos[i], centro, grados);
            }
            return puntosRotados;
        }

        // Rota un punto flotante alrededor del origen
        public static PointF RotarPuntoF(PointF punto, double grados)
        {
            double radianes = GradosARadianes(grados);
            double cos = Math.Cos(radianes);
            double sin = Math.Sin(radianes);

            float nuevoX = (float)(punto.X * cos - punto.Y * sin);
            float nuevoY = (float)(punto.X * sin + punto.Y * cos);

            return new PointF(nuevoX, nuevoY);
        }

        // Rota un arreglo de puntos flotantes alrededor del origen
        public static PointF[] RotarPuntosF(PointF[] puntos, double grados)
        {
            PointF[] puntosRotados = new PointF[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosRotados[i] = RotarPuntoF(puntos[i], grados);
            }
            return puntosRotados;
        }

        // Rota un punto flotante alrededor de un centro
        public static PointF RotarPuntoFDesdecentro(PointF punto, PointF centro, double grados)
        {
            double radianes = GradosARadianes(grados);
            double cos = Math.Cos(radianes);
            double sin = Math.Sin(radianes);

            // Trasladar al origen
            float relativeX = punto.X - centro.X;
            float relativeY = punto.Y - centro.Y;

            // Aplicar rotación
            float rotadoX = (float)(relativeX * cos - relativeY * sin);
            float rotadoY = (float)(relativeX * sin + relativeY * cos);

            // Trasladar de vuelta
            return new PointF(rotadoX + centro.X, rotadoY + centro.Y);
        }

        // Rota un arreglo de puntos flotantes alrededor de un centro
        public static PointF[] RotarPuntosFDesdecentro(PointF[] puntos, PointF centro, double grados)
        {
            PointF[] puntosRotados = new PointF[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosRotados[i] = RotarPuntoFDesdecentro(puntos[i], centro, grados);
            }
            return puntosRotados;
        }
    }
}

using System;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Transformations
{
    // Clase para escalar (cambiar tamaño) figuras
    // Fórmula: x' = x * escala, y' = y * escala
    public static class Escala
    {
        // Escala un punto respecto a su posición
        public static Point EscalarPunto(Point punto, double escala)
        {
            return new Point(
                (int)Math.Round(punto.X * escala),
                (int)Math.Round(punto.Y * escala)
            );
        }

        // Escala un arreglo de puntos
        public static Point[] EscalarPuntos(Point[] puntos, double escala)
        {
            Point[] puntosEscalados = new Point[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosEscalados[i] = EscalarPunto(puntos[i], escala);
            }
            return puntosEscalados;
        }

        // Escala un punto respecto a un centro
        public static Point EscalarPuntoDesdecentro(Point punto, Point centro, double escala)
        {
            int relativeX = punto.X - centro.X;
            int relativeY = punto.Y - centro.Y;

            int escalatoX = (int)Math.Round(relativeX * escala);
            int escalatoY = (int)Math.Round(relativeY * escala);

            return new Point(escalatoX + centro.X, escalatoY + centro.Y);
        }

        // Escala un arreglo de puntos respecto a un centro
        public static Point[] EscalarPuntosDesdecentro(Point[] puntos, Point centro, double escala)
        {
            Point[] puntosEscalados = new Point[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosEscalados[i] = EscalarPuntoDesdecentro(puntos[i], centro, escala);
            }
            return puntosEscalados;
        }

        // Escala un punto flotante respecto a su posición
        public static PointF EscalarPuntoF(PointF punto, float escala)
        {
            return new PointF(
                punto.X * escala,
                punto.Y * escala
            );
        }

        // Escala un arreglo de puntos flotantes
        public static PointF[] EscalarPuntosF(PointF[] puntos, float escala)
        {
            PointF[] puntosEscalados = new PointF[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosEscalados[i] = EscalarPuntoF(puntos[i], escala);
            }
            return puntosEscalados;
        }

        // Escala un punto flotante respecto a un centro
        public static PointF EscalarPuntoFDesdecentro(PointF punto, PointF centro, float escala)
        {
            float relativeX = punto.X - centro.X;
            float relativeY = punto.Y - centro.Y;

            float escalatoX = relativeX * escala;
            float escalatoY = relativeY * escala;

            return new PointF(escalatoX + centro.X, escalatoY + centro.Y);
        }

        // Escala un arreglo de puntos flotantes respecto a un centro
        public static PointF[] EscalarPuntosFDesdecentro(PointF[] puntos, PointF centro, float escala)
        {
            PointF[] puntosEscalados = new PointF[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosEscalados[i] = EscalarPuntoFDesdecentro(puntos[i], centro, escala);
            }
            return puntosEscalados;
        }
    }
}

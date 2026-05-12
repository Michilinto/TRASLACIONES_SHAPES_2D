using System;
using System.Drawing;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Transformations
{
    // Clase para trasladar (mover) figuras
    // Fórmula: x' = x + dx, y' = y + dy
    public static class Traslacion
    {
        // Traslada un punto individual
        public static Point TrasladarPunto(Point punto, int dx, int dy)
        {
            return new Point(punto.X + dx, punto.Y + dy);
        }

        // Traslada un arreglo de puntos
        public static Point[] TrasladarPuntos(Point[] puntos, int dx, int dy)
        {
            Point[] puntosTrasladados = new Point[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosTrasladados[i] = TrasladarPunto(puntos[i], dx, dy);
            }
            return puntosTrasladados;
        }

        // Traslada un punto flotante
        public static PointF TrasladarPuntoF(PointF punto, float dx, float dy)
        {
            return new PointF(punto.X + dx, punto.Y + dy);
        }

        // Traslada un arreglo de puntos flotantes
        public static PointF[] TrasladarPuntosF(PointF[] puntos, float dx, float dy)
        {
            PointF[] puntosTrasladados = new PointF[puntos.Length];
            for (int i = 0; i < puntos.Length; i++)
            {
                puntosTrasladados[i] = TrasladarPuntoF(puntos[i], dx, dy);
            }
            return puntosTrasladados;
        }
    }
}

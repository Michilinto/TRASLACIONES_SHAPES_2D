using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmRegularPolygon : Form
    {
        RegularPolygon polygon;
        private int pasoTraslacion = 10;
        private int pasoRotacion = 5;
        private int pasoEscala = 5;

        public FrmRegularPolygon()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            picCanvas.Paint += picCanvas_Paint;
            btnCalcular.Click += btnCalcular_Click;
            btnClean.Click += btnClean_Click;

            // Configurar TrackBar
            tbEscala.Minimum = 5;
            tbEscala.Maximum = 50;
            tbEscala.Value = 10;
            tbEscala.TickStyle = TickStyle.TopLeft;
            tbEscala.Scroll += tbEscala_Scroll;

            // Habilitar eventos de teclado
            this.KeyPreview = true;
            this.KeyDown += FrmRegularPolygon_KeyDown;
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (polygon != null)
            {
                polygon.Draw(e.Graphics);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int lados = (int)nudSides.Value;

            if (!double.TryParse(txtRadio.Text, out double longitud) || longitud <= 0)
            {
                lblMessage.Text = "Ingrese una longitud válida mayor a 0";
                return;
            }

            polygon = new RegularPolygon(
                lados,
                longitud,
                new Point(picCanvas.Width / 2, picCanvas.Height / 2),
                Color.Black
            );

            lblPerimeter.Text = polygon.GetPerimeter().ToString("F2");
            lblArea.Text = polygon.GetArea().ToString("F2");

            lblMessage.Text = "Polígono generado correctamente";

            picCanvas.Invalidate();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            polygon = null;

            lblArea.Text = "...";
            lblPerimeter.Text = "...";
            lblMessage.Text = "Datos limpiados";
            tbEscala.Value = 10;

            picCanvas.Invalidate();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            picCanvas.Paint -= picCanvas_Paint;
            this.KeyDown -= FrmRegularPolygon_KeyDown;
            base.OnFormClosing(e);
        }

        // Manejo de eventos de teclado para transformaciones
        private void FrmRegularPolygon_KeyDown(object sender, KeyEventArgs e)
        {
            if (polygon == null)
                return;

            switch (e.KeyCode)
            {
                // Trasladar con flechas
                case Keys.Up:
                    polygon.Trasladar(0, -pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Down:
                    polygon.Trasladar(0, pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Left:
                    polygon.Trasladar(-pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                case Keys.Right:
                    polygon.Trasladar(pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                // Rotar con A y D
                case Keys.A:
                    polygon.Rotar(pasoRotacion);
                    e.Handled = true;
                    break;

                case Keys.D:
                    polygon.Rotar(-pasoRotacion);
                    e.Handled = true;
                    break;
            }

            picCanvas.Invalidate();
        }

        // Manejo del TrackBar para escala
        private void tbEscala_Scroll(object sender, EventArgs e)
        {
            if (polygon == null)
                return;

            double nuevoValor = tbEscala.Value / 10.0;
            double valorActual = polygon.FactorEscala;

            if (valorActual > 0)
            {
                double factor = nuevoValor / valorActual;
                polygon.Escalar(factor);
                lblMessage.Text = "Escala: " + nuevoValor.ToString("F1") + "x";
            }

            picCanvas.Invalidate();
        }
    }
}

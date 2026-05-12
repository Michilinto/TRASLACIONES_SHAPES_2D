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
    public partial class FrmCircle : Form
    {
        private CCircle circle;
        private int pasoTraslacion = 10;
        private int pasoRotacion = 5;

        public FrmCircle()
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
            this.KeyDown += FrmCircle_KeyDown;
        }

        private void FrmCircle_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtRadius.Text, out double radius))
                {
                    lblMessage.Text = "Complete el campo correctamente";
                    return;
                }
                if (radius <= 0)
                {
                    lblMessage.Text = "El valor debe ser mayor a 0";
                    return;
                }
                Point position = new Point(150, 150);
                circle = new CCircle(position, Color.Orange, radius);
                lblArea.Text = circle.GetArea().ToString("F2");
                lblPerimeter.Text = circle.GetPerimeter().ToString("F2");
                lblMessage.Text = "Círculo calculado correctamente";
                picCanvas.Invalidate();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lblPerimeter.Text = "Perímetro: ";
            lblArea.Text = "Área: ";
            txtRadius.Text = "";
            circle = null;
            lblMessage.Text = "Campos limpiados";
            tbEscala.Value = 10;
            picCanvas.Invalidate();
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if(circle != null)
            {
                circle.Draw(e.Graphics);
            }
        }

        private void FrmCircle_KeyDown(object sender, KeyEventArgs e)
        {
            if (circle == null)
                return;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    circle.Trasladar(0, -pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Down:
                    circle.Trasladar(0, pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Left:
                    circle.Trasladar(-pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                case Keys.Right:
                    circle.Trasladar(pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                case Keys.A:
                    circle.Rotar(pasoRotacion);
                    e.Handled = true;
                    break;

                case Keys.D:
                    circle.Rotar(-pasoRotacion);
                    e.Handled = true;
                    break;
            }

            picCanvas.Invalidate();
        }

        private void tbEscala_Scroll(object sender, EventArgs e)
        {
            if (circle == null)
                return;

            double nuevoValor = tbEscala.Value / 10.0;
            double valorActual = circle.FactorEscala;

            if (valorActual > 0)
            {
                double factor = nuevoValor / valorActual;
                circle.Escalar(factor);
                lblMessage.Text = "Escala: " + nuevoValor.ToString("F1") + "x";
            }

            picCanvas.Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            picCanvas.Paint -= picCanvas_Paint;
            this.KeyDown -= FrmCircle_KeyDown;
            base.OnFormClosing(e);
        }
    }
}

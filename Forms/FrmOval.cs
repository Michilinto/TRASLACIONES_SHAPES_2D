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
    public partial class FrmOval : Form
    {
        private Oval oval;
        private int pasoTraslacion = 10;
        private int pasoRotacion = 5;

        public FrmOval()
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
            this.KeyDown += FrmOval_KeyDown;
        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (oval != null)
            {
                oval.Draw(e.Graphics);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double majorAxis, minorAxis;
                double altura = double.Parse(txtHeight.Text);
                double ancho = double.Parse(txtWidth.Text);
                if (altura > ancho)
                {
                    majorAxis = altura;
                    minorAxis = ancho;
                }
                else
                {
                    majorAxis = ancho;
                    minorAxis = altura;
                }

                if (majorAxis <= 0 || minorAxis <= 0)
                {
                    lblMessage.Text = "Los valores deben ser mayores a 0";
                    return;
                }
                Point position = new Point(150, 150);
                oval = new Oval(position, Color.Purple, majorAxis, minorAxis);
                lblArea.Text = oval.GetArea().ToString("F2");
                lblPerimeter.Text = oval.GetPerimeter().ToString("F2");
                lblMessage.Text = "Cálculo realizado exitosamente";
                picCanvas.Invalidate();
            }
            catch (FormatException)
            {
                lblMessage.Text = "Complete los campos correctamente";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWidth.Text = "";
            lblArea.Text = "...";
            lblPerimeter.Text = "...";
            oval = null;
            tbEscala.Value = 10;
            picCanvas.Invalidate();
        }

        private void FrmOval_KeyDown(object sender, KeyEventArgs e)
        {
            if (oval == null)
                return;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    oval.Trasladar(0, -pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Down:
                    oval.Trasladar(0, pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Left:
                    oval.Trasladar(-pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                case Keys.Right:
                    oval.Trasladar(pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                case Keys.A:
                    oval.Rotar(pasoRotacion);
                    e.Handled = true;
                    break;

                case Keys.D:
                    oval.Rotar(-pasoRotacion);
                    e.Handled = true;
                    break;
            }

            picCanvas.Invalidate();
        }

        private void tbEscala_Scroll(object sender, EventArgs e)
        {
            if (oval == null)
                return;

            double nuevoValor = tbEscala.Value / 10.0;
            double valorActual = oval.FactorEscala;

            if (valorActual > 0)
            {
                double factor = nuevoValor / valorActual;
                oval.Escalar(factor);
                lblMessage.Text = "Escala: " + nuevoValor.ToString("F1") + "x";
            }

            picCanvas.Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            picCanvas.Paint -= picCanvas_Paint;
            this.KeyDown -= FrmOval_KeyDown;
            base.OnFormClosing(e);
        }
    }
}

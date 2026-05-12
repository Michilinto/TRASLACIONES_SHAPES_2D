using System;
using System.Drawing;
using System.Windows.Forms;
using SHAPES_2D_BOLANOS_FLORES_VENEGAS.Shapes;

namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    public partial class FrmPie : Form
    {
        private Pie _shape = null;
        private int pasoTraslacion = 10;
        private int pasoRotacion = 5;

        public FrmPie()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            pnlCanvas.Paint += PnlCanvas_Paint;
            btnCalc.Click += btnCalc_Click;
            btnClear.Click += btnClear_Click;

            // Configurar TrackBar
            tbEscala.Minimum = 5;
            tbEscala.Maximum = 50;
            tbEscala.Value = 10;
            tbEscala.TickStyle = TickStyle.TopLeft;
            tbEscala.Scroll += tbEscala_Scroll;

            // Habilitar eventos de teclado
            this.KeyPreview = true;
            this.KeyDown += FrmPie_KeyDown;
        }

        private void PnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            _shape?.Draw(e.Graphics);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            if (!double.TryParse(txRadius.Text, out double r) || r <= 0)
            {
                lblError.Text = "⚠ El radio debe ser un número positivo.";
                return;
            }
            if (!double.TryParse(txAngle.Text, out double angle) || angle <= 0 || angle > 360)
            {
                lblError.Text = "⚠ El ángulo debe estar entre 1° y 360°.";
                return;
            }

            double maxFit = (Math.Min(pnlCanvas.Width, pnlCanvas.Height) - 40.0) / 2.0;
            double scale = maxFit / r;
            double sr = r * scale;

            // Usar el centro del panel como posición
            int posX = pnlCanvas.Width / 2;
            int posY = pnlCanvas.Height / 2;

            _shape = new Pie(sr, angle,
                         new Point(posX, posY),
                         Color.FromArgb(205, 133, 63));

            var real = new Pie(r, angle, new Point(0, 0), Color.White);
            lblPerimeter.Text = $"{real.GetPerimeter():F2}";
            lblArea.Text = $"{real.GetArea():F2}";

            pnlCanvas.Invalidate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txRadius.Clear();
            txAngle.Clear();
            lblPerimeter.Text = "...";
            lblArea.Text = "...";
            lblError.Text = "";
            _shape = null;
            tbEscala.Value = 10;
            pnlCanvas.Invalidate();
        }

        private void FrmPie_KeyDown(object sender, KeyEventArgs e)
        {
            if (_shape == null)
                return;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    _shape.Trasladar(0, -pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Down:
                    _shape.Trasladar(0, pasoTraslacion);
                    e.Handled = true;
                    break;

                case Keys.Left:
                    _shape.Trasladar(-pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                case Keys.Right:
                    _shape.Trasladar(pasoTraslacion, 0);
                    e.Handled = true;
                    break;

                case Keys.A:
                    _shape.Rotar(pasoRotacion);
                    e.Handled = true;
                    break;

                case Keys.D:
                    _shape.Rotar(-pasoRotacion);
                    e.Handled = true;
                    break;
            }

            pnlCanvas.Invalidate();
        }

        private void tbEscala_Scroll(object sender, EventArgs e)
        {
            if (_shape == null)
                return;

            double nuevoValor = tbEscala.Value / 10.0;
            double valorActual = _shape.FactorEscala;

            if (valorActual > 0)
            {
                double factor = nuevoValor / valorActual;
                _shape.Escalar(factor);
                lblError.Text = "Escala: " + nuevoValor.ToString("F1") + "x";
            }

            pnlCanvas.Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            pnlCanvas.Paint -= PnlCanvas_Paint;
            this.KeyDown -= FrmPie_KeyDown;
            base.OnFormClosing(e);
        }
    }
}
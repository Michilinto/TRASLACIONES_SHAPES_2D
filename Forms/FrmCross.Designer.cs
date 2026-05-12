namespace SHAPES_2D_BOLANOS_FLORES_VENEGAS.Forms
{
    partial class FrmCross
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblError = new System.Windows.Forms.Label();
            this.pnlCanvas = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblSubtitle3 = new System.Windows.Forms.Label();
            this.lblSubtitle4 = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txSize = new System.Windows.Forms.TextBox();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.txArm = new System.Windows.Forms.TextBox();
            this.lblSubtitle2 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCanvas)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblError.Location = new System.Drawing.Point(20, 62);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(25, 22);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "...";
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.pnlCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCanvas.Location = new System.Drawing.Point(15, 91);
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(540, 420);
            this.pnlCanvas.TabIndex = 14;
            this.pnlCanvas.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnCalc);
            this.panel2.Controls.Add(this.pnlResults);
            this.panel2.Controls.Add(this.lblTitle2);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(608, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 511);
            this.panel2.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(90, 400);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(98)))), ((int)(((byte)(69)))));
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCalc.Location = new System.Drawing.Point(90, 341);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(106, 34);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pnlResults
            // 
            this.pnlResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.pnlResults.Controls.Add(this.lblArea);
            this.pnlResults.Controls.Add(this.lblPerimeter);
            this.pnlResults.Controls.Add(this.lblSubtitle3);
            this.pnlResults.Controls.Add(this.lblSubtitle4);
            this.pnlResults.Location = new System.Drawing.Point(17, 218);
            this.pnlResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(263, 99);
            this.pnlResults.TabIndex = 6;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(78, 56);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(25, 22);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "...";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(125, 14);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(25, 22);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "...";
            // 
            // lblSubtitle3
            // 
            this.lblSubtitle3.AutoSize = true;
            this.lblSubtitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle3.Location = new System.Drawing.Point(9, 14);
            this.lblSubtitle3.Name = "lblSubtitle3";
            this.lblSubtitle3.Size = new System.Drawing.Size(102, 22);
            this.lblSubtitle3.TabIndex = 0;
            this.lblSubtitle3.Text = "Perímetro:";
            // 
            // lblSubtitle4
            // 
            this.lblSubtitle4.AutoSize = true;
            this.lblSubtitle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle4.Location = new System.Drawing.Point(9, 56);
            this.lblSubtitle4.Name = "lblSubtitle4";
            this.lblSubtitle4.Size = new System.Drawing.Size(58, 22);
            this.lblSubtitle4.TabIndex = 2;
            this.lblSubtitle4.Text = "Área:";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblTitle2.Location = new System.Drawing.Point(24, 178);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(104, 26);
            this.lblTitle2.TabIndex = 6;
            this.lblTitle2.Text = "Cálculos";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(74, 26);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Datos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.txSize);
            this.panel3.Controls.Add(this.lblSubtitle);
            this.panel3.Controls.Add(this.txArm);
            this.panel3.Controls.Add(this.lblSubtitle2);
            this.panel3.Location = new System.Drawing.Point(17, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 99);
            this.panel3.TabIndex = 5;
            // 
            // txSize
            // 
            this.txSize.Location = new System.Drawing.Point(161, 14);
            this.txSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSize.Name = "txSize";
            this.txSize.Size = new System.Drawing.Size(90, 26);
            this.txSize.TabIndex = 4;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle.Location = new System.Drawing.Point(9, 14);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(140, 22);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Tamaño Total:";
            // 
            // txArm
            // 
            this.txArm.Location = new System.Drawing.Point(161, 58);
            this.txArm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txArm.Name = "txArm";
            this.txArm.Size = new System.Drawing.Size(90, 26);
            this.txArm.TabIndex = 3;
            // 
            // lblSubtitle2
            // 
            this.lblSubtitle2.AutoSize = true;
            this.lblSubtitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSubtitle2.Location = new System.Drawing.Point(9, 56);
            this.lblSubtitle2.Name = "lblSubtitle2";
            this.lblSubtitle2.Size = new System.Drawing.Size(129, 22);
            this.lblSubtitle2.TabIndex = 2;
            this.lblSubtitle2.Text = "Ancho Brazo:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 51);
            this.pnlHeader.TabIndex = 15;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(19, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 29);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Cruz";
            // 
            // FrmCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCross";
            this.Text = "FrmCross";
            ((System.ComponentModel.ISupportInitialize)(this.pnlCanvas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox pnlCanvas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblSubtitle3;
        private System.Windows.Forms.Label lblSubtitle4;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txSize;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TextBox txArm;
        private System.Windows.Forms.Label lblSubtitle2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
    }
}
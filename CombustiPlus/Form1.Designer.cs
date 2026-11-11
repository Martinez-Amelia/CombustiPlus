namespace CombustiPlus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpNuevoDespacho = new GroupBox();
            btnDespachar = new Button();
            btnCotizar = new Button();
            cmbPago = new ComboBox();
            nudGalones = new NumericUpDown();
            cmbCombustible = new ComboBox();
            txtPlaca = new TextBox();
            lblPago = new Label();
            lblGalones = new Label();
            lblCombustible = new Label();
            lblPlaca = new Label();
            grpDetalle = new GroupBox();
            lstDetalle = new ListBox();
            grpDespachos = new GroupBox();
            btnPorCombustible = new Button();
            lstDespachos = new ListBox();
            lblResumen = new Label();
            grpNuevoDespacho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).BeginInit();
            grpDetalle.SuspendLayout();
            grpDespachos.SuspendLayout();
            SuspendLayout();
            // 
            // grpNuevoDespacho
            // 
            grpNuevoDespacho.Controls.Add(btnDespachar);
            grpNuevoDespacho.Controls.Add(btnCotizar);
            grpNuevoDespacho.Controls.Add(cmbPago);
            grpNuevoDespacho.Controls.Add(nudGalones);
            grpNuevoDespacho.Controls.Add(cmbCombustible);
            grpNuevoDespacho.Controls.Add(txtPlaca);
            grpNuevoDespacho.Controls.Add(lblPago);
            grpNuevoDespacho.Controls.Add(lblGalones);
            grpNuevoDespacho.Controls.Add(lblCombustible);
            grpNuevoDespacho.Controls.Add(lblPlaca);
            grpNuevoDespacho.Location = new Point(12, 12);
            grpNuevoDespacho.Name = "grpNuevoDespacho";
            grpNuevoDespacho.Size = new Size(379, 241);
            grpNuevoDespacho.TabIndex = 0;
            grpNuevoDespacho.TabStop = false;
            grpNuevoDespacho.Text = "Nuevo despacho";
            // 
            // btnDespachar
            // 
            btnDespachar.Location = new Point(198, 197);
            btnDespachar.Name = "btnDespachar";
            btnDespachar.Size = new Size(150, 35);
            btnDespachar.TabIndex = 8;
            btnDespachar.Text = "Despachar";
            btnDespachar.UseVisualStyleBackColor = true;
            btnDespachar.Click += button2_Click;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(23, 197);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(147, 35);
            btnCotizar.TabIndex = 0;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            // 
            // cmbPago
            // 
            cmbPago.FormattingEnabled = true;
            cmbPago.Location = new Point(83, 154);
            cmbPago.Name = "cmbPago";
            cmbPago.Size = new Size(265, 28);
            cmbPago.TabIndex = 7;
            // 
            // nudGalones
            // 
            nudGalones.Location = new Point(83, 108);
            nudGalones.Name = "nudGalones";
            nudGalones.Size = new Size(122, 27);
            nudGalones.TabIndex = 6;
            // 
            // cmbCombustible
            // 
            cmbCombustible.FormattingEnabled = true;
            cmbCombustible.Location = new Point(114, 64);
            cmbCombustible.Name = "cmbCombustible";
            cmbCombustible.Size = new Size(234, 28);
            cmbCombustible.TabIndex = 5;
            cmbCombustible.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(83, 26);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(265, 27);
            txtPlaca.TabIndex = 4;
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(14, 154);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(45, 20);
            lblPago.TabIndex = 3;
            lblPago.Text = "Pago:";
            // 
            // lblGalones
            // 
            lblGalones.AutoSize = true;
            lblGalones.Location = new Point(12, 108);
            lblGalones.Name = "lblGalones";
            lblGalones.Size = new Size(65, 20);
            lblGalones.TabIndex = 2;
            lblGalones.Text = "Galones:";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Location = new Point(12, 67);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(96, 20);
            lblCombustible.TabIndex = 1;
            lblCombustible.Text = "Combustible:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(14, 33);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(47, 20);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "Placa:";
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(lstDetalle);
            grpDetalle.Location = new Point(13, 259);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(381, 179);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle";
            // 
            // lstDetalle
            // 
            lstDetalle.FormattingEnabled = true;
            lstDetalle.Location = new Point(6, 26);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(362, 144);
            lstDetalle.TabIndex = 0;
            lstDetalle.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // grpDespachos
            // 
            grpDespachos.Controls.Add(btnPorCombustible);
            grpDespachos.Controls.Add(lstDespachos);
            grpDespachos.Location = new Point(397, 12);
            grpDespachos.Name = "grpDespachos";
            grpDespachos.Size = new Size(451, 335);
            grpDespachos.TabIndex = 2;
            grpDespachos.TabStop = false;
            grpDespachos.Text = "Despachos del dia";
            // 
            // btnPorCombustible
            // 
            btnPorCombustible.Location = new Point(6, 296);
            btnPorCombustible.Name = "btnPorCombustible";
            btnPorCombustible.Size = new Size(221, 29);
            btnPorCombustible.TabIndex = 1;
            btnPorCombustible.Text = "Galones por combustibles";
            btnPorCombustible.UseVisualStyleBackColor = true;
            // 
            // lstDespachos
            // 
            lstDespachos.FormattingEnabled = true;
            lstDespachos.Location = new Point(6, 26);
            lstDespachos.Name = "lstDespachos";
            lstDespachos.Size = new Size(439, 264);
            lstDespachos.TabIndex = 0;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(403, 363);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(50, 20);
            lblResumen.TabIndex = 3;
            lblResumen.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(lblResumen);
            Controls.Add(grpDespachos);
            Controls.Add(grpDetalle);
            Controls.Add(grpNuevoDespacho);
            Name = "Form1";
            Text = "CombustiPlus — Estacion Bavaro ";
            grpNuevoDespacho.ResumeLayout(false);
            grpNuevoDespacho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGalones).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDespachos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox gbxNuevoDespacho;
        private Label lblCombustible;
        private GroupBox grpNuevoDespacho;
        private Label lblPlaca;
        private TextBox txtPlaca;
        private Label lblPago;
        private Label lblGalones;
        private ComboBox cmbCombustible;
        private ComboBox cmbPago;
        private NumericUpDown nudGalones;
        private Button button1;
        private Button btnDespachar;
        private Button btnCotizar;
        private GroupBox grpDetalle;
        private ListBox lstDetalle;
        private GroupBox grpDespachos;
        private ListBox lstDespachos;
        private Button btnPorCombustible;
        private Label lblResumen;
    }
}

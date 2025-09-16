namespace pryDiFiniSintepart
{
    partial class frmBienvenido
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
            lblTitulo = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(31, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(643, 81);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido al sistema";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(237, 186);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(160, 57);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmBienvenido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 327);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Name = "frmBienvenido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAceptar;
    }
}

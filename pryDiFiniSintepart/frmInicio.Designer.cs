namespace pryDiFiniSintepart
{
    partial class Inicio
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblModulo = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmbModulo = new ComboBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(58, 60);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(94, 31);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(58, 128);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(131, 31);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModulo.Location = new Point(58, 201);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(96, 31);
            lblModulo.TabIndex = 2;
            lblModulo.Text = "Modulo";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.Blue;
            txtUsuario.Location = new Point(250, 64);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(250, 132);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(125, 27);
            txtContraseña.TabIndex = 4;
            // 
            // cmbModulo
            // 
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cmbModulo.Location = new Point(250, 207);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(125, 28);
            cmbModulo.TabIndex = 5;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(466, 65);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(132, 29);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(466, 133);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 277);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbModulo);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblModulo);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInicio";
            Load += Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblModulo;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ComboBox cmbModulo;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
namespace EnfignaServidor.Vistas
{
    partial class registro
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
            buttonEntrarJuego = new Button();
            groupBox2 = new GroupBox();
            inputPassword = new TextBox();
            inputUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEntrarJuego
            // 
            buttonEntrarJuego.BackColor = Color.FromArgb(255, 128, 0);
            buttonEntrarJuego.Location = new Point(238, 226);
            buttonEntrarJuego.Margin = new Padding(3, 4, 3, 4);
            buttonEntrarJuego.Name = "buttonEntrarJuego";
            buttonEntrarJuego.Size = new Size(159, 57);
            buttonEntrarJuego.TabIndex = 2;
            buttonEntrarJuego.Text = "Entrar";
            buttonEntrarJuego.UseVisualStyleBackColor = false;
            buttonEntrarJuego.Click += buttonEntrarJuego_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(inputPassword);
            groupBox2.Controls.Add(buttonEntrarJuego);
            groupBox2.Controls.Add(inputUsuario);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(258, 191);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(642, 369);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(291, 138);
            inputPassword.Margin = new Padding(3, 4, 3, 4);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(160, 27);
            inputPassword.TabIndex = 3;
            // 
            // inputUsuario
            // 
            inputUsuario.Location = new Point(291, 77);
            inputUsuario.Margin = new Padding(3, 4, 3, 4);
            inputUsuario.Name = "inputUsuario";
            inputUsuario.Size = new Size(164, 27);
            inputUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(118, 121);
            label2.Name = "label2";
            label2.Size = new Size(167, 46);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(129, 60);
            label1.Name = "label1";
            label1.Size = new Size(140, 46);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pantalla_Registro;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1125, 705);
            Controls.Add(groupBox2);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "registro";
            Text = "registroPantalla";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEntrarJuego;
        private GroupBox groupBox2;
        public TextBox inputPassword;
        public TextBox inputUsuario;
        private Label label2;
        private Label label1;
    }
}
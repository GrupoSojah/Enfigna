namespace EnfignaServidor.Vistas
{
    partial class buton_CrearSala
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
            button1 = new Button();
            button_atras = new Button();
            textBox1 = new TextBox();
            checkBox_privada = new CheckBox();
            checkBox_Publica = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.boton_crear;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(505, 576);
            button1.Name = "button1";
            button1.Size = new Size(264, 63);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button_atras
            // 
            button_atras.BackgroundImage = Properties.Resources.boton_atras;
            button_atras.BackgroundImageLayout = ImageLayout.Stretch;
            button_atras.FlatAppearance.BorderSize = 0;
            button_atras.FlatStyle = FlatStyle.Flat;
            button_atras.Location = new Point(32, 16);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(134, 70);
            button_atras.TabIndex = 2;
            button_atras.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 0);
            textBox1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(488, 285);
            textBox1.MaximumSize = new Size(900, 300);
            textBox1.MinimumSize = new Size(200, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 60);
            textBox1.TabIndex = 3;
            // 
            // checkBox_privada
            // 
            checkBox_privada.AutoSize = true;
            checkBox_privada.BackColor = Color.Transparent;
            checkBox_privada.Location = new Point(362, 402);
            checkBox_privada.Name = "checkBox_privada";
            checkBox_privada.Size = new Size(18, 17);
            checkBox_privada.TabIndex = 4;
            checkBox_privada.UseVisualStyleBackColor = false;
            // 
            // checkBox_Publica
            // 
            checkBox_Publica.AutoSize = true;
            checkBox_Publica.BackColor = Color.Transparent;
            checkBox_Publica.Location = new Point(671, 402);
            checkBox_Publica.Name = "checkBox_Publica";
            checkBox_Publica.Size = new Size(18, 17);
            checkBox_Publica.TabIndex = 5;
            checkBox_Publica.UseVisualStyleBackColor = false;
            // 
            // buton_CrearSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_crealSala2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1306, 709);
            Controls.Add(checkBox_Publica);
            Controls.Add(checkBox_privada);
            Controls.Add(textBox1);
            Controls.Add(button_atras);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "buton_CrearSala";
            Text = "CrearSala";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button_nombre;
        private Button button_atras;
        private TextBox textBox1;
        private CheckBox checkBox_privada;
        private CheckBox checkBox_Publica;
    }
}
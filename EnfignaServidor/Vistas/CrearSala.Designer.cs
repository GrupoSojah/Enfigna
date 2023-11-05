namespace EnfignaServidor.Vistas
{
    partial class crearSala
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
            button_CrearSala = new Button();
            button_atras = new Button();
            textBoxNombreSala = new TextBox();
            checkBox_privada = new CheckBox();
            checkBox_Publica = new CheckBox();
            textBoxContaseña = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_CrearSala
            // 
            button_CrearSala.BackgroundImage = Properties.Resources.boton_crear;
            button_CrearSala.BackgroundImageLayout = ImageLayout.Stretch;
            button_CrearSala.FlatAppearance.BorderSize = 0;
            button_CrearSala.FlatStyle = FlatStyle.Flat;
            button_CrearSala.Location = new Point(402, 557);
            button_CrearSala.Name = "button_CrearSala";
            button_CrearSala.Size = new Size(262, 92);
            button_CrearSala.TabIndex = 0;
            button_CrearSala.UseVisualStyleBackColor = true;
            button_CrearSala.Click += buttonCrearSala_Click;
            // 
            // button_atras
            // 
            button_atras.BackgroundImage = Properties.Resources.boton_atras;
            button_atras.BackgroundImageLayout = ImageLayout.Stretch;
            button_atras.FlatAppearance.BorderSize = 0;
            button_atras.FlatStyle = FlatStyle.Flat;
            button_atras.Location = new Point(32, 16);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(135, 71);
            button_atras.TabIndex = 2;
            button_atras.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreSala
            // 
            textBoxNombreSala.BackColor = Color.FromArgb(255, 128, 0);
            textBoxNombreSala.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreSala.Location = new Point(402, 283);
            textBoxNombreSala.MaximumSize = new Size(900, 300);
            textBoxNombreSala.MinimumSize = new Size(201, 60);
            textBoxNombreSala.Name = "textBoxNombreSala";
            textBoxNombreSala.Size = new Size(262, 60);
            textBoxNombreSala.TabIndex = 3;
            textBoxNombreSala.TextChanged += textBoxNombreSala_TextChanged;
            // 
            // checkBox_privada
            // 
            checkBox_privada.AutoSize = true;
            checkBox_privada.BackColor = Color.Transparent;
            checkBox_privada.Location = new Point(307, 401);
            checkBox_privada.Name = "checkBox_privada";
            checkBox_privada.Size = new Size(18, 17);
            checkBox_privada.TabIndex = 4;
            checkBox_privada.UseVisualStyleBackColor = false;
            checkBox_privada.CheckedChanged += checkBox_privada_CheckedChanged;
            // 
            // checkBox_Publica
            // 
            checkBox_Publica.AutoSize = true;
            checkBox_Publica.BackColor = Color.Transparent;
            checkBox_Publica.Location = new Point(569, 401);
            checkBox_Publica.Name = "checkBox_Publica";
            checkBox_Publica.Size = new Size(18, 17);
            checkBox_Publica.TabIndex = 5;
            checkBox_Publica.UseVisualStyleBackColor = false;
            // 
            // textBoxContaseña
            // 
            textBoxContaseña.BackColor = Color.FromArgb(255, 128, 0);
            textBoxContaseña.Location = new Point(879, 283);
            textBoxContaseña.Margin = new Padding(2, 3, 2, 3);
            textBoxContaseña.MaximumSize = new Size(900, 300);
            textBoxContaseña.MinimumSize = new Size(201, 60);
            textBoxContaseña.Name = "textBoxContaseña";
            textBoxContaseña.Size = new Size(201, 60);
            textBoxContaseña.TabIndex = 6;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.IpAddress;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(707, 285);
            label1.Name = "label1";
            label1.Size = new Size(167, 46);
            label1.TabIndex = 7;
            label1.Text = "Password:";
            // 
            // crearSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_crealSala2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1091, 701);
            Controls.Add(label1);
            Controls.Add(textBoxContaseña);
            Controls.Add(checkBox_Publica);
            Controls.Add(checkBox_privada);
            Controls.Add(textBoxNombreSala);
            Controls.Add(button_atras);
            Controls.Add(button_CrearSala);
            DoubleBuffered = true;
            Name = "crearSala";
            Text = "CrearSala";
            Load += buton_CrearSala_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_CrearSala;
        private Button button_nombre;
        private Button button_atras;
        private TextBox textBoxNombreSala;
        private CheckBox checkBox_privada;
        private CheckBox checkBox_Publica;
        private TextBox textBoxContaseña;
        private Label label1;
    }
}
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
            SuspendLayout();
            // 
            // button_CrearSala
            // 
            button_CrearSala.BackgroundImage = Properties.Resources.boton_crear;
            button_CrearSala.BackgroundImageLayout = ImageLayout.Stretch;
            button_CrearSala.FlatAppearance.BorderSize = 0;
            button_CrearSala.FlatStyle = FlatStyle.Flat;
            button_CrearSala.Location = new Point(352, 418);
            button_CrearSala.Margin = new Padding(3, 2, 3, 2);
            button_CrearSala.Name = "button_CrearSala";
            button_CrearSala.Size = new Size(229, 69);
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
            button_atras.Location = new Point(28, 12);
            button_atras.Margin = new Padding(3, 2, 3, 2);
            button_atras.Name = "button_atras";
            button_atras.Size = new Size(118, 53);
            button_atras.TabIndex = 2;
            button_atras.UseVisualStyleBackColor = true;
            // 
            // textBoxNombreSala
            // 
            textBoxNombreSala.BackColor = Color.FromArgb(255, 128, 0);
            textBoxNombreSala.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombreSala.Location = new Point(352, 206);
            textBoxNombreSala.Margin = new Padding(3, 2, 3, 2);
            textBoxNombreSala.MaximumSize = new Size(788, 300);
            textBoxNombreSala.MinimumSize = new Size(176, 60);
            textBoxNombreSala.Name = "textBoxNombreSala";
            textBoxNombreSala.Size = new Size(255, 60);
            textBoxNombreSala.TabIndex = 3;
            textBoxNombreSala.TextChanged += textBoxNombreSala_TextChanged;
            // 
            // checkBox_privada
            // 
            checkBox_privada.AutoSize = true;
            checkBox_privada.BackColor = Color.Transparent;
            checkBox_privada.Location = new Point(269, 301);
            checkBox_privada.Margin = new Padding(3, 2, 3, 2);
            checkBox_privada.Name = "checkBox_privada";
            checkBox_privada.Size = new Size(15, 14);
            checkBox_privada.TabIndex = 4;
            checkBox_privada.UseVisualStyleBackColor = false;
            checkBox_privada.CheckedChanged += checkBox_privada_CheckedChanged;
            // 
            // checkBox_Publica
            // 
            checkBox_Publica.AutoSize = true;
            checkBox_Publica.BackColor = Color.Transparent;
            checkBox_Publica.Location = new Point(498, 301);
            checkBox_Publica.Margin = new Padding(3, 2, 3, 2);
            checkBox_Publica.Name = "checkBox_Publica";
            checkBox_Publica.Size = new Size(15, 14);
            checkBox_Publica.TabIndex = 5;
            checkBox_Publica.UseVisualStyleBackColor = false;
            // 
            // textBoxContaseña
            // 
            textBoxContaseña.Location = new Point(391, 344);
            textBoxContaseña.Margin = new Padding(2, 2, 2, 2);
            textBoxContaseña.Name = "textBoxContaseña";
            textBoxContaseña.Size = new Size(106, 23);
            textBoxContaseña.TabIndex = 6;
            // 
            // crearSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_crealSala2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(955, 526);
            Controls.Add(textBoxContaseña);
            Controls.Add(checkBox_Publica);
            Controls.Add(checkBox_privada);
            Controls.Add(textBoxNombreSala);
            Controls.Add(button_atras);
            Controls.Add(button_CrearSala);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
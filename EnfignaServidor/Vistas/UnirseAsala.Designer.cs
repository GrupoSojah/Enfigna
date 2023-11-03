namespace EnfignaServidor.Vistas
{
    partial class UnirseAsala
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
            button_Unirse = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.boton_atras_fondo_UNIRSE_A_SALA_;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(27, 22);
            button1.Name = "button1";
            button1.Size = new Size(123, 63);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button_Unirse
            // 
            button_Unirse.BackgroundImage = Properties.Resources.Captura_de_pantalla_2023_10_29_141743;
            button_Unirse.BackgroundImageLayout = ImageLayout.Stretch;
            button_Unirse.FlatAppearance.BorderSize = 0;
            button_Unirse.FlatStyle = FlatStyle.Flat;
            button_Unirse.Location = new Point(458, 525);
            button_Unirse.Name = "button_Unirse";
            button_Unirse.Size = new Size(278, 77);
            button_Unirse.TabIndex = 1;
            button_Unirse.UseVisualStyleBackColor = true;
            // 
            // UnirseAsala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_UnirseAsala;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1185, 656);
            Controls.Add(button_Unirse);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "UnirseAsala";
            Text = "UnirseAsala";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button_Unirse;
    }
}
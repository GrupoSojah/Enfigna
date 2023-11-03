namespace EnfignaServidor.Vistas
{
    partial class Tienda
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
            button_Tienda = new Button();
            button_comprar = new Button();
            SuspendLayout();
            // 
            // button_Tienda
            // 
            button_Tienda.BackgroundImage = Properties.Resources.boton_Atras_tienda_;
            button_Tienda.BackgroundImageLayout = ImageLayout.Stretch;
            button_Tienda.FlatAppearance.BorderSize = 0;
            button_Tienda.FlatStyle = FlatStyle.Flat;
            button_Tienda.Location = new Point(31, 19);
            button_Tienda.Name = "button_Tienda";
            button_Tienda.Size = new Size(117, 69);
            button_Tienda.TabIndex = 0;
            button_Tienda.UseVisualStyleBackColor = true;
            // 
            // button_comprar
            // 
            button_comprar.BackgroundImage = Properties.Resources.boton_comprar;
            button_comprar.BackgroundImageLayout = ImageLayout.Stretch;
            button_comprar.FlatAppearance.BorderSize = 0;
            button_comprar.FlatStyle = FlatStyle.Flat;
            button_comprar.Location = new Point(470, 548);
            button_comprar.Name = "button_comprar";
            button_comprar.Size = new Size(220, 44);
            button_comprar.TabIndex = 1;
            button_comprar.UseVisualStyleBackColor = true;
            // 
            // Tienda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_Tienda;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 641);
            Controls.Add(button_comprar);
            Controls.Add(button_Tienda);
            DoubleBuffered = true;
            Name = "Tienda";
            Text = "Tienda";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Tienda;
        private Button button_comprar;
    }
}
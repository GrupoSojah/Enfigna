namespace EnfignaServidor.Vistas
{
    partial class menuPrincipal
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
            button_confi = new Button();
            button_play = new Button();
            button_mazo = new Button();
            button_tienda = new Button();
            labelusuario = new Label();
            labelDinero = new Label();
            labelHalo = new Label();
            SuspendLayout();
            // 
            // button_confi
            // 
            button_confi.BackgroundImage = Properties.Resources.boton_confi;
            button_confi.BackgroundImageLayout = ImageLayout.Stretch;
            button_confi.FlatAppearance.BorderSize = 0;
            button_confi.FlatStyle = FlatStyle.Flat;
            button_confi.Location = new Point(1149, 641);
            button_confi.Margin = new Padding(4);
            button_confi.Name = "button_confi";
            button_confi.Size = new Size(108, 120);
            button_confi.TabIndex = 0;
            button_confi.UseVisualStyleBackColor = true;
            // 
            // button_play
            // 
            button_play.BackgroundImage = Properties.Resources.boton_play;
            button_play.BackgroundImageLayout = ImageLayout.Stretch;
            button_play.FlatAppearance.BorderSize = 0;
            button_play.FlatStyle = FlatStyle.Flat;
            button_play.Location = new Point(402, 312);
            button_play.Margin = new Padding(4);
            button_play.Name = "button_play";
            button_play.Size = new Size(459, 194);
            button_play.TabIndex = 1;
            button_play.UseVisualStyleBackColor = true;
            button_play.Click += button_play_Click;
            // 
            // button_mazo
            // 
            button_mazo.BackgroundImage = Properties.Resources.boton_mazo;
            button_mazo.BackgroundImageLayout = ImageLayout.Stretch;
            button_mazo.FlatAppearance.BorderSize = 0;
            button_mazo.FlatStyle = FlatStyle.Flat;
            button_mazo.Location = new Point(402, 514);
            button_mazo.Margin = new Padding(4);
            button_mazo.Name = "button_mazo";
            button_mazo.Size = new Size(352, 125);
            button_mazo.TabIndex = 2;
            button_mazo.UseVisualStyleBackColor = true;
            button_mazo.Click += button_mazo_Click;
            // 
            // button_tienda
            // 
            button_tienda.BackgroundImage = Properties.Resources.boton_tienda;
            button_tienda.BackgroundImageLayout = ImageLayout.Stretch;
            button_tienda.FlatAppearance.BorderSize = 0;
            button_tienda.FlatStyle = FlatStyle.Flat;
            button_tienda.Location = new Point(436, 661);
            button_tienda.Margin = new Padding(4);
            button_tienda.Name = "button_tienda";
            button_tienda.Size = new Size(256, 85);
            button_tienda.TabIndex = 3;
            button_tienda.UseVisualStyleBackColor = true;
            button_tienda.Click += button_tienda_Click;
            // 
            // labelusuario
            // 
            labelusuario.AutoSize = true;
            labelusuario.Location = new Point(1159, 36);
            labelusuario.Name = "labelusuario";
            labelusuario.Size = new Size(72, 25);
            labelusuario.TabIndex = 4;
            labelusuario.Text = "Usuario";
            // 
            // labelDinero
            // 
            labelDinero.AutoSize = true;
            labelDinero.Location = new Point(1159, 80);
            labelDinero.Name = "labelDinero";
            labelDinero.Size = new Size(22, 25);
            labelDinero.TabIndex = 5;
            labelDinero.Text = "$";
            // 
            // labelHalo
            // 
            labelHalo.AutoSize = true;
            labelHalo.Location = new Point(1159, 123);
            labelHalo.Name = "labelHalo";
            labelHalo.Size = new Size(49, 25);
            labelHalo.TabIndex = 6;
            labelHalo.Text = "Halo";
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2023_10_29_132000;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1258, 761);
            Controls.Add(labelHalo);
            Controls.Add(labelDinero);
            Controls.Add(labelusuario);
            Controls.Add(button_tienda);
            Controls.Add(button_mazo);
            Controls.Add(button_confi);
            Controls.Add(button_play);
            DoubleBuffered = true;
            Margin = new Padding(4);
            Name = "menuPrincipal";
            Text = "menuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_confi;
        private Button button_play;
        private Button button_mazo;
        private Button button_tienda;
        private Label labelusuario;
        private Label labelDinero;
        private Label labelHalo;
    }
}
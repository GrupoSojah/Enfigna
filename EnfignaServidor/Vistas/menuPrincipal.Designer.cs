﻿namespace EnfignaServidor.Vistas
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
            SuspendLayout();
            // 
            // button_confi
            // 
            button_confi.BackgroundImage = Properties.Resources.boton_confi;
            button_confi.BackgroundImageLayout = ImageLayout.Stretch;
            button_confi.FlatAppearance.BorderSize = 0;
            button_confi.FlatStyle = FlatStyle.Flat;
            button_confi.Location = new Point(919, 513);
            button_confi.Name = "button_confi";
            button_confi.Size = new Size(86, 96);
            button_confi.TabIndex = 0;
            button_confi.UseVisualStyleBackColor = true;
            // 
            // button_play
            // 
            button_play.BackgroundImage = Properties.Resources.boton_play;
            button_play.BackgroundImageLayout = ImageLayout.Stretch;
            button_play.FlatAppearance.BorderSize = 0;
            button_play.FlatStyle = FlatStyle.Flat;
            button_play.Location = new Point(322, 250);
            button_play.Name = "button_play";
            button_play.Size = new Size(367, 155);
            button_play.TabIndex = 1;
            button_play.UseVisualStyleBackColor = true;
            // 
            // button_mazo
            // 
            button_mazo.BackgroundImage = Properties.Resources.boton_mazo;
            button_mazo.BackgroundImageLayout = ImageLayout.Stretch;
            button_mazo.FlatAppearance.BorderSize = 0;
            button_mazo.FlatStyle = FlatStyle.Flat;
            button_mazo.Location = new Point(322, 411);
            button_mazo.Name = "button_mazo";
            button_mazo.Size = new Size(282, 100);
            button_mazo.TabIndex = 2;
            button_mazo.UseVisualStyleBackColor = true;
            // 
            // button_tienda
            // 
            button_tienda.BackgroundImage = Properties.Resources.boton_tienda;
            button_tienda.BackgroundImageLayout = ImageLayout.Stretch;
            button_tienda.FlatAppearance.BorderSize = 0;
            button_tienda.FlatStyle = FlatStyle.Flat;
            button_tienda.Location = new Point(349, 529);
            button_tienda.Name = "button_tienda";
            button_tienda.Size = new Size(205, 68);
            button_tienda.TabIndex = 3;
            button_tienda.UseVisualStyleBackColor = true;
            // 
            // menuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2023_10_29_132000;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 609);
            Controls.Add(button_tienda);
            Controls.Add(button_mazo);
            Controls.Add(button_confi);
            Controls.Add(button_play);
            Name = "menuPrincipal";
            Text = "menuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button button_confi;
        private Button button_play;
        private Button button_mazo;
        private Button button_tienda;
    }
}
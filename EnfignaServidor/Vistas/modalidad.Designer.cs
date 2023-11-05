namespace EnfignaServidor.Vistas
{
    partial class modalidad
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
            button_Unirse = new Button();
            button_Crear = new Button();
            button_Atras = new Button();
            labelUsuario = new Label();
            SuspendLayout();
            // 
            // button_Unirse
            // 
            button_Unirse.BackgroundImage = Properties.Resources.boton_unirse;
            button_Unirse.BackgroundImageLayout = ImageLayout.Stretch;
            button_Unirse.FlatAppearance.BorderSize = 0;
            button_Unirse.FlatStyle = FlatStyle.Flat;
            button_Unirse.Location = new Point(603, 278);
            button_Unirse.Margin = new Padding(3, 2, 3, 2);
            button_Unirse.Name = "button_Unirse";
            button_Unirse.Size = new Size(213, 70);
            button_Unirse.TabIndex = 0;
            button_Unirse.UseVisualStyleBackColor = true;
            button_Unirse.Click += button_Unirse_Click;
            // 
            // button_Crear
            // 
            button_Crear.BackgroundImage = Properties.Resources.boton_crear__2_;
            button_Crear.BackgroundImageLayout = ImageLayout.Stretch;
            button_Crear.FlatAppearance.BorderSize = 0;
            button_Crear.FlatStyle = FlatStyle.Flat;
            button_Crear.Location = new Point(168, 290);
            button_Crear.Margin = new Padding(3, 2, 3, 2);
            button_Crear.Name = "button_Crear";
            button_Crear.Size = new Size(183, 49);
            button_Crear.TabIndex = 1;
            button_Crear.UseVisualStyleBackColor = true;
            button_Crear.Click += button_Crear_Click;
            // 
            // button_Atras
            // 
            button_Atras.BackgroundImage = Properties.Resources.boton_Atras_modalidad_;
            button_Atras.BackgroundImageLayout = ImageLayout.Stretch;
            button_Atras.FlatAppearance.BorderSize = 0;
            button_Atras.FlatStyle = FlatStyle.Flat;
            button_Atras.Location = new Point(18, 17);
            button_Atras.Margin = new Padding(3, 2, 3, 2);
            button_Atras.Name = "button_Atras";
            button_Atras.Size = new Size(113, 46);
            button_Atras.TabIndex = 2;
            button_Atras.UseVisualStyleBackColor = true;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(900, 19);
            labelUsuario.Margin = new Padding(2, 0, 2, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(38, 15);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "label1";
            // 
            // modalidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_modalidad;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(955, 448);
            Controls.Add(labelUsuario);
            Controls.Add(button_Atras);
            Controls.Add(button_Crear);
            Controls.Add(button_Unirse);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "modalidad";
            Text = "modalidad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Unirse;
        private Button button_Crear;
        private Button button_Atras;
        private Label labelUsuario;
    }
}
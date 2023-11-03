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
            groupBox1 = new GroupBox();
            buttonModificar = new Button();
            buttonCrearCuenta = new Button();
            buttonEntrarJuego = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            inputModificar = new TextBox();
            inputPassword = new TextBox();
            inputUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvUsuarios = new DataGridView();
            layoutImagens = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            layoutImagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonModificar);
            groupBox1.Controls.Add(buttonCrearCuenta);
            groupBox1.Location = new Point(727, 85);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(174, 257);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Botones";
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(22, 181);
            buttonModificar.Margin = new Padding(3, 4, 3, 4);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(86, 31);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonCrearCuenta
            // 
            buttonCrearCuenta.Location = new Point(22, 29);
            buttonCrearCuenta.Margin = new Padding(3, 4, 3, 4);
            buttonCrearCuenta.Name = "buttonCrearCuenta";
            buttonCrearCuenta.Size = new Size(121, 31);
            buttonCrearCuenta.TabIndex = 0;
            buttonCrearCuenta.Text = "Crear Cuenta";
            buttonCrearCuenta.UseVisualStyleBackColor = true;
            buttonCrearCuenta.Click += buttonCrearCuenta_Click;
            // 
            // buttonEntrarJuego
            // 
            buttonEntrarJuego.Location = new Point(91, 115);
            buttonEntrarJuego.Margin = new Padding(3, 4, 3, 4);
            buttonEntrarJuego.Name = "buttonEntrarJuego";
            buttonEntrarJuego.Size = new Size(86, 31);
            buttonEntrarJuego.TabIndex = 2;
            buttonEntrarJuego.Text = "Entrar";
            buttonEntrarJuego.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(inputModificar);
            groupBox2.Controls.Add(inputPassword);
            groupBox2.Controls.Add(buttonEntrarJuego);
            groupBox2.Controls.Add(inputUsuario);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(26, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(434, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 29);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Modifi";
            // 
            // inputModificar
            // 
            inputModificar.Location = new Point(296, 25);
            inputModificar.Margin = new Padding(3, 4, 3, 4);
            inputModificar.Name = "inputModificar";
            inputModificar.Size = new Size(114, 27);
            inputModificar.TabIndex = 4;
            // 
            // inputPassword
            // 
            inputPassword.Location = new Point(75, 69);
            inputPassword.Margin = new Padding(3, 4, 3, 4);
            inputPassword.Name = "inputPassword";
            inputPassword.Size = new Size(114, 27);
            inputPassword.TabIndex = 3;
            // 
            // inputUsuario
            // 
            inputUsuario.Location = new Point(75, 21);
            inputUsuario.Margin = new Padding(3, 4, 3, 4);
            inputUsuario.Name = "inputUsuario";
            inputUsuario.Size = new Size(114, 27);
            inputUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 69);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "usuario";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(596, 364);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(274, 200);
            dgvUsuarios.TabIndex = 4;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // layoutImagens
            // 
            layoutImagens.Controls.Add(pictureBox1);
            layoutImagens.Controls.Add(pictureBox2);
            layoutImagens.Controls.Add(flowLayoutPanel1);
            layoutImagens.Location = new Point(30, 301);
            layoutImagens.Margin = new Padding(3, 4, 3, 4);
            layoutImagens.Name = "layoutImagens";
            layoutImagens.Size = new Size(353, 224);
            layoutImagens.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 197);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(185, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 197);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 208);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(layoutImagens);
            Controls.Add(dgvUsuarios);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "registro";
            Text = "registroPantalla";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            layoutImagens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonEntrarJuego;
        private Button buttonModificar;
        private Button buttonCrearCuenta;
        private GroupBox groupBox2;
        private TextBox inputPassword;
        private TextBox inputUsuario;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox inputModificar;
        private DataGridView dgvUsuarios;
        private FlowLayoutPanel layoutImagens;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
namespace PayrollSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_ingresar = new Button();
            label3 = new Label();
            text_password = new TextBox();
            label2 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            text_usuario = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btn_clean_inicio_sesion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.Navy;
            btn_ingresar.FlatAppearance.BorderSize = 2;
            btn_ingresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.ForeColor = Color.White;
            btn_ingresar.Location = new Point(621, 783);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(173, 50);
            btn_ingresar.TabIndex = 5;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(826, 686);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 4;
            label3.Text = "Olvidé la contraseña";
            // 
            // text_password
            // 
            text_password.Location = new Point(614, 638);
            text_password.Name = "text_password";
            text_password.PasswordChar = '*';
            text_password.Size = new Size(375, 30);
            text_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(614, 596);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(967, 185);
            button2.Name = "button2";
            button2.Size = new Size(68, 53);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 576);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(418, 361);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(472, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(685, 289);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 949);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 91);
            label1.Name = "label1";
            label1.Size = new Size(241, 55);
            label1.TabIndex = 5;
            label1.Text = "!Bienvenido!";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(34, 246);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(366, 299);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // text_usuario
            // 
            text_usuario.Location = new Point(614, 531);
            text_usuario.Name = "text_usuario";
            text_usuario.Size = new Size(375, 30);
            text_usuario.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(614, 496);
            label4.Name = "label4";
            label4.Size = new Size(180, 21);
            label4.TabIndex = 6;
            label4.Text = "Nombre del Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(682, 393);
            label5.Name = "label5";
            label5.Size = new Size(214, 37);
            label5.TabIndex = 2;
            label5.Text = "Iniciar Sesión ";
            // 
            // btn_clean_inicio_sesion
            // 
            btn_clean_inicio_sesion.BackColor = Color.Navy;
            btn_clean_inicio_sesion.FlatAppearance.BorderSize = 2;
            btn_clean_inicio_sesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btn_clean_inicio_sesion.FlatStyle = FlatStyle.Flat;
            btn_clean_inicio_sesion.ForeColor = Color.White;
            btn_clean_inicio_sesion.Location = new Point(816, 783);
            btn_clean_inicio_sesion.Name = "btn_clean_inicio_sesion";
            btn_clean_inicio_sesion.Size = new Size(173, 50);
            btn_clean_inicio_sesion.TabIndex = 8;
            btn_clean_inicio_sesion.Text = "Limpiar";
            btn_clean_inicio_sesion.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1193, 949);
            Controls.Add(btn_clean_inicio_sesion);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btn_ingresar);
            Controls.Add(text_usuario);
            Controls.Add(text_password);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox text_password;
        private Label label2;
        private Button btn_ingresar;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private TextBox text_usuario;
        private Label label4;
        private Label label5;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btn_clean_inicio_sesion;
    }
}

namespace PayrollSystem
{
    partial class Add_usuariocs
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_usuariocs));
            button1 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1_Usuarios = new DataGridView();
            conexionBindingSource1 = new BindingSource(components);
            conexionBindingSource = new BindingSource(components);
            button2 = new Button();
            label6 = new Label();
            text_password_usuario = new TextBox();
            label3 = new Label();
            button7 = new Button();
            text_nombre_usuario = new TextBox();
            label2 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txt_estado_usuario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Usuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(34, 33);
            button1.Name = "button1";
            button1.Size = new Size(68, 53);
            button1.TabIndex = 56;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Navy;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(529, 655);
            button5.Name = "button5";
            button5.Size = new Size(108, 45);
            button5.TabIndex = 71;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(777, 655);
            button3.Name = "button3";
            button3.Size = new Size(102, 45);
            button3.TabIndex = 70;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(652, 655);
            button4.Name = "button4";
            button4.Size = new Size(108, 45);
            button4.TabIndex = 69;
            button4.Text = "Modificar";
            button4.UseVisualStyleBackColor = false;
            // 
            // dataGridView1_Usuarios
            // 
            dataGridView1_Usuarios.AutoGenerateColumns = false;
            dataGridView1_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1_Usuarios.DataSource = conexionBindingSource1;
            dataGridView1_Usuarios.Location = new Point(86, 395);
            dataGridView1_Usuarios.Name = "dataGridView1_Usuarios";
            dataGridView1_Usuarios.RowHeadersWidth = 51;
            dataGridView1_Usuarios.Size = new Size(793, 237);
            dataGridView1_Usuarios.TabIndex = 68;
            // 
            // conexionBindingSource1
            // 
            conexionBindingSource1.DataSource = typeof(Conexion);
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Conexion);
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(508, 317);
            button2.Name = "button2";
            button2.Size = new Size(102, 45);
            button2.TabIndex = 67;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 253);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 64;
            label6.Text = "Estado:";
            // 
            // text_password_usuario
            // 
            text_password_usuario.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_password_usuario.Location = new Point(260, 204);
            text_password_usuario.Name = "text_password_usuario";
            text_password_usuario.Size = new Size(490, 30);
            text_password_usuario.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 207);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 61;
            label3.Text = "Contraseña:";
            // 
            // button7
            // 
            button7.BackColor = Color.Lime;
            button7.FlatAppearance.BorderSize = 2;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(367, 317);
            button7.Name = "button7";
            button7.Size = new Size(102, 45);
            button7.TabIndex = 60;
            button7.Text = "Guardar";
            button7.UseVisualStyleBackColor = false;
            // 
            // text_nombre_usuario
            // 
            text_nombre_usuario.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_nombre_usuario.Location = new Point(260, 156);
            text_nombre_usuario.Name = "text_nombre_usuario";
            text_nombre_usuario.Size = new Size(490, 30);
            text_nombre_usuario.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(170, 158);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 58;
            label2.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(375, 46);
            label5.Name = "label5";
            label5.Size = new Size(147, 40);
            label5.TabIndex = 57;
            label5.Text = "Usuarios";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 10);
            panel1.TabIndex = 72;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(943, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 730);
            panel2.TabIndex = 73;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 730);
            panel3.TabIndex = 74;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(10, 730);
            panel4.Name = "panel4";
            panel4.Size = new Size(933, 10);
            panel4.TabIndex = 75;
            // 
            // txt_estado_usuario
            // 
            txt_estado_usuario.FormattingEnabled = true;
            txt_estado_usuario.Items.AddRange(new object[] { "Activo ", "Inactivo" });
            txt_estado_usuario.Location = new Point(260, 253);
            txt_estado_usuario.Name = "txt_estado_usuario";
            txt_estado_usuario.Size = new Size(490, 29);
            txt_estado_usuario.TabIndex = 76;
            // 
            // Add_usuariocs
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(953, 740);
            Controls.Add(txt_estado_usuario);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dataGridView1_Usuarios);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(text_password_usuario);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(text_nombre_usuario);
            Controls.Add(label2);
            Controls.Add(label5);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Add_usuariocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_usuariocs";
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Usuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button5;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1_Usuarios;
        private Button button2;
        private Label label6;
        private TextBox text_password_usuario;
        private Label label3;
        private Button button7;
        private TextBox text_nombre_usuario;
        private Label label2;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ComboBox txt_estado_usuario;
        private BindingSource conexionBindingSource;
        private BindingSource conexionBindingSource1;
    }
}
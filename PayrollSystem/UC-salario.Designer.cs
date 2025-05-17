namespace PayrollSystem
{
    partial class UC_salario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_salario));
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1588, 125);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(34, 28);
            button2.Name = "button2";
            button2.Size = new Size(146, 76);
            button2.TabIndex = 4;
            button2.Text = "Nuevo Rol";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 230);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 1;
            label1.Text = "Cédula Empleado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 226);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 30);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatAppearance.BorderColor = Color.Navy;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(526, 226);
            button1.Name = "button1";
            button1.Size = new Size(94, 35);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 173);
            label2.Name = "label2";
            label2.Size = new Size(364, 23);
            label2.TabIndex = 4;
            label2.Text = "Buscar nómina por cada empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(746, 235);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 5;
            label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(818, 229);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(259, 30);
            dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 352);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1507, 779);
            dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 315);
            label4.Name = "label4";
            label4.Size = new Size(166, 23);
            label4.TabIndex = 8;
            label4.Text = "Roles de Pagos ";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(1465, 187);
            button3.Name = "button3";
            button3.Size = new Size(74, 75);
            button3.TabIndex = 77;
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(1353, 187);
            button4.Name = "button4";
            button4.Size = new Size(77, 78);
            button4.TabIndex = 80;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderColor = Color.White;
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(1242, 192);
            button5.Name = "button5";
            button5.Size = new Size(77, 73);
            button5.TabIndex = 81;
            button5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1242, 279);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 82;
            label5.Text = "Eliminar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1468, 279);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 83;
            label6.Text = "Impirmir";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1359, 279);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 84;
            label7.Text = "Limpiar";
            // 
            // UC_salario
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_salario";
            Size = new Size(1600, 1165);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label4;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}

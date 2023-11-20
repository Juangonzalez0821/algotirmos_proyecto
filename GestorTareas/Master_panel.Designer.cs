namespace GestorTareas
{
    partial class Master_panel
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
            panel1 = new Panel();
            labelUserId = new Label();
            seeTask = new TabControl();
            tabPage1 = new TabPage();
            textBox3 = new TextBox();
            label6 = new Label();
            textTitle = new TextBox();
            label5 = new Label();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            label11 = new Label();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView3 = new DataGridView();
            textBox7 = new TextBox();
            label4 = new Label();
            label10 = new Label();
            button10 = new Button();
            label9 = new Label();
            button9 = new Button();
            textBox5 = new TextBox();
            button11 = new Button();
            label8 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            tabPage3 = new TabPage();
            textChangePass = new TextBox();
            textChangeUser = new TextBox();
            button12 = new Button();
            label3 = new Label();
            label2 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            seeTask.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 211, 188);
            panel1.Controls.Add(labelUserId);
            panel1.Controls.Add(seeTask);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1026, 584);
            panel1.TabIndex = 2;
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserId.Location = new Point(172, 18);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new Size(91, 30);
            labelUserId.TabIndex = 13;
            labelUserId.Text = "ID_User";
            labelUserId.Click += label5_Click;
            // 
            // seeTask
            // 
            seeTask.Controls.Add(tabPage1);
            seeTask.Controls.Add(tabPage2);
            seeTask.Controls.Add(tabPage3);
            seeTask.Location = new Point(216, 93);
            seeTask.Name = "seeTask";
            seeTask.SelectedIndex = 0;
            seeTask.Size = new Size(807, 491);
            seeTask.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(145, 213, 201);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textTitle);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 463);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Categorias";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(179, 240, 230);
            textBox3.Location = new Point(557, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(481, 160);
            label6.Name = "label6";
            label6.Size = new Size(260, 32);
            label6.TabIndex = 11;
            label6.Text = "ingrese el id de la categoria a eliminar o actualizar";
            label6.Click += label6_Click;
            // 
            // textTitle
            // 
            textTitle.BackColor = Color.FromArgb(179, 240, 230);
            textTitle.Location = new Point(557, 122);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(100, 23);
            textTitle.TabIndex = 10;
            textTitle.TextChanged += textTitle_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(581, 96);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Titulo";
            label5.Click += label5_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 36);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 8;
            label1.Text = "Tus categorias";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(187, 255, 248);
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(654, 236);
            button7.Name = "button7";
            button7.Size = new Size(90, 36);
            button7.TabIndex = 7;
            button7.Text = "Actualzar";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(187, 255, 248);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(569, 236);
            button6.Name = "button6";
            button6.Size = new Size(79, 39);
            button6.TabIndex = 6;
            button6.Text = "Eliminar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(187, 255, 248);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(481, 236);
            button5.Name = "button5";
            button5.Size = new Size(82, 39);
            button5.TabIndex = 5;
            button5.Text = "Crear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(333, 212);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(145, 213, 201);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(dataGridView3);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(button11);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 463);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tareas";
            tabPage2.Click += tabPage2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 38);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(535, 152);
            dataGridView2.TabIndex = 37;
            // 
            // label11
            // 
            label11.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(324, 346);
            label11.Name = "label11";
            label11.Size = new Size(231, 30);
            label11.TabIndex = 36;
            label11.Text = "ingrese el id de la tarea a eliminar o actualizar";
            label11.Click += label11_Click;
            // 
            // textBox6
            // 
            textBox6.AutoCompleteMode = AutoCompleteMode.Append;
            textBox6.BackColor = Color.FromArgb(179, 240, 230);
            textBox6.Location = new Point(335, 379);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 34;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(187, 255, 248);
            dateTimePicker1.Location = new Point(563, 227);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 23);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToOrderColumns = true;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 209);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(312, 212);
            dataGridView3.TabIndex = 32;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(179, 240, 230);
            textBox7.Location = new Point(593, 288);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 23);
            textBox7.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(243, 15);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 12;
            label4.Text = "Tus tareas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(623, 262);
            label10.Name = "label10";
            label10.Size = new Size(123, 15);
            label10.TabIndex = 30;
            label10.Text = "id de la categoria";
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(187, 255, 248);
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(359, 268);
            button10.Name = "button10";
            button10.Size = new Size(159, 43);
            button10.TabIndex = 21;
            button10.Text = "Crear Tarea";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(660, 209);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 28;
            label9.Text = "fecha";
            label9.Click += label9_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(187, 255, 248);
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(613, 335);
            button9.Name = "button9";
            button9.Size = new Size(159, 43);
            button9.TabIndex = 22;
            button9.Text = "Eliminar Tarea";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // textBox5
            // 
            textBox5.AutoCompleteMode = AutoCompleteMode.Append;
            textBox5.BackColor = Color.FromArgb(179, 240, 230);
            textBox5.Location = new Point(594, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 27;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(187, 255, 248);
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(613, 399);
            button11.Name = "button11";
            button11.Size = new Size(159, 43);
            button11.TabIndex = 23;
            button11.Text = "Atualizar Tarea";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(634, 69);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 26;
            label8.Text = "descripcion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(654, 15);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 24;
            label7.Text = "Titulo";
            label7.Click += label7_Click_1;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(179, 240, 230);
            textBox4.Location = new Point(594, 35);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 25;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(145, 213, 201);
            tabPage3.Controls.Add(textChangePass);
            tabPage3.Controls.Add(textChangeUser);
            tabPage3.Controls.Add(button12);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(799, 463);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Configuracion";
            // 
            // textChangePass
            // 
            textChangePass.AccessibleDescription = "";
            textChangePass.BackColor = Color.FromArgb(179, 240, 230);
            textChangePass.Location = new Point(310, 248);
            textChangePass.Name = "textChangePass";
            textChangePass.Size = new Size(208, 23);
            textChangePass.TabIndex = 12;
            // 
            // textChangeUser
            // 
            textChangeUser.AccessibleDescription = "";
            textChangeUser.BackColor = Color.FromArgb(179, 240, 230);
            textChangeUser.Location = new Point(310, 134);
            textChangeUser.Name = "textChangeUser";
            textChangeUser.Size = new Size(208, 23);
            textChangeUser.TabIndex = 11;
            textChangeUser.TextChanged += textChangeUser_TextChanged;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(187, 255, 248);
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(310, 310);
            button12.Name = "button12";
            button12.Size = new Size(208, 43);
            button12.TabIndex = 5;
            button12.Text = "Restablecer";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(348, 183);
            label3.Name = "label3";
            label3.Size = new Size(128, 30);
            label3.TabIndex = 1;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(371, 82);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 0;
            label2.Text = "Usuario";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(187, 255, 248);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(14, 277);
            button4.Name = "button4";
            button4.Size = new Size(180, 43);
            button4.TabIndex = 4;
            button4.Text = "Configuraciòn";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(187, 255, 248);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(14, 186);
            button3.Name = "button3";
            button3.Size = new Size(180, 43);
            button3.TabIndex = 3;
            button3.Text = "Tareas";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(187, 255, 248);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(14, 93);
            button2.Name = "button2";
            button2.Size = new Size(180, 43);
            button2.TabIndex = 2;
            button2.Text = "Categorias";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Master_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 579);
            Controls.Add(panel1);
            Name = "Master_panel";
            Text = "X";
            Load += Master_panel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            seeTask.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private TabControl seeTask;
        private TabPage tabPage1;
        private Label label1;
        private Button button7;
        private Button button6;
        private Button button5;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Label label4;
        private TabPage tabPage3;
        private TextBox textChangePass;
        private TextBox textChangeUser;
        private Button button12;
        private Label label3;
        private Label label2;
        private Label labelUserId;
        private TextBox textTitle;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox7;
        private Label label10;
        private Button button10;
        private Label label9;
        private Button button9;
        private TextBox textBox5;
        private Button button11;
        private Label label8;
        private Label label7;
        private TextBox textBox4;
        private DataGridView dataGridView3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox6;
        private Label label11;
        private DataGridView dataGridView2;
    }
}
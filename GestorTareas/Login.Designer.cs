namespace GestorTareas
{
    partial class Login
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
            registarUser = new Button();
            button1 = new Button();
            textPass = new TextBox();
            textUser = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 211, 188);
            panel1.Controls.Add(registarUser);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textPass);
            panel1.Controls.Add(textUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 382);
            panel1.TabIndex = 0;
            // 
            // registarUser
            // 
            registarUser.AccessibleRole = AccessibleRole.IpAddress;
            registarUser.BackColor = Color.FromArgb(187, 255, 248);
            registarUser.FlatAppearance.BorderColor = Color.DarkMagenta;
            registarUser.FlatAppearance.BorderSize = 3;
            registarUser.FlatStyle = FlatStyle.Popup;
            registarUser.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            registarUser.ForeColor = Color.Black;
            registarUser.Location = new Point(208, 299);
            registarUser.Name = "registarUser";
            registarUser.RightToLeft = RightToLeft.No;
            registarUser.Size = new Size(91, 34);
            registarUser.TabIndex = 13;
            registarUser.Text = "REGISTRAR";
            registarUser.UseVisualStyleBackColor = false;
            registarUser.Click += button2_Click;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.IpAddress;
            button1.BackColor = Color.FromArgb(187, 255, 248);
            button1.FlatAppearance.BorderColor = Color.DarkMagenta;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(98, 299);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(86, 34);
            button1.TabIndex = 12;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textPass
            // 
            textPass.BackColor = Color.FromArgb(179, 240, 230);
            textPass.Location = new Point(104, 198);
            textPass.Name = "textPass";
            textPass.Size = new Size(178, 23);
            textPass.TabIndex = 11;
            textPass.UseSystemPasswordChar = true;
            textPass.TextChanged += textPass_TextChanged;
            // 
            // textUser
            // 
            textUser.AccessibleDescription = "";
            textUser.BackColor = Color.FromArgb(179, 240, 230);
            textUser.Location = new Point(104, 151);
            textUser.Name = "textUser";
            textUser.Size = new Size(172, 23);
            textUser.TabIndex = 10;
            textUser.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(71, 211, 188);
            label1.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(144, 29);
            label1.Name = "label1";
            label1.Size = new Size(96, 34);
            label1.TabIndex = 7;
            label1.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 92, 78);
            ClientSize = new Size(553, 450);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button registarUser;
        private Button button1;
        private TextBox textPass;
        private TextBox textUser;
        private Label label1;
    }
}
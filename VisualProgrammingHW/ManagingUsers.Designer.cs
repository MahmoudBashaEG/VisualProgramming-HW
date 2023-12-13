namespace VisualProgrammingHW
{
    partial class ManagingUsers
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
            panel1 = new Panel();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label2 = new Label();
            add_btn = new Button();
            username = new TextBox();
            password = new TextBox();
            update_btn = new Button();
            button2 = new Button();
            clear_btn = new Button();
            list = new ListView();
            IdHeader = new ColumnHeader();
            UsernameHeader = new ColumnHeader();
            PasswordHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Indigo;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 606);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 372);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(794, 372);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // add_btn
            // 
            add_btn.BackColor = SystemColors.ActiveCaptionText;
            add_btn.Cursor = Cursors.Hand;
            add_btn.ForeColor = SystemColors.ButtonHighlight;
            add_btn.Location = new Point(453, 488);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(128, 46);
            add_btn.TabIndex = 3;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += register_btn_Click;
            // 
            // username
            // 
            username.Location = new Point(453, 404);
            username.Name = "username";
            username.Size = new Size(263, 27);
            username.TabIndex = 4;
            username.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(794, 404);
            password.Name = "password";
            password.Size = new Size(263, 27);
            password.TabIndex = 5;
            // 
            // update_btn
            // 
            update_btn.BackColor = SystemColors.ActiveCaptionText;
            update_btn.BackgroundImageLayout = ImageLayout.Center;
            update_btn.Cursor = Cursors.Hand;
            update_btn.ForeColor = SystemColors.ButtonHighlight;
            update_btn.Location = new Point(628, 488);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(124, 46);
            update_btn.TabIndex = 6;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(818, 488);
            button2.Name = "button2";
            button2.Size = new Size(116, 46);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // clear_btn
            // 
            clear_btn.BackColor = SystemColors.ActiveCaptionText;
            clear_btn.Cursor = Cursors.Hand;
            clear_btn.ForeColor = SystemColors.ButtonHighlight;
            clear_btn.Location = new Point(969, 488);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(129, 46);
            clear_btn.TabIndex = 8;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // list
            // 
            list.Columns.AddRange(new ColumnHeader[] { IdHeader, UsernameHeader, PasswordHeader });
            list.Location = new Point(453, 37);
            list.Name = "list";
            list.Size = new Size(604, 283);
            list.TabIndex = 9;
            list.UseCompatibleStateImageBehavior = false;
            list.View = View.Details;
            list.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // IdHeader
            // 
            IdHeader.Text = "Id";
            // 
            // UsernameHeader
            // 
            UsernameHeader.Text = "Username";
            // 
            // PasswordHeader
            // 
            PasswordHeader.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 600);
            Controls.Add(list);
            Controls.Add(clear_btn);
            Controls.Add(button2);
            Controls.Add(update_btn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(add_btn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Button add_btn;
        private TextBox username;
        private TextBox password;
        private Button update_btn;
        private Button button2;
        private Button clear_btn;
        private ListView list;
        private ColumnHeader UsernameHeader;
        private ColumnHeader PasswordHeader;
        private ColumnHeader IdHeader;
    }
}
namespace IP_Calculate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайныйIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPклассAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPклассBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPклассCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайнаяМаскаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.info_label5 = new System.Windows.Forms.Label();
            this.info_label4 = new System.Windows.Forms.Label();
            this.info_label3 = new System.Windows.Forms.Label();
            this.info_label2 = new System.Windows.Forms.Label();
            this.info_label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.опцииToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиИзПрограммыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // выйтиИзПрограммыToolStripMenuItem
            // 
            this.выйтиИзПрограммыToolStripMenuItem.Name = "выйтиИзПрограммыToolStripMenuItem";
            this.выйтиИзПрограммыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выйтиИзПрограммыToolStripMenuItem.Text = "Exit";
            this.выйтиИзПрограммыToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.случайныйIPToolStripMenuItem,
            this.случайнаяМаскаToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.опцииToolStripMenuItem.Text = "Options";
            // 
            // случайныйIPToolStripMenuItem
            // 
            this.случайныйIPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPклассAToolStripMenuItem,
            this.iPклассBToolStripMenuItem,
            this.iPклассCToolStripMenuItem});
            this.случайныйIPToolStripMenuItem.Name = "случайныйIPToolStripMenuItem";
            this.случайныйIPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.случайныйIPToolStripMenuItem.Text = "Random IP";
            // 
            // iPклассAToolStripMenuItem
            // 
            this.iPклассAToolStripMenuItem.Name = "iPклассAToolStripMenuItem";
            this.iPклассAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iPклассAToolStripMenuItem.Text = "IP (class A)";
            this.iPклассAToolStripMenuItem.Click += new System.EventHandler(this.IPclassAToolStripMenuItem_Click);
            // 
            // iPклассBToolStripMenuItem
            // 
            this.iPклассBToolStripMenuItem.Name = "iPклассBToolStripMenuItem";
            this.iPклассBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iPклассBToolStripMenuItem.Text = "IP (class B)";
            this.iPклассBToolStripMenuItem.Click += new System.EventHandler(this.IPclassBToolStripMenuItem_Click);
            // 
            // iPклассCToolStripMenuItem
            // 
            this.iPклассCToolStripMenuItem.Name = "iPклассCToolStripMenuItem";
            this.iPклассCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iPклассCToolStripMenuItem.Text = "IP (class C)";
            this.iPклассCToolStripMenuItem.Click += new System.EventHandler(this.IPclassCToolStripMenuItem_Click);
            // 
            // случайнаяМаскаToolStripMenuItem
            // 
            this.случайнаяМаскаToolStripMenuItem.Name = "случайнаяМаскаToolStripMenuItem";
            this.случайнаяМаскаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.случайнаяМаскаToolStripMenuItem.Text = "Random mask";
            this.случайнаяМаскаToolStripMenuItem.Click += new System.EventHandler(this.RandomMaskToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.оПрограммеToolStripMenuItem.Text = "About";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.авторToolStripMenuItem.Text = "Author";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.AuthorToolStripMenuItem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(10, 49);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox1.Mask = "###";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(30, 23);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyUp);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(55, 49);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox2.Mask = "###";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(30, 23);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox2_KeyUp);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(101, 49);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox3.Mask = "###";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(30, 23);
            this.maskedTextBox3.TabIndex = 4;
            this.maskedTextBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox3_KeyUp);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(146, 49);
            this.maskedTextBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox4.Mask = "###";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(30, 23);
            this.maskedTextBox4.TabIndex = 5;
            this.maskedTextBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox4_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter IP adress:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(181, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "/";
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(204, 49);
            this.maskedTextBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBox5.Mask = "##";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(30, 23);
            this.maskedTextBox5.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.85866F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.14134F));
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.info_label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.info_label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.info_label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.info_label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.info_label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 149);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(154, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 22);
            this.label14.TabIndex = 12;
            this.label14.Text = "Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(5, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hosts";
            // 
            // info_label5
            // 
            this.info_label5.AutoSize = true;
            this.info_label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_label5.Location = new System.Drawing.Point(154, 122);
            this.info_label5.Name = "info_label5";
            this.info_label5.Size = new System.Drawing.Size(0, 25);
            this.info_label5.TabIndex = 9;
            // 
            // info_label4
            // 
            this.info_label4.AutoSize = true;
            this.info_label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_label4.Location = new System.Drawing.Point(154, 98);
            this.info_label4.Name = "info_label4";
            this.info_label4.Size = new System.Drawing.Size(0, 22);
            this.info_label4.TabIndex = 8;
            // 
            // info_label3
            // 
            this.info_label3.AutoSize = true;
            this.info_label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_label3.Location = new System.Drawing.Point(154, 74);
            this.info_label3.Name = "info_label3";
            this.info_label3.Size = new System.Drawing.Size(0, 22);
            this.info_label3.TabIndex = 7;
            // 
            // info_label2
            // 
            this.info_label2.AutoSize = true;
            this.info_label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_label2.Location = new System.Drawing.Point(154, 50);
            this.info_label2.Name = "info_label2";
            this.info_label2.Size = new System.Drawing.Size(0, 22);
            this.info_label2.TabIndex = 6;
            // 
            // info_label1
            // 
            this.info_label1.AutoSize = true;
            this.info_label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_label1.Location = new System.Drawing.Point(154, 26);
            this.info_label1.Name = "info_label1";
            this.info_label1.Size = new System.Drawing.Size(0, 22);
            this.info_label1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Broadcast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(5, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Network";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Entered IP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 43);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 234);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(515, 273);
            this.MinimumSize = new System.Drawing.Size(515, 273);
            this.Name = "Form1";
            this.Text = "IP Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label info_label5;
        private Label info_label4;
        private Label info_label3;
        private Label info_label2;
        private Label info_label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label14;
        private Label label13;
        private Button button2;
        private ToolStripMenuItem выйтиИзПрограммыToolStripMenuItem;
        private ToolStripMenuItem случайныйIPToolStripMenuItem;
        private ToolStripMenuItem случайнаяМаскаToolStripMenuItem;
        private ToolStripMenuItem авторToolStripMenuItem;
        private ToolStripMenuItem iPклассAToolStripMenuItem;
        private ToolStripMenuItem iPклассBToolStripMenuItem;
        private ToolStripMenuItem iPклассCToolStripMenuItem;
    }
}
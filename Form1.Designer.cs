namespace Fifteen
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tableLayoutPanelX4 = new System.Windows.Forms.TableLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanelX4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayToolStripMenuItem,
            this.newGameToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(232, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PlayToolStripMenuItem
            // 
            this.PlayToolStripMenuItem.BackColor = System.Drawing.Color.Cornsilk;
            this.PlayToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem";
            this.PlayToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.PlayToolStripMenuItem.Size = new System.Drawing.Size(35, 29);
            this.PlayToolStripMenuItem.Text = "⏵";
            this.PlayToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(32, 29);
            this.newGameToolStripMenuItem.Text = "↺";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem});
            this.SettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(37, 29);
            this.SettingsToolStripMenuItem.Text = "⚙";
            // 
            // x3ToolStripMenuItem
            // 
            this.x3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            this.x3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x3ToolStripMenuItem.Text = "3x3";
            this.x3ToolStripMenuItem.Click += new System.EventHandler(this.x3ToolStripMenuItem_Click);
            // 
            // x4ToolStripMenuItem
            // 
            this.x4ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            this.x4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.x4ToolStripMenuItem.Text = "4x4";
            this.x4ToolStripMenuItem.Click += new System.EventHandler(this.x4ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 0;
            this.button1.Tag = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(61, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 52);
            this.button2.TabIndex = 1;
            this.button2.Tag = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(119, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 52);
            this.button3.TabIndex = 2;
            this.button3.Tag = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(177, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 52);
            this.button4.TabIndex = 3;
            this.button4.Tag = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(3, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 52);
            this.button5.TabIndex = 4;
            this.button5.Tag = "4";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(61, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 52);
            this.button6.TabIndex = 5;
            this.button6.Tag = "5";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(119, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 52);
            this.button7.TabIndex = 6;
            this.button7.Tag = "6";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(177, 61);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 52);
            this.button8.TabIndex = 7;
            this.button8.Tag = "7";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(3, 119);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 52);
            this.button9.TabIndex = 8;
            this.button9.Tag = "8";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(61, 119);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 52);
            this.button10.TabIndex = 9;
            this.button10.Tag = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(119, 119);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 52);
            this.button11.TabIndex = 10;
            this.button11.Tag = "10";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(177, 119);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 52);
            this.button12.TabIndex = 11;
            this.button12.Tag = "11";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(3, 177);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(52, 52);
            this.button13.TabIndex = 12;
            this.button13.Tag = "12";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(61, 177);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(52, 52);
            this.button14.TabIndex = 13;
            this.button14.Tag = "13";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button15
            // 
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(119, 177);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 52);
            this.button15.TabIndex = 14;
            this.button15.Tag = "14";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Btn_Click);
            // 
            // button16
            // 
            this.button16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(177, 177);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(52, 52);
            this.button16.TabIndex = 15;
            this.button16.Tag = "15";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.Btn_Click);
            // 
            // tableLayoutPanelX4
            // 
            this.tableLayoutPanelX4.BackColor = System.Drawing.Color.Ivory;
            this.tableLayoutPanelX4.ColumnCount = 4;
            this.tableLayoutPanelX4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.Controls.Add(this.button16, 3, 3);
            this.tableLayoutPanelX4.Controls.Add(this.button15, 2, 3);
            this.tableLayoutPanelX4.Controls.Add(this.button14, 1, 3);
            this.tableLayoutPanelX4.Controls.Add(this.button13, 0, 3);
            this.tableLayoutPanelX4.Controls.Add(this.button12, 3, 2);
            this.tableLayoutPanelX4.Controls.Add(this.button11, 2, 2);
            this.tableLayoutPanelX4.Controls.Add(this.button10, 1, 2);
            this.tableLayoutPanelX4.Controls.Add(this.button9, 0, 2);
            this.tableLayoutPanelX4.Controls.Add(this.button8, 3, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button6, 1, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button5, 0, 1);
            this.tableLayoutPanelX4.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanelX4.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanelX4.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanelX4.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanelX4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanelX4.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanelX4.Name = "tableLayoutPanelX4";
            this.tableLayoutPanelX4.RowCount = 4;
            this.tableLayoutPanelX4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelX4.Size = new System.Drawing.Size(232, 232);
            this.tableLayoutPanelX4.TabIndex = 0;
            //
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(232, 265);
            this.Controls.Add(this.tableLayoutPanelX4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanelX4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TableLayoutPanel tableLayoutPanelX4;
        private ToolStripMenuItem SettingsToolStripMenuItem;
        private ToolStripMenuItem PlayToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private ToolStripMenuItem x3ToolStripMenuItem;
        private ToolStripMenuItem x4ToolStripMenuItem;
    }
}
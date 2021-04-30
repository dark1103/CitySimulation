﻿
namespace GraphicInterface
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InfectionSpred_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InfectionIncubate_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Immune_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Visitors_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Persons_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.time_label = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.stop_textBox = new System.Windows.Forms.TextBox();
            this.generateBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 445);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfectionSpred_toolStripMenuItem1,
            this.InfectionIncubate_toolStripMenuItem1,
            this.Immune_toolStripMenuItem,
            this.Visitors_toolStripMenuItem,
            this.Persons_toolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(299, 114);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // InfectionSpred_toolStripMenuItem1
            // 
            this.InfectionSpred_toolStripMenuItem1.Name = "InfectionSpred_toolStripMenuItem1";
            this.InfectionSpred_toolStripMenuItem1.Size = new System.Drawing.Size(298, 22);
            this.InfectionSpred_toolStripMenuItem1.Text = "График распространителей";
            // 
            // InfectionIncubate_toolStripMenuItem1
            // 
            this.InfectionIncubate_toolStripMenuItem1.Name = "InfectionIncubate_toolStripMenuItem1";
            this.InfectionIncubate_toolStripMenuItem1.Size = new System.Drawing.Size(298, 22);
            this.InfectionIncubate_toolStripMenuItem1.Text = "График заражённых в стадии инкубации";
            // 
            // Immune_toolStripMenuItem
            // 
            this.Immune_toolStripMenuItem.Name = "Immune_toolStripMenuItem";
            this.Immune_toolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.Immune_toolStripMenuItem.Text = "График людей с имунитетом";
            // 
            // Visitors_toolStripMenuItem
            // 
            this.Visitors_toolStripMenuItem.Name = "Visitors_toolStripMenuItem";
            this.Visitors_toolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.Visitors_toolStripMenuItem.Text = "Посещаемость учреждения";
            // 
            // Persons_toolStripMenuItem
            // 
            this.Persons_toolStripMenuItem.Name = "Persons_toolStripMenuItem";
            this.Persons_toolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.Persons_toolStripMenuItem.Text = "Кол-во людей";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(930, 19);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(30, 15);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "--:--";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 23);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "DeltaTime";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(273, 12);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(95, 23);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "SleepTime";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(733, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Pause at";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // stop_textBox
            // 
            this.stop_textBox.Location = new System.Drawing.Point(814, 11);
            this.stop_textBox.Name = "stop_textBox";
            this.stop_textBox.Size = new System.Drawing.Size(84, 23);
            this.stop_textBox.TabIndex = 8;
            this.stop_textBox.Text = "00:00";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(1036, 11);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(23, 23);
            this.generateBtn.TabIndex = 9;
            this.generateBtn.Text = "G";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1065, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1198, 509);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.stop_textBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "City Simulation";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox stop_textBox;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem InfectionSpred_toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem InfectionIncubate_toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Immune_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Visitors_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Persons_toolStripMenuItem;
    }
}


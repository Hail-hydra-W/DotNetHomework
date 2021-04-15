
namespace CayleyTree
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.draw_button = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.th2_textBox = new System.Windows.Forms.TextBox();
            this.th1_textBox = new System.Windows.Forms.TextBox();
            this.per2_textBox = new System.Windows.Forms.TextBox();
            this.per1_textBox = new System.Windows.Forms.TextBox();
            this.leng_textBox = new System.Windows.Forms.TextBox();
            this.n_textBox = new System.Windows.Forms.TextBox();
            this.pen_label = new System.Windows.Forms.Label();
            this.th2_label = new System.Windows.Forms.Label();
            this.th1_label = new System.Windows.Forms.Label();
            this.per2_label = new System.Windows.Forms.Label();
            this.per1_label = new System.Windows.Forms.Label();
            this.leng_label = new System.Windows.Forms.Label();
            this.n_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.draw_button);
            this.splitContainer1.Panel1.Controls.Add(this.ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.th2_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.th1_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.per2_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.per1_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.leng_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.n_textBox);
            this.splitContainer1.Panel1.Controls.Add(this.pen_label);
            this.splitContainer1.Panel1.Controls.Add(this.th2_label);
            this.splitContainer1.Panel1.Controls.Add(this.th1_label);
            this.splitContainer1.Panel1.Controls.Add(this.per2_label);
            this.splitContainer1.Panel1.Controls.Add(this.per1_label);
            this.splitContainer1.Panel1.Controls.Add(this.leng_label);
            this.splitContainer1.Panel1.Controls.Add(this.n_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(802, 480);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // draw_button
            // 
            this.draw_button.Location = new System.Drawing.Point(79, 408);
            this.draw_button.Name = "draw_button";
            this.draw_button.Size = new System.Drawing.Size(94, 29);
            this.draw_button.TabIndex = 15;
            this.draw_button.Text = "draw";
            this.draw_button.UseVisualStyleBackColor = true;
            this.draw_button.Click += new System.EventHandler(this.draw_button_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Yellow"});
            this.ComboBox.Location = new System.Drawing.Point(135, 343);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(125, 32);
            this.ComboBox.TabIndex = 14;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // th2_textBox
            // 
            this.th2_textBox.Location = new System.Drawing.Point(135, 293);
            this.th2_textBox.Name = "th2_textBox";
            this.th2_textBox.Size = new System.Drawing.Size(125, 31);
            this.th2_textBox.TabIndex = 13;
            this.th2_textBox.TextChanged += new System.EventHandler(this.th2_textBox_TextChanged);
            // 
            // th1_textBox
            // 
            this.th1_textBox.Location = new System.Drawing.Point(135, 253);
            this.th1_textBox.Name = "th1_textBox";
            this.th1_textBox.Size = new System.Drawing.Size(125, 31);
            this.th1_textBox.TabIndex = 11;
            this.th1_textBox.TextChanged += new System.EventHandler(this.th1_textBox_TextChanged);
            // 
            // per2_textBox
            // 
            this.per2_textBox.Location = new System.Drawing.Point(135, 198);
            this.per2_textBox.Name = "per2_textBox";
            this.per2_textBox.Size = new System.Drawing.Size(125, 31);
            this.per2_textBox.TabIndex = 10;
            this.per2_textBox.TextChanged += new System.EventHandler(this.per2_textBox_TextChanged);
            // 
            // per1_textBox
            // 
            this.per1_textBox.Location = new System.Drawing.Point(135, 151);
            this.per1_textBox.Name = "per1_textBox";
            this.per1_textBox.Size = new System.Drawing.Size(125, 31);
            this.per1_textBox.TabIndex = 9;
            this.per1_textBox.TextChanged += new System.EventHandler(this.per1_textBox_TextChanged);
            // 
            // leng_textBox
            // 
            this.leng_textBox.Location = new System.Drawing.Point(135, 102);
            this.leng_textBox.Name = "leng_textBox";
            this.leng_textBox.Size = new System.Drawing.Size(125, 31);
            this.leng_textBox.TabIndex = 8;
            this.leng_textBox.TextChanged += new System.EventHandler(this.leng_textBox_TextChanged);
            // 
            // n_textBox
            // 
            this.n_textBox.Location = new System.Drawing.Point(135, 51);
            this.n_textBox.Name = "n_textBox";
            this.n_textBox.Size = new System.Drawing.Size(125, 31);
            this.n_textBox.TabIndex = 7;
            this.n_textBox.TextChanged += new System.EventHandler(this.n_textBox_TextChanged);
            // 
            // pen_label
            // 
            this.pen_label.AutoSize = true;
            this.pen_label.Location = new System.Drawing.Point(30, 346);
            this.pen_label.Name = "pen_label";
            this.pen_label.Size = new System.Drawing.Size(82, 24);
            this.pen_label.TabIndex = 6;
            this.pen_label.Text = "画笔颜色";
            // 
            // th2_label
            // 
            this.th2_label.AutoSize = true;
            this.th2_label.Location = new System.Drawing.Point(21, 296);
            this.th2_label.Name = "th2_label";
            this.th2_label.Size = new System.Drawing.Size(100, 24);
            this.th2_label.TabIndex = 5;
            this.th2_label.Text = "左分支角度";
            // 
            // th1_label
            // 
            this.th1_label.AutoSize = true;
            this.th1_label.Location = new System.Drawing.Point(21, 256);
            this.th1_label.Name = "th1_label";
            this.th1_label.Size = new System.Drawing.Size(100, 24);
            this.th1_label.TabIndex = 4;
            this.th1_label.Text = "右分支角度";
            // 
            // per2_label
            // 
            this.per2_label.AutoSize = true;
            this.per2_label.Location = new System.Drawing.Point(12, 201);
            this.per2_label.Name = "per2_label";
            this.per2_label.Size = new System.Drawing.Size(118, 24);
            this.per2_label.TabIndex = 3;
            this.per2_label.Text = "左分支长度比";
            // 
            // per1_label
            // 
            this.per1_label.AutoSize = true;
            this.per1_label.Location = new System.Drawing.Point(12, 151);
            this.per1_label.Name = "per1_label";
            this.per1_label.Size = new System.Drawing.Size(118, 24);
            this.per1_label.TabIndex = 2;
            this.per1_label.Text = "右分支长度比";
            // 
            // leng_label
            // 
            this.leng_label.AutoSize = true;
            this.leng_label.Location = new System.Drawing.Point(30, 109);
            this.leng_label.Name = "leng_label";
            this.leng_label.Size = new System.Drawing.Size(82, 24);
            this.leng_label.TabIndex = 1;
            this.leng_label.Text = "主干长度";
            // 
            // n_label
            // 
            this.n_label.AutoSize = true;
            this.n_label.Location = new System.Drawing.Point(30, 58);
            this.n_label.Name = "n_label";
            this.n_label.Size = new System.Drawing.Size(82, 24);
            this.n_label.TabIndex = 0;
            this.n_label.Text = "递归深度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 480);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label pen_label;
        private System.Windows.Forms.Label th2_label;
        private System.Windows.Forms.Label th1_label;
        private System.Windows.Forms.Label per2_label;
        private System.Windows.Forms.Label per1_label;
        private System.Windows.Forms.Label leng_label;
        private System.Windows.Forms.Label n_label;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button draw_button;
        private System.Windows.Forms.TextBox th2_textBox;
        private System.Windows.Forms.TextBox th1_textBox;
        private System.Windows.Forms.TextBox per2_textBox;
        private System.Windows.Forms.TextBox per1_textBox;
        private System.Windows.Forms.TextBox leng_textBox;
        private System.Windows.Forms.TextBox n_textBox;
    }
}


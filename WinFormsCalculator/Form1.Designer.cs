namespace WinFormsCalculator
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
            textBox = new TextBox();
            butPlus = new Button();
            but3 = new Button();
            butEql = new Button();
            butPoint = new Button();
            but2 = new Button();
            but1 = new Button();
            but0 = new Button();
            but4 = new Button();
            but5 = new Button();
            but6 = new Button();
            but9 = new Button();
            but8 = new Button();
            but7 = new Button();
            butDiv = new Button();
            butMin = new Button();
            butMulti = new Button();
            butClear = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.Window;
            textBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.Location = new Point(14, 28);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(236, 64);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // butPlus
            // 
            butPlus.BackColor = SystemColors.Highlight;
            butPlus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butPlus.ForeColor = Color.White;
            butPlus.Location = new Point(201, 296);
            butPlus.Margin = new Padding(3, 4, 3, 4);
            butPlus.Name = "butPlus";
            butPlus.Size = new Size(51, 69);
            butPlus.TabIndex = 16;
            butPlus.Text = "+";
            butPlus.UseVisualStyleBackColor = false;
            butPlus.Click += butPlus_Click;
            // 
            // but3
            // 
            but3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but3.ForeColor = Color.Blue;
            but3.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but3.Location = new Point(142, 236);
            but3.Margin = new Padding(3, 4, 3, 4);
            but3.Name = "but3";
            but3.Size = new Size(51, 60);
            but3.TabIndex = 17;
            but3.Text = "3";
            but3.UseVisualStyleBackColor = true;
            but3.Click += but3_Click;
            // 
            // butEql
            // 
            butEql.BackColor = SystemColors.Highlight;
            butEql.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butEql.ForeColor = Color.White;
            butEql.Location = new Point(142, 305);
            butEql.Margin = new Padding(3, 4, 3, 4);
            butEql.Name = "butEql";
            butEql.Size = new Size(51, 60);
            butEql.TabIndex = 18;
            butEql.Text = "=";
            butEql.UseVisualStyleBackColor = false;
            butEql.Click += butEql_Click;
            // 
            // butPoint
            // 
            butPoint.BackColor = SystemColors.Highlight;
            butPoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butPoint.ForeColor = Color.White;
            butPoint.Location = new Point(79, 305);
            butPoint.Margin = new Padding(3, 4, 3, 4);
            butPoint.Name = "butPoint";
            butPoint.Size = new Size(51, 60);
            butPoint.TabIndex = 19;
            butPoint.Text = ".";
            butPoint.UseVisualStyleBackColor = false;
            butPoint.Click += butPoint_Click;
            // 
            // but2
            // 
            but2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but2.ForeColor = Color.Blue;
            but2.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but2.Location = new Point(79, 236);
            but2.Margin = new Padding(3, 4, 3, 4);
            but2.Name = "but2";
            but2.Size = new Size(51, 60);
            but2.TabIndex = 20;
            but2.Text = "2";
            but2.UseVisualStyleBackColor = true;
            but2.Click += but2_Click;
            // 
            // but1
            // 
            but1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but1.ForeColor = Color.Blue;
            but1.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but1.Location = new Point(14, 236);
            but1.Margin = new Padding(3, 4, 3, 4);
            but1.Name = "but1";
            but1.Size = new Size(51, 60);
            but1.TabIndex = 21;
            but1.Text = "1";
            but1.UseVisualStyleBackColor = true;
            but1.Click += but1_Click;
            // 
            // but0
            // 
            but0.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but0.ForeColor = Color.Blue;
            but0.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but0.Location = new Point(14, 305);
            but0.Margin = new Padding(3, 4, 3, 4);
            but0.Name = "but0";
            but0.Size = new Size(51, 60);
            but0.TabIndex = 22;
            but0.Text = "0";
            but0.UseVisualStyleBackColor = true;
            but0.Click += but0_Click;
            // 
            // but4
            // 
            but4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but4.ForeColor = Color.Blue;
            but4.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but4.Location = new Point(14, 168);
            but4.Margin = new Padding(3, 4, 3, 4);
            but4.Name = "but4";
            but4.Size = new Size(51, 60);
            but4.TabIndex = 23;
            but4.Text = "4";
            but4.UseVisualStyleBackColor = true;
            but4.Click += but4_Click;
            // 
            // but5
            // 
            but5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but5.ForeColor = Color.Blue;
            but5.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but5.Location = new Point(79, 168);
            but5.Margin = new Padding(3, 4, 3, 4);
            but5.Name = "but5";
            but5.Size = new Size(51, 60);
            but5.TabIndex = 24;
            but5.Text = "5";
            but5.UseVisualStyleBackColor = true;
            but5.Click += but5_Click;
            // 
            // but6
            // 
            but6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but6.ForeColor = Color.Blue;
            but6.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but6.Location = new Point(142, 168);
            but6.Margin = new Padding(3, 4, 3, 4);
            but6.Name = "but6";
            but6.Size = new Size(51, 60);
            but6.TabIndex = 25;
            but6.Text = "6";
            but6.UseVisualStyleBackColor = true;
            but6.Click += but6_Click;
            // 
            // but9
            // 
            but9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but9.ForeColor = Color.Blue;
            but9.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but9.Location = new Point(142, 100);
            but9.Margin = new Padding(3, 4, 3, 4);
            but9.Name = "but9";
            but9.Size = new Size(51, 60);
            but9.TabIndex = 28;
            but9.Text = "9";
            but9.UseVisualStyleBackColor = true;
            but9.Click += but9_Click;
            // 
            // but8
            // 
            but8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but8.ForeColor = Color.Blue;
            but8.Image = Properties.Resources.BG1008080www_tiktarh_com_;
            but8.Location = new Point(79, 100);
            but8.Margin = new Padding(3, 4, 3, 4);
            but8.Name = "but8";
            but8.Size = new Size(51, 60);
            but8.TabIndex = 29;
            but8.Text = "8";
            but8.UseVisualStyleBackColor = true;
            but8.Click += but8_Click;
            // 
            // but7
            // 
            but7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but7.ForeColor = Color.Blue;
            but7.Image = (Image)resources.GetObject("but7.Image");
            but7.Location = new Point(14, 100);
            but7.Margin = new Padding(3, 4, 3, 4);
            but7.Name = "but7";
            but7.Size = new Size(51, 60);
            but7.TabIndex = 30;
            but7.Text = "7";
            but7.UseVisualStyleBackColor = true;
            but7.Click += but7_Click;
            // 
            // butDiv
            // 
            butDiv.BackColor = SystemColors.Highlight;
            butDiv.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butDiv.ForeColor = Color.White;
            butDiv.Location = new Point(201, 200);
            butDiv.Margin = new Padding(3, 4, 3, 4);
            butDiv.Name = "butDiv";
            butDiv.Size = new Size(51, 44);
            butDiv.TabIndex = 33;
            butDiv.Text = "/";
            butDiv.UseVisualStyleBackColor = false;
            butDiv.Click += butDiv_Click;
            // 
            // butMin
            // 
            butMin.BackColor = SystemColors.Highlight;
            butMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butMin.ForeColor = Color.White;
            butMin.Location = new Point(201, 250);
            butMin.Margin = new Padding(3, 4, 3, 4);
            butMin.Name = "butMin";
            butMin.Size = new Size(51, 44);
            butMin.TabIndex = 34;
            butMin.Text = "-";
            butMin.UseVisualStyleBackColor = false;
            butMin.Click += butMin_Click;
            // 
            // butMulti
            // 
            butMulti.BackColor = SystemColors.Highlight;
            butMulti.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butMulti.ForeColor = Color.White;
            butMulti.Location = new Point(201, 150);
            butMulti.Margin = new Padding(3, 4, 3, 4);
            butMulti.Name = "butMulti";
            butMulti.Size = new Size(51, 44);
            butMulti.TabIndex = 35;
            butMulti.Text = "*";
            butMulti.UseVisualStyleBackColor = false;
            butMulti.Click += butMulti_Click;
            // 
            // butClear
            // 
            butClear.BackColor = Color.Cyan;
            butClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butClear.ForeColor = Color.Red;
            butClear.Location = new Point(201, 100);
            butClear.Margin = new Padding(3, 4, 3, 4);
            butClear.Name = "butClear";
            butClear.Size = new Size(51, 44);
            butClear.TabIndex = 36;
            butClear.Text = "C";
            butClear.UseVisualStyleBackColor = false;
            butClear.Click += butClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(262, 383);
            Controls.Add(butClear);
            Controls.Add(butMulti);
            Controls.Add(butMin);
            Controls.Add(butDiv);
            Controls.Add(but7);
            Controls.Add(but8);
            Controls.Add(but9);
            Controls.Add(but6);
            Controls.Add(but5);
            Controls.Add(but4);
            Controls.Add(but0);
            Controls.Add(but1);
            Controls.Add(but2);
            Controls.Add(butPoint);
            Controls.Add(butEql);
            Controls.Add(but3);
            Controls.Add(butPlus);
            Controls.Add(textBox);
            ForeColor = Color.DodgerBlue;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button butPlus;
        private Button but3;
        private Button butEql;
        private Button butPoint;
        private Button but2;
        private Button but1;
        private Button but0;
        private Button but4;
        private Button but5;
        private Button but6;
        private Button but9;
        private Button but8;
        private Button but7;
        private Button butDiv;
        private Button butMin;
        private Button butMulti;
        private Button butClear;
    }
}

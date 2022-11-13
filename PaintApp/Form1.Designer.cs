namespace PaintApp
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tri = new System.Windows.Forms.RadioButton();
            this.rec = new System.Windows.Forms.RadioButton();
            this.curColor = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Shape = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveImage = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.saveImage);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton2);
            this.splitContainer1.Panel1.Controls.Add(this.tri);
            this.splitContainer1.Panel1.Controls.Add(this.rec);
            this.splitContainer1.Panel1.Controls.Add(this.curColor);
            this.splitContainer1.Panel1.Controls.Add(this.color);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Shape);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 859);
            this.splitContainer1.SplitterDistance = 394;
            this.splitContainer1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton2.Location = new System.Drawing.Point(158, 199);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 26);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Circle";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // tri
            // 
            this.tri.AutoSize = true;
            this.tri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tri.Location = new System.Drawing.Point(250, 110);
            this.tri.Name = "tri";
            this.tri.Size = new System.Drawing.Size(94, 26);
            this.tri.TabIndex = 10;
            this.tri.TabStop = true;
            this.tri.Text = "Triangle";
            this.tri.UseVisualStyleBackColor = true;
            // 
            // rec
            // 
            this.rec.AutoSize = true;
            this.rec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rec.Location = new System.Drawing.Point(60, 110);
            this.rec.Name = "rec";
            this.rec.Size = new System.Drawing.Size(109, 26);
            this.rec.TabIndex = 0;
            this.rec.TabStop = true;
            this.rec.Text = "Rectangle";
            this.rec.UseVisualStyleBackColor = true;
            // 
            // curColor
            // 
            this.curColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.curColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.curColor.Location = new System.Drawing.Point(116, 434);
            this.curColor.Name = "curColor";
            this.curColor.Size = new System.Drawing.Size(100, 24);
            this.curColor.TabIndex = 9;
            // 
            // color
            // 
            this.color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.color.Location = new System.Drawing.Point(236, 435);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(31, 23);
            this.color.TabIndex = 8;
            this.color.Text = "...";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(142, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color";
            // 
            // Shape
            // 
            this.Shape.AutoSize = true;
            this.Shape.Font = new System.Drawing.Font("Microsoft Sans Serif", 39F);
            this.Shape.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Shape.Location = new System.Drawing.Point(104, 23);
            this.Shape.Name = "Shape";
            this.Shape.Size = new System.Drawing.Size(196, 67);
            this.Shape.TabIndex = 0;
            this.Shape.Text = "Shape";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 825);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "PhuLe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveImage
            // 
            this.saveImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.saveImage.Location = new System.Drawing.Point(69, 706);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new System.Drawing.Size(249, 50);
            this.saveImage.TabIndex = 13;
            this.saveImage.Text = "Save current image";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new System.EventHandler(this.saveImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 859);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Shape;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.TextBox curColor;
        private System.Windows.Forms.RadioButton rec;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton tri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveImage;
    }
}


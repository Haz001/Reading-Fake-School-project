namespace Reading_CS
{
    partial class days
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.THURSDAY = new System.Windows.Forms.CheckBox();
            this.FRIDAY = new System.Windows.Forms.CheckBox();
            this.SATURDAY = new System.Windows.Forms.CheckBox();
            this.SUNDAY = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reading_CS.Properties.Resources.header;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.button1.Location = new System.Drawing.Point(214, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // THURSDAY
            // 
            this.THURSDAY.AutoSize = true;
            this.THURSDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THURSDAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.THURSDAY.Location = new System.Drawing.Point(12, 135);
            this.THURSDAY.Name = "THURSDAY";
            this.THURSDAY.Size = new System.Drawing.Size(298, 33);
            this.THURSDAY.TabIndex = 3;
            this.THURSDAY.Text = "Thursday - (Out of Stock)";
            this.THURSDAY.UseVisualStyleBackColor = true;
            this.THURSDAY.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FRIDAY
            // 
            this.FRIDAY.AutoSize = true;
            this.FRIDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRIDAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.FRIDAY.Location = new System.Drawing.Point(12, 174);
            this.FRIDAY.Name = "FRIDAY";
            this.FRIDAY.Size = new System.Drawing.Size(190, 33);
            this.FRIDAY.TabIndex = 4;
            this.FRIDAY.Text = "Friday - £69.50";
            this.FRIDAY.UseVisualStyleBackColor = true;
            this.FRIDAY.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // SATURDAY
            // 
            this.SATURDAY.AutoSize = true;
            this.SATURDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SATURDAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.SATURDAY.Location = new System.Drawing.Point(12, 213);
            this.SATURDAY.Name = "SATURDAY";
            this.SATURDAY.Size = new System.Drawing.Size(217, 33);
            this.SATURDAY.TabIndex = 5;
            this.SATURDAY.Text = "Saturday - £69.50";
            this.SATURDAY.UseVisualStyleBackColor = true;
            this.SATURDAY.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // SUNDAY
            // 
            this.SUNDAY.AutoSize = true;
            this.SUNDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUNDAY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.SUNDAY.Location = new System.Drawing.Point(12, 252);
            this.SUNDAY.Name = "SUNDAY";
            this.SUNDAY.Size = new System.Drawing.Size(203, 33);
            this.SUNDAY.TabIndex = 6;
            this.SUNDAY.Text = "Sunday - £74.50";
            this.SUNDAY.UseVisualStyleBackColor = true;
            // 
            // days
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SUNDAY);
            this.Controls.Add(this.SATURDAY);
            this.Controls.Add(this.FRIDAY);
            this.Controls.Add(this.THURSDAY);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "days";
            this.Text = "days";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox THURSDAY;
        private System.Windows.Forms.CheckBox FRIDAY;
        private System.Windows.Forms.CheckBox SATURDAY;
        private System.Windows.Forms.CheckBox SUNDAY;
    }
}
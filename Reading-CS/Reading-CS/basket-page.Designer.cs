namespace Reading_CS
{
    partial class basket_page
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.park_btn = new System.Windows.Forms.Button();
            this.lockers_btn = new System.Windows.Forms.Button();
            this.early_btn = new System.Windows.Forms.Button();
            this.sear_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.price_lb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "🛒";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(527, -1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(154, 325);
            this.listBox1.TabIndex = 1;
            // 
            // park_btn
            // 
            this.park_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.park_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.park_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.park_btn.Location = new System.Drawing.Point(0, 383);
            this.park_btn.Margin = new System.Windows.Forms.Padding(0);
            this.park_btn.Name = "park_btn";
            this.park_btn.Size = new System.Drawing.Size(100, 75);
            this.park_btn.TabIndex = 2;
            this.park_btn.Text = "Parking";
            this.park_btn.UseVisualStyleBackColor = true;
            this.park_btn.Click += new System.EventHandler(this.park_btn_Click);
            // 
            // lockers_btn
            // 
            this.lockers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lockers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockers_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.lockers_btn.Location = new System.Drawing.Point(100, 383);
            this.lockers_btn.Margin = new System.Windows.Forms.Padding(0);
            this.lockers_btn.Name = "lockers_btn";
            this.lockers_btn.Size = new System.Drawing.Size(100, 75);
            this.lockers_btn.TabIndex = 2;
            this.lockers_btn.Text = "Lockers";
            this.lockers_btn.UseVisualStyleBackColor = true;
            this.lockers_btn.Click += new System.EventHandler(this.lockers_btn_Click);
            // 
            // early_btn
            // 
            this.early_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.early_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.early_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.early_btn.Location = new System.Drawing.Point(200, 383);
            this.early_btn.Margin = new System.Windows.Forms.Padding(0);
            this.early_btn.Name = "early_btn";
            this.early_btn.Size = new System.Drawing.Size(100, 75);
            this.early_btn.TabIndex = 2;
            this.early_btn.Text = "Early Pass";
            this.early_btn.UseVisualStyleBackColor = true;
            this.early_btn.Click += new System.EventHandler(this.early_btn_Click);
            // 
            // sear_btn
            // 
            this.sear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sear_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(5)))));
            this.sear_btn.Location = new System.Drawing.Point(300, 383);
            this.sear_btn.Margin = new System.Windows.Forms.Padding(0);
            this.sear_btn.Name = "sear_btn";
            this.sear_btn.Size = new System.Drawing.Size(100, 75);
            this.sear_btn.TabIndex = 2;
            this.sear_btn.Text = "Seat Of Luxury";
            this.sear_btn.UseVisualStyleBackColor = true;
            this.sear_btn.Click += new System.EventHandler(this.sear_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Reading_CS.Properties.Resources.date_logo_home_reading;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 350);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // price_lb
            // 
            this.price_lb.AutoSize = true;
            this.price_lb.Location = new System.Drawing.Point(527, 327);
            this.price_lb.Name = "price_lb";
            this.price_lb.Size = new System.Drawing.Size(35, 13);
            this.price_lb.TabIndex = 4;
            this.price_lb.Text = "label2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.doubleToolStripMenuItem,
            this.payToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doubleToolStripMenuItem.Text = "Double";
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.payToolStripMenuItem.Text = "Pay";
            // 
            // basket_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.price_lb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sear_btn);
            this.Controls.Add(this.early_btn);
            this.Controls.Add(this.lockers_btn);
            this.Controls.Add(this.park_btn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "basket_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "basket_page";
            this.Load += new System.EventHandler(this.basket_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button park_btn;
        private System.Windows.Forms.Button lockers_btn;
        private System.Windows.Forms.Button early_btn;
        private System.Windows.Forms.Button sear_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label price_lb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
    }
}
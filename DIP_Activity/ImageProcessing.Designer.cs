namespace DIP_Activity
{
    partial class ImageProcessing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Copy_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Greyscale_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Inversion_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Histogram_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sepia_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_MenuItem,
            this.Save_MenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Open_MenuItem
            // 
            this.Open_MenuItem.Name = "Open_MenuItem";
            this.Open_MenuItem.Size = new System.Drawing.Size(128, 26);
            this.Open_MenuItem.Text = "Open";
            this.Open_MenuItem.Click += new System.EventHandler(this.Open_MenuItem_Click);
            // 
            // Save_MenuItem
            // 
            this.Save_MenuItem.Name = "Save_MenuItem";
            this.Save_MenuItem.Size = new System.Drawing.Size(128, 26);
            this.Save_MenuItem.Text = "Save";
            this.Save_MenuItem.Click += new System.EventHandler(this.Save_MenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Copy_MenuItem,
            this.Greyscale_MenuItem,
            this.Inversion_MenuItem,
            this.Histogram_MenuItem,
            this.Sepia_MenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // Copy_MenuItem
            // 
            this.Copy_MenuItem.Name = "Copy_MenuItem";
            this.Copy_MenuItem.Size = new System.Drawing.Size(162, 26);
            this.Copy_MenuItem.Text = "Copy";
            this.Copy_MenuItem.Click += new System.EventHandler(this.Copy_MenuItem_Click);
            // 
            // Greyscale_MenuItem
            // 
            this.Greyscale_MenuItem.Name = "Greyscale_MenuItem";
            this.Greyscale_MenuItem.Size = new System.Drawing.Size(162, 26);
            this.Greyscale_MenuItem.Text = "Greyscale";
            this.Greyscale_MenuItem.Click += new System.EventHandler(this.Greyscale_MenuItem_Click);
            // 
            // Inversion_MenuItem
            // 
            this.Inversion_MenuItem.Name = "Inversion_MenuItem";
            this.Inversion_MenuItem.Size = new System.Drawing.Size(162, 26);
            this.Inversion_MenuItem.Text = "Inversion";
            this.Inversion_MenuItem.Click += new System.EventHandler(this.Inversion_MenuItem_Click);
            // 
            // Histogram_MenuItem
            // 
            this.Histogram_MenuItem.Name = "Histogram_MenuItem";
            this.Histogram_MenuItem.Size = new System.Drawing.Size(162, 26);
            this.Histogram_MenuItem.Text = "Histogram";
            this.Histogram_MenuItem.Click += new System.EventHandler(this.Histogram_MenuItem_Click);
            // 
            // Sepia_MenuItem
            // 
            this.Sepia_MenuItem.Name = "Sepia_MenuItem";
            this.Sepia_MenuItem.Size = new System.Drawing.Size(162, 26);
            this.Sepia_MenuItem.Text = "Sepia";
            this.Sepia_MenuItem.Click += new System.EventHandler(this.Sepia_MenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 345);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(470, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(381, 345);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // ImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 506);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageProcessing";
            this.Text = "Digital Image Processing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Copy_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Greyscale_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Inversion_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Histogram_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sepia_MenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


namespace TourTest.Window.Forms
{
    partial class StartForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripFIO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TourToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HotelToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFIO,
            this.toolStripRole});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripFIO
            // 
            this.toolStripFIO.Name = "toolStripFIO";
            this.toolStripFIO.Size = new System.Drawing.Size(40, 25);
            this.toolStripFIO.Text = "FIO";
            // 
            // toolStripRole
            // 
            this.toolStripRole.Name = "toolStripRole";
            this.toolStripRole.Size = new System.Drawing.Size(51, 25);
            this.toolStripRole.Text = "Роль";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TourToolMenu,
            this.HotelToolMenu});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.формыToolStripMenuItem.Text = "Формы";
            // 
            // TourToolMenu
            // 
            this.TourToolMenu.Name = "TourToolMenu";
            this.TourToolMenu.Size = new System.Drawing.Size(270, 34);
            this.TourToolMenu.Text = "Туры";
            this.TourToolMenu.Click += new System.EventHandler(this.TourToolMenu_Click);
            // 
            // HotelToolMenu
            // 
            this.HotelToolMenu.Name = "HotelToolMenu";
            this.HotelToolMenu.Size = new System.Drawing.Size(270, 34);
            this.HotelToolMenu.Text = "Отели";
            this.HotelToolMenu.Click += new System.EventHandler(this.HotelToolMenu_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFIO;
        private System.Windows.Forms.ToolStripStatusLabel toolStripRole;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TourToolMenu;
        private System.Windows.Forms.ToolStripMenuItem HotelToolMenu;
    }
}
namespace MyEditorTTT
{
    partial class MyEditorParent
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.windowToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(581, 33);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FileToolStripMenuItem1
            // 
            this.FileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem4,
            this.OpenToolStripMenuItem5,
            this.SaveToolStripMenuItem6,
            this.CloseAllToolStripMenuItem,
            this.ExitToolStripMenuItem7});
            this.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1";
            this.FileToolStripMenuItem1.Size = new System.Drawing.Size(54, 29);
            this.FileToolStripMenuItem1.Text = "&File";
            // 
            // NewToolStripMenuItem4
            // 
            this.NewToolStripMenuItem4.Name = "NewToolStripMenuItem4";
            this.NewToolStripMenuItem4.Size = new System.Drawing.Size(270, 34);
            this.NewToolStripMenuItem4.Text = "&New";
            // 
            // OpenToolStripMenuItem5
            // 
            this.OpenToolStripMenuItem5.Name = "OpenToolStripMenuItem5";
            this.OpenToolStripMenuItem5.Size = new System.Drawing.Size(270, 34);
            this.OpenToolStripMenuItem5.Text = "&Open";
            this.OpenToolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // SaveToolStripMenuItem6
            // 
            this.SaveToolStripMenuItem6.Name = "SaveToolStripMenuItem6";
            this.SaveToolStripMenuItem6.Size = new System.Drawing.Size(270, 34);
            this.SaveToolStripMenuItem6.Text = "&Save";
            // 
            // CloseAllToolStripMenuItem
            // 
            this.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem";
            this.CloseAllToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.CloseAllToolStripMenuItem.Text = "&Close All";
            // 
            // ExitToolStripMenuItem7
            // 
            this.ExitToolStripMenuItem7.Name = "ExitToolStripMenuItem7";
            this.ExitToolStripMenuItem7.Size = new System.Drawing.Size(270, 34);
            this.ExitToolStripMenuItem7.Text = "E&xit";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(58, 29);
            this.toolStripMenuItem3.Text = "&Edit";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem9.Text = "&Copy";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem10.Text = "&Cut";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem11.Text = "&Paste";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tileToolStripMenuItem.Text = "&Tile";
            // 
            // MyEditorParent
            // 
            this.ClientSize = new System.Drawing.Size(581, 363);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MyEditorParent";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        public System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem5;
        public System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem4;
        public System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem6;
        public System.Windows.Forms.ToolStripMenuItem CloseAllToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
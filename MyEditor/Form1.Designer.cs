namespace MyEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.BoldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FontToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.MSSansSerifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.UnderlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.FileToolStripMenuItem.Text = "&File";
            this.FileToolStripMenuItem.ToolTipText = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.NewToolStripMenuItem.Text = "&New";
            this.NewToolStripMenuItem.ToolTipText = "New";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.ToolTipText = "Open";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.ToolTipText = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.EditToolStripMenuItem.Text = "&Edit";
            this.EditToolStripMenuItem.ToolTipText = "Edit";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.CopyToolStripMenuItem.Text = "&Copy";
            this.CopyToolStripMenuItem.ToolTipText = "Copy";
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.CutToolStripMenuItem.Text = "&Cut";
            this.CutToolStripMenuItem.ToolTipText = "Cut";
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.ToolTipText = "Paste";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 414);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 380);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldToolStripButton,
            this.ItalicsToolStripButton,
            this.UnderlineToolStripButton,
            this.ColorToolStripButton,
            this.FontToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 33);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // BoldToolStripButton
            // 
            this.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldToolStripButton.Image")));
            this.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolStripButton.Name = "BoldToolStripButton";
            this.BoldToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.BoldToolStripButton.Text = "toolStripButton1";
            this.BoldToolStripButton.ToolTipText = "Bold";
            // 
            // ItalicsToolStripButton
            // 
            this.ItalicsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicsToolStripButton.Image")));
            this.ItalicsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicsToolStripButton.Name = "ItalicsToolStripButton";
            this.ItalicsToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.ItalicsToolStripButton.Text = "toolStripButton";
            this.ItalicsToolStripButton.ToolTipText = "Italics";
            // 
            // ColorToolStripButton
            // 
            this.ColorToolStripButton.BackColor = System.Drawing.Color.Black;
            this.ColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorToolStripButton.Name = "ColorToolStripButton";
            this.ColorToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.ColorToolStripButton.Text = "toolStripButton3";
            this.ColorToolStripButton.ToolTipText = "Color";
            // 
            // FontToolStripButton
            // 
            this.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSSansSerifToolStripMenuItem,
            this.TimesNewRomanToolStripMenuItem});
            this.FontToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FontToolStripButton.Image")));
            this.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontToolStripButton.Name = "FontToolStripButton";
            this.FontToolStripButton.Size = new System.Drawing.Size(42, 28);
            this.FontToolStripButton.Text = "toolStripButton4";
            this.FontToolStripButton.ToolTipText = "Font";
            // 
            // MSSansSerifToolStripMenuItem
            // 
            this.MSSansSerifToolStripMenuItem.Name = "MSSansSerifToolStripMenuItem";
            this.MSSansSerifToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.MSSansSerifToolStripMenuItem.Text = "MS Sans Serif";
            this.MSSansSerifToolStripMenuItem.ToolTipText = "MS Sans Serif";
            // 
            // TimesNewRomanToolStripMenuItem
            // 
            this.TimesNewRomanToolStripMenuItem.Name = "TimesNewRomanToolStripMenuItem";
            this.TimesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.TimesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.TimesNewRomanToolStripMenuItem.ToolTipText = "Times New Roman";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.ToolTipText = "Exit";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "rtf";
            this.openFileDialog.Filter = "Rich Text Files| *.rtf|Plain Text Files| *.txt|All Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rtf";
            this.saveFileDialog.Filter = "Rich Text Files| *.rtf|Plain Text Files| *.txt|All Files|*.*";
            // 
            // UnderlineToolStripButton
            // 
            this.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineToolStripButton.Image")));
            this.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineToolStripButton.Name = "UnderlineToolStripButton";
            this.UnderlineToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.UnderlineToolStripButton.Text = "Underline";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicsToolStripMenuItem,
            this.underlineToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(160, 100);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.boldToolStripMenuItem.Text = "&Bold";
            this.boldToolStripMenuItem.ToolTipText = "Bold Selected Text";
            // 
            // italicsToolStripMenuItem
            // 
            this.italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            this.italicsToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.italicsToolStripMenuItem.Text = "&Italics";
            this.italicsToolStripMenuItem.ToolTipText = "Italicize Selected Text";
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(159, 32);
            this.underlineToolStripMenuItem.Text = "&Underline";
            this.underlineToolStripMenuItem.ToolTipText = "Underline Selcected Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton BoldToolStripButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripButton ItalicsToolStripButton;
        private System.Windows.Forms.ToolStripButton ColorToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton FontToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem MSSansSerifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TimesNewRomanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton UnderlineToolStripButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
    }
}


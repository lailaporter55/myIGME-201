namespace DynamicPeople
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            teacherButton = new Button();
            studentButton = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(studentButton);
            splitContainer1.Panel1.Controls.Add(teacherButton);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 132;
            splitContainer1.TabIndex = 0;
            // 
            // teacherButton
            // 
            teacherButton.Location = new Point(8, 8);
            teacherButton.Name = "teacherButton";
            teacherButton.Size = new Size(112, 95);
            teacherButton.TabIndex = 0;
            teacherButton.Text = "button1";
            teacherButton.UseVisualStyleBackColor = true;
            // 
            // studentButton
            // 
            studentButton.Location = new Point(8, 123);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(112, 100);
            studentButton.TabIndex = 1;
            studentButton.Text = "button2";
            studentButton.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "student.png");
            imageList1.Images.SetKeyName(1, "teacher.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button studentButton;
        private Button teacherButton;
        private ImageList imageList1;
    }
}
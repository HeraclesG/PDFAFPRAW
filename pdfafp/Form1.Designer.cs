namespace pdfafp
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
            button1 = new Button();
            lnFile = new TextBox();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 47);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 0;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lnFile
            // 
            lnFile.Location = new Point(12, 48);
            lnFile.Name = "lnFile";
            lnFile.Size = new Size(296, 23);
            lnFile.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(142, 89);
            button2.Name = "button2";
            button2.Size = new Size(117, 32);
            button2.TabIndex = 0;
            button2.Text = "Convert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 2;
            label1.Text = "PDF2AFP Converter";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 133);
            Controls.Add(label1);
            Controls.Add(lnFile);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox lnFile;
        private Button button2;
        private Label label1;
    }
}

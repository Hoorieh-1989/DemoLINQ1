namespace DemoLINQ1
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
            buttonLINQ = new Button();
            SuspendLayout();
            // 
            // buttonLINQ
            // 
            buttonLINQ.Location = new Point(111, 200);
            buttonLINQ.Name = "buttonLINQ";
            buttonLINQ.Size = new Size(203, 65);
            buttonLINQ.TabIndex = 0;
            buttonLINQ.Text = "kör LINQ";
            buttonLINQ.UseVisualStyleBackColor = true;
            buttonLINQ.Visible = true;
            buttonLINQ.Click += buttonLINQ_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 372);
            Controls.Add(buttonLINQ);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLINQ;
    }
}

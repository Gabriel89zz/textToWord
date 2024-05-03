namespace textToWord
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
            txtNormalText = new TextBox();
            btnSaveAsWord = new Button();
            SuspendLayout();
            // 
            // txtNormalText
            // 
            txtNormalText.Location = new Point(12, 12);
            txtNormalText.Multiline = true;
            txtNormalText.Name = "txtNormalText";
            txtNormalText.Size = new Size(776, 362);
            txtNormalText.TabIndex = 0;
            // 
            // btnSaveAsWord
            // 
            btnSaveAsWord.Location = new Point(12, 390);
            btnSaveAsWord.Name = "btnSaveAsWord";
            btnSaveAsWord.Size = new Size(114, 48);
            btnSaveAsWord.TabIndex = 1;
            btnSaveAsWord.Text = "Save as Word";
            btnSaveAsWord.UseVisualStyleBackColor = true;
            btnSaveAsWord.Click += btnSaveAsWord_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveAsWord);
            Controls.Add(txtNormalText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNormalText;
        private Button btnSaveAsWord;
    }
}

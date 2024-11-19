namespace PngtoJpgConvert
{
    partial class FrmHome
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
            btnConvert = new Button();
            SuspendLayout();
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(55, 16);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(81, 35);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += this.btnConvert_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(191, 67);
            Controls.Add(btnConvert);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convert Png to Jpg";
            ResumeLayout(false);
        }

        #endregion

        private Button btnConvert;
    }
}

namespace _111111111111111
{
    partial class Form2
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
        public TextBox txttotal;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblgg = new Label();
            SuspendLayout();
            // 
            // lblgg
            // 
            lblgg.AutoSize = true;
            lblgg.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgg.ForeColor = Color.Black;
            lblgg.Location = new Point(207, 194);
            lblgg.Name = "lblgg";
            lblgg.Size = new Size(397, 46);
            lblgg.TabIndex = 0;
            lblgg.Text = "Grade Percentage: 0.0%";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblgg);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            Paint += Form2_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblgg;
    }
}
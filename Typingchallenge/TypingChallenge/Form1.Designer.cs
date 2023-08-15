namespace TypingChallenge
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
            this.CbDiffcultySettings = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartChallenge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CbDiffcultySettings
            // 
            this.CbDiffcultySettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbDiffcultySettings.FormattingEnabled = true;
            this.CbDiffcultySettings.Items.AddRange(new object[] {
            "Easy",
            "Meduim",
            "Hard"});
            this.CbDiffcultySettings.Location = new System.Drawing.Point(245, 116);
            this.CbDiffcultySettings.Name = "CbDiffcultySettings";
            this.CbDiffcultySettings.Size = new System.Drawing.Size(127, 21);
            this.CbDiffcultySettings.TabIndex = 0;
            this.CbDiffcultySettings.SelectedIndexChanged += new System.EventHandler(this.CbDiffcultySettings_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diffculty Settings :";
            // 
            // btnStartChallenge
            // 
            this.btnStartChallenge.Location = new System.Drawing.Point(191, 208);
            this.btnStartChallenge.Name = "btnStartChallenge";
            this.btnStartChallenge.Size = new System.Drawing.Size(140, 47);
            this.btnStartChallenge.TabIndex = 2;
            this.btnStartChallenge.Text = "Start Challenge";
            this.btnStartChallenge.UseVisualStyleBackColor = true;
            this.btnStartChallenge.Click += new System.EventHandler(this.btnStartChallenge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 308);
            this.Controls.Add(this.btnStartChallenge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbDiffcultySettings);
            this.Name = "Form1";
            this.Text = "TypingChallenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartChallenge;
        public System.Windows.Forms.ComboBox CbDiffcultySettings;
    }
}


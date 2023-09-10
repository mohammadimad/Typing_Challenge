
namespace Typingchallenge
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
            this.cbQuestionLevel = new System.Windows.Forms.ComboBox();
            this.lblDiffcultySwttings = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbQuestionLevel
            // 
            this.cbQuestionLevel.BackColor = System.Drawing.Color.DimGray;
            this.cbQuestionLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestionLevel.FormattingEnabled = true;
            this.cbQuestionLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cbQuestionLevel.Location = new System.Drawing.Point(273, 95);
            this.cbQuestionLevel.Name = "cbQuestionLevel";
            this.cbQuestionLevel.Size = new System.Drawing.Size(149, 24);
            this.cbQuestionLevel.TabIndex = 0;
            // 
            // lblDiffcultySwttings
            // 
            this.lblDiffcultySwttings.AutoSize = true;
            this.lblDiffcultySwttings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffcultySwttings.Location = new System.Drawing.Point(117, 96);
            this.lblDiffcultySwttings.Name = "lblDiffcultySwttings";
            this.lblDiffcultySwttings.Size = new System.Drawing.Size(131, 20);
            this.lblDiffcultySwttings.TabIndex = 1;
            this.lblDiffcultySwttings.Text = "Diffculty Swttings";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(216, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Challenge";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(668, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDiffcultySwttings);
            this.Controls.Add(this.cbQuestionLevel);
            this.Name = "Form1";
            this.Text = "Typing Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbQuestionLevel;
        private System.Windows.Forms.Label lblDiffcultySwttings;
        private System.Windows.Forms.Button btnStartChallenge;
        private System.Windows.Forms.Button button1;
    }
}


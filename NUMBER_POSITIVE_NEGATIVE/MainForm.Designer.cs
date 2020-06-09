namespace NUMBER_POSITIVE_NEGATIVE
{
    partial class MainForm
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
            this.NumberTxtBx = new System.Windows.Forms.TextBox();
            this.WhatInTheBoxLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberTxtBx
            // 
            this.NumberTxtBx.Location = new System.Drawing.Point(180, 113);
            this.NumberTxtBx.Name = "NumberTxtBx";
            this.NumberTxtBx.Size = new System.Drawing.Size(100, 20);
            this.NumberTxtBx.TabIndex = 0;
            this.NumberTxtBx.TextChanged += new System.EventHandler(this.NumberTxtBx_TextChanged);
            // 
            // WhatInTheBoxLbl
            // 
            this.WhatInTheBoxLbl.AutoSize = true;
            this.WhatInTheBoxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.WhatInTheBoxLbl.Location = new System.Drawing.Point(342, 96);
            this.WhatInTheBoxLbl.Name = "WhatInTheBoxLbl";
            this.WhatInTheBoxLbl.Size = new System.Drawing.Size(83, 37);
            this.WhatInTheBoxLbl.TabIndex = 1;
            this.WhatInTheBoxLbl.Text = "NaN";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 331);
            this.Controls.Add(this.WhatInTheBoxLbl);
            this.Controls.Add(this.NumberTxtBx);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Positive Or Negative";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberTxtBx;
        private System.Windows.Forms.Label WhatInTheBoxLbl;
    }
}


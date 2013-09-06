namespace WindowsFormsApplication1
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
            this.btnSelfDestruct = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelfDestruct
            // 
            this.btnSelfDestruct.Location = new System.Drawing.Point(89, 84);
            this.btnSelfDestruct.Name = "btnSelfDestruct";
            this.btnSelfDestruct.Size = new System.Drawing.Size(118, 45);
            this.btnSelfDestruct.TabIndex = 0;
            this.btnSelfDestruct.Text = "Self destruct";
            this.btnSelfDestruct.UseVisualStyleBackColor = true;
            this.btnSelfDestruct.Click += new System.EventHandler(this.btnSelfDestruct_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.BackColor = System.Drawing.SystemColors.Info;
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(90, 132);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(117, 40);
            this.txtFeedback.TabIndex = 1;
            this.txtFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.btnSelfDestruct);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Self destruct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelfDestruct;
        private System.Windows.Forms.Label txtFeedback;
    }
}


namespace WinFormPart1
{
    partial class ShowMessage
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
            this.messagMe = new System.Windows.Forms.Label();
            this.messagelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messagMe
            // 
            this.messagMe.AutoSize = true;
            this.messagMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagMe.Location = new System.Drawing.Point(317, 226);
            this.messagMe.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.messagMe.Name = "messagMe";
            this.messagMe.Size = new System.Drawing.Size(0, 24);
            this.messagMe.TabIndex = 1;
            // 
            // messagelabel
            // 
            this.messagelabel.AutoSize = true;
            this.messagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagelabel.Location = new System.Drawing.Point(205, 226);
            this.messagelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(65, 24);
            this.messagelabel.TabIndex = 0;
            this.messagelabel.Text = "Mesaj:";
            // 
            // ShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 620);
            this.Controls.Add(this.messagMe);
            this.Controls.Add(this.messagelabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ShowMessage";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label messagMe;
        private System.Windows.Forms.Label messagelabel;
    }
}
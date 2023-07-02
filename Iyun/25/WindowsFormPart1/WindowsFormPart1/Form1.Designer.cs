namespace WindowsFormPart1
{
    partial class MyNewForm
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
            this.clickEvent = new System.Windows.Forms.Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.SendMessage = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // clickEvent
            // 
            this.clickEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickEvent.Location = new System.Drawing.Point(340, 156);
            this.clickEvent.Name = "clickEvent";
            this.clickEvent.Size = new System.Drawing.Size(65, 32);
            this.clickEvent.TabIndex = 0;
            this.clickEvent.Text = "Click here";
            this.clickEvent.UseVisualStyleBackColor = true;
            this.clickEvent.Click += new System.EventHandler(this.clickEvent_Click);
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(236, 60);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(284, 21);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "Gondermek istediyiniz mesaji daxil edin";
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(305, 108);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(141, 20);
            this.SendMessage.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(457, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 113);
            this.panel1.TabIndex = 3;
            // 
            // MyNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.clickEvent);
            this.Name = "MyNewForm";
            this.Text = "MyNewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickEvent;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.TextBox SendMessage;
        private System.Windows.Forms.Panel panel1;
    }
}


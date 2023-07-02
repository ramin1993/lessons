namespace Calculator
{
    partial class Calculator
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
            this.writeVala = new System.Windows.Forms.TextBox();
            this.writeValb = new System.Windows.Forms.TextBox();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.DvideBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.SubtractionBtn = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.EmptyWarningA = new System.Windows.Forms.Label();
            this.EmptyWarningB = new System.Windows.Forms.Label();
            this.EqualsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeVala
            // 
            this.writeVala.Location = new System.Drawing.Point(116, 26);
            this.writeVala.Name = "writeVala";
            this.writeVala.Size = new System.Drawing.Size(74, 20);
            this.writeVala.TabIndex = 1;
            // 
            // writeValb
            // 
            this.writeValb.Location = new System.Drawing.Point(116, 60);
            this.writeValb.Name = "writeValb";
            this.writeValb.Size = new System.Drawing.Size(74, 20);
            this.writeValb.TabIndex = 3;
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplyBtn.Location = new System.Drawing.Point(196, 26);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(22, 23);
            this.MultiplyBtn.TabIndex = 4;
            this.MultiplyBtn.Text = "*";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            this.MultiplyBtn.Click += new System.EventHandler(this.GetMathOperator_Click);
            // 
            // DvideBtn
            // 
            this.DvideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DvideBtn.Location = new System.Drawing.Point(196, 60);
            this.DvideBtn.Name = "DvideBtn";
            this.DvideBtn.Size = new System.Drawing.Size(22, 23);
            this.DvideBtn.TabIndex = 5;
            this.DvideBtn.Text = "/";
            this.DvideBtn.UseVisualStyleBackColor = true;
            this.DvideBtn.Click += new System.EventHandler(this.GetMathOperator_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBtn.Location = new System.Drawing.Point(224, 26);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(22, 23);
            this.PlusBtn.TabIndex = 6;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.GetMathOperator_Click);
            // 
            // SubtractionBtn
            // 
            this.SubtractionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionBtn.Location = new System.Drawing.Point(224, 60);
            this.SubtractionBtn.Name = "SubtractionBtn";
            this.SubtractionBtn.Size = new System.Drawing.Size(22, 23);
            this.SubtractionBtn.TabIndex = 7;
            this.SubtractionBtn.Text = "-";
            this.SubtractionBtn.UseVisualStyleBackColor = true;
            this.SubtractionBtn.Click += new System.EventHandler(this.GetMathOperator_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Result.Location = new System.Drawing.Point(112, 125);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 24);
            this.Result.TabIndex = 8;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmptyWarningA
            // 
            this.EmptyWarningA.AutoSize = true;
            this.EmptyWarningA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyWarningA.ForeColor = System.Drawing.Color.Red;
            this.EmptyWarningA.Location = new System.Drawing.Point(473, 100);
            this.EmptyWarningA.Name = "EmptyWarningA";
            this.EmptyWarningA.Size = new System.Drawing.Size(0, 20);
            this.EmptyWarningA.TabIndex = 10;
            // 
            // EmptyWarningB
            // 
            this.EmptyWarningB.AutoSize = true;
            this.EmptyWarningB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyWarningB.ForeColor = System.Drawing.Color.Red;
            this.EmptyWarningB.Location = new System.Drawing.Point(477, 137);
            this.EmptyWarningB.Name = "EmptyWarningB";
            this.EmptyWarningB.Size = new System.Drawing.Size(0, 20);
            this.EmptyWarningB.TabIndex = 11;
            // 
            // EqualsBtn
            // 
            this.EqualsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsBtn.Location = new System.Drawing.Point(116, 91);
            this.EqualsBtn.Name = "EqualsBtn";
            this.EqualsBtn.Size = new System.Drawing.Size(130, 31);
            this.EqualsBtn.TabIndex = 12;
            this.EqualsBtn.Text = "=";
            this.EqualsBtn.UseVisualStyleBackColor = true;
            this.EqualsBtn.Click += new System.EventHandler(this.EqualsBtn_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(361, 162);
            this.Controls.Add(this.EqualsBtn);
            this.Controls.Add(this.EmptyWarningB);
            this.Controls.Add(this.EmptyWarningA);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SubtractionBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.DvideBtn);
            this.Controls.Add(this.MultiplyBtn);
            this.Controls.Add(this.writeValb);
            this.Controls.Add(this.writeVala);
            this.Name = "Calculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox writeVala;
        private System.Windows.Forms.TextBox writeValb;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button DvideBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button SubtractionBtn;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label EmptyWarningA;
        private System.Windows.Forms.Label EmptyWarningB;
        private System.Windows.Forms.Button EqualsBtn;
    }
}
namespace Rhyme_Generator
{
    partial class UserInterface
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
            this.uxButton = new System.Windows.Forms.Button();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.uxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxButton
            // 
            this.uxButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton.Location = new System.Drawing.Point(197, 12);
            this.uxButton.Name = "uxButton";
            this.uxButton.Size = new System.Drawing.Size(75, 52);
            this.uxButton.TabIndex = 0;
            this.uxButton.Text = "Generate Rhyme";
            this.uxButton.UseVisualStyleBackColor = false;
            this.uxButton.Click += new System.EventHandler(this.uxButton_Click);
            // 
            // uxInput
            // 
            this.uxInput.Location = new System.Drawing.Point(12, 29);
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(179, 20);
            this.uxInput.TabIndex = 1;
            // 
            // uxOutput
            // 
            this.uxOutput.Location = new System.Drawing.Point(12, 85);
            this.uxOutput.Name = "uxOutput";
            this.uxOutput.ReadOnly = true;
            this.uxOutput.Size = new System.Drawing.Size(179, 20);
            this.uxOutput.TabIndex = 2;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 150);
            this.Controls.Add(this.uxOutput);
            this.Controls.Add(this.uxInput);
            this.Controls.Add(this.uxButton);
            this.Name = "UserInterface";
            this.Text = "Rhyme Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxButton;
        private System.Windows.Forms.TextBox uxInput;
        private System.Windows.Forms.TextBox uxOutput;
    }
}


namespace Greeting_Card_Summative
{
    partial class greetingCard
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
            this.openCard = new System.Windows.Forms.Button();
            this.openLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openCard
            // 
            this.openCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCard.Location = new System.Drawing.Point(48, 21);
            this.openCard.Name = "openCard";
            this.openCard.Size = new System.Drawing.Size(190, 95);
            this.openCard.TabIndex = 0;
            this.openCard.Text = "Open Greeting Card";
            this.openCard.UseVisualStyleBackColor = true;
            this.openCard.Click += new System.EventHandler(this.button1_Click);
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLabel.Location = new System.Drawing.Point(24, 184);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(248, 30);
            this.openLabel.TabIndex = 1;
            this.openLabel.Text = "What\'s your destiny???";
            // 
            // greetingCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.openCard);
            this.Name = "greetingCard";
            this.Text = "Greeting Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openCard;
        private System.Windows.Forms.Label openLabel;
    }
}


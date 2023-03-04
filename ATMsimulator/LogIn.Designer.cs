namespace ATMsimulator
{
    partial class LogIn
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
            this.labelPIN = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.buttonPIN = new System.Windows.Forms.Button();
            this.buttonCreateNewCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.BackColor = System.Drawing.Color.LightCyan;
            this.labelPIN.Font = new System.Drawing.Font("Minion Pro", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPIN.Location = new System.Drawing.Point(41, 177);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(159, 46);
            this.labelPIN.TabIndex = 0;
            this.labelPIN.Text = "Enter PIN";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPIN.Location = new System.Drawing.Point(228, 177);
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(305, 44);
            this.textBoxPIN.TabIndex = 1;
            // 
            // buttonPIN
            // 
            this.buttonPIN.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonPIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPIN.Location = new System.Drawing.Point(170, 267);
            this.buttonPIN.Name = "buttonPIN";
            this.buttonPIN.Size = new System.Drawing.Size(252, 75);
            this.buttonPIN.TabIndex = 2;
            this.buttonPIN.Text = "OK";
            this.buttonPIN.UseVisualStyleBackColor = false;
            this.buttonPIN.Click += new System.EventHandler(this.buttonPIN_Click);
            // 
            // buttonCreateNewCard
            // 
            this.buttonCreateNewCard.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.buttonCreateNewCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateNewCard.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateNewCard.Name = "buttonCreateNewCard";
            this.buttonCreateNewCard.Size = new System.Drawing.Size(252, 32);
            this.buttonCreateNewCard.TabIndex = 3;
            this.buttonCreateNewCard.Text = "Create a card";
            this.buttonCreateNewCard.UseVisualStyleBackColor = false;
            this.buttonCreateNewCard.Click += new System.EventHandler(this.buttonCreateNewCard_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.buttonCreateNewCard);
            this.Controls.Add(this.buttonPIN);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.labelPIN);
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.Button buttonPIN;
        private System.Windows.Forms.Button buttonCreateNewCard;
    }
}
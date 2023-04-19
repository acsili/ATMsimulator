namespace ATMsimulator
{
    partial class СreateСard
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
            this.labelCreateCard = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonCraeteCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCreateCard
            // 
            this.labelCreateCard.AutoSize = true;
            this.labelCreateCard.BackColor = System.Drawing.Color.DarkOrange;
            this.labelCreateCard.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateCard.Location = new System.Drawing.Point(13, 13);
            this.labelCreateCard.Name = "labelCreateCard";
            this.labelCreateCard.Size = new System.Drawing.Size(222, 44);
            this.labelCreateCard.TabIndex = 0;
            this.labelCreateCard.Text = "Create a card";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Turquoise;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(182, 34);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Enter name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(230, 136);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(340, 36);
            this.textBoxName.TabIndex = 2;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.Color.Turquoise;
            this.labelSurname.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.Location = new System.Drawing.Point(8, 204);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(227, 34);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Enter surname";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.Location = new System.Drawing.Point(274, 205);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(296, 36);
            this.textBoxSurname.TabIndex = 4;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Turquoise;
            this.labelInfo.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(8, 272);
            this.labelInfo.MaximumSize = new System.Drawing.Size(570, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(445, 68);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "PIN and card number will be generated automatically";
            // 
            // buttonCraeteCard
            // 
            this.buttonCraeteCard.BackColor = System.Drawing.Color.Thistle;
            this.buttonCraeteCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCraeteCard.Location = new System.Drawing.Point(182, 400);
            this.buttonCraeteCard.Name = "buttonCraeteCard";
            this.buttonCraeteCard.Size = new System.Drawing.Size(205, 88);
            this.buttonCraeteCard.TabIndex = 6;
            this.buttonCraeteCard.Text = "Create";
            this.buttonCraeteCard.UseVisualStyleBackColor = false;
            this.buttonCraeteCard.Click += new System.EventHandler(this.buttonCraeteCard_Click);
            // 
            // СreateСard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.buttonCraeteCard);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelCreateCard);
            this.Name = "СreateСard";
            this.Text = "СreateСard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.СreateСard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateCard;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonCraeteCard;
    }
}
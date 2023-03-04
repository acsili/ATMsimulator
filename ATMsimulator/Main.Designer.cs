namespace ATMsimulator
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUserInterface = new System.Windows.Forms.Label();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.buttonDepositCash = new System.Windows.Forms.Button();
            this.buttonGetCash = new System.Windows.Forms.Button();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonEndSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserInterface
            // 
            this.labelUserInterface.AutoSize = true;
            this.labelUserInterface.BackColor = System.Drawing.Color.DarkOrange;
            this.labelUserInterface.Font = new System.Drawing.Font("Myriad Pro Cond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserInterface.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelUserInterface.Location = new System.Drawing.Point(10, 20);
            this.labelUserInterface.Name = "labelUserInterface";
            this.labelUserInterface.Size = new System.Drawing.Size(279, 48);
            this.labelUserInterface.TabIndex = 0;
            this.labelUserInterface.Text = "ATM User Interface";
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.BackColor = System.Drawing.SystemColors.Info;
            this.labelNameSurname.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSurname.Location = new System.Drawing.Point(510, 20);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(230, 34);
            this.labelNameSurname.TabIndex = 1;
            this.labelNameSurname.Text = "Name Surname";
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.BackColor = System.Drawing.SystemColors.Info;
            this.labelCardNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCardNumber.Location = new System.Drawing.Point(510, 55);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(146, 26);
            this.labelCardNumber.TabIndex = 2;
            this.labelCardNumber.Text = "Card Number";
            // 
            // buttonDepositCash
            // 
            this.buttonDepositCash.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDepositCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDepositCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDepositCash.Location = new System.Drawing.Point(100, 200);
            this.buttonDepositCash.Name = "buttonDepositCash";
            this.buttonDepositCash.Size = new System.Drawing.Size(250, 150);
            this.buttonDepositCash.TabIndex = 3;
            this.buttonDepositCash.Text = "Deposit Cash";
            this.buttonDepositCash.UseVisualStyleBackColor = false;
            this.buttonDepositCash.Click += new System.EventHandler(this.buttonDepositCash_Click);
            // 
            // buttonGetCash
            // 
            this.buttonGetCash.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGetCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGetCash.Location = new System.Drawing.Point(356, 200);
            this.buttonGetCash.Name = "buttonGetCash";
            this.buttonGetCash.Size = new System.Drawing.Size(250, 150);
            this.buttonGetCash.TabIndex = 4;
            this.buttonGetCash.Text = "Get Cash";
            this.buttonGetCash.UseVisualStyleBackColor = false;
            this.buttonGetCash.Click += new System.EventHandler(this.buttonGetCash_Click);
            // 
            // buttonBalance
            // 
            this.buttonBalance.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBalance.Location = new System.Drawing.Point(612, 200);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(250, 150);
            this.buttonBalance.TabIndex = 5;
            this.buttonBalance.Text = "Balance";
            this.buttonBalance.UseVisualStyleBackColor = false;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkMagenta;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(100, 356);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 150);
            this.button4.TabIndex = 6;
            this.button4.Text = "Operations History";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Goldenrod;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(356, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 150);
            this.button5.TabIndex = 7;
            this.button5.Text = "Print A Check";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumPurple;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(612, 356);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 150);
            this.button6.TabIndex = 8;
            this.button6.Text = "ATM References";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // buttonEndSession
            // 
            this.buttonEndSession.BackColor = System.Drawing.Color.Tan;
            this.buttonEndSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndSession.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEndSession.Location = new System.Drawing.Point(100, 587);
            this.buttonEndSession.Name = "buttonEndSession";
            this.buttonEndSession.Size = new System.Drawing.Size(189, 77);
            this.buttonEndSession.TabIndex = 9;
            this.buttonEndSession.Text = "End Session";
            this.buttonEndSession.UseVisualStyleBackColor = false;
            this.buttonEndSession.Click += new System.EventHandler(this.buttonEndSession_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.buttonEndSession);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonBalance);
            this.Controls.Add(this.buttonGetCash);
            this.Controls.Add(this.buttonDepositCash);
            this.Controls.Add(this.labelCardNumber);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.labelUserInterface);
            this.Name = "Main";
            this.Text = "ATM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserInterface;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Button buttonDepositCash;
        private System.Windows.Forms.Button buttonGetCash;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonEndSession;
    }
}


namespace change_learn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblCents = new System.Windows.Forms.TextBox();
            this.lblTwoonies = new System.Windows.Forms.TextBox();
            this.lblLoonies = new System.Windows.Forms.TextBox();
            this.lblQuarters = new System.Windows.Forms.TextBox();
            this.lblDimes = new System.Windows.Forms.TextBox();
            this.lblNickels = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rounded Cents:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Twoonie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loonie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quarter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dime";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nickel";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(125, 31);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 20);
            this.txtMoney.TabIndex = 6;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // lblCents
            // 
            this.lblCents.Location = new System.Drawing.Point(147, 92);
            this.lblCents.Name = "lblCents";
            this.lblCents.Size = new System.Drawing.Size(100, 20);
            this.lblCents.TabIndex = 7;
            // 
            // lblTwoonies
            // 
            this.lblTwoonies.Location = new System.Drawing.Point(147, 131);
            this.lblTwoonies.Name = "lblTwoonies";
            this.lblTwoonies.Size = new System.Drawing.Size(100, 20);
            this.lblTwoonies.TabIndex = 8;
            // 
            // lblLoonies
            // 
            this.lblLoonies.Location = new System.Drawing.Point(147, 170);
            this.lblLoonies.Name = "lblLoonies";
            this.lblLoonies.Size = new System.Drawing.Size(100, 20);
            this.lblLoonies.TabIndex = 9;
            // 
            // lblQuarters
            // 
            this.lblQuarters.Location = new System.Drawing.Point(147, 204);
            this.lblQuarters.Name = "lblQuarters";
            this.lblQuarters.Size = new System.Drawing.Size(100, 20);
            this.lblQuarters.TabIndex = 10;
            // 
            // lblDimes
            // 
            this.lblDimes.Location = new System.Drawing.Point(147, 242);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(100, 20);
            this.lblDimes.TabIndex = 11;
            // 
            // lblNickels
            // 
            this.lblNickels.Location = new System.Drawing.Point(147, 276);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(100, 20);
            this.lblNickels.TabIndex = 12;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(176, 58);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 13;
            this.btnChange.Text = "&Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 368);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblQuarters);
            this.Controls.Add(this.lblLoonies);
            this.Controls.Add(this.lblTwoonies);
            this.Controls.Add(this.lblCents);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox lblCents;
        private System.Windows.Forms.TextBox lblTwoonies;
        private System.Windows.Forms.TextBox lblLoonies;
        private System.Windows.Forms.TextBox lblQuarters;
        private System.Windows.Forms.TextBox lblDimes;
        private System.Windows.Forms.TextBox lblNickels;
        private System.Windows.Forms.Button btnChange;
    }
}


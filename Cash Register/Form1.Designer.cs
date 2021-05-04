
namespace Cash_Register
{
    partial class cashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashRegister));
            this.piesLabel = new System.Windows.Forms.Label();
            this.burgersLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.piesInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.burgersInput = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.recieptButton = new System.Windows.Forms.Button();
            this.totalLabel2 = new System.Windows.Forms.Label();
            this.taxLabel2 = new System.Windows.Forms.Label();
            this.subTotallabel2 = new System.Windows.Forms.Label();
            this.reciptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // piesLabel
            // 
            this.piesLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piesLabel.Location = new System.Drawing.Point(29, 90);
            this.piesLabel.Name = "piesLabel";
            this.piesLabel.Size = new System.Drawing.Size(225, 35);
            this.piesLabel.TabIndex = 0;
            this.piesLabel.Text = "Number of Pies";
            // 
            // burgersLabel
            // 
            this.burgersLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgersLabel.Location = new System.Drawing.Point(30, 125);
            this.burgersLabel.Name = "burgersLabel";
            this.burgersLabel.Size = new System.Drawing.Size(311, 29);
            this.burgersLabel.TabIndex = 1;
            this.burgersLabel.Text = "Number of Burgers";
            // 
            // drinksLabel
            // 
            this.drinksLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(30, 163);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(347, 30);
            this.drinksLabel.TabIndex = 2;
            this.drinksLabel.Text = "Number of Drinks";
            // 
            // piesInput
            // 
            this.piesInput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piesInput.Location = new System.Drawing.Point(211, 90);
            this.piesInput.Multiline = true;
            this.piesInput.Name = "piesInput";
            this.piesInput.Size = new System.Drawing.Size(63, 27);
            this.piesInput.TabIndex = 3;
            // 
            // drinksInput
            // 
            this.drinksInput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksInput.Location = new System.Drawing.Point(211, 157);
            this.drinksInput.Multiline = true;
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(63, 30);
            this.drinksInput.TabIndex = 4;
            // 
            // burgersInput
            // 
            this.burgersInput.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgersInput.Location = new System.Drawing.Point(211, 125);
            this.burgersInput.Multiline = true;
            this.burgersInput.Name = "burgersInput";
            this.burgersInput.Size = new System.Drawing.Size(63, 26);
            this.burgersInput.TabIndex = 5;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Pink;
            this.totalButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(50, 200);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(205, 44);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Calculate Totals";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(47, 250);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(73, 23);
            this.subTotalLabel.TabIndex = 7;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(47, 296);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(73, 23);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(47, 273);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(73, 23);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(79, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(624, 39);
            this.titleLabel.TabIndex = 10;
            this.titleLabel.Text = "Humphrey\'s Diner";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.Color.Red;
            this.dividerLabel.Location = new System.Drawing.Point(30, 332);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(244, 10);
            this.dividerLabel.TabIndex = 11;
            // 
            // recieptButton
            // 
            this.recieptButton.BackColor = System.Drawing.Color.Pink;
            this.recieptButton.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptButton.Location = new System.Drawing.Point(50, 364);
            this.recieptButton.Name = "recieptButton";
            this.recieptButton.Size = new System.Drawing.Size(205, 46);
            this.recieptButton.TabIndex = 16;
            this.recieptButton.Text = "Print Reciept";
            this.recieptButton.UseVisualStyleBackColor = false;
            this.recieptButton.Click += new System.EventHandler(this.recieptButton_Click);
            // 
            // totalLabel2
            // 
            this.totalLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel2.Location = new System.Drawing.Point(182, 273);
            this.totalLabel2.Name = "totalLabel2";
            this.totalLabel2.Size = new System.Drawing.Size(73, 23);
            this.totalLabel2.TabIndex = 19;
            // 
            // taxLabel2
            // 
            this.taxLabel2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel2.Location = new System.Drawing.Point(182, 296);
            this.taxLabel2.Name = "taxLabel2";
            this.taxLabel2.Size = new System.Drawing.Size(73, 23);
            this.taxLabel2.TabIndex = 20;
            // 
            // subTotallabel2
            // 
            this.subTotallabel2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotallabel2.Location = new System.Drawing.Point(182, 247);
            this.subTotallabel2.Name = "subTotallabel2";
            this.subTotallabel2.Size = new System.Drawing.Size(73, 23);
            this.subTotallabel2.TabIndex = 21;
            // 
            // reciptLabel
            // 
            this.reciptLabel.BackColor = System.Drawing.Color.White;
            this.reciptLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptLabel.Location = new System.Drawing.Point(323, 51);
            this.reciptLabel.Name = "reciptLabel";
            this.reciptLabel.Size = new System.Drawing.Size(414, 359);
            this.reciptLabel.TabIndex = 22;
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reciptLabel);
            this.Controls.Add(this.subTotallabel2);
            this.Controls.Add(this.taxLabel2);
            this.Controls.Add(this.totalLabel2);
            this.Controls.Add(this.recieptButton);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.burgersInput);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.piesInput);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.burgersLabel);
            this.Controls.Add(this.piesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashRegister";
            this.Text = "Humphrey\'s Diner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label piesLabel;
        private System.Windows.Forms.Label burgersLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox piesInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.TextBox burgersInput;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Button recieptButton;
        private System.Windows.Forms.Label totalLabel2;
        private System.Windows.Forms.Label taxLabel2;
        private System.Windows.Forms.Label subTotallabel2;
        private System.Windows.Forms.Label reciptLabel;
    }
}


namespace MegaDesk
{
    partial class MegaDesk
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
            this.addNewQuoteButton = new System.Windows.Forms.Button();
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuoteButton
            // 
            this.addNewQuoteButton.Location = new System.Drawing.Point(12, 25);
            this.addNewQuoteButton.Name = "addNewQuoteButton";
            this.addNewQuoteButton.Size = new System.Drawing.Size(160, 60);
            this.addNewQuoteButton.TabIndex = 0;
            this.addNewQuoteButton.Text = "Add New Quote";
            this.addNewQuoteButton.UseVisualStyleBackColor = true;
            this.addNewQuoteButton.Click += new System.EventHandler(this.addNewQuoteButton_Click);
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.Location = new System.Drawing.Point(12, 124);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(160, 60);
            this.viewQuotesButton.TabIndex = 1;
            this.viewQuotesButton.Text = "View Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = true;
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Location = new System.Drawing.Point(12, 224);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(160, 60);
            this.searchQuotesButton.TabIndex = 2;
            this.searchQuotesButton.Text = "Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 320);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(160, 60);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // MegaDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 409);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.viewQuotesButton);
            this.Controls.Add(this.addNewQuoteButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MegaDesk";
            this.Text = "MegaDesk -- Mena-Osorio";
            this.Load += new System.EventHandler(this.MegaDesk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuoteButton;
        private System.Windows.Forms.Button viewQuotesButton;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button exitButton;
    }
}


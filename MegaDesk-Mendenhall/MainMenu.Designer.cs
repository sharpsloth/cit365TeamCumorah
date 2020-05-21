namespace MegaDesk_Mendenhall
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newQuote = new System.Windows.Forms.Button();
            this.exitBttn = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.BackColor = System.Drawing.Color.White;
            this.newQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuote.Location = new System.Drawing.Point(34, 444);
            this.newQuote.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(200, 50);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "&Add New Quote";
            this.newQuote.UseVisualStyleBackColor = false;
            this.newQuote.Click += new System.EventHandler(this.newQuote_Click);
            // 
            // exitBttn
            // 
            this.exitBttn.BackColor = System.Drawing.Color.White;
            this.exitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBttn.Location = new System.Drawing.Point(823, 444);
            this.exitBttn.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.exitBttn.Name = "exitBttn";
            this.exitBttn.Size = new System.Drawing.Size(200, 50);
            this.exitBttn.TabIndex = 1;
            this.exitBttn.Text = "E&xit";
            this.exitBttn.UseVisualStyleBackColor = false;
            this.exitBttn.Click += new System.EventHandler(this.exitBttn_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.BackColor = System.Drawing.Color.White;
            this.searchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.Location = new System.Drawing.Point(561, 444);
            this.searchQuotes.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Size = new System.Drawing.Size(200, 50);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "&Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = false;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.BackColor = System.Drawing.Color.White;
            this.viewQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.Location = new System.Drawing.Point(293, 444);
            this.viewQuotes.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Size = new System.Drawing.Size(200, 50);
            this.viewQuotes.TabIndex = 3;
            this.viewQuotes.Text = "&View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = false;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Mendenhall.Properties.Resources.macbook_336704_1920_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1057, 518);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.exitBttn);
            this.Controls.Add(this.newQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newQuote;
        private System.Windows.Forms.Button exitBttn;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button viewQuotes;
    }
}


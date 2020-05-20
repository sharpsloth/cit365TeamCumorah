namespace MegaDesk_Mendenhall
{
    partial class ViewAllQuotes
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
            this.returnMainMenu = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // returnMainMenu
            // 
            this.returnMainMenu.BackColor = System.Drawing.Color.White;
            this.returnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainMenu.Location = new System.Drawing.Point(281, 395);
            this.returnMainMenu.Margin = new System.Windows.Forms.Padding(20, 20, 20, 35);
            this.returnMainMenu.Name = "returnMainMenu";
            this.returnMainMenu.Size = new System.Drawing.Size(200, 30);
            this.returnMainMenu.TabIndex = 12;
            this.returnMainMenu.Text = "Return to Main Menu";
            this.returnMainMenu.UseVisualStyleBackColor = false;
            this.returnMainMenu.Click += new System.EventHandler(this.returnMainMenu_Click);
            // 
            // dataGridViewAll
            // 
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(775, 359);
            this.dataGridViewAll.TabIndex = 13;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.returnMainMenu);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewAll;
    }
}
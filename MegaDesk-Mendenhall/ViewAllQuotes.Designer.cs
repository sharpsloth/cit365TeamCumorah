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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.returnMainMenu = new System.Windows.Forms.Button();
            this.dataGridViewAll = new System.Windows.Forms.DataGridView();
            this.sortDateBtn = new System.Windows.Forms.Button();
            this.sortCustomerNameBtn = new System.Windows.Forms.Button();
            this.sortMaterialBtn = new System.Windows.Forms.Button();
            this.sortRushDaysBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).BeginInit();
            this.SuspendLayout();
            // 
            // returnMainMenu
            // 
            this.returnMainMenu.BackColor = System.Drawing.Color.White;
            this.returnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewAll.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewAll.Name = "dataGridViewAll";
            this.dataGridViewAll.Size = new System.Drawing.Size(775, 325);
            this.dataGridViewAll.TabIndex = 13;
            // 
            // sortDateBtn
            // 
            this.sortDateBtn.BackColor = System.Drawing.Color.White;
            this.sortDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortDateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sortDateBtn.Location = new System.Drawing.Point(139, 358);
            this.sortDateBtn.Margin = new System.Windows.Forms.Padding(20, 20, 20, 35);
            this.sortDateBtn.Name = "sortDateBtn";
            this.sortDateBtn.Size = new System.Drawing.Size(101, 30);
            this.sortDateBtn.TabIndex = 14;
            this.sortDateBtn.Text = "Sort Date";
            this.sortDateBtn.UseVisualStyleBackColor = false;
            this.sortDateBtn.Click += new System.EventHandler(this.sortDateBtn_Click);
            // 
            // sortCustomerNameBtn
            // 
            this.sortCustomerNameBtn.BackColor = System.Drawing.Color.White;
            this.sortCustomerNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortCustomerNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sortCustomerNameBtn.Location = new System.Drawing.Point(254, 358);
            this.sortCustomerNameBtn.Margin = new System.Windows.Forms.Padding(20, 20, 20, 35);
            this.sortCustomerNameBtn.Name = "sortCustomerNameBtn";
            this.sortCustomerNameBtn.Size = new System.Drawing.Size(110, 30);
            this.sortCustomerNameBtn.TabIndex = 15;
            this.sortCustomerNameBtn.Text = "Sort Name";
            this.sortCustomerNameBtn.UseVisualStyleBackColor = false;
            this.sortCustomerNameBtn.Click += new System.EventHandler(this.sortCustomerNameBtn_Click);
            // 
            // sortMaterialBtn
            // 
            this.sortMaterialBtn.BackColor = System.Drawing.Color.White;
            this.sortMaterialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortMaterialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sortMaterialBtn.Location = new System.Drawing.Point(379, 358);
            this.sortMaterialBtn.Margin = new System.Windows.Forms.Padding(20, 20, 20, 35);
            this.sortMaterialBtn.Name = "sortMaterialBtn";
            this.sortMaterialBtn.Size = new System.Drawing.Size(126, 30);
            this.sortMaterialBtn.TabIndex = 16;
            this.sortMaterialBtn.Text = "Sort Material";
            this.sortMaterialBtn.UseVisualStyleBackColor = false;
            this.sortMaterialBtn.Click += new System.EventHandler(this.sortMaterialBtn_Click);
            // 
            // sortRushDaysBtn
            // 
            this.sortRushDaysBtn.BackColor = System.Drawing.Color.White;
            this.sortRushDaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortRushDaysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sortRushDaysBtn.Location = new System.Drawing.Point(519, 358);
            this.sortRushDaysBtn.Margin = new System.Windows.Forms.Padding(20, 20, 20, 35);
            this.sortRushDaysBtn.Name = "sortRushDaysBtn";
            this.sortRushDaysBtn.Size = new System.Drawing.Size(148, 30);
            this.sortRushDaysBtn.TabIndex = 18;
            this.sortRushDaysBtn.Text = "Sort Rush Days";
            this.sortRushDaysBtn.UseVisualStyleBackColor = false;
            this.sortRushDaysBtn.Click += new System.EventHandler(this.sortRushDaysBtn_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Mendenhall.Properties.Resources.macbook_336704_1920_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortRushDaysBtn);
            this.Controls.Add(this.sortMaterialBtn);
            this.Controls.Add(this.sortCustomerNameBtn);
            this.Controls.Add(this.sortDateBtn);
            this.Controls.Add(this.dataGridViewAll);
            this.Controls.Add(this.returnMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllQuotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewAll;
        private System.Windows.Forms.Button sortDateBtn;
        private System.Windows.Forms.Button sortCustomerNameBtn;
        private System.Windows.Forms.Button sortMaterialBtn;
        private System.Windows.Forms.Button sortRushDaysBtn;
    }
}
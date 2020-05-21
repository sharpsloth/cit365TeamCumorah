using System;

namespace MegaDesk_Mendenhall
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.submitQuote = new System.Windows.Forms.Button();
            this.AddQuoteCancelBttn = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.drawerSelection = new System.Windows.Forms.NumericUpDown();
            this.materialSelection = new System.Windows.Forms.DomainUpDown();
            this.materialLabel = new System.Windows.Forms.Label();
            this.shippingLabel = new System.Windows.Forms.Label();
            this.shippingBox = new System.Windows.Forms.DomainUpDown();
            this.errorProviderDepth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawerSelection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // submitQuote
            // 
            this.submitQuote.BackColor = System.Drawing.Color.White;
            this.submitQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitQuote.Location = new System.Drawing.Point(126, 331);
            this.submitQuote.Margin = new System.Windows.Forms.Padding(20);
            this.submitQuote.Name = "submitQuote";
            this.submitQuote.Size = new System.Drawing.Size(150, 30);
            this.submitQuote.TabIndex = 8;
            this.submitQuote.Text = "Submit";
            this.submitQuote.UseVisualStyleBackColor = false;
            this.submitQuote.Click += new System.EventHandler(this.submitQuote_Click);
            // 
            // AddQuoteCancelBttn
            // 
            this.AddQuoteCancelBttn.BackColor = System.Drawing.Color.White;
            this.AddQuoteCancelBttn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddQuoteCancelBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddQuoteCancelBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteCancelBttn.Location = new System.Drawing.Point(336, 331);
            this.AddQuoteCancelBttn.Margin = new System.Windows.Forms.Padding(20);
            this.AddQuoteCancelBttn.Name = "AddQuoteCancelBttn";
            this.AddQuoteCancelBttn.Size = new System.Drawing.Size(150, 30);
            this.AddQuoteCancelBttn.TabIndex = 9;
            this.AddQuoteCancelBttn.Text = "Cancel";
            this.AddQuoteCancelBttn.UseVisualStyleBackColor = false;
            this.AddQuoteCancelBttn.Click += new System.EventHandler(this.AddQuoteCancelBttn_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(246, 98);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(150, 22);
            this.nameBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(181, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Padding = new System.Windows.Forms.Padding(2);
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // widthBox
            // 
            this.widthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.Location = new System.Drawing.Point(246, 160);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(150, 22);
            this.widthBox.TabIndex = 4;
            this.widthBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthBox_Validating);
            this.widthBox.Validated += new System.EventHandler(this.widthBox_Validated);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(183, 162);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Padding = new System.Windows.Forms.Padding(2);
            this.widthLabel.Size = new System.Drawing.Size(51, 20);
            this.widthLabel.TabIndex = 8;
            this.widthLabel.Text = "Width";
            // 
            // depthBox
            // 
            this.depthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthBox.Location = new System.Drawing.Point(247, 129);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(150, 22);
            this.depthBox.TabIndex = 3;
            this.depthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthBox_KeyPress);
            this.depthBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthBox_Validating);
            this.depthBox.Validated += new System.EventHandler(this.depthBox_Validated);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(181, 131);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Padding = new System.Windows.Forms.Padding(2);
            this.depthLabel.Size = new System.Drawing.Size(53, 20);
            this.depthLabel.TabIndex = 7;
            this.depthLabel.Text = "Depth";
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.drawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersLabel.Location = new System.Drawing.Point(165, 191);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Padding = new System.Windows.Forms.Padding(2);
            this.drawersLabel.Size = new System.Drawing.Size(69, 20);
            this.drawersLabel.TabIndex = 9;
            this.drawersLabel.Text = "Drawers";
            // 
            // drawerSelection
            // 
            this.drawerSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerSelection.Location = new System.Drawing.Point(246, 191);
            this.drawerSelection.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerSelection.Name = "drawerSelection";
            this.drawerSelection.Size = new System.Drawing.Size(75, 22);
            this.drawerSelection.TabIndex = 5;
            this.drawerSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialSelection
            // 
            this.materialSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSelection.Location = new System.Drawing.Point(246, 222);
            this.materialSelection.Name = "materialSelection";
            this.materialSelection.Size = new System.Drawing.Size(100, 22);
            this.materialSelection.TabIndex = 6;
            this.materialSelection.Text = "Pine";
            this.materialSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialSelection.Wrap = true;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(165, 221);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Padding = new System.Windows.Forms.Padding(2);
            this.materialLabel.Size = new System.Drawing.Size(68, 20);
            this.materialLabel.TabIndex = 11;
            this.materialLabel.Text = "Material";
            // 
            // shippingLabel
            // 
            this.shippingLabel.AutoSize = true;
            this.shippingLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.shippingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingLabel.Location = new System.Drawing.Point(161, 253);
            this.shippingLabel.Name = "shippingLabel";
            this.shippingLabel.Padding = new System.Windows.Forms.Padding(2);
            this.shippingLabel.Size = new System.Drawing.Size(73, 20);
            this.shippingLabel.TabIndex = 13;
            this.shippingLabel.Text = "Shipping";
            // 
            // shippingBox
            // 
            this.shippingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingBox.Items.Add("3 Days");
            this.shippingBox.Items.Add("5 Days");
            this.shippingBox.Items.Add("7 Days");
            this.shippingBox.Items.Add("14 Days");
            this.shippingBox.Location = new System.Drawing.Point(246, 253);
            this.shippingBox.Name = "shippingBox";
            this.shippingBox.Size = new System.Drawing.Size(100, 22);
            this.shippingBox.TabIndex = 7;
            this.shippingBox.Text = "14 Days";
            this.shippingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shippingBox.Wrap = true;
            // 
            // errorProviderDepth
            // 
            this.errorProviderDepth.ContainerControl = this;
            // 
            // errorProviderWidth
            // 
            this.errorProviderWidth.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 160);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = " 12\'\' - 48\'\'";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 129);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = " 24\'\' - 96\'\'";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_Mendenhall.Properties.Resources.notebook_1280538_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.AddQuoteCancelBttn;
            this.ClientSize = new System.Drawing.Size(595, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shippingLabel);
            this.Controls.Add(this.shippingBox);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.materialSelection);
            this.Controls.Add(this.drawerSelection);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.AddQuoteCancelBttn);
            this.Controls.Add(this.submitQuote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.drawerSelection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitQuote;
        private System.Windows.Forms.Button AddQuoteCancelBttn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.NumericUpDown drawerSelection;
        private System.Windows.Forms.DomainUpDown materialSelection;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label shippingLabel;
        private System.Windows.Forms.DomainUpDown shippingBox;
        private System.Windows.Forms.ErrorProvider errorProviderDepth;
        private System.Windows.Forms.ErrorProvider errorProviderWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
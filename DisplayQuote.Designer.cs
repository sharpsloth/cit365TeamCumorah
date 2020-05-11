namespace MegaDesk_Mendenhall
{
    partial class DisplayQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayQuote));
            this.returnMainMenu = new System.Windows.Forms.Button();
            this.drawerSelection = new System.Windows.Forms.NumericUpDown();
            this.displayTable = new System.Windows.Forms.TableLayoutPanel();
            this.basePriceIncludes = new System.Windows.Forms.Label();
            this.basePriceLabel = new System.Windows.Forms.Label();
            this.displayNameLabel = new System.Windows.Forms.Label();
            this.quoteTitle = new System.Windows.Forms.Label();
            this.displayName = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.rushCostLabel = new System.Windows.Forms.Label();
            this.rushStatusLabel = new System.Windows.Forms.Label();
            this.materialCostLabel = new System.Windows.Forms.Label();
            this.materialNameLabel = new System.Windows.Forms.Label();
            this.drawerCostLabel = new System.Windows.Forms.Label();
            this.drawerAmountLabel = new System.Windows.Forms.Label();
            this.drawerPriceLabel = new System.Windows.Forms.Label();
            this.displaySizeCostLabel = new System.Windows.Forms.Label();
            this.displaySizeCost = new System.Windows.Forms.Label();
            this.displayOverageLabel = new System.Windows.Forms.Label();
            this.displayOverage = new System.Windows.Forms.Label();
            this.displayAreaLabel = new System.Windows.Forms.Label();
            this.displayArea = new System.Windows.Forms.Label();
            this.displayCostPerInLabel = new System.Windows.Forms.Label();
            this.displayCostPerIn = new System.Windows.Forms.Label();
            this.drawerPrice = new System.Windows.Forms.Label();
            this.drawerAmount = new System.Windows.Forms.Label();
            this.drawerCost = new System.Windows.Forms.Label();
            this.materialName = new System.Windows.Forms.Label();
            this.materialCost = new System.Windows.Forms.Label();
            this.rushStatus = new System.Windows.Forms.Label();
            this.rushCost = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.todaysDateLabel = new System.Windows.Forms.Label();
            this.todaysDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawerSelection)).BeginInit();
            this.displayTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnMainMenu
            // 
            this.returnMainMenu.BackColor = System.Drawing.Color.White;
            this.returnMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.returnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMainMenu.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainMenu.Location = new System.Drawing.Point(96, 485);
            this.returnMainMenu.Margin = new System.Windows.Forms.Padding(20, 20, 20, 35);
            this.returnMainMenu.Name = "returnMainMenu";
            this.returnMainMenu.Size = new System.Drawing.Size(200, 30);
            this.returnMainMenu.TabIndex = 10;
            this.returnMainMenu.Text = "Return to Main Menu";
            this.returnMainMenu.UseVisualStyleBackColor = false;
            this.returnMainMenu.Click += new System.EventHandler(this.returnMainMenu_Click);
            // 
            // drawerSelection
            // 
            this.drawerSelection.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerSelection.Location = new System.Drawing.Point(286, 200);
            this.drawerSelection.Name = "drawerSelection";
            this.drawerSelection.Size = new System.Drawing.Size(75, 25);
            this.drawerSelection.TabIndex = 20;
            this.drawerSelection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayTable
            // 
            this.displayTable.BackColor = System.Drawing.Color.Transparent;
            this.displayTable.ColumnCount = 2;
            this.displayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displayTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.displayTable.Controls.Add(this.basePriceIncludes, 0, 5);
            this.displayTable.Controls.Add(this.basePriceLabel, 0, 4);
            this.displayTable.Controls.Add(this.quoteTitle, 0, 0);
            this.displayTable.Controls.Add(this.basePrice, 1, 4);
            this.displayTable.Controls.Add(this.totalCostLabel, 0, 21);
            this.displayTable.Controls.Add(this.rushCostLabel, 0, 19);
            this.displayTable.Controls.Add(this.rushStatusLabel, 0, 18);
            this.displayTable.Controls.Add(this.materialCostLabel, 0, 16);
            this.displayTable.Controls.Add(this.materialNameLabel, 0, 15);
            this.displayTable.Controls.Add(this.drawerCostLabel, 0, 13);
            this.displayTable.Controls.Add(this.drawerAmountLabel, 0, 12);
            this.displayTable.Controls.Add(this.drawerPriceLabel, 0, 11);
            this.displayTable.Controls.Add(this.displaySizeCostLabel, 0, 9);
            this.displayTable.Controls.Add(this.displaySizeCost, 1, 9);
            this.displayTable.Controls.Add(this.displayOverageLabel, 0, 8);
            this.displayTable.Controls.Add(this.displayOverage, 1, 8);
            this.displayTable.Controls.Add(this.displayAreaLabel, 0, 7);
            this.displayTable.Controls.Add(this.displayArea, 1, 7);
            this.displayTable.Controls.Add(this.displayCostPerInLabel, 0, 6);
            this.displayTable.Controls.Add(this.displayCostPerIn, 1, 6);
            this.displayTable.Controls.Add(this.drawerPrice, 1, 11);
            this.displayTable.Controls.Add(this.drawerAmount, 1, 12);
            this.displayTable.Controls.Add(this.drawerCost, 1, 13);
            this.displayTable.Controls.Add(this.materialName, 1, 15);
            this.displayTable.Controls.Add(this.materialCost, 1, 16);
            this.displayTable.Controls.Add(this.rushStatus, 1, 18);
            this.displayTable.Controls.Add(this.rushCost, 1, 19);
            this.displayTable.Controls.Add(this.totalCost, 1, 21);
            this.displayTable.Controls.Add(this.displayNameLabel, 0, 1);
            this.displayTable.Controls.Add(this.displayName, 1, 1);
            this.displayTable.Controls.Add(this.todaysDateLabel, 0, 2);
            this.displayTable.Controls.Add(this.todaysDate, 1, 2);
            this.displayTable.Font = new System.Drawing.Font("Roboto Slab", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTable.Location = new System.Drawing.Point(25, 24);
            this.displayTable.Name = "displayTable";
            this.displayTable.RowCount = 22;
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.displayTable.Size = new System.Drawing.Size(335, 455);
            this.displayTable.TabIndex = 28;
            // 
            // basePriceIncludes
            // 
            this.basePriceIncludes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.basePriceIncludes.AutoSize = true;
            this.displayTable.SetColumnSpan(this.basePriceIncludes, 2);
            this.basePriceIncludes.Location = new System.Drawing.Point(71, 107);
            this.basePriceIncludes.Name = "basePriceIncludes";
            this.basePriceIncludes.Size = new System.Drawing.Size(192, 15);
            this.basePriceIncludes.TabIndex = 2;
            this.basePriceIncludes.Text = "* base price includes up to 1,000 in²";
            // 
            // basePriceLabel
            // 
            this.basePriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.basePriceLabel.AutoSize = true;
            this.basePriceLabel.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePriceLabel.Location = new System.Drawing.Point(94, 86);
            this.basePriceLabel.Name = "basePriceLabel";
            this.basePriceLabel.Size = new System.Drawing.Size(70, 17);
            this.basePriceLabel.TabIndex = 1;
            this.basePriceLabel.Text = "Base Price:";
            // 
            // displayNameLabel
            // 
            this.displayNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayNameLabel.AutoSize = true;
            this.displayNameLabel.Location = new System.Drawing.Point(123, 27);
            this.displayNameLabel.Name = "displayNameLabel";
            this.displayNameLabel.Size = new System.Drawing.Size(41, 15);
            this.displayNameLabel.TabIndex = 0;
            this.displayNameLabel.Text = "Name:";
            // 
            // quoteTitle
            // 
            this.quoteTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quoteTitle.AutoSize = true;
            this.displayTable.SetColumnSpan(this.quoteTitle, 2);
            this.quoteTitle.Font = new System.Drawing.Font("Roboto Slab Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteTitle.Location = new System.Drawing.Point(100, 0);
            this.quoteTitle.Name = "quoteTitle";
            this.quoteTitle.Size = new System.Drawing.Size(135, 25);
            this.quoteTitle.TabIndex = 14;
            this.quoteTitle.Text = "Quote Details";
            // 
            // displayName
            // 
            this.displayName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.displayName.AutoSize = true;
            this.displayName.Location = new System.Drawing.Point(170, 27);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(77, 15);
            this.displayName.TabIndex = 15;
            this.displayName.Text = "Sara Johnson";
            // 
            // basePrice
            // 
            this.basePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.basePrice.AutoSize = true;
            this.basePrice.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basePrice.Location = new System.Drawing.Point(170, 86);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(52, 17);
            this.basePrice.TabIndex = 16;
            this.basePrice.Text = "$200.00";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Roboto Slab Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(77, 429);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(87, 21);
            this.totalCostLabel.TabIndex = 13;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // rushCostLabel
            // 
            this.rushCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rushCostLabel.AutoSize = true;
            this.rushCostLabel.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushCostLabel.Location = new System.Drawing.Point(60, 386);
            this.rushCostLabel.Name = "rushCostLabel";
            this.rushCostLabel.Size = new System.Drawing.Size(104, 17);
            this.rushCostLabel.TabIndex = 12;
            this.rushCostLabel.Text = "Rush Order Cost:";
            // 
            // rushStatusLabel
            // 
            this.rushStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rushStatusLabel.AutoSize = true;
            this.rushStatusLabel.Location = new System.Drawing.Point(111, 367);
            this.rushStatusLabel.Name = "rushStatusLabel";
            this.rushStatusLabel.Size = new System.Drawing.Size(53, 15);
            this.rushStatusLabel.TabIndex = 11;
            this.rushStatusLabel.Text = "Delivery:";
            // 
            // materialCostLabel
            // 
            this.materialCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialCostLabel.AutoSize = true;
            this.materialCostLabel.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCostLabel.Location = new System.Drawing.Point(76, 326);
            this.materialCostLabel.Name = "materialCostLabel";
            this.materialCostLabel.Size = new System.Drawing.Size(88, 17);
            this.materialCostLabel.TabIndex = 10;
            this.materialCostLabel.Text = "Material Cost:";
            // 
            // materialNameLabel
            // 
            this.materialNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.materialNameLabel.AutoSize = true;
            this.materialNameLabel.Location = new System.Drawing.Point(109, 307);
            this.materialNameLabel.Name = "materialNameLabel";
            this.materialNameLabel.Size = new System.Drawing.Size(55, 15);
            this.materialNameLabel.TabIndex = 9;
            this.materialNameLabel.Text = "Material:";
            // 
            // drawerCostLabel
            // 
            this.drawerCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.drawerCostLabel.AutoSize = true;
            this.drawerCostLabel.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerCostLabel.Location = new System.Drawing.Point(82, 266);
            this.drawerCostLabel.Name = "drawerCostLabel";
            this.drawerCostLabel.Size = new System.Drawing.Size(82, 17);
            this.drawerCostLabel.TabIndex = 8;
            this.drawerCostLabel.Text = "Drawer Cost:";
            // 
            // drawerAmountLabel
            // 
            this.drawerAmountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.drawerAmountLabel.AutoSize = true;
            this.drawerAmountLabel.Location = new System.Drawing.Point(51, 247);
            this.drawerAmountLabel.Name = "drawerAmountLabel";
            this.drawerAmountLabel.Size = new System.Drawing.Size(113, 15);
            this.drawerAmountLabel.TabIndex = 7;
            this.drawerAmountLabel.Text = "Number of Drawers:";
            // 
            // drawerPriceLabel
            // 
            this.drawerPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.drawerPriceLabel.AutoSize = true;
            this.drawerPriceLabel.Location = new System.Drawing.Point(64, 227);
            this.drawerPriceLabel.Name = "drawerPriceLabel";
            this.drawerPriceLabel.Size = new System.Drawing.Size(100, 15);
            this.drawerPriceLabel.TabIndex = 6;
            this.drawerPriceLabel.Text = "Price Per Drawer:";
            // 
            // displaySizeCostLabel
            // 
            this.displaySizeCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displaySizeCostLabel.AutoSize = true;
            this.displaySizeCostLabel.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySizeCostLabel.Location = new System.Drawing.Point(101, 186);
            this.displaySizeCostLabel.Name = "displaySizeCostLabel";
            this.displaySizeCostLabel.Size = new System.Drawing.Size(63, 17);
            this.displaySizeCostLabel.TabIndex = 5;
            this.displaySizeCostLabel.Text = "Size Cost:";
            // 
            // displaySizeCost
            // 
            this.displaySizeCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.displaySizeCost.AutoSize = true;
            this.displaySizeCost.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaySizeCost.Location = new System.Drawing.Point(170, 186);
            this.displaySizeCost.Name = "displaySizeCost";
            this.displaySizeCost.Size = new System.Drawing.Size(57, 17);
            this.displaySizeCost.TabIndex = 19;
            this.displaySizeCost.Text = "$3768.00";
            // 
            // displayOverageLabel
            // 
            this.displayOverageLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayOverageLabel.AutoSize = true;
            this.displayOverageLabel.Location = new System.Drawing.Point(88, 167);
            this.displayOverageLabel.Name = "displayOverageLabel";
            this.displayOverageLabel.Size = new System.Drawing.Size(76, 15);
            this.displayOverageLabel.TabIndex = 4;
            this.displayOverageLabel.Text = "Size Overage:";
            // 
            // displayOverage
            // 
            this.displayOverage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.displayOverage.AutoSize = true;
            this.displayOverage.Location = new System.Drawing.Point(170, 167);
            this.displayOverage.Name = "displayOverage";
            this.displayOverage.Size = new System.Drawing.Size(31, 15);
            this.displayOverage.TabIndex = 18;
            this.displayOverage.Text = "3568";
            // 
            // displayAreaLabel
            // 
            this.displayAreaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayAreaLabel.AutoSize = true;
            this.displayAreaLabel.Location = new System.Drawing.Point(130, 147);
            this.displayAreaLabel.Name = "displayAreaLabel";
            this.displayAreaLabel.Size = new System.Drawing.Size(34, 15);
            this.displayAreaLabel.TabIndex = 3;
            this.displayAreaLabel.Text = "Area:";
            // 
            // displayArea
            // 
            this.displayArea.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.displayArea.AutoSize = true;
            this.displayArea.Location = new System.Drawing.Point(170, 147);
            this.displayArea.Name = "displayArea";
            this.displayArea.Size = new System.Drawing.Size(31, 15);
            this.displayArea.TabIndex = 17;
            this.displayArea.Text = "4568";
            // 
            // displayCostPerInLabel
            // 
            this.displayCostPerInLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayCostPerInLabel.AutoSize = true;
            this.displayCostPerInLabel.Location = new System.Drawing.Point(94, 127);
            this.displayCostPerInLabel.Name = "displayCostPerInLabel";
            this.displayCostPerInLabel.Size = new System.Drawing.Size(70, 15);
            this.displayCostPerInLabel.TabIndex = 20;
            this.displayCostPerInLabel.Text = "Cost Per in²:";
            // 
            // displayCostPerIn
            // 
            this.displayCostPerIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.displayCostPerIn.AutoSize = true;
            this.displayCostPerIn.Location = new System.Drawing.Point(170, 127);
            this.displayCostPerIn.Name = "displayCostPerIn";
            this.displayCostPerIn.Size = new System.Drawing.Size(33, 15);
            this.displayCostPerIn.TabIndex = 21;
            this.displayCostPerIn.Text = "$1.00";
            // 
            // drawerPrice
            // 
            this.drawerPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drawerPrice.AutoSize = true;
            this.drawerPrice.Location = new System.Drawing.Point(170, 227);
            this.drawerPrice.Name = "drawerPrice";
            this.drawerPrice.Size = new System.Drawing.Size(40, 15);
            this.drawerPrice.TabIndex = 22;
            this.drawerPrice.Text = "$50.00";
            // 
            // drawerAmount
            // 
            this.drawerAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drawerAmount.AutoSize = true;
            this.drawerAmount.Location = new System.Drawing.Point(170, 247);
            this.drawerAmount.Name = "drawerAmount";
            this.drawerAmount.Size = new System.Drawing.Size(13, 15);
            this.drawerAmount.TabIndex = 23;
            this.drawerAmount.Text = "4";
            // 
            // drawerCost
            // 
            this.drawerCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drawerCost.AutoSize = true;
            this.drawerCost.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerCost.Location = new System.Drawing.Point(170, 266);
            this.drawerCost.Name = "drawerCost";
            this.drawerCost.Size = new System.Drawing.Size(52, 17);
            this.drawerCost.TabIndex = 24;
            this.drawerCost.Text = "$200.00";
            // 
            // materialName
            // 
            this.materialName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialName.AutoSize = true;
            this.materialName.Location = new System.Drawing.Point(170, 307);
            this.materialName.Name = "materialName";
            this.materialName.Size = new System.Drawing.Size(31, 15);
            this.materialName.TabIndex = 25;
            this.materialName.Text = "Pine";
            // 
            // materialCost
            // 
            this.materialCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialCost.AutoSize = true;
            this.materialCost.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCost.Location = new System.Drawing.Point(170, 326);
            this.materialCost.Name = "materialCost";
            this.materialCost.Size = new System.Drawing.Size(44, 17);
            this.materialCost.TabIndex = 26;
            this.materialCost.Text = "$50.00";
            // 
            // rushStatus
            // 
            this.rushStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rushStatus.AutoSize = true;
            this.rushStatus.Location = new System.Drawing.Point(170, 367);
            this.rushStatus.Name = "rushStatus";
            this.rushStatus.Size = new System.Drawing.Size(35, 15);
            this.rushStatus.TabIndex = 27;
            this.rushStatus.Text = "3 Day";
            // 
            // rushCost
            // 
            this.rushCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rushCost.AutoSize = true;
            this.rushCost.Font = new System.Drawing.Font("Roboto Slab Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushCost.Location = new System.Drawing.Point(170, 386);
            this.rushCost.Name = "rushCost";
            this.rushCost.Size = new System.Drawing.Size(44, 17);
            this.rushCost.TabIndex = 28;
            this.rushCost.Text = "$80.00";
            // 
            // totalCost
            // 
            this.totalCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Roboto Slab Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(170, 429);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(77, 22);
            this.totalCost.TabIndex = 29;
            this.totalCost.Text = "$4098.00";
            // 
            // todaysDateLabel
            // 
            this.todaysDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.todaysDateLabel.AutoSize = true;
            this.todaysDateLabel.Location = new System.Drawing.Point(132, 47);
            this.todaysDateLabel.Name = "todaysDateLabel";
            this.todaysDateLabel.Size = new System.Drawing.Size(32, 15);
            this.todaysDateLabel.TabIndex = 30;
            this.todaysDateLabel.Text = "Date:";
            // 
            // todaysDate
            // 
            this.todaysDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.todaysDate.AutoSize = true;
            this.todaysDate.Location = new System.Drawing.Point(170, 47);
            this.todaysDate.Name = "todaysDate";
            this.todaysDate.Size = new System.Drawing.Size(36, 15);
            this.todaysDate.TabIndex = 31;
            this.todaysDate.Text = "today";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.returnMainMenu;
            this.ClientSize = new System.Drawing.Size(385, 550);
            this.Controls.Add(this.displayTable);
            this.Controls.Add(this.drawerSelection);
            this.Controls.Add(this.returnMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayQuote";
            this.Text = "Quote";
            ((System.ComponentModel.ISupportInitialize)(this.drawerSelection)).EndInit();
            this.displayTable.ResumeLayout(false);
            this.displayTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnMainMenu;
        private System.Windows.Forms.NumericUpDown drawerSelection;
        private System.Windows.Forms.TableLayoutPanel displayTable;
        private System.Windows.Forms.Label displayNameLabel;
        private System.Windows.Forms.Label basePriceLabel;
        private System.Windows.Forms.Label basePriceIncludes;
        private System.Windows.Forms.Label displayAreaLabel;
        private System.Windows.Forms.Label displayOverageLabel;
        private System.Windows.Forms.Label displaySizeCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label rushCostLabel;
        private System.Windows.Forms.Label rushStatusLabel;
        private System.Windows.Forms.Label materialCostLabel;
        private System.Windows.Forms.Label materialNameLabel;
        private System.Windows.Forms.Label drawerCostLabel;
        private System.Windows.Forms.Label drawerAmountLabel;
        private System.Windows.Forms.Label drawerPriceLabel;
        private System.Windows.Forms.Label quoteTitle;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Label basePrice;
        private System.Windows.Forms.Label displaySizeCost;
        private System.Windows.Forms.Label displayOverage;
        private System.Windows.Forms.Label displayArea;
        private System.Windows.Forms.Label displayCostPerInLabel;
        private System.Windows.Forms.Label displayCostPerIn;
        private System.Windows.Forms.Label drawerPrice;
        private System.Windows.Forms.Label drawerAmount;
        private System.Windows.Forms.Label drawerCost;
        private System.Windows.Forms.Label materialName;
        private System.Windows.Forms.Label materialCost;
        private System.Windows.Forms.Label rushStatus;
        private System.Windows.Forms.Label rushCost;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label todaysDateLabel;
        private System.Windows.Forms.Label todaysDate;
    }
}
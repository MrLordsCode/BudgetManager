namespace BudgetManager
{
    partial class WindowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.menuStripMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxLabel = new System.Windows.Forms.CheckBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.labelMoneyIn = new System.Windows.Forms.Label();
            this.numericUpDownMoneyIn = new System.Windows.Forms.NumericUpDown();
            this.buttonMoneyIn = new System.Windows.Forms.Button();
            this.buttonMoneyOut = new System.Windows.Forms.Button();
            this.numericUpDownMoneyOut = new System.Windows.Forms.NumericUpDown();
            this.labelMoneyOut = new System.Windows.Forms.Label();
            this.listBoxBudgeting = new System.Windows.Forms.ListBox();
            this.labelTotalMoneyIn = new System.Windows.Forms.Label();
            this.labelMoneyInTotal = new System.Windows.Forms.Label();
            this.labelTotalMoneyOut = new System.Windows.Forms.Label();
            this.labelMoneyOutTotal = new System.Windows.Forms.Label();
            this.labelTotalMoney = new System.Windows.Forms.Label();
            this.labelMoneyTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanelTotals = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLabel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMoneyIn = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMoneyOut = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonEditSelected = new System.Windows.Forms.Button();
            this.buttonSortList = new System.Windows.Forms.Button();
            this.tableLayoutPanelEditSelected = new System.Windows.Forms.TableLayoutPanel();
            this.labelEditLabel = new System.Windows.Forms.Label();
            this.labelEditMoney = new System.Windows.Forms.Label();
            this.buttonUpdateSelected = new System.Windows.Forms.Button();
            this.textBoxEditLabel = new System.Windows.Forms.TextBox();
            this.buttonCancelEdit = new System.Windows.Forms.Button();
            this.numericUpDownEditMoney = new System.Windows.Forms.NumericUpDown();
            this.menuStripMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoneyIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoneyOut)).BeginInit();
            this.tableLayoutPanelTotals.SuspendLayout();
            this.tableLayoutPanelLabel.SuspendLayout();
            this.tableLayoutPanelMoneyIn.SuspendLayout();
            this.tableLayoutPanelMoneyOut.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.tableLayoutPanelEditSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            this.menuStripMainMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripMainMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenu.Name = "menuStripMainMenu";
            this.menuStripMainMenu.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStripMainMenu.Size = new System.Drawing.Size(404, 24);
            this.menuStripMainMenu.TabIndex = 0;
            this.menuStripMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.MenuSave);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.MenuLoad);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.AutoSize = true;
            this.checkBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxLabel.Location = new System.Drawing.Point(5, 5);
            this.checkBoxLabel.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.Size = new System.Drawing.Size(89, 24);
            this.checkBoxLabel.TabIndex = 1;
            this.checkBoxLabel.Text = "Add Label";
            this.checkBoxLabel.UseVisualStyleBackColor = true;
            this.checkBoxLabel.CheckedChanged += new System.EventHandler(this.AddLabelCheck);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLabel.Enabled = false;
            this.textBoxLabel.Location = new System.Drawing.Point(101, 5);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(276, 23);
            this.textBoxLabel.TabIndex = 2;
            // 
            // labelMoneyIn
            // 
            this.labelMoneyIn.AutoSize = true;
            this.labelMoneyIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoneyIn.Location = new System.Drawing.Point(5, 3);
            this.labelMoneyIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyIn.Name = "labelMoneyIn";
            this.labelMoneyIn.Size = new System.Drawing.Size(88, 28);
            this.labelMoneyIn.TabIndex = 3;
            this.labelMoneyIn.Text = "Money In";
            this.labelMoneyIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownMoneyIn
            // 
            this.numericUpDownMoneyIn.DecimalPlaces = 2;
            this.numericUpDownMoneyIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMoneyIn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMoneyIn.Location = new System.Drawing.Point(100, 5);
            this.numericUpDownMoneyIn.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMoneyIn.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownMoneyIn.Name = "numericUpDownMoneyIn";
            this.numericUpDownMoneyIn.Size = new System.Drawing.Size(162, 23);
            this.numericUpDownMoneyIn.TabIndex = 4;
            this.numericUpDownMoneyIn.ThousandsSeparator = true;
            // 
            // buttonMoneyIn
            // 
            this.buttonMoneyIn.AutoSize = true;
            this.buttonMoneyIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMoneyIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoneyIn.Location = new System.Drawing.Point(269, 5);
            this.buttonMoneyIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoneyIn.Name = "buttonMoneyIn";
            this.buttonMoneyIn.Size = new System.Drawing.Size(108, 24);
            this.buttonMoneyIn.TabIndex = 5;
            this.buttonMoneyIn.Text = "Add Money In";
            this.buttonMoneyIn.UseVisualStyleBackColor = true;
            this.buttonMoneyIn.Click += new System.EventHandler(this.AddMoneyIn);
            // 
            // buttonMoneyOut
            // 
            this.buttonMoneyOut.AutoSize = true;
            this.buttonMoneyOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMoneyOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoneyOut.Location = new System.Drawing.Point(269, 5);
            this.buttonMoneyOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoneyOut.Name = "buttonMoneyOut";
            this.buttonMoneyOut.Size = new System.Drawing.Size(108, 24);
            this.buttonMoneyOut.TabIndex = 8;
            this.buttonMoneyOut.Text = "Add Money Out";
            this.buttonMoneyOut.UseVisualStyleBackColor = true;
            this.buttonMoneyOut.Click += new System.EventHandler(this.AddMoneyOut);
            // 
            // numericUpDownMoneyOut
            // 
            this.numericUpDownMoneyOut.DecimalPlaces = 2;
            this.numericUpDownMoneyOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMoneyOut.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMoneyOut.Location = new System.Drawing.Point(100, 5);
            this.numericUpDownMoneyOut.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMoneyOut.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownMoneyOut.Name = "numericUpDownMoneyOut";
            this.numericUpDownMoneyOut.Size = new System.Drawing.Size(162, 23);
            this.numericUpDownMoneyOut.TabIndex = 7;
            this.numericUpDownMoneyOut.ThousandsSeparator = true;
            // 
            // labelMoneyOut
            // 
            this.labelMoneyOut.AutoSize = true;
            this.labelMoneyOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoneyOut.Location = new System.Drawing.Point(5, 3);
            this.labelMoneyOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyOut.Name = "labelMoneyOut";
            this.labelMoneyOut.Size = new System.Drawing.Size(88, 28);
            this.labelMoneyOut.TabIndex = 6;
            this.labelMoneyOut.Text = "Money Out";
            this.labelMoneyOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxBudgeting
            // 
            this.listBoxBudgeting.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBudgeting.FormattingEnabled = true;
            this.listBoxBudgeting.ItemHeight = 15;
            this.listBoxBudgeting.Location = new System.Drawing.Point(11, 140);
            this.listBoxBudgeting.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBudgeting.Name = "listBoxBudgeting";
            this.listBoxBudgeting.Size = new System.Drawing.Size(264, 154);
            this.listBoxBudgeting.TabIndex = 9;
            this.listBoxBudgeting.SelectedIndexChanged += new System.EventHandler(this.CancelEdit);
            // 
            // labelTotalMoneyIn
            // 
            this.labelTotalMoneyIn.AutoSize = true;
            this.labelTotalMoneyIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMoneyIn.Location = new System.Drawing.Point(5, 3);
            this.labelTotalMoneyIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalMoneyIn.Name = "labelTotalMoneyIn";
            this.labelTotalMoneyIn.Size = new System.Drawing.Size(123, 15);
            this.labelTotalMoneyIn.TabIndex = 10;
            this.labelTotalMoneyIn.Text = "Total Money In";
            // 
            // labelMoneyInTotal
            // 
            this.labelMoneyInTotal.AutoSize = true;
            this.labelMoneyInTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoneyInTotal.Location = new System.Drawing.Point(135, 3);
            this.labelMoneyInTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyInTotal.Name = "labelMoneyInTotal";
            this.labelMoneyInTotal.Size = new System.Drawing.Size(124, 15);
            this.labelMoneyInTotal.TabIndex = 11;
            this.labelMoneyInTotal.Text = "£0.00";
            // 
            // labelTotalMoneyOut
            // 
            this.labelTotalMoneyOut.AutoSize = true;
            this.labelTotalMoneyOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMoneyOut.Location = new System.Drawing.Point(5, 21);
            this.labelTotalMoneyOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalMoneyOut.Name = "labelTotalMoneyOut";
            this.labelTotalMoneyOut.Size = new System.Drawing.Size(123, 15);
            this.labelTotalMoneyOut.TabIndex = 13;
            this.labelTotalMoneyOut.Text = "Total Money Out";
            // 
            // labelMoneyOutTotal
            // 
            this.labelMoneyOutTotal.AutoSize = true;
            this.labelMoneyOutTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoneyOutTotal.Location = new System.Drawing.Point(135, 21);
            this.labelMoneyOutTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyOutTotal.Name = "labelMoneyOutTotal";
            this.labelMoneyOutTotal.Size = new System.Drawing.Size(124, 15);
            this.labelMoneyOutTotal.TabIndex = 12;
            this.labelMoneyOutTotal.Text = "£0.00";
            // 
            // labelTotalMoney
            // 
            this.labelTotalMoney.AutoSize = true;
            this.labelTotalMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalMoney.Location = new System.Drawing.Point(5, 39);
            this.labelTotalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalMoney.Name = "labelTotalMoney";
            this.labelTotalMoney.Size = new System.Drawing.Size(123, 15);
            this.labelTotalMoney.TabIndex = 15;
            this.labelTotalMoney.Text = "Total Money";
            // 
            // labelMoneyTotal
            // 
            this.labelMoneyTotal.AutoSize = true;
            this.labelMoneyTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMoneyTotal.Location = new System.Drawing.Point(135, 39);
            this.labelMoneyTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoneyTotal.Name = "labelMoneyTotal";
            this.labelMoneyTotal.Size = new System.Drawing.Size(124, 15);
            this.labelMoneyTotal.TabIndex = 14;
            this.labelMoneyTotal.Text = "£0.00";
            // 
            // tableLayoutPanelTotals
            // 
            this.tableLayoutPanelTotals.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelTotals.ColumnCount = 2;
            this.tableLayoutPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTotals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTotals.Controls.Add(this.labelTotalMoneyIn, 0, 0);
            this.tableLayoutPanelTotals.Controls.Add(this.labelMoneyOutTotal, 1, 1);
            this.tableLayoutPanelTotals.Controls.Add(this.labelMoneyInTotal, 1, 0);
            this.tableLayoutPanelTotals.Controls.Add(this.labelTotalMoneyOut, 0, 1);
            this.tableLayoutPanelTotals.Controls.Add(this.labelMoneyTotal, 1, 2);
            this.tableLayoutPanelTotals.Controls.Add(this.labelTotalMoney, 0, 2);
            this.tableLayoutPanelTotals.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelTotals.Location = new System.Drawing.Point(11, 298);
            this.tableLayoutPanelTotals.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelTotals.Name = "tableLayoutPanelTotals";
            this.tableLayoutPanelTotals.RowCount = 3;
            this.tableLayoutPanelTotals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTotals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTotals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelTotals.Size = new System.Drawing.Size(264, 57);
            this.tableLayoutPanelTotals.TabIndex = 16;
            // 
            // tableLayoutPanelLabel
            // 
            this.tableLayoutPanelLabel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelLabel.ColumnCount = 2;
            this.tableLayoutPanelLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelLabel.Controls.Add(this.textBoxLabel, 1, 0);
            this.tableLayoutPanelLabel.Controls.Add(this.checkBoxLabel, 0, 0);
            this.tableLayoutPanelLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelLabel.Location = new System.Drawing.Point(11, 26);
            this.tableLayoutPanelLabel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelLabel.Name = "tableLayoutPanelLabel";
            this.tableLayoutPanelLabel.RowCount = 1;
            this.tableLayoutPanelLabel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLabel.Size = new System.Drawing.Size(382, 34);
            this.tableLayoutPanelLabel.TabIndex = 17;
            // 
            // tableLayoutPanelMoneyIn
            // 
            this.tableLayoutPanelMoneyIn.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelMoneyIn.ColumnCount = 3;
            this.tableLayoutPanelMoneyIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMoneyIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelMoneyIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMoneyIn.Controls.Add(this.buttonMoneyIn, 2, 0);
            this.tableLayoutPanelMoneyIn.Controls.Add(this.numericUpDownMoneyIn, 1, 0);
            this.tableLayoutPanelMoneyIn.Controls.Add(this.labelMoneyIn, 0, 0);
            this.tableLayoutPanelMoneyIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelMoneyIn.Location = new System.Drawing.Point(11, 64);
            this.tableLayoutPanelMoneyIn.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMoneyIn.Name = "tableLayoutPanelMoneyIn";
            this.tableLayoutPanelMoneyIn.RowCount = 1;
            this.tableLayoutPanelMoneyIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMoneyIn.Size = new System.Drawing.Size(382, 34);
            this.tableLayoutPanelMoneyIn.TabIndex = 18;
            // 
            // tableLayoutPanelMoneyOut
            // 
            this.tableLayoutPanelMoneyOut.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelMoneyOut.ColumnCount = 3;
            this.tableLayoutPanelMoneyOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMoneyOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelMoneyOut.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMoneyOut.Controls.Add(this.buttonMoneyOut, 2, 0);
            this.tableLayoutPanelMoneyOut.Controls.Add(this.numericUpDownMoneyOut, 1, 0);
            this.tableLayoutPanelMoneyOut.Controls.Add(this.labelMoneyOut, 0, 0);
            this.tableLayoutPanelMoneyOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelMoneyOut.Location = new System.Drawing.Point(11, 102);
            this.tableLayoutPanelMoneyOut.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelMoneyOut.Name = "tableLayoutPanelMoneyOut";
            this.tableLayoutPanelMoneyOut.RowCount = 1;
            this.tableLayoutPanelMoneyOut.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMoneyOut.Size = new System.Drawing.Size(382, 34);
            this.tableLayoutPanelMoneyOut.TabIndex = 19;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonClose, 0, 4);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonClearList, 0, 3);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonDeleteSelected, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonEditSelected, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonSortList, 0, 0);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(280, 141);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 5;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(113, 214);
            this.tableLayoutPanelButtons.TabIndex = 20;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(6, 174);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(101, 34);
            this.buttonClose.TabIndex = 21;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearList.Location = new System.Drawing.Point(6, 132);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(101, 33);
            this.buttonClearList.TabIndex = 3;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.ClearList);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelected.Location = new System.Drawing.Point(6, 90);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(101, 33);
            this.buttonDeleteSelected.TabIndex = 2;
            this.buttonDeleteSelected.Text = "Delete Selected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.DeleteSelected);
            // 
            // buttonEditSelected
            // 
            this.buttonEditSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditSelected.Location = new System.Drawing.Point(6, 48);
            this.buttonEditSelected.Name = "buttonEditSelected";
            this.buttonEditSelected.Size = new System.Drawing.Size(101, 33);
            this.buttonEditSelected.TabIndex = 1;
            this.buttonEditSelected.Text = "Edit Selected";
            this.buttonEditSelected.UseVisualStyleBackColor = true;
            this.buttonEditSelected.Click += new System.EventHandler(this.EditSelected);
            // 
            // buttonSortList
            // 
            this.buttonSortList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSortList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSortList.Location = new System.Drawing.Point(6, 6);
            this.buttonSortList.Name = "buttonSortList";
            this.buttonSortList.Size = new System.Drawing.Size(101, 33);
            this.buttonSortList.TabIndex = 0;
            this.buttonSortList.Text = "Sort List";
            this.buttonSortList.UseVisualStyleBackColor = true;
            this.buttonSortList.Click += new System.EventHandler(this.SortList);
            // 
            // tableLayoutPanelEditSelected
            // 
            this.tableLayoutPanelEditSelected.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelEditSelected.ColumnCount = 3;
            this.tableLayoutPanelEditSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelEditSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelEditSelected.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelEditSelected.Controls.Add(this.labelEditLabel, 0, 0);
            this.tableLayoutPanelEditSelected.Controls.Add(this.labelEditMoney, 0, 1);
            this.tableLayoutPanelEditSelected.Controls.Add(this.buttonUpdateSelected, 2, 0);
            this.tableLayoutPanelEditSelected.Controls.Add(this.textBoxEditLabel, 1, 0);
            this.tableLayoutPanelEditSelected.Controls.Add(this.buttonCancelEdit, 2, 1);
            this.tableLayoutPanelEditSelected.Controls.Add(this.numericUpDownEditMoney, 1, 1);
            this.tableLayoutPanelEditSelected.Enabled = false;
            this.tableLayoutPanelEditSelected.Location = new System.Drawing.Point(11, 64);
            this.tableLayoutPanelEditSelected.Name = "tableLayoutPanelEditSelected";
            this.tableLayoutPanelEditSelected.RowCount = 2;
            this.tableLayoutPanelEditSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEditSelected.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEditSelected.Size = new System.Drawing.Size(382, 71);
            this.tableLayoutPanelEditSelected.TabIndex = 21;
            this.tableLayoutPanelEditSelected.Visible = false;
            // 
            // labelEditLabel
            // 
            this.labelEditLabel.AutoSize = true;
            this.labelEditLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEditLabel.Location = new System.Drawing.Point(6, 3);
            this.labelEditLabel.Name = "labelEditLabel";
            this.labelEditLabel.Size = new System.Drawing.Size(49, 31);
            this.labelEditLabel.TabIndex = 0;
            this.labelEditLabel.Text = "Label";
            this.labelEditLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEditMoney
            // 
            this.labelEditMoney.AutoSize = true;
            this.labelEditMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEditMoney.Location = new System.Drawing.Point(6, 37);
            this.labelEditMoney.Name = "labelEditMoney";
            this.labelEditMoney.Size = new System.Drawing.Size(49, 31);
            this.labelEditMoney.TabIndex = 1;
            this.labelEditMoney.Text = "Money";
            this.labelEditMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonUpdateSelected
            // 
            this.buttonUpdateSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdateSelected.Location = new System.Drawing.Point(270, 6);
            this.buttonUpdateSelected.Name = "buttonUpdateSelected";
            this.buttonUpdateSelected.Size = new System.Drawing.Size(106, 25);
            this.buttonUpdateSelected.TabIndex = 4;
            this.buttonUpdateSelected.Text = "Update";
            this.buttonUpdateSelected.UseVisualStyleBackColor = true;
            this.buttonUpdateSelected.Click += new System.EventHandler(this.UpdateSelected);
            // 
            // textBoxEditLabel
            // 
            this.textBoxEditLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxEditLabel.Location = new System.Drawing.Point(64, 6);
            this.textBoxEditLabel.Name = "textBoxEditLabel";
            this.textBoxEditLabel.Size = new System.Drawing.Size(197, 23);
            this.textBoxEditLabel.TabIndex = 3;
            // 
            // buttonCancelEdit
            // 
            this.buttonCancelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancelEdit.Location = new System.Drawing.Point(270, 40);
            this.buttonCancelEdit.Name = "buttonCancelEdit";
            this.buttonCancelEdit.Size = new System.Drawing.Size(106, 25);
            this.buttonCancelEdit.TabIndex = 5;
            this.buttonCancelEdit.Text = "Cancel";
            this.buttonCancelEdit.UseVisualStyleBackColor = true;
            this.buttonCancelEdit.Click += new System.EventHandler(this.EditSelected);
            // 
            // numericUpDownEditMoney
            // 
            this.numericUpDownEditMoney.DecimalPlaces = 2;
            this.numericUpDownEditMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericUpDownEditMoney.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEditMoney.Location = new System.Drawing.Point(64, 40);
            this.numericUpDownEditMoney.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownEditMoney.Name = "numericUpDownEditMoney";
            this.numericUpDownEditMoney.Size = new System.Drawing.Size(197, 23);
            this.numericUpDownEditMoney.TabIndex = 2;
            this.numericUpDownEditMoney.ThousandsSeparator = true;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 366);
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Controls.Add(this.tableLayoutPanelMoneyOut);
            this.Controls.Add(this.tableLayoutPanelMoneyIn);
            this.Controls.Add(this.tableLayoutPanelLabel);
            this.Controls.Add(this.tableLayoutPanelTotals);
            this.Controls.Add(this.listBoxBudgeting);
            this.Controls.Add(this.menuStripMainMenu);
            this.Controls.Add(this.tableLayoutPanelEditSelected);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMainMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "WindowMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Manager";
            this.menuStripMainMenu.ResumeLayout(false);
            this.menuStripMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoneyIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoneyOut)).EndInit();
            this.tableLayoutPanelTotals.ResumeLayout(false);
            this.tableLayoutPanelTotals.PerformLayout();
            this.tableLayoutPanelLabel.ResumeLayout(false);
            this.tableLayoutPanelLabel.PerformLayout();
            this.tableLayoutPanelMoneyIn.ResumeLayout(false);
            this.tableLayoutPanelMoneyIn.PerformLayout();
            this.tableLayoutPanelMoneyOut.ResumeLayout(false);
            this.tableLayoutPanelMoneyOut.PerformLayout();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.tableLayoutPanelEditSelected.ResumeLayout(false);
            this.tableLayoutPanelEditSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxLabel;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label labelMoneyIn;
        private System.Windows.Forms.NumericUpDown numericUpDownMoneyIn;
        private System.Windows.Forms.Button buttonMoneyIn;
        private System.Windows.Forms.Button buttonMoneyOut;
        private System.Windows.Forms.NumericUpDown numericUpDownMoneyOut;
        private System.Windows.Forms.Label labelMoneyOut;
        private System.Windows.Forms.ListBox listBoxBudgeting;
        private System.Windows.Forms.Label labelTotalMoneyIn;
        private System.Windows.Forms.Label labelMoneyInTotal;
        private System.Windows.Forms.Label labelTotalMoneyOut;
        private System.Windows.Forms.Label labelMoneyOutTotal;
        private System.Windows.Forms.Label labelTotalMoney;
        private System.Windows.Forms.Label labelMoneyTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTotals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMoneyIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMoneyOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonEditSelected;
        private System.Windows.Forms.Button buttonSortList;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEditSelected;
        private System.Windows.Forms.Label labelEditLabel;
        private System.Windows.Forms.Label labelEditMoney;
        private System.Windows.Forms.NumericUpDown numericUpDownEditMoney;
        private System.Windows.Forms.TextBox textBoxEditLabel;
        private System.Windows.Forms.Button buttonUpdateSelected;
        private System.Windows.Forms.Button buttonCancelEdit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}
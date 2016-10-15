/*
 *  Georgios Psarakis 
 *  200289922  
 *  10/14/2016 
 */
namespace SharpAutoCenter
{
    partial class AutoCenter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TradeInTextBox = new System.Windows.Forms.TextBox();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalitemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ComputerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.LeatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.StereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.ExteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.PearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.AdditionalitemsGroupBox.SuspendLayout();
            this.ExteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1183, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "AutoCenterMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calibriToolStripMenuItem,
            this.ArialToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fontToolStripMenuItem.Text = "Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.orangeToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.colorToolStripMenuItem.Text = "Color...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriceLabel.Location = new System.Drawing.Point(60, 53);
            this.BasePriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(114, 23);
            this.BasePriceLabel.TabIndex = 1;
            this.BasePriceLabel.Text = "Base Price:";
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(60, 104);
            this.AdditionalOptionsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(201, 23);
            this.AdditionalOptionsLabel.TabIndex = 2;
            this.AdditionalOptionsLabel.Text = "Additional Options:";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(60, 179);
            this.SubTotalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(102, 23);
            this.SubTotalLabel.TabIndex = 3;
            this.SubTotalLabel.Text = "SubTotal:";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(60, 217);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(165, 23);
            this.SalesTaxLabel.TabIndex = 4;
            this.SalesTaxLabel.Text = "Sales Tax (13%):";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(60, 308);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(65, 23);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total:";
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(60, 369);
            this.TradeInAllowanceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(195, 23);
            this.TradeInAllowanceLabel.TabIndex = 6;
            this.TradeInAllowanceLabel.Text = "Trade In Allowance";
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountDueLabel.Location = new System.Drawing.Point(60, 432);
            this.AmountDueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(139, 23);
            this.AmountDueLabel.TabIndex = 7;
            this.AmountDueLabel.Text = "Amount Due:";
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriceTextBox.Location = new System.Drawing.Point(386, 53);
            this.BasePriceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.ReadOnly = true;
            this.BasePriceTextBox.Size = new System.Drawing.Size(196, 31);
            this.BasePriceTextBox.TabIndex = 8;
            // 
            // AdditionalOptionsTextBox
            // 
            this.AdditionalOptionsTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalOptionsTextBox.Location = new System.Drawing.Point(386, 104);
            this.AdditionalOptionsTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.AdditionalOptionsTextBox.Name = "AdditionalOptionsTextBox";
            this.AdditionalOptionsTextBox.ReadOnly = true;
            this.AdditionalOptionsTextBox.Size = new System.Drawing.Size(196, 31);
            this.AdditionalOptionsTextBox.TabIndex = 9;
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTextBox.Location = new System.Drawing.Point(386, 169);
            this.SubTotalTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.ReadOnly = true;
            this.SubTotalTextBox.Size = new System.Drawing.Size(196, 31);
            this.SubTotalTextBox.TabIndex = 10;
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxTextBox.Location = new System.Drawing.Point(386, 217);
            this.SalesTaxTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.ReadOnly = true;
            this.SalesTaxTextBox.Size = new System.Drawing.Size(196, 31);
            this.SalesTaxTextBox.TabIndex = 11;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(386, 308);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(196, 31);
            this.TotalTextBox.TabIndex = 12;
            // 
            // TradeInTextBox
            // 
            this.TradeInTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradeInTextBox.Location = new System.Drawing.Point(386, 369);
            this.TradeInTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TradeInTextBox.Name = "TradeInTextBox";
            this.TradeInTextBox.Size = new System.Drawing.Size(196, 31);
            this.TradeInTextBox.TabIndex = 13;
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountDueTextBox.Location = new System.Drawing.Point(386, 422);
            this.AmountDueTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.ReadOnly = true;
            this.AmountDueTextBox.Size = new System.Drawing.Size(196, 31);
            this.AmountDueTextBox.TabIndex = 14;
            // 
            // AdditionalitemsGroupBox
            // 
            this.AdditionalitemsGroupBox.Controls.Add(this.ComputerNavigationCheckBox);
            this.AdditionalitemsGroupBox.Controls.Add(this.LeatherInteriorCheckBox);
            this.AdditionalitemsGroupBox.Controls.Add(this.StereoSystemCheckBox);
            this.AdditionalitemsGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalitemsGroupBox.Location = new System.Drawing.Point(704, 53);
            this.AdditionalitemsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.AdditionalitemsGroupBox.Name = "AdditionalitemsGroupBox";
            this.AdditionalitemsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.AdditionalitemsGroupBox.Size = new System.Drawing.Size(448, 187);
            this.AdditionalitemsGroupBox.TabIndex = 15;
            this.AdditionalitemsGroupBox.TabStop = false;
            this.AdditionalitemsGroupBox.Text = "Additional Items";
            // 
            // ComputerNavigationCheckBox
            // 
            this.ComputerNavigationCheckBox.AutoSize = true;
            this.ComputerNavigationCheckBox.Location = new System.Drawing.Point(56, 113);
            this.ComputerNavigationCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.ComputerNavigationCheckBox.Name = "ComputerNavigationCheckBox";
            this.ComputerNavigationCheckBox.Size = new System.Drawing.Size(242, 27);
            this.ComputerNavigationCheckBox.TabIndex = 2;
            this.ComputerNavigationCheckBox.Text = "Computer Navigation";
            this.ComputerNavigationCheckBox.UseVisualStyleBackColor = true;
            this.ComputerNavigationCheckBox.CheckedChanged += new System.EventHandler(this.ComputerNavigationCheckBox_CheckedChanged);
            // 
            // LeatherInteriorCheckBox
            // 
            this.LeatherInteriorCheckBox.AutoSize = true;
            this.LeatherInteriorCheckBox.Location = new System.Drawing.Point(56, 75);
            this.LeatherInteriorCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.LeatherInteriorCheckBox.Name = "LeatherInteriorCheckBox";
            this.LeatherInteriorCheckBox.Size = new System.Drawing.Size(186, 27);
            this.LeatherInteriorCheckBox.TabIndex = 1;
            this.LeatherInteriorCheckBox.Text = "Leather Interior";
            this.LeatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.LeatherInteriorCheckBox.CheckedChanged += new System.EventHandler(this.LeatherInteriorCheckBox_CheckedChanged);
            // 
            // StereoSystemCheckBox
            // 
            this.StereoSystemCheckBox.AutoSize = true;
            this.StereoSystemCheckBox.Location = new System.Drawing.Point(56, 36);
            this.StereoSystemCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.StereoSystemCheckBox.Name = "StereoSystemCheckBox";
            this.StereoSystemCheckBox.Size = new System.Drawing.Size(171, 27);
            this.StereoSystemCheckBox.TabIndex = 0;
            this.StereoSystemCheckBox.Text = "Stereo System";
            this.StereoSystemCheckBox.UseVisualStyleBackColor = true;
            this.StereoSystemCheckBox.CheckedChanged += new System.EventHandler(this.StereoSystemCheckBox_CheckedChanged);
            // 
            // ExteriorFinishGroupBox
            // 
            this.ExteriorFinishGroupBox.Controls.Add(this.CustomizedDetailingRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.PearlizedRadioButton);
            this.ExteriorFinishGroupBox.Controls.Add(this.StandardRadioButton);
            this.ExteriorFinishGroupBox.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExteriorFinishGroupBox.Location = new System.Drawing.Point(704, 287);
            this.ExteriorFinishGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.ExteriorFinishGroupBox.Name = "ExteriorFinishGroupBox";
            this.ExteriorFinishGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.ExteriorFinishGroupBox.Size = new System.Drawing.Size(448, 168);
            this.ExteriorFinishGroupBox.TabIndex = 16;
            this.ExteriorFinishGroupBox.TabStop = false;
            this.ExteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // CustomizedDetailingRadioButton
            // 
            this.CustomizedDetailingRadioButton.AutoSize = true;
            this.CustomizedDetailingRadioButton.Location = new System.Drawing.Point(56, 125);
            this.CustomizedDetailingRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.CustomizedDetailingRadioButton.Name = "CustomizedDetailingRadioButton";
            this.CustomizedDetailingRadioButton.Size = new System.Drawing.Size(244, 27);
            this.CustomizedDetailingRadioButton.TabIndex = 2;
            this.CustomizedDetailingRadioButton.TabStop = true;
            this.CustomizedDetailingRadioButton.Text = "Customized Detailing";
            this.CustomizedDetailingRadioButton.UseVisualStyleBackColor = true;
            // 
            // PearlizedRadioButton
            // 
            this.PearlizedRadioButton.AutoSize = true;
            this.PearlizedRadioButton.Location = new System.Drawing.Point(56, 86);
            this.PearlizedRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.PearlizedRadioButton.Name = "PearlizedRadioButton";
            this.PearlizedRadioButton.Size = new System.Drawing.Size(121, 27);
            this.PearlizedRadioButton.TabIndex = 1;
            this.PearlizedRadioButton.TabStop = true;
            this.PearlizedRadioButton.Text = "Pearlized";
            this.PearlizedRadioButton.UseVisualStyleBackColor = true;
            this.PearlizedRadioButton.CheckedChanged += new System.EventHandler(this.PearlizedRadioButton_CheckedChanged);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardRadioButton.Location = new System.Drawing.Point(56, 47);
            this.StandardRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(119, 27);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this.StandardRadioButton_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(73, 515);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(6);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(150, 46);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calcualte";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(507, 515);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(6);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(150, 46);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(959, 515);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(150, 46);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // calibriToolStripMenuItem
            // 
            this.calibriToolStripMenuItem.Name = "calibriToolStripMenuItem";
            this.calibriToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.calibriToolStripMenuItem.Text = "Calibri";
            this.calibriToolStripMenuItem.Click += new System.EventHandler(this.calibriToolStripMenuItem_Click);
            // 
            // ArialToolStripMenuItem
            // 
            this.ArialToolStripMenuItem.Name = "ArialToolStripMenuItem";
            this.ArialToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ArialToolStripMenuItem.Text = "Arial";
            this.ArialToolStripMenuItem.Click += new System.EventHandler(this.ArialToolStripMenuItem_Click);
            // 
            // AutoCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 581);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExteriorFinishGroupBox);
            this.Controls.Add(this.AdditionalitemsGroupBox);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.TradeInTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.AdditionalOptionsTextBox);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TradeInAllowanceLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AutoCenter";
            this.Text = "Auto Center";
            this.Load += new System.EventHandler(this.AutoCenter_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AdditionalitemsGroupBox.ResumeLayout(false);
            this.AdditionalitemsGroupBox.PerformLayout();
            this.ExteriorFinishGroupBox.ResumeLayout(false);
            this.ExteriorFinishGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TradeInAllowanceLabel;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.TextBox AdditionalOptionsTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TradeInTextBox;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.GroupBox AdditionalitemsGroupBox;
        private System.Windows.Forms.GroupBox ExteriorFinishGroupBox;
        private System.Windows.Forms.CheckBox ComputerNavigationCheckBox;
        private System.Windows.Forms.CheckBox LeatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox StereoSystemCheckBox;
        private System.Windows.Forms.RadioButton CustomizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton PearlizedRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArialToolStripMenuItem;
    }
}


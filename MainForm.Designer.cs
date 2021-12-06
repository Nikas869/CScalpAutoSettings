
namespace CScalpAutoSettings
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._FSRLauncherFolderPathTextBox = new System.Windows.Forms.TextBox();
            this._FSRLauncherFolderPathLabel = new System.Windows.Forms.Label();
            this._FSRLauncherFolderPathButton = new System.Windows.Forms.Button();
            this._ApplyButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._profitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._maxDecimalPlaces = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._decimalPriceChangeFactor = new System.Windows.Forms.NumericUpDown();
            this._reduceAmountsPriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._reduceAmounts = new System.Windows.Forms.CheckBox();
            this._showRulerCheckBox = new System.Windows.Forms.CheckBox();
            this._enableNotificationsCheckBox = new System.Windows.Forms.CheckBox();
            this._serverSideSLTPCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._applyForSpot = new System.Windows.Forms.CheckBox();
            this._applyForUSDMFutures = new System.Windows.Forms.CheckBox();
            this._ApplyForCOINMFutures = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._maxDecimalPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._decimalPriceChangeFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // _FSRLauncherFolderPathTextBox
            // 
            this._FSRLauncherFolderPathTextBox.Enabled = false;
            this._FSRLauncherFolderPathTextBox.Location = new System.Drawing.Point(176, 10);
            this._FSRLauncherFolderPathTextBox.Name = "_FSRLauncherFolderPathTextBox";
            this._FSRLauncherFolderPathTextBox.Size = new System.Drawing.Size(403, 25);
            this._FSRLauncherFolderPathTextBox.TabIndex = 0;
            // 
            // _FSRLauncherFolderPathLabel
            // 
            this._FSRLauncherFolderPathLabel.AutoSize = true;
            this._FSRLauncherFolderPathLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._FSRLauncherFolderPathLabel.Location = new System.Drawing.Point(13, 13);
            this._FSRLauncherFolderPathLabel.Name = "_FSRLauncherFolderPathLabel";
            this._FSRLauncherFolderPathLabel.Size = new System.Drawing.Size(157, 17);
            this._FSRLauncherFolderPathLabel.TabIndex = 1;
            this._FSRLauncherFolderPathLabel.Text = "FSR Launcher folder path:";
            // 
            // _FSRLauncherFolderPathButton
            // 
            this._FSRLauncherFolderPathButton.Location = new System.Drawing.Point(585, 10);
            this._FSRLauncherFolderPathButton.Name = "_FSRLauncherFolderPathButton";
            this._FSRLauncherFolderPathButton.Size = new System.Drawing.Size(107, 25);
            this._FSRLauncherFolderPathButton.TabIndex = 2;
            this._FSRLauncherFolderPathButton.Text = "Browse";
            this._FSRLauncherFolderPathButton.UseVisualStyleBackColor = true;
            this._FSRLauncherFolderPathButton.Click += new System.EventHandler(this._FSRLauncherFolderPathButton_Click);
            // 
            // _ApplyButton
            // 
            this._ApplyButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._ApplyButton.Location = new System.Drawing.Point(585, 378);
            this._ApplyButton.Name = "_ApplyButton";
            this._ApplyButton.Size = new System.Drawing.Size(107, 38);
            this._ApplyButton.TabIndex = 3;
            this._ApplyButton.Text = "Apply";
            this._ApplyButton.UseVisualStyleBackColor = true;
            this._ApplyButton.Click += new System.EventHandler(this._ApplyButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._profitTypeComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._maxDecimalPlaces);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._decimalPriceChangeFactor);
            this.groupBox1.Controls.Add(this._reduceAmountsPriceTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._reduceAmounts);
            this.groupBox1.Controls.Add(this._showRulerCheckBox);
            this.groupBox1.Controls.Add(this._enableNotificationsCheckBox);
            this.groupBox1.Controls.Add(this._serverSideSLTPCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common Settings";
            // 
            // _profitTypeComboBox
            // 
            this._profitTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._profitTypeComboBox.FormattingEnabled = true;
            this._profitTypeComboBox.Items.AddRange(new object[] {
            "Percent",
            "Points",
            "Points * Amount"});
            this._profitTypeComboBox.Location = new System.Drawing.Point(552, 85);
            this._profitTypeComboBox.Name = "_profitTypeComboBox";
            this._profitTypeComboBox.Size = new System.Drawing.Size(121, 25);
            this._profitTypeComboBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Profit display type";
            // 
            // _maxDecimalPlaces
            // 
            this._maxDecimalPlaces.Location = new System.Drawing.Point(625, 54);
            this._maxDecimalPlaces.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this._maxDecimalPlaces.Name = "_maxDecimalPlaces";
            this._maxDecimalPlaces.Size = new System.Drawing.Size(48, 25);
            this._maxDecimalPlaces.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max decimal places in amounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Decimal price change factor";
            // 
            // _decimalPriceChangeFactor
            // 
            this._decimalPriceChangeFactor.Location = new System.Drawing.Point(625, 23);
            this._decimalPriceChangeFactor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._decimalPriceChangeFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._decimalPriceChangeFactor.Name = "_decimalPriceChangeFactor";
            this._decimalPriceChangeFactor.Size = new System.Drawing.Size(48, 25);
            this._decimalPriceChangeFactor.TabIndex = 6;
            this._decimalPriceChangeFactor.ThousandsSeparator = true;
            this._decimalPriceChangeFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _reduceAmountsPriceTextBox
            // 
            this._reduceAmountsPriceTextBox.Enabled = false;
            this._reduceAmountsPriceTextBox.HidePromptOnLeave = true;
            this._reduceAmountsPriceTextBox.Location = new System.Drawing.Point(175, 130);
            this._reduceAmountsPriceTextBox.Mask = "0.99";
            this._reduceAmountsPriceTextBox.Name = "_reduceAmountsPriceTextBox";
            this._reduceAmountsPriceTextBox.Size = new System.Drawing.Size(55, 25);
            this._reduceAmountsPriceTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "if token price is lower then";
            // 
            // _reduceAmounts
            // 
            this._reduceAmounts.AutoSize = true;
            this._reduceAmounts.Location = new System.Drawing.Point(6, 105);
            this._reduceAmounts.Name = "_reduceAmounts";
            this._reduceAmounts.Size = new System.Drawing.Size(225, 21);
            this._reduceAmounts.TabIndex = 3;
            this._reduceAmounts.Text = "Reduce amounts from a thousand";
            this._reduceAmounts.UseVisualStyleBackColor = true;
            // 
            // _showRulerCheckBox
            // 
            this._showRulerCheckBox.AutoSize = true;
            this._showRulerCheckBox.Location = new System.Drawing.Point(6, 78);
            this._showRulerCheckBox.Name = "_showRulerCheckBox";
            this._showRulerCheckBox.Size = new System.Drawing.Size(89, 21);
            this._showRulerCheckBox.TabIndex = 2;
            this._showRulerCheckBox.Text = "Show ruler";
            this._showRulerCheckBox.UseVisualStyleBackColor = true;
            // 
            // _enableNotificationsCheckBox
            // 
            this._enableNotificationsCheckBox.AutoSize = true;
            this._enableNotificationsCheckBox.Location = new System.Drawing.Point(6, 51);
            this._enableNotificationsCheckBox.Name = "_enableNotificationsCheckBox";
            this._enableNotificationsCheckBox.Size = new System.Drawing.Size(140, 21);
            this._enableNotificationsCheckBox.TabIndex = 1;
            this._enableNotificationsCheckBox.Text = "Enable notifications";
            this._enableNotificationsCheckBox.UseVisualStyleBackColor = true;
            // 
            // _serverSideSLTPCheckBox
            // 
            this._serverSideSLTPCheckBox.AutoSize = true;
            this._serverSideSLTPCheckBox.Location = new System.Drawing.Point(6, 24);
            this._serverSideSLTPCheckBox.Name = "_serverSideSLTPCheckBox";
            this._serverSideSLTPCheckBox.Size = new System.Drawing.Size(246, 21);
            this._serverSideSLTPCheckBox.TabIndex = 0;
            this._serverSideSLTPCheckBox.Text = "Use server side Stop-Loss/Take-Profit";
            this._serverSideSLTPCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Book Settings";
            // 
            // statusStrip1
            // 
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _applyForSpot
            // 
            this._applyForSpot.AutoSize = true;
            this._applyForSpot.Location = new System.Drawing.Point(13, 390);
            this._applyForSpot.Name = "_applyForSpot";
            this._applyForSpot.Size = new System.Drawing.Size(54, 21);
            this._applyForSpot.TabIndex = 8;
            this._applyForSpot.Text = "Spot";
            this._applyForSpot.UseVisualStyleBackColor = true;
            // 
            // _applyForUSDMFutures
            // 
            this._applyForUSDMFutures.AutoSize = true;
            this._applyForUSDMFutures.Location = new System.Drawing.Point(73, 390);
            this._applyForUSDMFutures.Name = "_applyForUSDMFutures";
            this._applyForUSDMFutures.Size = new System.Drawing.Size(115, 21);
            this._applyForUSDMFutures.TabIndex = 9;
            this._applyForUSDMFutures.Text = "USD-M Futures";
            this._applyForUSDMFutures.UseVisualStyleBackColor = true;
            // 
            // _ApplyForCOINMFutures
            // 
            this._ApplyForCOINMFutures.AutoSize = true;
            this._ApplyForCOINMFutures.Location = new System.Drawing.Point(194, 390);
            this._ApplyForCOINMFutures.Name = "_ApplyForCOINMFutures";
            this._ApplyForCOINMFutures.Size = new System.Drawing.Size(121, 21);
            this._ApplyForCOINMFutures.TabIndex = 10;
            this._ApplyForCOINMFutures.Text = "COIN-M Futures";
            this._ApplyForCOINMFutures.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this._ApplyForCOINMFutures);
            this.Controls.Add(this._applyForUSDMFutures);
            this.Controls.Add(this._applyForSpot);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._ApplyButton);
            this.Controls.Add(this._FSRLauncherFolderPathButton);
            this.Controls.Add(this._FSRLauncherFolderPathLabel);
            this.Controls.Add(this._FSRLauncherFolderPathTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CScalp Auto Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._maxDecimalPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._decimalPriceChangeFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _FSRLauncherFolderPathTextBox;
        private System.Windows.Forms.Label _FSRLauncherFolderPathLabel;
        private System.Windows.Forms.Button _FSRLauncherFolderPathButton;
        private System.Windows.Forms.Button _ApplyButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _reduceAmounts;
        private System.Windows.Forms.CheckBox _showRulerCheckBox;
        private System.Windows.Forms.CheckBox _enableNotificationsCheckBox;
        private System.Windows.Forms.CheckBox _serverSideSLTPCheckBox;
        private System.Windows.Forms.MaskedTextBox _reduceAmountsPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _maxDecimalPlaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _decimalPriceChangeFactor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox _profitTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox _applyForSpot;
        private System.Windows.Forms.CheckBox _applyForUSDMFutures;
        private System.Windows.Forms.CheckBox _ApplyForCOINMFutures;
    }
}


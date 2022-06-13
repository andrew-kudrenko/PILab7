namespace PILab7
{
    partial class AccountForm
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
            this.collectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeByRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsData = new System.Windows.Forms.DataGridView();
            this.ByInterestRateData = new System.Windows.Forms.DataGridView();
            this.TheReachestLabel = new System.Windows.Forms.Label();
            this.ReachestOwnerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.InterestRateTextBox = new System.Windows.Forms.TextBox();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveFormButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.InterestRateFilteringTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ByInterestRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collectionToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // collectionToolStripMenuItem
            // 
            this.collectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            this.collectionToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.collectionToolStripMenuItem.Text = "Collection";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.CheckOnClick = true;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.OnCreateItem);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "View";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.OnViewItem);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Edit";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnEditItem);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.OnSaveCollection);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.OnLoadCollection);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.findToolStripMenuItem,
            this.takeByRateToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sortToolStripMenuItem.Text = "Sort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.OnSort);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.findToolStripMenuItem.Text = "Find The Richest Owner";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.OnFindTheRichest);
            // 
            // takeByRateToolStripMenuItem
            // 
            this.takeByRateToolStripMenuItem.Name = "takeByRateToolStripMenuItem";
            this.takeByRateToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.takeByRateToolStripMenuItem.Text = "Take by Rate";
            this.takeByRateToolStripMenuItem.Click += new System.EventHandler(this.OnTakeByRate);
            // 
            // AccountsData
            // 
            this.AccountsData.AllowUserToOrderColumns = true;
            this.AccountsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsData.Location = new System.Drawing.Point(371, 46);
            this.AccountsData.Name = "AccountsData";
            this.AccountsData.Size = new System.Drawing.Size(417, 242);
            this.AccountsData.TabIndex = 1;
            this.AccountsData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellClick);
            // 
            // ByInterestRateData
            // 
            this.ByInterestRateData.AllowUserToOrderColumns = true;
            this.ByInterestRateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ByInterestRateData.Location = new System.Drawing.Point(12, 46);
            this.ByInterestRateData.Name = "ByInterestRateData";
            this.ByInterestRateData.Size = new System.Drawing.Size(353, 242);
            this.ByInterestRateData.TabIndex = 2;
            // 
            // TheReachestLabel
            // 
            this.TheReachestLabel.AutoSize = true;
            this.TheReachestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheReachestLabel.Location = new System.Drawing.Point(9, 305);
            this.TheReachestLabel.Name = "TheReachestLabel";
            this.TheReachestLabel.Size = new System.Drawing.Size(151, 16);
            this.TheReachestLabel.TabIndex = 3;
            this.TheReachestLabel.Text = "The Reachest Owner";
            // 
            // ReachestOwnerTextBox
            // 
            this.ReachestOwnerTextBox.Enabled = false;
            this.ReachestOwnerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReachestOwnerTextBox.Location = new System.Drawing.Point(15, 324);
            this.ReachestOwnerTextBox.Name = "ReachestOwnerTextBox";
            this.ReachestOwnerTextBox.Size = new System.Drawing.Size(279, 20);
            this.ReachestOwnerTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Taken by Certain Interest Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "All Collection";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(371, 324);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(210, 20);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // InterestRateTextBox
            // 
            this.InterestRateTextBox.Location = new System.Drawing.Point(587, 324);
            this.InterestRateTextBox.Name = "InterestRateTextBox";
            this.InterestRateTextBox.Size = new System.Drawing.Size(65, 20);
            this.InterestRateTextBox.TabIndex = 9;
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(658, 324);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(60, 20);
            this.BalanceTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Interest Rate";
            // 
            // SaveFormButton
            // 
            this.SaveFormButton.Location = new System.Drawing.Point(728, 321);
            this.SaveFormButton.Name = "SaveFormButton";
            this.SaveFormButton.Size = new System.Drawing.Size(60, 23);
            this.SaveFormButton.TabIndex = 14;
            this.SaveFormButton.Text = "Save";
            this.SaveFormButton.UseVisualStyleBackColor = true;
            this.SaveFormButton.Click += new System.EventHandler(this.OnSaveCollection);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Interest Rate";
            // 
            // InterestRateFilteringTextBox
            // 
            this.InterestRateFilteringTextBox.Location = new System.Drawing.Point(300, 324);
            this.InterestRateFilteringTextBox.Name = "InterestRateFilteringTextBox";
            this.InterestRateFilteringTextBox.Size = new System.Drawing.Size(65, 20);
            this.InterestRateFilteringTextBox.TabIndex = 15;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InterestRateFilteringTextBox);
            this.Controls.Add(this.SaveFormButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.InterestRateTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReachestOwnerTextBox);
            this.Controls.Add(this.TheReachestLabel);
            this.Controls.Add(this.ByInterestRateData);
            this.Controls.Add(this.AccountsData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.InitializeForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ByInterestRateData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem collectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeByRateToolStripMenuItem;
        private System.Windows.Forms.DataGridView AccountsData;
        private System.Windows.Forms.DataGridView ByInterestRateData;
        private System.Windows.Forms.Label TheReachestLabel;
        private System.Windows.Forms.TextBox ReachestOwnerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox InterestRateTextBox;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveFormButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InterestRateFilteringTextBox;
    }
}
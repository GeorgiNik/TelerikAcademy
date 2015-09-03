namespace rpg_Game_V1
{
    partial class ChoiceWindow
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
            this.buttonContinue = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStatsPlayer = new System.Windows.Forms.Label();
            this.buttonRefreshStats = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.DimGray;
            this.buttonContinue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonContinue.Font = new System.Drawing.Font("MetalShred", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonContinue.Location = new System.Drawing.Point(3, 57);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(821, 167);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "CONTINUE FORWARD";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonReset, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonContinue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonInventory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.3469F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.27045F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.27045F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11221F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReset.Font = new System.Drawing.Font("MetalShred", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.DimGray;
            this.buttonReset.Location = new System.Drawing.Point(3, 399);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(821, 47);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "RESTART THIS ADVENTURE";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.Color.DimGray;
            this.buttonInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInventory.Font = new System.Drawing.Font("MetalShred", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventory.ForeColor = System.Drawing.Color.GreenYellow;
            this.buttonInventory.Location = new System.Drawing.Point(3, 228);
            this.buttonInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(821, 167);
            this.buttonInventory.TabIndex = 3;
            this.buttonInventory.Text = "INVENTORY";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.labelName);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.labelStatsPlayer);
            this.flowLayoutPanel1.Controls.Add(this.buttonRefreshStats);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(821, 49);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 14);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Set name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "s";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelStatsPlayer
            // 
            this.labelStatsPlayer.AutoSize = true;
            this.labelStatsPlayer.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatsPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatsPlayer.Location = new System.Drawing.Point(231, 0);
            this.labelStatsPlayer.Name = "labelStatsPlayer";
            this.labelStatsPlayer.Size = new System.Drawing.Size(55, 14);
            this.labelStatsPlayer.TabIndex = 1;
            this.labelStatsPlayer.Text = "label1";
            // 
            // buttonRefreshStats
            // 
            this.buttonRefreshStats.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRefreshStats.Font = new System.Drawing.Font("Lucida Console", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefreshStats.Location = new System.Drawing.Point(292, 2);
            this.buttonRefreshStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefreshStats.Name = "buttonRefreshStats";
            this.buttonRefreshStats.Size = new System.Drawing.Size(76, 48);
            this.buttonRefreshStats.TabIndex = 0;
            this.buttonRefreshStats.Text = "Refresh stats";
            this.buttonRefreshStats.UseVisualStyleBackColor = false;
            this.buttonRefreshStats.Click += new System.EventHandler(this.buttonRefreshStats_Click);
            // 
            // ChoiceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChoiceWindow";
            this.Text = "ChoiceWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonRefreshStats;
        private System.Windows.Forms.Label labelStatsPlayer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;

    }
}
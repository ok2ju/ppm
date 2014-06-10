namespace PPM
{
    partial class MainWindow
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
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.ButtonInputGenerate = new System.Windows.Forms.Button();
            this.GroupBoxTable = new System.Windows.Forms.GroupBox();
            this.DataGirdView = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Context3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Context2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Context1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GroupBoxInput.SuspendLayout();
            this.GroupBoxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.Controls.Add(this.richTextBox1);
            this.GroupBoxInput.Controls.Add(this.ButtonInputGenerate);
            this.GroupBoxInput.Location = new System.Drawing.Point(9, 270);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Size = new System.Drawing.Size(666, 152);
            this.GroupBoxInput.TabIndex = 0;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "Input Symbols";
            this.GroupBoxInput.Enter += new System.EventHandler(this.GroupBoxInput_Enter);
            // 
            // ButtonInputGenerate
            // 
            this.ButtonInputGenerate.Location = new System.Drawing.Point(7, 121);
            this.ButtonInputGenerate.Name = "ButtonInputGenerate";
            this.ButtonInputGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonInputGenerate.TabIndex = 1;
            this.ButtonInputGenerate.Text = "Generate";
            this.ButtonInputGenerate.UseVisualStyleBackColor = true;
            this.ButtonInputGenerate.Click += new System.EventHandler(this.ButtonInputGenerate_Click);
            // 
            // GroupBoxTable
            // 
            this.GroupBoxTable.Controls.Add(this.DataGirdView);
            this.GroupBoxTable.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxTable.Name = "GroupBoxTable";
            this.GroupBoxTable.Size = new System.Drawing.Size(666, 252);
            this.GroupBoxTable.TabIndex = 1;
            this.GroupBoxTable.TabStop = false;
            this.GroupBoxTable.Text = "Frequence Table";
            // 
            // DataGirdView
            // 
            this.DataGirdView.AllowUserToAddRows = false;
            this.DataGirdView.AllowUserToDeleteRows = false;
            this.DataGirdView.AllowUserToOrderColumns = true;
            this.DataGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGirdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.Context3,
            this.Context2,
            this.Context1,
            this.Chance});
            this.DataGirdView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGirdView.Location = new System.Drawing.Point(3, 16);
            this.DataGirdView.Name = "DataGirdView";
            this.DataGirdView.ReadOnly = true;
            this.DataGirdView.Size = new System.Drawing.Size(660, 233);
            this.DataGirdView.TabIndex = 0;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // Context3
            // 
            this.Context3.HeaderText = "Context 3";
            this.Context3.Name = "Context3";
            this.Context3.ReadOnly = true;
            this.Context3.Width = 125;
            // 
            // Context2
            // 
            this.Context2.HeaderText = "Context 2";
            this.Context2.Name = "Context2";
            this.Context2.ReadOnly = true;
            this.Context2.Width = 125;
            // 
            // Context1
            // 
            this.Context1.HeaderText = "Context 1";
            this.Context1.Name = "Context1";
            this.Context1.ReadOnly = true;
            this.Context1.Width = 125;
            // 
            // Chance
            // 
            this.Chance.HeaderText = "Chance";
            this.Chance.Name = "Chance";
            this.Chance.ReadOnly = true;
            this.Chance.Width = 125;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(647, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "bcbcabcbcabccbc";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 435);
            this.Controls.Add(this.GroupBoxTable);
            this.Controls.Add(this.GroupBoxInput);
            this.Name = "MainWindow";
            this.Text = "PPM Tables";
            this.GroupBoxInput.ResumeLayout(false);
            this.GroupBoxTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGirdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxInput;
        private System.Windows.Forms.Button ButtonInputGenerate;
        private System.Windows.Forms.GroupBox GroupBoxTable;
        private System.Windows.Forms.DataGridView DataGirdView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Context3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Context2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Context1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chance;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


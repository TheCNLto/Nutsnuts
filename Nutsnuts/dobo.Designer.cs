namespace Nutsnuts
{
    partial class dobo
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dotext = new System.Windows.Forms.Label();
            this.dcount = new System.Windows.Forms.Label();
            this.dododo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.dotext, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dcount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dododo, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dotext
            // 
            this.dotext.AutoSize = true;
            this.dotext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotext.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dotext.Location = new System.Drawing.Point(203, 149);
            this.dotext.Name = "dotext";
            this.dotext.Size = new System.Drawing.Size(194, 149);
            this.dotext.TabIndex = 0;
            this.dotext.Text = "Dobás";
            this.dotext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dcount
            // 
            this.dcount.AutoSize = true;
            this.dcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dcount.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dcount.Location = new System.Drawing.Point(403, 149);
            this.dcount.Name = "dcount";
            this.dcount.Size = new System.Drawing.Size(194, 149);
            this.dcount.TabIndex = 1;
            this.dcount.Text = "0";
            this.dcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dododo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dododo, 2);
            this.dododo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dododo.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dododo.Location = new System.Drawing.Point(203, 301);
            this.dododo.Name = "dododo";
            this.dododo.Size = new System.Drawing.Size(394, 146);
            this.dododo.TabIndex = 2;
            this.dododo.Text = "Dobás";
            this.dododo.UseVisualStyleBackColor = true;
            this.dododo.Click += new System.EventHandler(this.dododo_Click);
            // 
            // dobo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "dobo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NutsNuts - dobo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label dotext;
        private Label dcount;
        private Button dododo;
    }
}
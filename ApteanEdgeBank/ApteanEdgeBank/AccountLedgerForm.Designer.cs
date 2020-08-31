namespace ApteanEdgeBank
{
    partial class AccountLedgerForm
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
            this.ActivityGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivityGridView
            // 
            this.ActivityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivityGridView.Location = new System.Drawing.Point(0, 0);
            this.ActivityGridView.Name = "ActivityGridView";
            this.ActivityGridView.ReadOnly = true;
            this.ActivityGridView.Size = new System.Drawing.Size(643, 254);
            this.ActivityGridView.TabIndex = 0;
            // 
            // AccountLedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 254);
            this.Controls.Add(this.ActivityGridView);
            this.Name = "AccountLedgerForm";
            this.Text = "AccountLedgerForm";
            ((System.ComponentModel.ISupportInitialize)(this.ActivityGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ActivityGridView;
    }
}
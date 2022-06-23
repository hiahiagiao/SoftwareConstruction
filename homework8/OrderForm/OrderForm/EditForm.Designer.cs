
namespace OrderForm
{
    partial class EditForm
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
            this.SubmitDGV = new System.Windows.Forms.DataGridView();
            this.SubmitBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitDGV
            // 
            this.SubmitDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubmitDGV.Location = new System.Drawing.Point(0, 0);
            this.SubmitDGV.Name = "SubmitDGV";
            this.SubmitDGV.RowHeadersWidth = 51;
            this.SubmitDGV.RowTemplate.Height = 27;
            this.SubmitDGV.Size = new System.Drawing.Size(240, 150);
            this.SubmitDGV.TabIndex = 0;
            // 
            // SubmitBT
            // 
            this.SubmitBT.Location = new System.Drawing.Point(50, 399);
            this.SubmitBT.Name = "SubmitBT";
            this.SubmitBT.Size = new System.Drawing.Size(75, 23);
            this.SubmitBT.TabIndex = 1;
            this.SubmitBT.Text = "提交";
            this.SubmitBT.UseVisualStyleBackColor = true;
            this.SubmitBT.Click += new System.EventHandler(this.SubmitBT_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubmitBT);
            this.Controls.Add(this.SubmitDGV);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.SubmitDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SubmitDGV;
        private System.Windows.Forms.Button SubmitBT;
    }
}
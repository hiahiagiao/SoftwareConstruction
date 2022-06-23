
namespace OrderForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersDGV = new System.Windows.Forms.DataGridView();
            this.DetailsDGV = new System.Windows.Forms.DataGridView();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadBT = new System.Windows.Forms.Button();
            this.CreateBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.UpdateBT = new System.Windows.Forms.Button();
            this.ExportBT = new System.Windows.Forms.Button();
            this.ImportBT = new System.Windows.Forms.Button();
            this.KeywordBOX = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DetailsBDS = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersBDS = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.DetailsDGV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OrdersDGV, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(577, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // OrdersDGV
            // 
            this.OrdersDGV.AllowUserToAddRows = false;
            this.OrdersDGV.AutoGenerateColumns = false;
            this.OrdersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.OrdersDGV.DataSource = this.OrdersBDS;
            this.OrdersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersDGV.Location = new System.Drawing.Point(4, 4);
            this.OrdersDGV.Margin = new System.Windows.Forms.Padding(4);
            this.OrdersDGV.Name = "OrdersDGV";
            this.OrdersDGV.RowHeadersWidth = 51;
            this.OrdersDGV.RowTemplate.Height = 23;
            this.OrdersDGV.Size = new System.Drawing.Size(569, 214);
            this.OrdersDGV.TabIndex = 7;
            // 
            // DetailsDGV
            // 
            this.DetailsDGV.AllowUserToAddRows = false;
            this.DetailsDGV.AutoGenerateColumns = false;
            this.DetailsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitPrice,
            this.idDataGridViewTextBoxColumn1,
            this.customerDataGridViewTextBoxColumn1,
            this.createTimeDataGridViewTextBoxColumn1,
            this.totalAmountDataGridViewTextBoxColumn1});
            this.DetailsDGV.DataSource = this.DetailsBDS;
            this.DetailsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsDGV.Location = new System.Drawing.Point(4, 226);
            this.DetailsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.DetailsDGV.Name = "DetailsDGV";
            this.DetailsDGV.RowHeadersWidth = 51;
            this.DetailsDGV.RowTemplate.Height = 23;
            this.DetailsDGV.Size = new System.Drawing.Size(569, 215);
            this.DetailsDGV.TabIndex = 8;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // ReadBT
            // 
            this.ReadBT.Location = new System.Drawing.Point(651, 30);
            this.ReadBT.Name = "ReadBT";
            this.ReadBT.Size = new System.Drawing.Size(75, 23);
            this.ReadBT.TabIndex = 1;
            this.ReadBT.Text = "查";
            this.ReadBT.UseVisualStyleBackColor = true;
            this.ReadBT.Click += new System.EventHandler(this.ReadBT_Click);
            // 
            // CreateBT
            // 
            this.CreateBT.Location = new System.Drawing.Point(651, 196);
            this.CreateBT.Name = "CreateBT";
            this.CreateBT.Size = new System.Drawing.Size(75, 23);
            this.CreateBT.TabIndex = 2;
            this.CreateBT.Text = "增";
            this.CreateBT.UseVisualStyleBackColor = true;
            this.CreateBT.Click += new System.EventHandler(this.CreateBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(651, 238);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(75, 23);
            this.DeleteBT.TabIndex = 3;
            this.DeleteBT.Text = "删";
            this.DeleteBT.UseVisualStyleBackColor = true;
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(651, 282);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(75, 23);
            this.UpdateBT.TabIndex = 4;
            this.UpdateBT.Text = "改";
            this.UpdateBT.UseVisualStyleBackColor = true;
            // 
            // ExportBT
            // 
            this.ExportBT.Location = new System.Drawing.Point(651, 328);
            this.ExportBT.Name = "ExportBT";
            this.ExportBT.Size = new System.Drawing.Size(75, 23);
            this.ExportBT.TabIndex = 5;
            this.ExportBT.Text = "导出";
            this.ExportBT.UseVisualStyleBackColor = true;
            this.ExportBT.Click += new System.EventHandler(this.ExportBT_Click);
            // 
            // ImportBT
            // 
            this.ImportBT.Location = new System.Drawing.Point(651, 371);
            this.ImportBT.Name = "ImportBT";
            this.ImportBT.Size = new System.Drawing.Size(75, 23);
            this.ImportBT.TabIndex = 6;
            this.ImportBT.Text = "导入";
            this.ImportBT.UseVisualStyleBackColor = true;
            this.ImportBT.Click += new System.EventHandler(this.ImportBT_Click);
            // 
            // KeywordBOX
            // 
            this.KeywordBOX.Location = new System.Drawing.Point(617, 108);
            this.KeywordBOX.Name = "KeywordBOX";
            this.KeywordBOX.Size = new System.Drawing.Size(138, 25);
            this.KeywordBOX.TabIndex = 7;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DetailsBDS
            // 
            this.DetailsBDS.DataSource = this.OrdersBDS;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdersBDS
            // 
            this.OrdersBDS.DataSource = typeof(OrderApp.Order);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // customerDataGridViewTextBoxColumn1
            // 
            this.customerDataGridViewTextBoxColumn1.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn1.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn1.Name = "customerDataGridViewTextBoxColumn1";
            // 
            // createTimeDataGridViewTextBoxColumn1
            // 
            this.createTimeDataGridViewTextBoxColumn1.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn1.HeaderText = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn1.Name = "createTimeDataGridViewTextBoxColumn1";
            // 
            // totalAmountDataGridViewTextBoxColumn1
            // 
            this.totalAmountDataGridViewTextBoxColumn1.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn1.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn1.Name = "totalAmountDataGridViewTextBoxColumn1";
            this.totalAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeywordBOX);
            this.Controls.Add(this.ImportBT);
            this.Controls.Add(this.ExportBT);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.DeleteBT);
            this.Controls.Add(this.CreateBT);
            this.Controls.Add(this.ReadBT);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailsBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DetailsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.BindingSource DetailsBDS;
        private System.Windows.Forms.DataGridView OrdersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource OrdersBDS;
        private System.Windows.Forms.Button ReadBT;
        private System.Windows.Forms.Button CreateBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button UpdateBT;
        private System.Windows.Forms.Button ExportBT;
        private System.Windows.Forms.Button ImportBT;
        private System.Windows.Forms.TextBox KeywordBOX;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn1;
    }
}


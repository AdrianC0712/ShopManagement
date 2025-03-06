namespace ShopManagement
{
    partial class ShopManagementForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shopManagementDataSet = new ShopManagement.ShopManagementDataSet();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseTableAdapter = new ShopManagement.ShopManagementDataSetTableAdapters.ProduseTableAdapter();
            this.produseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireprodusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitatemasuraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproducatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrinstocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodusDataGridViewTextBoxColumn,
            this.denumireprodusDataGridViewTextBoxColumn,
            this.cantitateaDataGridViewTextBoxColumn,
            this.unitatemasuraDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.idproducatorDataGridViewTextBoxColumn,
            this.nrinstocDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // shopManagementDataSet
            // 
            this.shopManagementDataSet.DataSetName = "ShopManagementDataSet";
            this.shopManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.shopManagementDataSet;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // produseBindingSource1
            // 
            this.produseBindingSource1.DataMember = "Produse";
            this.produseBindingSource1.DataSource = this.shopManagementDataSet;
            // 
            // idprodusDataGridViewTextBoxColumn
            // 
            this.idprodusDataGridViewTextBoxColumn.DataPropertyName = "Id_produs";
            this.idprodusDataGridViewTextBoxColumn.HeaderText = "Id_produs";
            this.idprodusDataGridViewTextBoxColumn.Name = "idprodusDataGridViewTextBoxColumn";
            this.idprodusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // denumireprodusDataGridViewTextBoxColumn
            // 
            this.denumireprodusDataGridViewTextBoxColumn.DataPropertyName = "Denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.HeaderText = "Denumire_produs";
            this.denumireprodusDataGridViewTextBoxColumn.Name = "denumireprodusDataGridViewTextBoxColumn";
            this.denumireprodusDataGridViewTextBoxColumn.Width = 270;
            // 
            // cantitateaDataGridViewTextBoxColumn
            // 
            this.cantitateaDataGridViewTextBoxColumn.DataPropertyName = "Cantitatea";
            this.cantitateaDataGridViewTextBoxColumn.HeaderText = "Cantitatea";
            this.cantitateaDataGridViewTextBoxColumn.Name = "cantitateaDataGridViewTextBoxColumn";
            // 
            // unitatemasuraDataGridViewTextBoxColumn
            // 
            this.unitatemasuraDataGridViewTextBoxColumn.DataPropertyName = "Unitate_masura";
            this.unitatemasuraDataGridViewTextBoxColumn.HeaderText = "Unitate_masura";
            this.unitatemasuraDataGridViewTextBoxColumn.Name = "unitatemasuraDataGridViewTextBoxColumn";
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            // 
            // idproducatorDataGridViewTextBoxColumn
            // 
            this.idproducatorDataGridViewTextBoxColumn.DataPropertyName = "Id_producator";
            this.idproducatorDataGridViewTextBoxColumn.HeaderText = "Id_producator";
            this.idproducatorDataGridViewTextBoxColumn.Name = "idproducatorDataGridViewTextBoxColumn";
            // 
            // nrinstocDataGridViewTextBoxColumn
            // 
            this.nrinstocDataGridViewTextBoxColumn.DataPropertyName = "Nr_in_stoc";
            this.nrinstocDataGridViewTextBoxColumn.HeaderText = "Nr_in_stoc";
            this.nrinstocDataGridViewTextBoxColumn.Name = "nrinstocDataGridViewTextBoxColumn";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(12, 196);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(98, 30);
            this.AddProductButton.TabIndex = 1;
            this.AddProductButton.Text = "Adauga produs";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ShopManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShopManagementForm";
            this.Text = "ShopManagementForm";
            this.Load += new System.EventHandler(this.ShopManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ShopManagementDataSet shopManagementDataSet;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private ShopManagementDataSetTableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireprodusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitatemasuraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrinstocDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produseBindingSource1;
        private System.Windows.Forms.Button AddProductButton;
    }
}
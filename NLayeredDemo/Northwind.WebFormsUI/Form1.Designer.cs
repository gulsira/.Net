namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxAddProd = new System.Windows.Forms.GroupBox();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblNumberPerUnit = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxProdNameAdd = new System.Windows.Forms.TextBox();
            this.tbxPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxStockAmountAdd = new System.Windows.Forms.TextBox();
            this.tbxPerUnitAdd = new System.Windows.Forms.TextBox();
            this.gbxEditProd = new System.Windows.Forms.GroupBox();
            this.tbxPerUnitEdit = new System.Windows.Forms.TextBox();
            this.tbxStockAmountEdit = new System.Windows.Forms.TextBox();
            this.tbxPriceEdit = new System.Windows.Forms.TextBox();
            this.tbxProdNameEdit = new System.Windows.Forms.TextBox();
            this.cbxCategoryEdit = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblPerUnitEdit = new System.Windows.Forms.Label();
            this.lblStockAmountEdit = new System.Windows.Forms.Label();
            this.lblPriceEdit = new System.Windows.Forms.Label();
            this.lblCategoryEdit = new System.Windows.Forms.Label();
            this.lblProdNameEdit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxAddProd.SuspendLayout();
            this.gbxEditProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 174);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(1068, 212);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(776, 70);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "List By Category";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(12, 98);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(776, 70);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search By Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(25, 34);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(25, 33);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(53, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(106, 34);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(267, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(106, 33);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(267, 22);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // gbxAddProd
            // 
            this.gbxAddProd.Controls.Add(this.tbxPerUnitAdd);
            this.gbxAddProd.Controls.Add(this.tbxStockAmountAdd);
            this.gbxAddProd.Controls.Add(this.tbxPriceAdd);
            this.gbxAddProd.Controls.Add(this.tbxProdNameAdd);
            this.gbxAddProd.Controls.Add(this.cbxCategoryAdd);
            this.gbxAddProd.Controls.Add(this.btnAdd);
            this.gbxAddProd.Controls.Add(this.lblNumberPerUnit);
            this.gbxAddProd.Controls.Add(this.lblStockAmount);
            this.gbxAddProd.Controls.Add(this.lblPrice);
            this.gbxAddProd.Controls.Add(this.lblCategoryAdd);
            this.gbxAddProd.Controls.Add(this.lblProdName);
            this.gbxAddProd.Location = new System.Drawing.Point(12, 421);
            this.gbxAddProd.Name = "gbxAddProd";
            this.gbxAddProd.Size = new System.Drawing.Size(634, 214);
            this.gbxAddProd.TabIndex = 3;
            this.gbxAddProd.TabStop = false;
            this.gbxAddProd.Text = "Add Product";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(19, 38);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(98, 17);
            this.lblProdName.TabIndex = 0;
            this.lblProdName.Text = "Product Name";
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(22, 90);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryAdd.TabIndex = 1;
            this.lblCategoryAdd.Text = "Category";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(22, 147);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(272, 38);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(95, 17);
            this.lblStockAmount.TabIndex = 3;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // lblNumberPerUnit
            // 
            this.lblNumberPerUnit.AutoSize = true;
            this.lblNumberPerUnit.Location = new System.Drawing.Point(275, 90);
            this.lblNumberPerUnit.Name = "lblNumberPerUnit";
            this.lblNumberPerUnit.Size = new System.Drawing.Size(113, 17);
            this.lblNumberPerUnit.TabIndex = 4;
            this.lblNumberPerUnit.Text = "Number Per Unit";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(337, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(133, 90);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(121, 24);
            this.cbxCategoryAdd.TabIndex = 6;
            // 
            // tbxProdNameAdd
            // 
            this.tbxProdNameAdd.Location = new System.Drawing.Point(133, 38);
            this.tbxProdNameAdd.Name = "tbxProdNameAdd";
            this.tbxProdNameAdd.Size = new System.Drawing.Size(121, 22);
            this.tbxProdNameAdd.TabIndex = 7;
            // 
            // tbxPriceAdd
            // 
            this.tbxPriceAdd.Location = new System.Drawing.Point(133, 144);
            this.tbxPriceAdd.Name = "tbxPriceAdd";
            this.tbxPriceAdd.Size = new System.Drawing.Size(121, 22);
            this.tbxPriceAdd.TabIndex = 8;
            // 
            // tbxStockAmountAdd
            // 
            this.tbxStockAmountAdd.Location = new System.Drawing.Point(394, 38);
            this.tbxStockAmountAdd.Name = "tbxStockAmountAdd";
            this.tbxStockAmountAdd.Size = new System.Drawing.Size(116, 22);
            this.tbxStockAmountAdd.TabIndex = 9;
            // 
            // tbxPerUnitAdd
            // 
            this.tbxPerUnitAdd.Location = new System.Drawing.Point(394, 90);
            this.tbxPerUnitAdd.Name = "tbxPerUnitAdd";
            this.tbxPerUnitAdd.Size = new System.Drawing.Size(116, 22);
            this.tbxPerUnitAdd.TabIndex = 10;
            // 
            // gbxEditProd
            // 
            this.gbxEditProd.Controls.Add(this.tbxPerUnitEdit);
            this.gbxEditProd.Controls.Add(this.tbxStockAmountEdit);
            this.gbxEditProd.Controls.Add(this.tbxPriceEdit);
            this.gbxEditProd.Controls.Add(this.tbxProdNameEdit);
            this.gbxEditProd.Controls.Add(this.cbxCategoryEdit);
            this.gbxEditProd.Controls.Add(this.btnEdit);
            this.gbxEditProd.Controls.Add(this.lblPerUnitEdit);
            this.gbxEditProd.Controls.Add(this.lblStockAmountEdit);
            this.gbxEditProd.Controls.Add(this.lblPriceEdit);
            this.gbxEditProd.Controls.Add(this.lblCategoryEdit);
            this.gbxEditProd.Controls.Add(this.lblProdNameEdit);
            this.gbxEditProd.Location = new System.Drawing.Point(716, 421);
            this.gbxEditProd.Name = "gbxEditProd";
            this.gbxEditProd.Size = new System.Drawing.Size(634, 214);
            this.gbxEditProd.TabIndex = 4;
            this.gbxEditProd.TabStop = false;
            this.gbxEditProd.Text = "Edit Product";
            // 
            // tbxPerUnitEdit
            // 
            this.tbxPerUnitEdit.Location = new System.Drawing.Point(394, 90);
            this.tbxPerUnitEdit.Name = "tbxPerUnitEdit";
            this.tbxPerUnitEdit.Size = new System.Drawing.Size(116, 22);
            this.tbxPerUnitEdit.TabIndex = 10;
            // 
            // tbxStockAmountEdit
            // 
            this.tbxStockAmountEdit.Location = new System.Drawing.Point(394, 38);
            this.tbxStockAmountEdit.Name = "tbxStockAmountEdit";
            this.tbxStockAmountEdit.Size = new System.Drawing.Size(116, 22);
            this.tbxStockAmountEdit.TabIndex = 9;
            // 
            // tbxPriceEdit
            // 
            this.tbxPriceEdit.Location = new System.Drawing.Point(133, 144);
            this.tbxPriceEdit.Name = "tbxPriceEdit";
            this.tbxPriceEdit.Size = new System.Drawing.Size(121, 22);
            this.tbxPriceEdit.TabIndex = 8;
            // 
            // tbxProdNameEdit
            // 
            this.tbxProdNameEdit.Location = new System.Drawing.Point(133, 38);
            this.tbxProdNameEdit.Name = "tbxProdNameEdit";
            this.tbxProdNameEdit.Size = new System.Drawing.Size(121, 22);
            this.tbxProdNameEdit.TabIndex = 7;
            // 
            // cbxCategoryEdit
            // 
            this.cbxCategoryEdit.FormattingEnabled = true;
            this.cbxCategoryEdit.Location = new System.Drawing.Point(133, 90);
            this.cbxCategoryEdit.Name = "cbxCategoryEdit";
            this.cbxCategoryEdit.Size = new System.Drawing.Size(121, 24);
            this.cbxCategoryEdit.TabIndex = 6;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(337, 134);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 42);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblPerUnitEdit
            // 
            this.lblPerUnitEdit.AutoSize = true;
            this.lblPerUnitEdit.Location = new System.Drawing.Point(275, 90);
            this.lblPerUnitEdit.Name = "lblPerUnitEdit";
            this.lblPerUnitEdit.Size = new System.Drawing.Size(113, 17);
            this.lblPerUnitEdit.TabIndex = 4;
            this.lblPerUnitEdit.Text = "Number Per Unit";
            // 
            // lblStockAmountEdit
            // 
            this.lblStockAmountEdit.AutoSize = true;
            this.lblStockAmountEdit.Location = new System.Drawing.Point(272, 38);
            this.lblStockAmountEdit.Name = "lblStockAmountEdit";
            this.lblStockAmountEdit.Size = new System.Drawing.Size(95, 17);
            this.lblStockAmountEdit.TabIndex = 3;
            this.lblStockAmountEdit.Text = "Stock Amount";
            // 
            // lblPriceEdit
            // 
            this.lblPriceEdit.AutoSize = true;
            this.lblPriceEdit.Location = new System.Drawing.Point(22, 147);
            this.lblPriceEdit.Name = "lblPriceEdit";
            this.lblPriceEdit.Size = new System.Drawing.Size(40, 17);
            this.lblPriceEdit.TabIndex = 2;
            this.lblPriceEdit.Text = "Price";
            // 
            // lblCategoryEdit
            // 
            this.lblCategoryEdit.AutoSize = true;
            this.lblCategoryEdit.Location = new System.Drawing.Point(22, 90);
            this.lblCategoryEdit.Name = "lblCategoryEdit";
            this.lblCategoryEdit.Size = new System.Drawing.Size(65, 17);
            this.lblCategoryEdit.TabIndex = 1;
            this.lblCategoryEdit.Text = "Category";
            // 
            // lblProdNameEdit
            // 
            this.lblProdNameEdit.AutoSize = true;
            this.lblProdNameEdit.Location = new System.Drawing.Point(19, 38);
            this.lblProdNameEdit.Name = "lblProdNameEdit";
            this.lblProdNameEdit.Size = new System.Drawing.Size(98, 17);
            this.lblProdNameEdit.TabIndex = 0;
            this.lblProdNameEdit.Text = "Product Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1110, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 657);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxEditProd);
            this.Controls.Add(this.gbxAddProd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxAddProd.ResumeLayout(false);
            this.gbxAddProd.PerformLayout();
            this.gbxEditProd.ResumeLayout(false);
            this.gbxEditProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxAddProd;
        private System.Windows.Forms.TextBox tbxPerUnitAdd;
        private System.Windows.Forms.TextBox tbxStockAmountAdd;
        private System.Windows.Forms.TextBox tbxPriceAdd;
        private System.Windows.Forms.TextBox tbxProdNameAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumberPerUnit;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategoryAdd;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.GroupBox gbxEditProd;
        private System.Windows.Forms.TextBox tbxPerUnitEdit;
        private System.Windows.Forms.TextBox tbxStockAmountEdit;
        private System.Windows.Forms.TextBox tbxPriceEdit;
        private System.Windows.Forms.TextBox tbxProdNameEdit;
        private System.Windows.Forms.ComboBox cbxCategoryEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblPerUnitEdit;
        private System.Windows.Forms.Label lblStockAmountEdit;
        private System.Windows.Forms.Label lblPriceEdit;
        private System.Windows.Forms.Label lblCategoryEdit;
        private System.Windows.Forms.Label lblProdNameEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}


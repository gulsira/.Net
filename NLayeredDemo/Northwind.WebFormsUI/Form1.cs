using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryAdd.DataSource = _categoryService.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryEdit.DataSource = _categoryService.GetAll();
            cbxCategoryEdit.DisplayMember = "CategoryName";
            cbxCategoryEdit.ValueMember = "CategoryId";
        }

        public void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }catch { };
            
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxSearch.Text))
            {
                dgwProduct.DataSource = _productService.SearchProductsByName(tbxSearch.Text);
            } else
            {
                LoadProducts();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = tbxProdNameAdd.Text,
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxPriceAdd.Text),
                UnitsInStock = Convert.ToInt16(tbxStockAmountAdd.Text),
                QuantityPerUnit = tbxPerUnitAdd.Text
            });
            LoadProducts();
            MessageBox.Show("Product Added");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _productService.Edit(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProdNameEdit.Text,
                CategoryId = Convert.ToInt32(cbxCategoryEdit.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxPriceEdit.Text),
                UnitsInStock = Convert.ToInt16(tbxStockAmountEdit.Text),
                QuantityPerUnit = tbxPerUnitEdit.Text
            });
            LoadProducts();
            MessageBox.Show("Product Edited");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            tbxProdNameEdit.Text = row.Cells[1].Value.ToString();
            cbxCategoryEdit.SelectedValue = row.Cells[2].Value.ToString();
            tbxPriceEdit.Text = row.Cells[3].Value.ToString();
            tbxStockAmountEdit.Text = row.Cells[5].Value.ToString();
            tbxPerUnitEdit.Text = row.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null )
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });
                    LoadProducts();
                    MessageBox.Show("Product Deleted");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
               
            }
        }
    }
}

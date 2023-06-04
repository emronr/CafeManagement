using CafeManagement.Business.DTOs.Inputs;
using CafeManagement.Business.Services.Management;
using CafeManagement.Business.Services.Menu;

namespace CafeManagement.WinForm
{
    public partial class Menu : Form
    {
        private readonly int TableId;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IManagementService _managementService;

        public Menu(
            int tableId,
            ICategoryService categoryService,
            IProductService productService,
            IManagementService managementService)
        {
            TableId = tableId;
            this._categoryService = categoryService;
            this._productService = productService;
            this._managementService = managementService;
            InitializeComponent();
            productDetailPanel.Visible = false;
            addOrderPanel.Visible = false;
            TableId = tableId;
            GetCategories();
            GetProducts();
        }


        private async void GetProducts(int? categoryId = null)
        {
            productListPanel.Controls.Clear();
            var products = await _productService.GetProducts();

            if (categoryId != null)
                products = products.Where(x => x.CategoryId == (int)categoryId).ToList();

            int columnCount = 5;
            int rowCount = products.Count % columnCount == 0
                ? products.Count / columnCount
                : products.Count / columnCount + 1;


            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    var product = products.Skip(row * columnCount + column).FirstOrDefault();
                    if (product == null)
                        continue;
                    Button button = new Button();
                    button.Name = product.Id.ToString();
                    button.Text = product.Name.ToString();
                    button.Left = column * 110;
                    button.Top = row * 110;
                    button.Width = 100;
                    button.Height = 100;
                    button.BackColor = Color.Aqua;
                    button.Click += new EventHandler(Product_Click);
                    productListPanel.Controls.Add(button);
                }
            }
        }

        private async void GetCategories()
        {
            categoryPanel.Controls.Clear();
            var categories = await _categoryService.GetCategories();
            int count = 0;
            foreach (var category in categories)
            {
                ContextMenuStrip cm = new ContextMenuStrip();
                cm.Items.Add("Yeni Ürün", null, new EventHandler(NewProduct_Click));
                Button categoryButton = new Button()
                {
                    Name = category.Id.ToString(),
                    Text = category.Name.ToString(),
                    Left = 20,
                    Top = count * 100,
                    Height = 80,
                    Width = 110,
                    BackColor = Color.LightCyan
                };
                categoryButton.Click += Category_Click;
                cm.Items[0].Tag = category.Id.ToString();
                categoryButton.ContextMenuStrip = cm;
                categoryPanel.Controls.Add(categoryButton);
                count++;
            }
        }

        private void Product_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var product =  _productService.GetProduct(Convert.ToInt32(button.Name)).Result;
            lblProductId.Text = product.Id.ToString();
            txtProductName.Text = product.Name;
            txtProductDescription.Text = product.Description;
            txtProductPrice.Text = product.Price.ToString();
            productDetailPanel.Visible = true;
            addOrderPanel.Visible = true;
            btnAddProduct.Visible = false;
            btnProductUpdate.Visible = true;
        }

        private void Category_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            GetProducts(Convert.ToInt32(button.Name));
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var productDto = _productService.GetProduct(Convert.ToInt32(lblProductId.Text)).Result;
            productDto.Name = txtProductName.Text;
            productDto.Description = txtProductDescription.Text;
            productDto.Price = Convert.ToDecimal(txtProductPrice.Text);
            _productService.UpdateProductAsync(productDto);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            var createOrderDto = new CreateOrderInput()
            {
                ProductId = Convert.ToInt32(lblProductId.Text),
                Quantity = Convert.ToInt32(txtCount.Text),
                TableId = this.TableId
            };
            _managementService.CreateOrder(createOrderDto);
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            var categoryId = Convert.ToInt32(button.Tag);

            var newProduct = new CreateProductInput()
            {
                CategoryId = categoryId,
                Name = txtProductName.Text,
                Description = txtProductDescription.Text,
                Price = Convert.ToDecimal(txtProductPrice.Text),
            };

            _productService.CreateProductAsync(newProduct);

            GetProducts(categoryId);
            productDetailPanel.Visible = true;
        }

        private void NewProduct_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            lblProductId.Text = "-";
            txtProductName.Text = string.Empty;
            txtProductDescription.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            addOrderPanel.Visible = false;
            productDetailPanel.Visible = true;
            btnProductUpdate.Visible = false;
            btnAddProduct.Visible = true;
            btnAddProduct.Tag = menu.Tag;
        }
    }
}



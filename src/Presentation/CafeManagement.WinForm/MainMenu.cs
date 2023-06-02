using CafeManagement.Business.DTOs;
using CafeManagement.Business.Services.Management;
using CafeManagement.Business.Services.Menu;

namespace CafeManagement.WinForm
{
    public partial class MainMenu : Form
    {
        private readonly IManagementService _managementService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        private int _tableId;
        private int _orderId;

        public MainMenu(IManagementService managementService,
            IProductService productService,
            ICategoryService categoryService)
        {
            _productService = productService;
            _managementService = managementService;
            _categoryService = categoryService;
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = true;
            CreateTables();
        }

        private async void CreateTables()
        {
            tablesPanel.Controls.Clear();
            var tables = await _managementService.GetTables();
            int rowCount = 3;
            int columnCount = tables.Count % rowCount == 0
                ? tables.Count / rowCount
                : tables.Count / rowCount + 1;

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    var table = tables.Skip(row * rowCount + column).FirstOrDefault();
                    Button button = new Button();
                    button.Name = "btnTable" + table.Id.ToString();
                    button.Text = table.TableName.ToString();
                    button.Tag = table.Id.ToString();
                    button.Left = column * 250;
                    button.Top = row * 250;
                    button.Width = 150;
                    button.Height = 150;
                    button.BackColor = table.IsFull
                        ? GoodCustomer(await _managementService.GetActiveOrder(table.Id))
                            ? Color.Green
                            : Color.Red
                        : Color.Gray;
                    button.Click += new EventHandler(Table_Click);
                    tablesPanel.Controls.Add(button);
                }
            }
        }

        private async void GetActiveOrder()
        {
            if (_tableId == null)
                return;

            var order = await _managementService.GetActiveOrder(_tableId);
            Button tableButton = tablesPanel.Controls.OfType<Button>().FirstOrDefault(x => x.Name == $"btnTable{_tableId}");
            if (order == null)
            {
                lblOpenDateValue.Text = "-";
                lblLastOrderDateValue.Text = "-";
                btnShowTotalPrice.Text = "0";
                orderListBox.Items.Clear();
                if (tableButton != null)
                    tableButton.BackColor = Color.Gray;
                return;
            }
            _orderId = order.Id;
            lblOpenDateValue.Text = order.CreateDate.ToString();
            lblLastOrderDateValue.Text = order.LastOrderDate.ToString();
            btnShowTotalPrice.Text = order.GetTotalPrice().ToString();
            orderListBox.Items.Clear();
            foreach (OrderDetailDto detail in order.OrderDetails)
            {
                string orderDetailText = detail.Product.Name + " x " + detail.Quantity.ToString();
                orderListBox.Items.Add(orderDetailText);
            }

            if (GoodCustomer(order))
                tableButton.BackColor = Color.Green;
            else
                tableButton.BackColor = Color.Red;

        }
        private void Table_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            lblTableId.Text = $"Masa No : {button.Tag}";
            _tableId = Convert.ToInt32(button.Tag);
            GetActiveOrder();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (_tableId == default)
            {
                MessageBox.Show("Massa Seçiniz!");
                return;
            }
            Form productForm = new Menu(Convert.ToInt32(lblTableId.Text.Split(": ")[1]),
                _categoryService,
                _productService,
                _managementService);
            productForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetActiveOrder();
        }

        private async void btnHesapAl_Click(object sender, EventArgs e)
        {
            await _managementService.CloseOrder(_tableId);
            GetActiveOrder();
        }

        private bool GoodCustomer(OrderDto orderDto)
           => DateTime.Now - orderDto.LastOrderDate < TimeSpan.FromSeconds(30);
    }
}

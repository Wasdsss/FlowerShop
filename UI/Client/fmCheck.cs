using FlowerShop.CLasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerShop.UI.Client
{
    public partial class fmCheck : Form
    {
        List<Order> showOrder;

        public fmCheck(List<Order> order)
        {
            InitializeComponent();
            showOrder = order;
            LoadDataToListBox();
            GetData();
            lstCheck.HorizontalScrollbar = true;
            lstCheck.ClearSelected();
        }

        private void GetData()
        {
            /*//Подсчёт суммы заказа, подсчёт скидки заказа.
            decimal finalSumWithDiscount = 0;
            int finalSumDiscountAmount = 0;

            foreach (Order order in showOrder)
            {
                finalSumWithDiscount += Convert.ToDecimal(order.ProductCostWithDiscount);
                finalSumDiscountAmount += Convert.ToInt32(order.ProductDiscount);
            }
            lblCost.Text = $"Сумма заказа: {finalSumWithDiscount}";
            lblDiscount.Text = $"Сумма скидки: {finalSumDiscountAmount}%";
            lblAdress.Text = $"Пункт выдачи: {Order.OrderAdress}";
            lblOrderDate.Text = $"Дата заказа: {Order.OrderDate.ToString("D")}";*/

            decimal sumWithDiscount = 0;
            int sumDiscount = 0;
            int productCount = 0;

            foreach (Order order in showOrder)
            {
                sumWithDiscount += Convert.ToDecimal(order.ProductCostWithDiscount);

                sumDiscount += Convert.ToInt32(order.ProductDiscount);
                productCount++;
            }
            int avgDiscount = sumDiscount / productCount;
            lblCost.Text = $"Цена заказа: {sumWithDiscount}";
            lblDiscount.Text = $"Общая скидка: {avgDiscount}";
            lblOrderDate.Text = $"Дата заказа: {Order.OrderDate.ToString("D")}";
            lblAdress.Text = $"Пункт выдачи:\n{Order.OrderAdress}";
        }

        private void LoadDataToListBox()
        {
            lstCheck.DataSource = showOrder
                    .GroupBy(o => new { o.ProductId, o.ProductName, o.ProductCost, o.ProductManufacturer, o.ProductCategory, o.ProductDiscount, o.ProductDescription, o.ProductCostWithDiscount, o.ProductPhoto })
                    .Select(group => new Order
                    {
                        ProductId = group.Key.ProductId,
                        ProductName = group.Key.ProductName,
                        ProductCost = group.Key.ProductCost,
                        ProductManufacturer = group.Key.ProductManufacturer,
                        ProductCategory = group.Key.ProductCategory,
                        ProductDiscount = group.Key.ProductDiscount,
                        ProductDescription = group.Key.ProductDescription,
                        ProductCostWithDiscount = group.Key.ProductCostWithDiscount,
                        ProductPhoto = group.Key.ProductPhoto,
                        Count = group.Count()
                    })
                    .ToList();
            lstCheck.DisplayMember = "Values";

            //lstCheck.DisplayMember = "Values";
            //lstCheck.DataSource = showOrder;
        }


    }
}

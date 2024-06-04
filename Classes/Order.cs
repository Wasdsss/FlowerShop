using FlowerShop.UI.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.CLasses
{
    public class Order
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCost { get; set; }
        public string ProductManufacturer { get; set; }
        public string ProductCategory { get; set; }
        public string ProductDiscount { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCostWithDiscount { get; set; }
        public string ProductPhoto { get; set; }
        public static string OrderAdress{ get; set; }
        public static DateTime OrderDate { get; set; }
        public static DateTime OrderDeliveryDate { get; set; }
        public int Count { get; set; }
        public string Values => $" Товар: {ProductName} | Категория: {ProductCategory} | Скидка: {ProductDiscount}% | Итоговая стоимость: {ProductCostWithDiscount} | Кол-во: {Count}";
    }
}

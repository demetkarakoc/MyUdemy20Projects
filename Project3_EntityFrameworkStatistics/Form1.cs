using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Db3Project20Entities db = new Db3Project20Entities();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            int categoryCount = db.TblCategory.Count();
            lblCategoryCount.Text= categoryCount.ToString();

            //Toplam ürün sayısı
            int productCount = db.TblProduct.Count();
            lblProductCount.Text = productCount.ToString();

            //Toplam Müşteri sayısı
            int customerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = customerCount.ToString();

            //Toplam Sipariş sayısı
            int orderCount = db.TblOrder.Count();
            lblOrderCount.Text = orderCount.ToString();

            //Toplam Stok Sayısı
            var totalProductStockCount = db.TblProduct.Sum(x=>x.ProductStock);
            lblProductTotalStock.Text = totalProductStockCount.ToString();

            //Ortalama ürün fiyatı
            var averageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblProductAveragePrice.Text = averageProductPrice.ToString() + "TL";

            //Toplam meyve stoku sayısı
            var totalProductCountByCategoryIsFruit = db.TblProduct.Where(x=>x.CategoryId==1).Sum(y=>y.ProductStock);
            lblProductCountByIsFruit.Text= totalProductCountByCategoryIsFruit.ToString();

            //Gazoz toplam işlem hacmi
            var totalPriceByProductNameIsGazozGetStock = db.TblProduct.Where(x=> x.ProductName == "Gazoz").Select(y=>y.ProductStock).FirstOrDefault();
            var totalPriceByProductNameIsGazozGetUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y=>y.ProductPrice).FirstOrDefault();
            var totalPriceByProductNameIsGazoz = totalPriceByProductNameIsGazozGetStock * totalPriceByProductNameIsGazozGetUnitPrice;
            lblTotalPriceByProductNameIsGazoz.Text= totalPriceByProductNameIsGazoz.ToString() + "TL";


            //Stok sayısı 100' den az olan ürün sayısı
            var productCountryByStockCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lblProductStockSmallerThen100.Text= productCountryByStockCountSmallerThen100.ToString();

            //Kategorisi sebze ve durumu aktif olan ürün stoğu
            int id = db.TblCategory.Where(w => w.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault();
            var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where(x => x.CategoryId == (db.TblCategory.Where(w=> w.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault()) && x.ProductStatus == true).Sum(y => y.ProductStock);
            lblProductCountByCategorySebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();

            //Türkiye'den yapılan Siparişler SQL Query
            var orderCountFromTürkiye = db.Database.SqlQuery<int>("Select count (*)From TblOrder Where CustomerId  In( \r\nSelect CustomerId From TblCustomer Where \r\nCustomerCountry='Türkiye')").FirstOrDefault();
            lblOrderCountFromTürkiyeSQL.Text = orderCountFromTürkiye.ToString();


            //Türkiye'den yapılan Siparişler Entity Framework
            var turkishCustomerIds = db.TblCustomer.Where(x=> x.CustomerCountry == "Türkiye")
                                                   .Select(y => y.CustomerId)
                                                   .ToList();
            var orderCountFromTurkeyWithEf = db.TblOrder.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
            lblOrderCountFromTurkiyeByEF.Text= orderCountFromTurkeyWithEf.ToString();

            //Siparişler içinde kategorisi  meyve olan ürünlerin toplam satış fiyatı SQL
            var orderTotalPriceByCategoryIsMeyve = db.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) From TblOrder o Join TblProduct p On\r\no.ProductId=p.ProductId Join TblCategory c On\r\np.CategoryId=c.CategoryId Where c.CategoryName = 'Meyve'").FirstOrDefault();
            lblOrderTotalPriceByCategoryIsMeyve.Text = orderTotalPriceByCategoryIsMeyve.ToString() + "TL";

            //Siparişler içinde kategorisi  meyve olan ürünlerin toplam satış fiyatı EF

            var orderTotalPriceByCategoryIsMeyveEf = (from o in db.TblOrder
                                                      join p in db.TblProduct on o.ProductId equals p.ProductId
                                                      join c in db.TblCategory on p.CategoryId equals c.CategoryId
                                                      where c.CategoryName == "Meyve"
                                                      select o.TotalPrice).Sum();
            lblorderTotalPriceByCategoryIsMeyveEf.Text = orderTotalPriceByCategoryIsMeyveEf.ToString() + "TL";

            //Son eklenen ürün adı
            var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductName).Select(y=>y.ProductName).FirstOrDefault();
            lblLastProductName.Text = lastProductName.ToString();


            //Son eklenen ürün kategori adı
            var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(y => y.CategoryId).FirstOrDefault();
            var lastProductCategoryName = db.TblCategory.Where(x=>x.CategoryId == lastProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
            lblLastProductCategoryName.Text = lastProductCategoryName.ToString();



            //Aktif ürün sayısı
            var activeCountProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
            lblActiveProductCount.Text = activeCountProductCount.ToString();


            //Toplam kola stok satışlarından kazanılan para
            var coloStock = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductStock).FirstOrDefault();
            var colaPrice = db.TblProduct.Where(x=>x.ProductName =="Kola").Select(y=>y.ProductPrice).FirstOrDefault();
            var totalColaStockPrice = coloStock * colaPrice;
            lblTotalPriceWithStockByCola.Text = totalColaStockPrice.ToString() + "TL";


            //Son sipariş veren müşteri adı
            var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(y => y.CustomerId).FirstOrDefault();
            var lastCustomerName=db.TblCustomer.Where(x=>x.CustomerId==lastCustomerId).Select(y => y.CustomerName).FirstOrDefault();
            lblLastCustomerName.Text = lastCustomerName.ToString();

           
            //Ülke Çeşitliliği sayısı
            var countryDifferentCount = db.TblCustomer.Select(x=>x.CustomerCountry).Distinct().Count();
            lblCountryDifferentCount.Text = countryDifferentCount.ToString();













        }
    }
}

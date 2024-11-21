using Project9_MongoDbOrder.Entities;
using Project9_MongoDbOrder.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDiscrit.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
            };

            orderOperation.AddOrder(order);
            MessageBox.Show("Ekleme işlemi başarılı");

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var updateOrder = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDiscrit.Text,
                OrderId = id,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
            };

            orderOperation.UpdateOrder(updateOrder);
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            Order orders = orderOperation.GetOrderById(id);
            dataGridView1.DataSource = new List<Order> { orders };
        }
    }
}

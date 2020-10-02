using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem;

namespace OrderSystemWinform
{

    public partial class OrderSystemForm : Form
    {

        public List<Order> orders = new List<Order>();

        private Order currentSelectedOrder;

        private OrderService orderService;

        public OrderSystemForm()
        {
            InitializeComponent();
            this.orderService = new OrderService(CreateTestList1());
            this.orders = this.orderService.orderList;
            Order_DGV.DataSource = this.orders;
            Order_DGV.ClearSelection();
        }

        private List<Order> CreateTestList1()
        {
            OrderDetails commodity1 = new OrderDetails("apple", 5.99f, 5);
            OrderDetails commodity2 = new OrderDetails("banana", 3.99f, 1);
            OrderDetails commodity3 = new OrderDetails("orange", 4.99f, 2);
            OrderDetails commodity4 = new OrderDetails("lemon", 6.99f, 3);

            List<OrderDetails> orderDetails1 = new List<OrderDetails>();
            orderDetails1.Add(commodity1);

            List<OrderDetails> orderDetails2 = new List<OrderDetails>();
            orderDetails2.Add(commodity2);

            List<OrderDetails> orderDetails3 = new List<OrderDetails>();
            orderDetails1.Add(commodity3);
            orderDetails3.Add(commodity4);

            Order order1 = new Order(1, "Chen", "Wuhan", orderDetails1);
            Order order2 = new Order(2, "Navon", "Wuhan", orderDetails2);
            Order order3 = new Order(3, "Chen", "Beijing", orderDetails3);

            List<Order> orderList = new List<Order>();

            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);

            return orderList;

        }

        public void RefreshOrderDGV()
        {
            Order_DGV.DataSource = this.orders;
            //Console.WriteLine(this.orders.Count);
            Detail_DGV.DataSource = null;
        }

        public void EditOrder(Order order)
        {
           // Console.WriteLine("Edit");
            if (!this.orderService.orderList.Contains(order))
            {
                //Console.WriteLine(this.orderService.orderList.Count);
                this.orderService.Add(order);
                this.orders = null;

                Order_DGV.DataSource = null;
                Detail_DGV.DataSource = null;
                this.orders = this.orderService.orderList;
                RefreshOrderDGV();
            }
        }




        private void Order_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (!int.TryParse(Order_DGV.SelectedRows[0].Cells[0].Value.ToString(), out int orderID))
                throw new Exception("No Order Selected");
            //Console.WriteLine(orderID);
            this.currentSelectedOrder = orderService.SelectOrderById(orderID);
            Console.WriteLine(this.currentSelectedOrder.ID);
            Detail_DGV.DataSource = this.currentSelectedOrder.OrderDetailsDic.Values.ToList();
        }

        public static void Main()
        {
            Application.Run(new OrderSystemForm());
        }


        private void Search_Btn_Click(object sender, EventArgs e)
        {
            if (SearchCtx_TB.Text == "")
            {
                this.orders = this.orderService.orderList;
                RefreshOrderDGV();
                return;
            }
            
            if (Address_RBtn.Checked)
            {
                List<Order> result = this.orderService.SelectOrderByAddress(SearchCtx_TB.Text);
                if (result.Count <= 0)
                    MessageBox.Show("No Result");
                else
                {
                    //this.orders.Clear();
                    this.orders = result;
                    RefreshOrderDGV();
                }
                return;
            }

            if (Customer_RBtn.Checked)
            {
                List<Order> result = this.orderService.SelectOrderByCustomer(SearchCtx_TB.Text);
                if (result.Count <= 0)
                    MessageBox.Show("No Result");
                else
                {
                    //this.orders.Clear();
                    this.orders = result;
                    RefreshOrderDGV();
                }
                return;
            }

            if(ID_RBtn.Checked)
            {
                if (!int.TryParse(SearchCtx_TB.Text, out int result))
                {
                    MessageBox.Show("Input Invalid");
                }
                else
                {
                    Order order = this.orderService.SelectOrderById(result);
                    if (order == null)
                        MessageBox.Show("No Result");
                    else
                    { 
                        this.orders = new List<Order>();
                        this.orders.Add(order);
                        RefreshOrderDGV();
                    }
                }
                return;
            }
            
        }

        
        private void Create_Btn_Click(object sender, EventArgs e)
        {
            OrderEditForm orderEditForm = new OrderEditForm(new Order(this.orderService.orderList.Count + 1, "", "", new List<OrderDetails>()));
            orderEditForm.FinishEditDelegate = this.EditOrder;
            orderEditForm.ShowDialog();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedOrder != null)
            {
                OrderEditForm orderEditForm = new OrderEditForm(this.currentSelectedOrder);
                orderEditForm.FinishEditDelegate = this.EditOrder;
                orderEditForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Order Selected");
            }

        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (this.currentSelectedOrder != null)
            {
                //this.orders.Remove(this.currentSelectedOrder);

                Console.WriteLine("this.orderService.orderlist.Count:" + this.orderService.orderList.Count);
                Order_DGV.DataSource = null;
                this.orders = null; 
                
                this.orderService.DeleteOrder(this.currentSelectedOrder);
                this.currentSelectedOrder = null;
                this.orders = this.orderService.orderList;
                Console.WriteLine("this.orderService.orderlist.Count:" + this.orderService.orderList.Count);
                RefreshOrderDGV();
            }
            else
            {
                MessageBox.Show("No Order Selected");
            }
        }
    }
}

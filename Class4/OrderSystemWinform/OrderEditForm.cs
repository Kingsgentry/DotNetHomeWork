using OrderSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystemWinform
{
    public partial class OrderEditForm : Form
    {
        private Order selectedOrder;
        private OrderDetails selectedOrderDetail;

        public delegate void OrderSystemDelegate(Order order);
        public OrderSystemDelegate FinishEditDelegate;


        public OrderEditForm(Order order)
        {
            this.selectedOrder = order;
            InitializeComponent();
            ID_TB.Text = order.ID.ToString();
            Customer_TB.Text = order.Customer;
            Address_TB.Text = order.Address;
            Order_DGV.DataSource = order.OrderDetailsDic.Values.ToList();
            Order_DGV.ClearSelection();
            
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (this.selectedOrder.OrderDetailsDic.ContainsKey(Name_TB.Text))
            {
                MessageBox.Show(Name_TB.Text + " Already Exists");
                Name_TB.Text = "";
                return;
            }

            this.selectedOrder.OrderDetailsDic.Add(Name_TB.Text, new OrderDetails(Name_TB.Text, float.Parse(Price_TB.Text), int.Parse(Number_TB.Text)));
            RefreshOrderDGV();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (this.selectedOrder.OrderDetailsDic.ContainsValue(selectedOrderDetail))
            {
                this.selectedOrder.OrderDetailsDic.Remove(this.selectedOrderDetail.Name);
                RefreshOrderDGV();
            }
        }

        private void Unselected_Btn_Click(object sender, EventArgs e)
        {
            Order_DGV.ClearSelection();
            this.selectedOrderDetail = null;
            //Name_TB.Text = "";
            //Price_TB.Text = "";
            //Number_TB.Text = "";
            Name_TB.ReadOnly = false;
        }

        private void Customer_TB_TextChanged(object sender, EventArgs e)
        {
            selectedOrder.ChangeCustomer(Customer_TB.Text);
        }

        private void Address_TB_TextChanged(object sender, EventArgs e)
        {
            selectedOrder.ChangeAddress(Address_TB.Text);
        }

        private void Finish_Btn_Click(object sender, EventArgs e)
        {
            FinishEditDelegate(this.selectedOrder);
            this.Dispose();
        }

        private void Price_TB_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(Price_TB.Text, out float result))
            {
                MessageBox.Show("Input Invalid");
                Price_TB.Text = "";
                return;
            }

            if (Order_DGV.SelectedRows.Count == 1 && this.selectedOrderDetail != null)
            {
                this.selectedOrderDetail.ChangeSinglePrice(result);
                RefreshOrderDGV();
            }

        }

        private void Number_TB_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Number_TB.Text, out int result))
            {
                MessageBox.Show("Input Invalid");
                Number_TB.Text = "";
                return;
            }

            if (Order_DGV.SelectedRows.Count == 1 && this.selectedOrderDetail != null)
            {
                this.selectedOrderDetail.ChangeNumber(result);
                RefreshOrderDGV();
            }
        }

        private void Order_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(orderID);
            this.selectedOrderDetail = this.selectedOrder.OrderDetailsDic[Order_DGV.SelectedRows[0].Cells[0].Value.ToString()];
            if (selectedOrderDetail == null)
                throw new Exception("No Commodity Found");

            Name_TB.Text = this.selectedOrderDetail.Name;
            Price_TB.Text = this.selectedOrderDetail.SinglePrice.ToString();
            Number_TB.Text = this.selectedOrderDetail.Number.ToString();
            Name_TB.ReadOnly = true;

        }

        private void RefreshOrderDGV()
        {
            Order_DGV.DataSource = this.selectedOrder.OrderDetailsDic.Values.ToList();
        }

        private void Name_TB_TextChanged(object sender, EventArgs e)
        {


            if (Order_DGV.SelectedRows.Count == 1 && this.selectedOrderDetail != null)
            {
                this.selectedOrderDetail.ChangeName(Name_TB.Text);
                RefreshOrderDGV();
            }
        }


    }
}

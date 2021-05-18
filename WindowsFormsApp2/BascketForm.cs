using Restaurant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BascketForm : Form
    {
        public static Order wish;
        public BascketForm()
        {
            string add = "";
            foreach(var item in wish.wishes)
            {
                add += $"{item.name} x{item.num_of_portion} \n"; // printing of the order
            }

            InitializeComponent();
            foreach(var item in wish.wishes)
            {
                DDcomboBox1.Items.Add(item.name); // filling box with dishes that we will be able to delete
            }

            deliveryBox.Items.Add(Delivery.pickup.ToString());
            deliveryBox.Items.Add(Delivery.courier.ToString());

            wish.CalcPrice();
            Price.Text += $" {wish.price.ToString()} UAH";
            DishesList.Text = add;
        }

        private void PrintOrder() 
        {
            string add = "";
            foreach (var item in wish.wishes)
            {
                add += $"{item.name} x{item.num_of_portion} \n";
                DishesList.Text = add;
            }

            wish.CalcPrice();
            Price.Text = $"PRICE: {wish.price.ToString()} UAH";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panelForOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DishesList_Click(object sender, EventArgs e)
        {

        }

        private void DDcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string del = DDcomboBox1.SelectedItem.ToString();
            wish.RemoveDishByName(del);
            PrintOrder();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(deliveryBox.SelectedItem.ToString() == "pickup")
            {
                wish.delivery = Delivery.pickup;
            }
            else
            {
                wish.delivery = Delivery.courier;
            }
        }

        private void CHECKOUT_Click(object sender, EventArgs e)
        {
            if (deliveryBox.Text == "")
            {
                
                MessageBox.Show("Choose delivery option!");
                return;
            }

            string result = "Thank you for your order! Our manager will contact you by phone";
            MessageBox.Show(result);
        }
    }
}

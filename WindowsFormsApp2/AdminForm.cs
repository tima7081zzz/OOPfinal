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
    public partial class AdminForm : Form
    {
        public MenuRest<AdminAccount> content = new MenuRest<AdminAccount>(AccountType.Admin);

        public AdminForm()
        {
            InitializeComponent();
            PrintMenu(); // printing menu of the restaurant
            FillDeleteBox(); // fiiling box with dishes
        }

        private void PrintMenu()
        {
            List.Text = "";
            bool changer = false;
            foreach(var item in content.GetDish())
            {
                List.Text += $"{item.name} - {item.price} \t\t\t\t\t\t\t\t";
                if(changer)
                {
                    List.Text += "\n";
                    changer = false;
                }
                else
                {
                    changer = true;
                }
            }
        }

        private void FillDeleteBox()
        {
            foreach(var item in content.GetDish())
            {
                deleteBox.Items.Add(item.name);
            }
        }

        private void FillDeleteIngrBox() // filling box with additable ingredients of the chosen dish
        {
            string name = deleteBox.Text;
            foreach(var item in content.getDishByName(name).structure)
            {
                deleteIngrBox.Items.Add(item.Name);
            }
        }

        private void delete_dish_Click(object sender, EventArgs e)
        {
            
            int id_dish = content.getIndexDishByName(deleteBox.SelectedItem.ToString());
            int id_ingredient = content.GetIndexIngrByName(deleteIngrBox.SelectedItem.ToString());
            content.Remove(id_ingredient, id_dish.ToString());


            //clearing of all of the fields in form 

            deleteBox.Items.Clear();
            deleteIngrBox.Items.Clear();
            content = new MenuRest<AdminAccount>(AccountType.Admin);
            PrintMenu();
            FillDeleteBox();
        }

        private void deleteIngrBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteIngrBox.Items.Clear();
            FillDeleteIngrBox();
        }
    }
}

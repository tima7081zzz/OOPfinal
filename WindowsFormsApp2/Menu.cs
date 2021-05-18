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
    public partial class Menu : Form
    {
        int X = 1;
        int Y = 1;
        public List<Button> btns = new List<Button>();
        public Order wish = new Order();
        string name_;
        
        MenuRest<ClientAccount> content = new MenuRest<ClientAccount>(AccountType.Client);

        public Menu()
        {
            InitializeComponent();
            wish.Notify += MessageHandler; // events 
        }
        
        private void MessageHandler(string mes)
        {
            messageLabel.Text = $"\"{mes}\"";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void back_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Starter_Click(object sender, EventArgs e)
        {
            //this is special algorithm that I develop that makes buttons in a dynamic way
            //every dish of the section is seperate button, so there could be any number of buttons.
            //this algorithm calculate proper size and position of each of the buttons to they filling 
            //form in square like manner

            HideButtons();
            List<Dish> sect = new List<Dish>();
            sect = content.getDishesBySection("Starter");


            //finding of the start positions 

            int size = sect.Count;
            int numX = (int)Math.Ceiling(Math.Sqrt(size));
            int numY = (int)(size / numX);
            int AddX = size - (numY * numX);

            int index = 0;
            int gap = 10;
            int YpointBtn;
            if (AddX>0)
            {
                YpointBtn = (int)(390 / (numY + 1));
            }
            else
            {
                YpointBtn = (int)(390 / numY);
            }
            
            int XpointBtnSq = (int)(780 / numX);
            int XpointBtnAdd = 0;
            if (AddX!=0)
            {
                XpointBtnAdd = (int)(780 / AddX);
            }
            
            int StartX = 10;
            int StartY = 140;

            //cycle that go through the window of the program and prints buttons in square
            for (int i = 0; i < numY; i++)
            {
                for (int j = 0; j < numX; j++)
                {
                    //adding button with needed properties

                    Button btn = new Button();
                    btn.BackColor = SystemColors.HotTrack;
                    btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                    btn.Name = sect[index].name;
                    btn.Size = new Size(XpointBtnSq-gap, YpointBtn-gap);
                    btn.Location = new Point(StartX, StartY);
                    btn.TabIndex = 1;
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new EventHandler(Btn_Click);
                    back.Controls.Add(btn);
                    btns.Add(btn);
                    StartX += XpointBtnSq;
                    index++;
                    X++;
                }
                StartX = 10;
                StartY += YpointBtn;
                Y++;
            }

            //cycle that go through the end of the window and prints remaining buttons
            StartX = 10;
            for (int i = 0; i < AddX; i++)
            {
                //adding button with needed properties

                Button btn = new Button();
                btn.BackColor = SystemColors.HotTrack;
                btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                btn.Name = sect[index].name;
                btn.Size = new Size(XpointBtnAdd - gap, YpointBtn - gap);
                btn.Location = new Point(StartX, StartY);
                btn.TabIndex = 1;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(Btn_Click);
                back.Controls.Add(btn);
                btns.Add(btn);
                StartX += XpointBtnAdd;
                index++;
                X++;
            }
        }

        private void MainCourse_Click(object sender, EventArgs e)
        {
            //this is special algorithm that I develop that makes buttons in a dynamic way
            //every dish of the section is seperate button, so there could be any number of buttons.
            //this algorithm calculate proper size and position of each of the buttons to they filling 
            //form in square like manner

            HideButtons();
            List<Dish> sect = new List<Dish>();
            sect = content.getDishesBySection("MainCourse");

            //finding of the start positions 
            int size = sect.Count;
            int numX = (int)Math.Ceiling(Math.Sqrt(size));
            int numY = (int)(size / numX);
            int AddX = size - (numY * numX);

            int index = 0;
            int gap = 10;
            int YpointBtn;
            if (AddX > 0)
            {
                YpointBtn = (int)(390 / (numY + 1));
            }
            else
            {
                YpointBtn = (int)(390 / numY);
            }

            int XpointBtnSq = (int)(780 / numX);
            int XpointBtnAdd = 0;
            if (AddX != 0)
            {
                XpointBtnAdd = (int)(780 / AddX);
            }

            //cycle that go through the window of the program and prints buttons in square
            int StartX = 10;
            int StartY = 140;
            for (int i = 0; i < numY; i++)
            {
                for (int j = 0; j < numX; j++)
                {
                    //adding button with needed properties


                    Button btn = new Button();
                    btn.BackColor = SystemColors.HotTrack;
                    btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                    btn.Name = sect[index].name;
                    btn.Size = new Size(XpointBtnSq - gap, YpointBtn - gap);
                    btn.Location = new Point(StartX, StartY);
                    btn.TabIndex = 1;
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new EventHandler(Btn_Click);
                    back.Controls.Add(btn);
                    btns.Add(btn);
                    StartX += XpointBtnSq;
                    index++;
                    X++;
                }
                StartX = 10;
                StartY += YpointBtn;
                Y++;
            }

            //cycle that go through the end of the window and prints remaining buttons
            StartX = 10;
            for (int i = 0; i < AddX; i++)
            {
                //adding button with needed properties


                Button btn = new Button();
                btn.BackColor = SystemColors.HotTrack;
                btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                btn.Name = sect[index].name;
                btn.Size = new Size(XpointBtnAdd - gap, YpointBtn - gap);
                btn.Location = new Point(StartX, StartY);
                btn.TabIndex = 1;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(Btn_Click);
                back.Controls.Add(btn);
                btns.Add(btn);
                StartX += XpointBtnAdd;
                index++;
                X++;
            }
        }

        private void Garnish_Click(object sender, EventArgs e)
        {
            //this is special algorithm that I develop that makes buttons in a dynamic way
            //every dish of the section is seperate button, so there could be any number of buttons.
            //this algorithm calculate proper size and position of each of the buttons to they filling 
            //form in square like manner

            HideButtons();
            List<Dish> sect = new List<Dish>();
            sect = content.getDishesBySection("Garnish");

            int size = sect.Count;
            int numX = (int)Math.Ceiling(Math.Sqrt(size));
            int numY = (int)(size / numX);
            int AddX = size - (numY * numX);

            //finding of the start positions 
            int index = 0;
            int gap = 10;
            int YpointBtn;
            if (AddX > 0)
            {
                YpointBtn = (int)(390 / (numY + 1));
            }
            else
            {
                YpointBtn = (int)(390 / numY);
            }

            int XpointBtnSq = (int)(780 / numX);
            int XpointBtnAdd = 0;
            if (AddX != 0)
            {
                XpointBtnAdd = (int)(780 / AddX);
            }

            //cycle that go through the window of the program and prints buttons in square
            int StartX = 10;
            int StartY = 140;
            for (int i = 0; i < numY; i++)
            {
                for (int j = 0; j < numX; j++)
                {
                    //adding button with needed properties


                    Button btn = new Button();
                    btn.BackColor = SystemColors.HotTrack;
                    btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                    btn.Name = sect[index].name;
                    btn.Size = new Size(XpointBtnSq - gap, YpointBtn - gap);
                    btn.Location = new Point(StartX, StartY);
                    btn.TabIndex = 1;
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new EventHandler(Btn_Click);
                    back.Controls.Add(btn);
                    btns.Add(btn);
                    StartX += XpointBtnSq;
                    index++;
                    X++;
                }
                StartX = 10;
                StartY += YpointBtn;
                Y++;
            }

            //cycle that go through the end of the window and prints remaining buttons
            StartX = 10;
            for (int i = 0; i < AddX; i++)
            {
                //adding button with needed properties


                Button btn = new Button();
                btn.BackColor = SystemColors.HotTrack;
                btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                btn.Name = sect[index].name;
                btn.Size = new Size(XpointBtnAdd - gap, YpointBtn - gap);
                btn.Location = new Point(StartX, StartY);
                btn.TabIndex = 1;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(Btn_Click);
                back.Controls.Add(btn);
                btns.Add(btn);
                StartX += XpointBtnAdd;
                index++;
                X++;
            }
        }

        private void Salad_Click(object sender, EventArgs e)
        {
            //this is special algorithm that I develop that makes buttons in a dynamic way
            //every dish of the section is seperate button, so there could be any number of buttons.
            //this algorithm calculate proper size and position of each of the buttons to they filling 
            //form in square like manner

            HideButtons();
            List<Dish> sect = new List<Dish>();
            sect = content.getDishesBySection("Salad");

            //finding of the start positions 

            int size = sect.Count;
            int numX = (int)Math.Ceiling(Math.Sqrt(size));
            int numY = (int)(size / numX);
            int AddX = size - (numY * numX);

            int index = 0;
            int gap = 10;
            int YpointBtn;
            if (AddX > 0)
            {
                YpointBtn = (int)(390 / (numY + 1));
            }
            else
            {
                YpointBtn = (int)(390 / numY);
            }

            int XpointBtnSq = (int)(780 / numX);
            int XpointBtnAdd = 0;
            if (AddX != 0)
            {
                XpointBtnAdd = (int)(780 / AddX);
            }

            //cycle that go through the window of the program and prints buttons in square
            int StartX = 10;
            int StartY = 140;
            for (int i = 0; i < numY; i++)
            {
                for (int j = 0; j < numX; j++)
                {
                    //adding button with needed properties


                    Button btn = new Button();
                    btn.BackColor = SystemColors.HotTrack;
                    btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                    btn.Name = sect[index].name;
                    btn.Size = new Size(XpointBtnSq - gap, YpointBtn - gap);
                    btn.Location = new Point(StartX, StartY);
                    btn.TabIndex = 1;
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new EventHandler(Btn_Click);
                    back.Controls.Add(btn);
                    btns.Add(btn);
                    StartX += XpointBtnSq;
                    index++;
                    X++;
                }
                StartX = 10;
                StartY += YpointBtn;
                Y++;
            }

            //cycle that go through the end of the window and prints remaining buttons
            StartX = 10;
            for (int i = 0; i < AddX; i++)
            {
                //adding button with needed properties


                Button btn = new Button();
                btn.BackColor = SystemColors.HotTrack;
                btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                btn.Name = sect[index].name;
                btn.Size = new Size(XpointBtnAdd - gap, YpointBtn - gap);
                btn.Location = new Point(StartX, StartY);
                btn.TabIndex = 1;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(Btn_Click);
                back.Controls.Add(btn);
                btns.Add(btn);
                StartX += XpointBtnAdd;
                index++;
                X++;
            }
        }

        private void Dessert_Click(object sender, EventArgs e)
        {
            HideButtons();
            List<Dish> sect = new List<Dish>();
            sect = content.getDishesBySection("Dessert");

            //finding of the start positions 
            int size = sect.Count;
            int numX = (int)Math.Ceiling(Math.Sqrt(size));
            int numY = (int)(size / numX);
            int AddX = size - (numY * numX);

            int index = 0;
            int gap = 10;
            int YpointBtn;
            if (AddX > 0)
            {
                YpointBtn = (int)(390 / (numY + 1));
            }
            else
            {
                YpointBtn = (int)(390 / numY);
            }

            int XpointBtnSq = (int)(780 / numX);
            int XpointBtnAdd = 0;
            if (AddX != 0)
            {
                XpointBtnAdd = (int)(780 / AddX);
            }

            //cycle that go through the window of the program and prints buttons in square
            int StartX = 10;
            int StartY = 140;
            for (int i = 0; i < numY; i++)
            {
                for (int j = 0; j < numX; j++)
                {
                    //adding button with needed properties


                    Button btn = new Button();
                    btn.BackColor = SystemColors.HotTrack;
                    btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                    btn.Name = sect[index].name;
                    btn.Size = new Size(XpointBtnSq - gap, YpointBtn - gap);
                    btn.Location = new Point(StartX, StartY);
                    btn.TabIndex = 1;
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new EventHandler(Btn_Click);
                    back.Controls.Add(btn);
                    btns.Add(btn);
                    StartX += XpointBtnSq;
                    index++;
                    X++;
                }
                StartX = 10;
                StartY += YpointBtn;
                Y++;
            }

            //cycle that go through the end of the window and prints remaining buttons
            StartX = 10;
            for (int i = 0; i < AddX; i++)
            {
                //adding button with needed properties


                Button btn = new Button();
                btn.BackColor = SystemColors.HotTrack;
                btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                btn.Name = sect[index].name;
                btn.Size = new Size(XpointBtnAdd - gap, YpointBtn - gap);
                btn.Location = new Point(StartX, StartY);
                btn.TabIndex = 1;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(Btn_Click);
                back.Controls.Add(btn);
                btns.Add(btn);
                StartX += XpointBtnAdd;
                index++;
                X++;
            }
        }

        private void Beverages_Click(object sender, EventArgs e)
        {
            HideButtons();
            List<Dish> sect = new List<Dish>();
            sect = content.getDishesBySection("Beverages");

            //finding of the start positions 
            int size = sect.Count;
            int numX = (int)Math.Ceiling(Math.Sqrt(size));
            int numY = (int)(size / numX);
            int AddX = size - (numY * numX);

            int index = 0;
            int gap = 10;
            int YpointBtn;
            if (AddX > 0)
            {
                YpointBtn = (int)(390 / (numY + 1));
            }
            else
            {
                YpointBtn = (int)(390 / numY);
            }

            int XpointBtnSq = (int)(780 / numX);
            int XpointBtnAdd = 0;
            if (AddX != 0)
            {
                XpointBtnAdd = (int)(780 / AddX);
            }

            //cycle that go through the window of the program and prints buttons in square
            int StartX = 10;
            int StartY = 140;
            for (int i = 0; i < numY; i++)
            {
                for (int j = 0; j < numX; j++)
                {
                    //adding button with needed properties


                    Button btn = new Button();
                    btn.BackColor = SystemColors.HotTrack;
                    btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                    btn.Name = sect[index].name;
                    btn.Size = new Size(XpointBtnSq - gap, YpointBtn - gap);
                    btn.Location = new Point(StartX, StartY);
                    btn.TabIndex = 1;
                    btn.UseVisualStyleBackColor = false;
                    btn.Click += new EventHandler(Btn_Click);
                    back.Controls.Add(btn);
                    btns.Add(btn);
                    StartX += XpointBtnSq;
                    index++;
                    X++;
                }
                StartX = 10;
                StartY += YpointBtn;
                Y++;
            }

            //cycle that go through the end of the window and prints remaining buttons
            StartX = 10;
            for (int i = 0; i < AddX; i++)
            {
                //adding button with needed properties


                Button btn = new Button();
                btn.BackColor = SystemColors.HotTrack;
                btn.Font = new Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                btn.Text = btn.Text = $"{sect[index].name} \n {sect[index].price} UAH";
                btn.Name = sect[index].name;
                btn.Size = new Size(XpointBtnAdd - gap, YpointBtn - gap);
                btn.Location = new Point(StartX, StartY);
                btn.TabIndex = 1;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(Btn_Click);
                back.Controls.Add(btn);
                btns.Add(btn);
                StartX += XpointBtnAdd;
                index++;
                X++;
            }
        }

        void HideButtons()
        {
            foreach (var item in btns)
            {
                item.Hide();// hiding of the buttons of previous section
            }

            btns = new List<Button>();//clearing the list of the buttons of previous section
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // clearing of the fields on the window of the program
            Ingredients.Items.Clear();
            comboBox1.Items.Clear();
            numOfPorion.Clear();

            Button btn = (Button)sender;
            name_ = btn.Name;
            Dish current = content.getDishByName(name_);

            foreach(var item in current.structure)
            {
                Ingredients.Items.Add($"{item.Name}");//filling box with structure of the dish
            }

            foreach (var item in current.structure)
            {
                if(item.IsEditable)
                {
                    comboBox1.Items.Add($"{item.Name}");//filling box with editable ingredients from the dish
                }
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            //adding al the items to thw window 
            this.panelbottom.Controls.Add(this.numOfPorion);
            this.panelbottom.Controls.Add(this.AddToBasket);
            this.panelbottom.Controls.Add(this.comboBox1);
            this.panelbottom.Controls.Add(this.DeleteInrg);
            this.panelbottom.Controls.Add(this.Structure);
            this.panelbottom.Controls.Add(this.Ingredients);
        }

        private void AddToBasket_Click(object sender, EventArgs e)
        {
            if (numOfPorion.Text == "")//condition of filling the field
            {

                MessageBox.Show("Type the number of portion!");
                return;
            }

            
            try
            {
                int num = int.Parse(numOfPorion.Text);
                content.getDishByName(name_).setPortion(num);
            }
            catch(Exception ex)//exception of incorect input or wrong number
            {
                MessageBox.Show(ex.Message);
                return;
            }
            wish.AddDish(content.getDishByName(name_));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();

            //removing selected item from the structure
            int index = content.getIndexDishByName(name_);
            content.GetDish()[index].Remove(selectedState); 
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Basket_Click(object sender, EventArgs e)
        {
            //going to basket form
            BascketForm.wish = wish;
            BascketForm basket_form = new BascketForm();
            this.Hide();
            basket_form.Show();


        }

        private void BlueBack_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

namespace WindowsFormsApp2
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Panel();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.Beverages = new System.Windows.Forms.Button();
            this.Dessert = new System.Windows.Forms.Button();
            this.Salad = new System.Windows.Forms.Button();
            this.Garnish = new System.Windows.Forms.Button();
            this.MainCourse = new System.Windows.Forms.Button();
            this.Starter = new System.Windows.Forms.Button();
            this.BlueBack = new System.Windows.Forms.Panel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.Basket = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.AddToBasket = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DeleteInrg = new System.Windows.Forms.Label();
            this.Structure = new System.Windows.Forms.Label();
            this.Ingredients = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.numOfPorion = new System.Windows.Forms.TextBox();
            this.back.SuspendLayout();
            this.BlueBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Controls.Add(this.panelbottom);
            this.back.Controls.Add(this.Beverages);
            this.back.Controls.Add(this.Dessert);
            this.back.Controls.Add(this.Salad);
            this.back.Controls.Add(this.Garnish);
            this.back.Controls.Add(this.MainCourse);
            this.back.Controls.Add(this.Starter);
            this.back.Controls.Add(this.BlueBack);
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(793, 595);
            this.back.TabIndex = 0;
            this.back.Paint += new System.Windows.Forms.PaintEventHandler(this.back_Paint);
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelbottom.Location = new System.Drawing.Point(0, 525);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(793, 69);
            this.panelbottom.TabIndex = 3;
            // 
            // Beverages
            // 
            this.Beverages.BackColor = System.Drawing.Color.SteelBlue;
            this.Beverages.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Beverages.Location = new System.Drawing.Point(657, 92);
            this.Beverages.Name = "Beverages";
            this.Beverages.Size = new System.Drawing.Size(124, 31);
            this.Beverages.TabIndex = 1;
            this.Beverages.Text = "Beverages";
            this.Beverages.UseVisualStyleBackColor = false;
            this.Beverages.Click += new System.EventHandler(this.Beverages_Click);
            // 
            // Dessert
            // 
            this.Dessert.BackColor = System.Drawing.Color.SteelBlue;
            this.Dessert.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dessert.Location = new System.Drawing.Point(527, 92);
            this.Dessert.Name = "Dessert";
            this.Dessert.Size = new System.Drawing.Size(124, 31);
            this.Dessert.TabIndex = 1;
            this.Dessert.Text = "Dessert";
            this.Dessert.UseVisualStyleBackColor = false;
            this.Dessert.Click += new System.EventHandler(this.Dessert_Click);
            // 
            // Salad
            // 
            this.Salad.BackColor = System.Drawing.Color.SteelBlue;
            this.Salad.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Salad.Location = new System.Drawing.Point(397, 92);
            this.Salad.Name = "Salad";
            this.Salad.Size = new System.Drawing.Size(124, 31);
            this.Salad.TabIndex = 1;
            this.Salad.Text = "Salad";
            this.Salad.UseVisualStyleBackColor = false;
            this.Salad.Click += new System.EventHandler(this.Salad_Click);
            // 
            // Garnish
            // 
            this.Garnish.BackColor = System.Drawing.Color.SteelBlue;
            this.Garnish.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Garnish.Location = new System.Drawing.Point(266, 92);
            this.Garnish.Name = "Garnish";
            this.Garnish.Size = new System.Drawing.Size(124, 31);
            this.Garnish.TabIndex = 1;
            this.Garnish.Text = "Garnish";
            this.Garnish.UseVisualStyleBackColor = false;
            this.Garnish.Click += new System.EventHandler(this.Garnish_Click);
            // 
            // MainCourse
            // 
            this.MainCourse.BackColor = System.Drawing.Color.SteelBlue;
            this.MainCourse.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainCourse.Location = new System.Drawing.Point(136, 92);
            this.MainCourse.Name = "MainCourse";
            this.MainCourse.Size = new System.Drawing.Size(124, 31);
            this.MainCourse.TabIndex = 1;
            this.MainCourse.Text = "Main Course";
            this.MainCourse.UseVisualStyleBackColor = false;
            this.MainCourse.Click += new System.EventHandler(this.MainCourse_Click);
            // 
            // Starter
            // 
            this.Starter.BackColor = System.Drawing.Color.SteelBlue;
            this.Starter.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Starter.Location = new System.Drawing.Point(8, 92);
            this.Starter.Name = "Starter";
            this.Starter.Size = new System.Drawing.Size(124, 31);
            this.Starter.TabIndex = 1;
            this.Starter.Text = "Starter";
            this.Starter.UseVisualStyleBackColor = false;
            this.Starter.Click += new System.EventHandler(this.Starter_Click);
            // 
            // BlueBack
            // 
            this.BlueBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BlueBack.Controls.Add(this.messageLabel);
            this.BlueBack.Controls.Add(this.Basket);
            this.BlueBack.Controls.Add(this.MenuLabel);
            this.BlueBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlueBack.Location = new System.Drawing.Point(0, 0);
            this.BlueBack.Name = "BlueBack";
            this.BlueBack.Size = new System.Drawing.Size(793, 85);
            this.BlueBack.TabIndex = 0;
            this.BlueBack.Paint += new System.Windows.Forms.PaintEventHandler(this.BlueBack_Paint);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.messageLabel.Location = new System.Drawing.Point(495, 29);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(30, 19);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "\" \"  ";
            // 
            // Basket
            // 
            this.Basket.BackColor = System.Drawing.Color.Orange;
            this.Basket.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Basket.ForeColor = System.Drawing.Color.Transparent;
            this.Basket.Location = new System.Drawing.Point(657, 12);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(124, 54);
            this.Basket.TabIndex = 1;
            this.Basket.Text = "GO \r\nTO BASKET";
            this.Basket.UseVisualStyleBackColor = false;
            this.Basket.Click += new System.EventHandler(this.Basket_Click);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MenuLabel.Location = new System.Drawing.Point(282, 9);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(216, 80);
            this.MenuLabel.TabIndex = 0;
            this.MenuLabel.Text = "MENU";
            this.MenuLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddToBasket
            // 
            this.AddToBasket.BackColor = System.Drawing.Color.Orange;
            this.AddToBasket.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToBasket.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddToBasket.Location = new System.Drawing.Point(657, 5);
            this.AddToBasket.Name = "AddToBasket";
            this.AddToBasket.Size = new System.Drawing.Size(124, 58);
            this.AddToBasket.TabIndex = 0;
            this.AddToBasket.Text = "ADD\r\nTO BASKET";
            this.AddToBasket.UseVisualStyleBackColor = false;
            this.AddToBasket.Click += new System.EventHandler(this.AddToBasket_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(437, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // DeleteInrg
            // 
            this.DeleteInrg.AutoSize = true;
            this.DeleteInrg.Font = new System.Drawing.Font("Adobe Gothic Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteInrg.Location = new System.Drawing.Point(280, 27);
            this.DeleteInrg.Name = "DeleteInrg";
            this.DeleteInrg.Size = new System.Drawing.Size(151, 19);
            this.DeleteInrg.TabIndex = 0;
            this.DeleteInrg.Text = "DELETE INGREDIENT:";
            this.DeleteInrg.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Structure
            // 
            this.Structure.AutoSize = true;
            this.Structure.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Structure.Location = new System.Drawing.Point(0, 22);
            this.Structure.Name = "Structure";
            this.Structure.Size = new System.Drawing.Size(116, 24);
            this.Structure.TabIndex = 0;
            this.Structure.Text = "STRUCTURE:";
            // 
            // Ingredients
            // 
            this.Ingredients.BackColor = System.Drawing.Color.SteelBlue;
            this.Ingredients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ingredients.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ingredients.FormattingEnabled = true;
            this.Ingredients.Location = new System.Drawing.Point(122, 13);
            this.Ingredients.Name = "Ingredients";
            this.Ingredients.Size = new System.Drawing.Size(150, 38);
            this.Ingredients.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(313, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "Main Course";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(162, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 31);
            this.button3.TabIndex = 1;
            this.button3.Text = "Main Course";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(12, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 31);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 85);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "MENU";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(313, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 31);
            this.button5.TabIndex = 1;
            this.button5.Text = "Main Course";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // numOfPorion
            // 
            this.numOfPorion.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numOfPorion.Location = new System.Drawing.Point(601, 13);
            this.numOfPorion.Name = "numOfPorion";
            this.numOfPorion.Size = new System.Drawing.Size(40, 45);
            this.numOfPorion.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 595);
            this.Controls.Add(this.back);
            this.Name = "Menu";
            this.Text = "Menu";
            this.back.ResumeLayout(false);
            this.BlueBack.ResumeLayout(false);
            this.BlueBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Panel BlueBack;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button Starter;
        private System.Windows.Forms.Button MainCourse;
        private System.Windows.Forms.Button Salad;
        private System.Windows.Forms.Button Garnish;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Dessert;
        private System.Windows.Forms.Button Beverages;
        private System.Windows.Forms.Button Basket;
        private System.Windows.Forms.ComboBox Ingredients;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Label DeleteInrg;
        private System.Windows.Forms.Label Structure;
        private System.Windows.Forms.Button AddToBasket;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox numOfPorion;
        private System.Windows.Forms.Label messageLabel;
    }
}
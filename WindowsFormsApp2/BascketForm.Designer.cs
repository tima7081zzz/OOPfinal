namespace WindowsFormsApp2
{
    partial class BascketForm
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
            this.CHECKOUT = new System.Windows.Forms.Button();
            this.DeliveryLabel = new System.Windows.Forms.Label();
            this.deliveryBox = new System.Windows.Forms.ComboBox();
            this.DDcomboBox1 = new System.Windows.Forms.ComboBox();
            this.DeleteDish = new System.Windows.Forms.Label();
            this.panelForOrder = new System.Windows.Forms.Panel();
            this.DishesList = new System.Windows.Forms.Label();
            this.LabelDishesList = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.panelBasket = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.Label();
            this.BSKT = new System.Windows.Forms.Label();
            this.back.SuspendLayout();
            this.panelForOrder.SuspendLayout();
            this.panelBasket.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Controls.Add(this.CHECKOUT);
            this.back.Controls.Add(this.DeliveryLabel);
            this.back.Controls.Add(this.deliveryBox);
            this.back.Controls.Add(this.DDcomboBox1);
            this.back.Controls.Add(this.DeleteDish);
            this.back.Controls.Add(this.panelForOrder);
            this.back.Controls.Add(this.panelBasket);
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(800, 493);
            this.back.TabIndex = 0;
            // 
            // CHECKOUT
            // 
            this.CHECKOUT.BackColor = System.Drawing.Color.Orange;
            this.CHECKOUT.Font = new System.Drawing.Font("Adobe Gothic Std B", 44.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CHECKOUT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CHECKOUT.Location = new System.Drawing.Point(339, 295);
            this.CHECKOUT.Name = "CHECKOUT";
            this.CHECKOUT.Size = new System.Drawing.Size(353, 177);
            this.CHECKOUT.TabIndex = 6;
            this.CHECKOUT.Text = "CHECKOUT";
            this.CHECKOUT.UseVisualStyleBackColor = false;
            this.CHECKOUT.Click += new System.EventHandler(this.CHECKOUT_Click);
            // 
            // DeliveryLabel
            // 
            this.DeliveryLabel.AutoSize = true;
            this.DeliveryLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeliveryLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeliveryLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeliveryLabel.Location = new System.Drawing.Point(339, 229);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(99, 24);
            this.DeliveryLabel.TabIndex = 5;
            this.DeliveryLabel.Text = "DELIVERY:";
            this.DeliveryLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // deliveryBox
            // 
            this.deliveryBox.FormattingEnabled = true;
            this.deliveryBox.Location = new System.Drawing.Point(510, 229);
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(182, 23);
            this.deliveryBox.TabIndex = 4;
            this.deliveryBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DDcomboBox1
            // 
            this.DDcomboBox1.FormattingEnabled = true;
            this.DDcomboBox1.Location = new System.Drawing.Point(510, 122);
            this.DDcomboBox1.Name = "DDcomboBox1";
            this.DDcomboBox1.Size = new System.Drawing.Size(182, 23);
            this.DDcomboBox1.TabIndex = 3;
            this.DDcomboBox1.SelectedIndexChanged += new System.EventHandler(this.DDcomboBox1_SelectedIndexChanged);
            // 
            // DeleteDish
            // 
            this.DeleteDish.AutoSize = true;
            this.DeleteDish.BackColor = System.Drawing.SystemColors.Highlight;
            this.DeleteDish.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteDish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteDish.Location = new System.Drawing.Point(339, 122);
            this.DeleteDish.Name = "DeleteDish";
            this.DeleteDish.Size = new System.Drawing.Size(124, 24);
            this.DeleteDish.TabIndex = 2;
            this.DeleteDish.Text = "DELETE DISH:";
            this.DeleteDish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DeleteDish.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panelForOrder
            // 
            this.panelForOrder.BackColor = System.Drawing.Color.SteelBlue;
            this.panelForOrder.Controls.Add(this.DishesList);
            this.panelForOrder.Controls.Add(this.LabelDishesList);
            this.panelForOrder.Controls.Add(this.Order);
            this.panelForOrder.Location = new System.Drawing.Point(18, 106);
            this.panelForOrder.Name = "panelForOrder";
            this.panelForOrder.Size = new System.Drawing.Size(262, 366);
            this.panelForOrder.TabIndex = 1;
            this.panelForOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForOrder_Paint);
            // 
            // DishesList
            // 
            this.DishesList.AutoSize = true;
            this.DishesList.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DishesList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DishesList.Location = new System.Drawing.Point(17, 40);
            this.DishesList.Name = "DishesList";
            this.DishesList.Size = new System.Drawing.Size(63, 24);
            this.DishesList.TabIndex = 2;
            this.DishesList.Text = "label1";
            this.DishesList.Click += new System.EventHandler(this.DishesList_Click);
            // 
            // LabelDishesList
            // 
            this.LabelDishesList.AutoSize = true;
            this.LabelDishesList.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelDishesList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDishesList.Location = new System.Drawing.Point(17, 55);
            this.LabelDishesList.Name = "LabelDishesList";
            this.LabelDishesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelDishesList.Size = new System.Drawing.Size(0, 20);
            this.LabelDishesList.TabIndex = 1;
            this.LabelDishesList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelDishesList.Click += new System.EventHandler(this.label1_Click);
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Order.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Order.Location = new System.Drawing.Point(0, 0);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(220, 40);
            this.Order.TabIndex = 0;
            this.Order.Text = "YOUR ORDER:";
            // 
            // panelBasket
            // 
            this.panelBasket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelBasket.Controls.Add(this.Price);
            this.panelBasket.Controls.Add(this.BSKT);
            this.panelBasket.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBasket.Location = new System.Drawing.Point(0, 0);
            this.panelBasket.Name = "panelBasket";
            this.panelBasket.Size = new System.Drawing.Size(800, 100);
            this.panelBasket.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Adobe Gothic Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Price.Location = new System.Drawing.Point(589, 47);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(83, 30);
            this.Price.TabIndex = 7;
            this.Price.Text = "PRICE:";
            // 
            // BSKT
            // 
            this.BSKT.AutoSize = true;
            this.BSKT.Font = new System.Drawing.Font("Adobe Gothic Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BSKT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BSKT.Location = new System.Drawing.Point(276, 20);
            this.BSKT.Name = "BSKT";
            this.BSKT.Size = new System.Drawing.Size(261, 80);
            this.BSKT.TabIndex = 0;
            this.BSKT.Text = "BASKET";
            this.BSKT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BascketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.back);
            this.Name = "BascketForm";
            this.Text = "BascketForm";
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            this.panelForOrder.ResumeLayout(false);
            this.panelForOrder.PerformLayout();
            this.panelBasket.ResumeLayout(false);
            this.panelBasket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Panel panelBasket;
        private System.Windows.Forms.Panel panelForOrder;
        private System.Windows.Forms.Label LabelDishesList;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label DeleteDish;
        private System.Windows.Forms.Label BSKT;
        private System.Windows.Forms.Label DeliveryLabel;
        private System.Windows.Forms.ComboBox deliveryBox;
        private System.Windows.Forms.ComboBox DDcomboBox1;
        private System.Windows.Forms.Button CHECKOUT;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label DishesList;
    }
}
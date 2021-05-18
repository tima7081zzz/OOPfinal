namespace WindowsFormsApp2
{
    partial class AdminForm
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
            this.deleteIngrBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.forAssortment = new System.Windows.Forms.Panel();
            this.List = new System.Windows.Forms.Label();
            this.ASSORTMENT = new System.Windows.Forms.Label();
            this.delete_ingrfrom = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.ComboBox();
            this.DELETE = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Panel();
            this.EDIT_MENU = new System.Windows.Forms.Label();
            this.back.SuspendLayout();
            this.forAssortment.SuspendLayout();
            this.topLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back.Controls.Add(this.deleteIngrBox);
            this.back.Controls.Add(this.label2);
            this.back.Controls.Add(this.label1);
            this.back.Controls.Add(this.forAssortment);
            this.back.Controls.Add(this.delete_ingrfrom);
            this.back.Controls.Add(this.deleteBox);
            this.back.Controls.Add(this.DELETE);
            this.back.Controls.Add(this.divider);
            this.back.Controls.Add(this.topLabel);
            this.back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(800, 529);
            this.back.TabIndex = 0;
            // 
            // deleteIngrBox
            // 
            this.deleteIngrBox.FormattingEnabled = true;
            this.deleteIngrBox.Location = new System.Drawing.Point(625, 191);
            this.deleteIngrBox.Name = "deleteIngrBox";
            this.deleteIngrBox.Size = new System.Drawing.Size(150, 23);
            this.deleteIngrBox.TabIndex = 9;
            this.deleteIngrBox.SelectedIndexChanged += new System.EventHandler(this.deleteIngrBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(504, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGREDIENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(570, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "DISH";
            // 
            // forAssortment
            // 
            this.forAssortment.BackColor = System.Drawing.Color.SteelBlue;
            this.forAssortment.Controls.Add(this.List);
            this.forAssortment.Controls.Add(this.ASSORTMENT);
            this.forAssortment.Location = new System.Drawing.Point(20, 98);
            this.forAssortment.Name = "forAssortment";
            this.forAssortment.Size = new System.Drawing.Size(450, 419);
            this.forAssortment.TabIndex = 10;
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.List.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.List.Location = new System.Drawing.Point(10, 30);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(54, 20);
            this.List.TabIndex = 1;
            this.List.Text = "label1";
            // 
            // ASSORTMENT
            // 
            this.ASSORTMENT.AutoSize = true;
            this.ASSORTMENT.BackColor = System.Drawing.Color.SteelBlue;
            this.ASSORTMENT.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ASSORTMENT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ASSORTMENT.Location = new System.Drawing.Point(0, 0);
            this.ASSORTMENT.Name = "ASSORTMENT";
            this.ASSORTMENT.Size = new System.Drawing.Size(152, 26);
            this.ASSORTMENT.TabIndex = 0;
            this.ASSORTMENT.Text = "ASSORTMENT:";
            // 
            // delete_ingrfrom
            // 
            this.delete_ingrfrom.BackColor = System.Drawing.Color.Orange;
            this.delete_ingrfrom.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_ingrfrom.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete_ingrfrom.Location = new System.Drawing.Point(570, 287);
            this.delete_ingrfrom.Name = "delete_ingrfrom";
            this.delete_ingrfrom.Size = new System.Drawing.Size(140, 58);
            this.delete_ingrfrom.TabIndex = 7;
            this.delete_ingrfrom.Text = "DELETE\r\n";
            this.delete_ingrfrom.UseVisualStyleBackColor = false;
            this.delete_ingrfrom.Click += new System.EventHandler(this.delete_dish_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.FormattingEnabled = true;
            this.deleteBox.Location = new System.Drawing.Point(625, 138);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(150, 23);
            this.deleteBox.TabIndex = 9;
            this.deleteBox.SelectedIndexChanged += new System.EventHandler(this.deleteBox_SelectedIndexChanged);
            // 
            // DELETE
            // 
            this.DELETE.AutoSize = true;
            this.DELETE.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DELETE.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DELETE.Location = new System.Drawing.Point(504, 89);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(288, 24);
            this.DELETE.TabIndex = 2;
            this.DELETE.Text = "DELETE INGREDIENT FROM DISH";
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.divider.Location = new System.Drawing.Point(487, 80);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(11, 449);
            this.divider.TabIndex = 1;
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.topLabel.Controls.Add(this.EDIT_MENU);
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.topLabel.Location = new System.Drawing.Point(0, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(800, 82);
            this.topLabel.TabIndex = 0;
            // 
            // EDIT_MENU
            // 
            this.EDIT_MENU.AutoSize = true;
            this.EDIT_MENU.Font = new System.Drawing.Font("Adobe Gothic Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EDIT_MENU.Location = new System.Drawing.Point(224, 2);
            this.EDIT_MENU.Name = "EDIT_MENU";
            this.EDIT_MENU.Size = new System.Drawing.Size(364, 80);
            this.EDIT_MENU.TabIndex = 0;
            this.EDIT_MENU.Text = "EDIT MENU";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.back);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            this.forAssortment.ResumeLayout(false);
            this.forAssortment.PerformLayout();
            this.topLabel.ResumeLayout(false);
            this.topLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Button delete_ingrfrom;
        private System.Windows.Forms.ComboBox deleteBox;
        private System.Windows.Forms.Label DELETE;
        private System.Windows.Forms.Panel divider;
        private System.Windows.Forms.Panel topLabel;
        private System.Windows.Forms.Label EDIT_MENU;
        private System.Windows.Forms.Panel forAssortment;
        private System.Windows.Forms.Label List;
        private System.Windows.Forms.Label ASSORTMENT;
        private System.Windows.Forms.ComboBox deleteIngrBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
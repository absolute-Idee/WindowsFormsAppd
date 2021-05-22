
namespace WinFormsForDataBase_URBAEV
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.id_in_orderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.total_priceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Show_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input product(all fields must be filled)";
            // 
            // id_in_orderTextBox
            // 
            this.id_in_orderTextBox.Location = new System.Drawing.Point(208, 93);
            this.id_in_orderTextBox.Name = "id_in_orderTextBox";
            this.id_in_orderTextBox.Size = new System.Drawing.Size(125, 27);
            this.id_in_orderTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID in order";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(208, 127);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 27);
            this.nameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "name";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(208, 161);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(125, 27);
            this.amountTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "amount";
            // 
            // total_priceTextBox
            // 
            this.total_priceTextBox.Location = new System.Drawing.Point(208, 228);
            this.total_priceTextBox.Name = "total_priceTextBox";
            this.total_priceTextBox.Size = new System.Drawing.Size(125, 27);
            this.total_priceTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "total price";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(45, 276);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(94, 29);
            this.Add_button.TabIndex = 9;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(208, 195);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(125, 27);
            this.priceTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "price";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(387, 342);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(94, 29);
            this.delete_button.TabIndex = 12;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "to delete input ID and name and press the button";
            // 
            // Show_button
            // 
            this.Show_button.Location = new System.Drawing.Point(208, 275);
            this.Show_button.Name = "Show_button";
            this.Show_button.Size = new System.Drawing.Size(94, 29);
            this.Show_button.TabIndex = 14;
            this.Show_button.Text = "Show";
            this.Show_button.UseVisualStyleBackColor = true;
            this.Show_button.Click += new System.EventHandler(this.Show_button_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 380);
            this.Controls.Add(this.Show_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.total_priceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_in_orderTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_in_orderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox total_price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total_priceTextBox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Show_button;
    }
}
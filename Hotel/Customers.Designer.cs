﻿namespace Hotel
{
    partial class Customers
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
            this.btn_reservations = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_customers = new System.Windows.Forms.Label();
            this.lbl_rooms = new System.Windows.Forms.Label();
            this.lbl_reservations = new System.Windows.Forms.Label();
            this.lbl_home = new System.Windows.Forms.Label();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reservations
            // 
            this.btn_reservations.Location = new System.Drawing.Point(73, 93);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Size = new System.Drawing.Size(150, 33);
            this.btn_reservations.TabIndex = 5;
            this.btn_reservations.Text = "Add Customer";
            this.btn_reservations.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "View Customers";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.SlateGray;
            this.pnl_top.Controls.Add(this.btn_exit);
            this.pnl_top.Controls.Add(this.lbl_customers);
            this.pnl_top.Controls.Add(this.lbl_rooms);
            this.pnl_top.Controls.Add(this.lbl_reservations);
            this.pnl_top.Controls.Add(this.lbl_home);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(886, 55);
            this.pnl_top.TabIndex = 8;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(825, 16);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(33, 22);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_customers
            // 
            this.lbl_customers.AutoSize = true;
            this.lbl_customers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customers.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_customers.Location = new System.Drawing.Point(263, 19);
            this.lbl_customers.Name = "lbl_customers";
            this.lbl_customers.Size = new System.Drawing.Size(113, 19);
            this.lbl_customers.TabIndex = 4;
            this.lbl_customers.Text = "CUSTOMERS";
            // 
            // lbl_rooms
            // 
            this.lbl_rooms.AutoSize = true;
            this.lbl_rooms.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rooms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_rooms.Location = new System.Drawing.Point(406, 19);
            this.lbl_rooms.Name = "lbl_rooms";
            this.lbl_rooms.Size = new System.Drawing.Size(69, 19);
            this.lbl_rooms.TabIndex = 3;
            this.lbl_rooms.Text = "ROOMS";
            this.lbl_rooms.Click += new System.EventHandler(this.lbl_rooms_Click);
            // 
            // lbl_reservations
            // 
            this.lbl_reservations.AutoSize = true;
            this.lbl_reservations.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reservations.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_reservations.Location = new System.Drawing.Point(107, 19);
            this.lbl_reservations.Name = "lbl_reservations";
            this.lbl_reservations.Size = new System.Drawing.Size(135, 19);
            this.lbl_reservations.TabIndex = 1;
            this.lbl_reservations.Text = "RESERVATIONS";
            this.lbl_reservations.Click += new System.EventHandler(this.lbl_reservations_Click);
            // 
            // lbl_home
            // 
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_home.Location = new System.Drawing.Point(28, 19);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(57, 19);
            this.lbl_home.TabIndex = 0;
            this.lbl_home.Text = "HOME";
            this.lbl_home.Click += new System.EventHandler(this.lbl_home_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 518);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_reservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_reservations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_customers;
        private System.Windows.Forms.Label lbl_rooms;
        private System.Windows.Forms.Label lbl_reservations;
        private System.Windows.Forms.Label lbl_home;
    }
}
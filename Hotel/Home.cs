using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbl_reservations_Click(object sender, EventArgs e)
        {
            this.Hide();

            Reservations r = new Reservations();
            r.ShowDialog();
            this.Show();
            this.Close();
        }

        private void lbl_customers_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customers c = new Customers();
            c.ShowDialog();
            this.Show();
            this.Close();
        }

        private void lbl_rooms_Click(object sender, EventArgs e)
        {
            this.Hide();

            Rooms r = new Rooms();
            r.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}

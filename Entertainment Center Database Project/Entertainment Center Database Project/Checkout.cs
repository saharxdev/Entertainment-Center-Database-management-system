using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Entertainment_Center_Database_Project
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myDB"].ToString());
        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Reservation";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dv.DataSource = dt;
            }
            catch (Exception msg)
            {
                MessageBox.Show("An error has occured" + msg,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            string register = "INSERT INTO Reservation (Date, PaymentMethod,TotalAmount) VALUES (@Date, @PaymentMethod,@TotalAmount)";
            SqlCommand cmd = new SqlCommand(register, connect);
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = DateTime.Parse(txt_date.Text.Trim()); // Assuming txt_date contains a valid date string
            cmd.Parameters.AddWithValue("@PaymentMethod", txt_paymnt.Text.Trim());
            cmd.Parameters.AddWithValue("@TotalAmount", txt_ttlamount.Text.Trim());

            
            
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
            }

            cmd.ExecuteNonQuery();

            if (connect.State == ConnectionState.Open)
            {
                connect.Close();
            }
            MessageBox.Show("Your Reservation is successfully complete.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void txt_date_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

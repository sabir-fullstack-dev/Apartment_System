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

namespace Apart
{
    public partial class DeptList : Form
    {
        public DeptList()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"");

        private void showdata()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From User_Info", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["id"].ToString();
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Surname"].ToString());
                item.SubItems.Add(reader["Dept"].ToString());

                listView1.Items.Add(item);

            }
            conn.Close();
        }

            private void DeptList_Load(object sender, EventArgs e)
        {

            showdata();
        }
    }
}

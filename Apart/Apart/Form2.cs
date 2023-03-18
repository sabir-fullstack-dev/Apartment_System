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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"");

        private void showdata()
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From User_Info",conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["id"].ToString();
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Surname"].ToString());
                item.SubItems.Add(reader["Apartments"].ToString());
                item.SubItems.Add(reader["Phone"].ToString());
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add(reader["Dept"].ToString());

                listView1.Items.Add(item);

            }
            conn.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into User_Info(Name,Surname,Apartments,Phone,Email,Dept) values ('"+textEdit1.Text.ToString()+"','"+textEdit2.Text.ToString()+"','"+textEdit3.Text.ToString()+"','"+textEdit4.Text.ToString()+"','"+textEdit5.Text.ToString()+"', '"+textEdit6.Text.ToString()+"')",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            showdata();

        }

        int id = 0;

        private void removeBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("Delete From User_Info where id=(" + id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            showdata() ;

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textEdit1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textEdit2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textEdit3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textEdit4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textEdit5.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textEdit6.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            textEdit1.Text = "";
            textEdit2.Text = "";
            textEdit3.Text = "";
            textEdit4.Text = "";
            textEdit5.Text = "";
            textEdit6.Text = "";

            textEdit1.Focus();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update User_Info set Name='"+textEdit1.Text.ToString()+ "',Surname='"+textEdit2.Text.ToString()+ "',Apartments='"+textEdit3.Text.ToString()+ "',Phone='"+textEdit4.Text.ToString()+"',Email='"+textEdit5.Text.ToString()+ "',Dept='"+textEdit6.Text.ToString()+"'where id="+id+"",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            showdata();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From User_Info where Name like '%"+textEdit7.Text+"%'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = reader["id"].ToString();
                item.SubItems.Add(reader["Name"].ToString());
                item.SubItems.Add(reader["Surname"].ToString());
                item.SubItems.Add(reader["Apartments"].ToString());
                item.SubItems.Add(reader["Phone"].ToString());
                item.SubItems.Add(reader["Email"].ToString());
                item.SubItems.Add(reader["Dept"].ToString());

                listView1.Items.Add(item);

            }
            conn.Close();
        }
    }
}
// Data Source=DESKTOP-CTJE467\MSSQLSERVER2023;Initial Catalog=apartment;Integrated Security=True
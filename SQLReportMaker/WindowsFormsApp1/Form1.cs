using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void connectcsv() {

            bool error = false;

            try
            {

                StreamWriter ir = new StreamWriter("report.csv");


                try
                {

                    error = false;
                    string connetionString = null;
                    SqlConnection connection;
                    SqlCommand command;

                    string sql = null;
                    string database = dbs.Text;
                    string machinename = machine.Text;
                    int MachineLength = machinename.Length;

                    SqlDataReader dataReader;

                    if (MachineLength == 0)
                    {
                        connetionString = "Server= localhost; Database=" + database + ";Integrated Security = SSPI;";
                    }

                    else
                    {
                        connetionString = "Server=" + machinename + "; Database=" + database + ";Integrated Security = SSPI;";
                    }

                    sql = query.Text;
                    connection = new SqlConnection(connetionString);




                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();




					//change the number of the fields what depends on your sql statement

                    while (dataReader.Read())
                    {
                        ir.WriteLine(dataReader.GetValue(0) + ";" + dataReader.GetValue(1) + ";" + dataReader.GetValue(2) + ";" + dataReader.GetValue(3) + ";" + dataReader.GetValue(4) + ";");

                    }


                    ir.Close();
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();




                }

                catch (System.InvalidOperationException)
                {

                    error = true;
                    MessageBox.Show("Empty query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                catch (System.Data.SqlClient.SqlException)
                {
                    error = true;
                    MessageBox.Show("Your query is not correct or authetication error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                ir.Close();


            }

            catch (System.IO.IOException)
            {
                error = true;
                MessageBox.Show("The file has been opened or damaged", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (error == false)
            {

                MessageBox.Show("The result has been exported to report.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                MessageBox.Show("Something bad was happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public void connectxt() {


            bool error = false;

            try
            {

                StreamWriter ir = new StreamWriter("report.csv");


                try
                {

                    error = false;
                    string connetionString = null;
                    SqlConnection connection;
                    SqlCommand command;

                    string sql = null;
                    string database = dbs.Text;
                    string machinename = machine.Text;
                    int MachineLength = machinename.Length;

                    SqlDataReader dataReader;

                    if (MachineLength == 0)
                    {
                        connetionString = "Server= localhost; Database=" + database + ";Integrated Security = SSPI;";
                    }

                    else
                    {
                        connetionString = "Server=" + machinename + "; Database=" + database + ";Integrated Security = SSPI;";
                    }

                    sql = query.Text;
                    connection = new SqlConnection(connetionString);




                    connection.Open();
                    command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();


					
					//change the number of the fields what depends on your sql statement


                    while (dataReader.Read())
                    {
                        ir.WriteLine(dataReader.GetValue(0) + ";" + dataReader.GetValue(1) + ";" + dataReader.GetValue(2) + ";" + dataReader.GetValue(3) + ";" + dataReader.GetValue(4) + ";");

                    }


                    ir.Close();
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();




                }

                catch (System.InvalidOperationException)
                {
                    error = true;
                    MessageBox.Show("Empty query", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (System.Data.SqlClient.SqlException)
                {
                    error = true;
                    MessageBox.Show("Your query is not correct or authetication error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                ir.Close();


            }

            catch (System.IO.IOException)
            {
                error = true;
                MessageBox.Show("The file has been opened or damaged", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (error == false)
            {

                MessageBox.Show("The result has been exported to report.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                MessageBox.Show("Something bad was happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }



        private void button1_Click(object sender, EventArgs e)
        {
            connectcsv();

        }

        private void TXT_Click(object sender, EventArgs e)
        {

            connectxt();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

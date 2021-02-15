using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Desktop_Notifier
{
    public partial class Form1 : Form
    {
        bool dragStrip;
        int moveX, moveY;

            DataTable table = new DataTable();
            DataColumn taskNameColumn;
            DataColumn deadLineDolumn;
            DataColumn creationTimeColumn;
            DataRow row;
            DataView view;
        public Form1()
        {
            InitializeComponent();



            taskNameColumn = new DataColumn();
            taskNameColumn.DataType = System.Type.GetType("System.String");
            taskNameColumn.ColumnName = "Task Name";
            table.Columns.Add(taskNameColumn);

            deadLineDolumn = new DataColumn();
            deadLineDolumn.DataType = Type.GetType("System.String");
            deadLineDolumn.ColumnName = "Dead Line";
            table.Columns.Add(deadLineDolumn);

            creationTimeColumn = new DataColumn();
            creationTimeColumn.DataType = Type.GetType("System.String");
            creationTimeColumn.ColumnName = "Created At";
            table.Columns.Add(creationTimeColumn);

            view = new DataView(table);
            tableTasks.DataSource = view;

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            this.clockLabel.Text = currentTime.ToString("hh:mm:ss");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void topStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragStrip = true;
                moveX = e.X;
                moveY = e.Y;
            }
        }

        private void topStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragStrip)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void topStrip_MouseUp(object sender, MouseEventArgs e)
        {
            dragStrip = false;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (nameInsertBox != null && deadLineInsertBox != null &&
                nameInsertBox.Text != "" && deadLineInsertBox.Text != "")
            {
                string digitsPattern = @"\d{2}:\d{2}";
                Regex digit = new Regex(digitsPattern);
                if (digit.IsMatch(deadLineInsertBox.Text))
                {
                    row = table.NewRow();
                    row["Task Name"] = nameInsertBox.Text;
                    row["Dead Line"] = deadLineInsertBox.Text;
                    row["Created At"] = DateTime.Now.ToString("hh:mm");
                    nameInsertBox.Text = "";
                    deadLineInsertBox.Text = "";
                    table.Rows.Add(row);
                }
                else
                {
                    string message = "Please enter a valid time!";
                    string caption = "Invalid dead line time";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);
                }
            }




            view = new DataView(table);


            tableTasks.DataSource = view;
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
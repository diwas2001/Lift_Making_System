using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System.Data;

namespace Lift_Making_System
{
    public partial class Form1 : Form
    {

        private string connstring = String.Format("Server ={0}; Port = {1};" +
            "User Id ={2}; Password={3}; Database={4};",
            "localhost",5433,"postgres","123456","lift");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;        


public Form1()
        {
            InitializeComponent();
        }

        private void timerUp_Tick(object sender, EventArgs e)
        {

            Lift.Location = new Point(Lift.Location.X, Lift.Location.Y - 10);
            timerUp.Enabled = true;
            if (Lift.Location.Y == 40)
            {
                timerUp.Enabled = false;
            }


        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            timerUp.Enabled = true;
        }

        private void timerDown_Tick(object sender, EventArgs e)
        {
            Lift.Location = new Point(Lift.Location.X, Lift.Location.Y + 10);
            timerDown.Enabled = true;
            if (Lift.Location.Y == 460)
            {
                timerDown.Enabled = false;
            }

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            timerDown.Enabled = true;
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            timerOpen.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
        }

        private void timerOpen_Tick(object sender, EventArgs e)
        {
            if(Lift.Location.Y == 460)
            {
                Left_Door.Location = new Point(Left_Door.Location.X - 10, Left_Door.Location.Y);
                Right_Door.Location = new Point(Right_Door.Location.X + 10, Right_Door.Location.Y);
                timerOpen.Enabled = true;
                if (Left_Door.Location.X == 114)
                {
                    timerOpen.Enabled = false;


                }
            }
            if(Lift.Location.Y == 40)
            {
               First_Floor_Left.Location = new Point(First_Floor_Left.Location.X - 10, First_Floor_Left.Location.Y);
                First_Floor_Right.Location = new Point(First_Floor_Right.Location.X + 10, First_Floor_Right.Location.Y);
                timerOpen.Enabled = true;
                if (First_Floor_Left.Location.X == 114)
                {
                    timerOpen.Enabled = false;


                }
            }
           
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            if(Lift.Location.Y == 460)
            {
                Left_Door.Location = new Point(Left_Door.Location.X + 10, Left_Door.Location.Y);
                Right_Door.Location = new Point(Right_Door.Location.X - 10, Right_Door.Location.Y);
                timerClose.Enabled = true;
                if (Left_Door.Location.X == 184)
                {
                    timerClose.Enabled = false;


                }
            }
            if (Lift.Location.Y == 40)
            {

                First_Floor_Left.Location = new Point(First_Floor_Left.Location.X + 10, First_Floor_Left.Location.Y);
                First_Floor_Right.Location = new Point(First_Floor_Right.Location.X - 10, First_Floor_Right.Location.Y);
                timerClose.Enabled = true;
                if (First_Floor_Left.Location.X == 184)
                {
                    timerClose.Enabled = false;


                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           conn = new NpgsqlConnection(connstring);
           Select(); 
        }
        private void Select()
        {
           try
            {

                conn.Open();
                sql = @"select * from elevator_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                dgvData.DataSource = null;
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("error: " +ex.Message);
            }
        
        }
        private void Insert()
        {

        }


      
    }
}
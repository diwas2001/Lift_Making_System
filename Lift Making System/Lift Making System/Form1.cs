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
            Insert(sender,e);
            Select();
            // {


            // MessageBox.Show(getValue);


            /*  if (getValue == "Up")
              {
                  string details = "Going up from Ground Floor to First Floor.";

              }
              else
              {
                  return "Invalid";
              }*/
        }
        public static string Button(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            // MessageBox.Show(clicked.Text);
            if (button.Text == "Up")
            {
                return button.Text;
            }
            else if (button.Name == "Down")
            {
                return button.Text;
            }
            else if (button.Name == "Open")
            {
                return button.Text;
            }
            else
            {
                return button.Text;
            }

        }

        public string Details(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            switch (clicked.Text)
            {
                case "Up":
                    if (timerUp.Enabled)
                    {
                        return "Went Up from Ground Floor to First Floor";

                    }
                    else
                    {
                        return "";
                    }

                case "Down":
                    if (timerDown.Enabled)
                    {
                        return "Went Down from First Floor to Ground Floor";
                    }
                    else
                    {
                        return "";
                    }

                case "buttonOpen":
                    if (timerOpen.Enabled && Lift.Location.Y == 460)
                    {
                        return "Door opened at Ground Floor";
                    }

                    else if (timerOpen.Enabled && Lift.Location.Y == 40)
                    {
                        return "Door opened at First Floor";
                    }
                    else
                    {
                        return "";
                    }
                case "buttonClose":
                    if (timerClose.Enabled && Lift.Location.Y == 460)
                    {
                        return "Door closed at Ground Floor";
                    }
                    else if (timerClose.Enabled && Lift.Location.Y == 40)
                    {
                        return "Door closed at First Floor";
                    }
                    else
                    {
                        return "";
                    }
                default: return "";
            }
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
        private void buttonDown_Click_1(object sender, EventArgs e)
        {
            timerDown.Enabled = true;
            Insert(sender, e);
            Select();
            /* String getValue = ((Button)sender).Text; //this will get the value of the text using sender
                                                      //}

             // MessageBox.Show(getValue);
             if (getValue == "Down")
             {
                 string details = "Going down from FIrst Floor to Ground Floor.";
                 return getValue + details;
             }
             else
             {
                 return "Invalid Error";
             }*/
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timerOpen.Enabled = true;
            String getValue = ((Button)sender).Text;
            Insert(sender, e);
            Select();//this will get the value of the text using sender
                     //}

            //MessageBox.Show(getValue);
            if (getValue ==  "Open" && Lift.Location.Y == 40)
            {
                string details = "Opened door at First Floor";
                MessageBox.Show(details);

            }
            else
            {
                string details = "Opened door at Ground Floor";
                MessageBox.Show(details);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
            String getValue = ((Button)sender).Text;
            Insert(sender, e);
            Select();//this will get the value of the text using sender
                     //}

            // MessageBox.Show(getValue);
            if (getValue == "close" && Lift.Location.Y == 40)
            {
                string details = "close door at First Floor";
                MessageBox.Show(details);

            }
            else
            {
                string details = "close door at Ground Floor";
                MessageBox.Show(details);
            }

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


        private void Insert(Object sender, EventArgs e)
        {
            string btn = Button((Button)sender, e);
            string details = Details((Button)sender, e);


            try
            {
                conn.Open();
                sql = String.Format("insert into elevator(button_clicked,button_date,button_time,button_deatils) values('{0}','{1}', '{2}', '{3}')", btn, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"),details);
                cmd = new NpgsqlCommand(sql, conn);
                /*cmd.Parameters.AddWithValue("Button_Clicked", btn);
                cmd.Parameters.AddWithValue("Button_Date", DateTime.Now.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("Button_time", DateTime.Now.ToString("hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("Button_deatils", details);*/
                cmd.ExecuteScalar();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                conn.Close();
            }


        }

       
    }
}
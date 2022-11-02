namespace Lift_Making_System
{
    public partial class Form1 : Form
    {
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

        private void Lift_Click(object sender, EventArgs e)
        {

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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Left_Door_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
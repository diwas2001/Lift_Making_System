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
                if (Lift.Location.Y == 85)
                {
                    timerUp.Enabled = false;
                }
            
           
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            timerUp.Enabled = true;
        }
    }
}
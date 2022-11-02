namespace Lift_Making_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lift = new System.Windows.Forms.PictureBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.timerUp = new System.Windows.Forms.Timer(this.components);
            this.timerDown = new System.Windows.Forms.Timer(this.components);
            this.Left_Door = new System.Windows.Forms.PictureBox();
            this.Right_Door = new System.Windows.Forms.PictureBox();
            this.timerOpen = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.First_Floor_Left = new System.Windows.Forms.PictureBox();
            this.First_Floor_Right = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Floor_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Floor_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Lift
            // 
            this.Lift.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lift.Image = ((System.Drawing.Image)(resources.GetObject("Lift.Image")));
            this.Lift.Location = new System.Drawing.Point(184, 460);
            this.Lift.Name = "Lift";
            this.Lift.Size = new System.Drawing.Size(163, 285);
            this.Lift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Lift.TabIndex = 0;
            this.Lift.TabStop = false;
            this.Lift.Click += new System.EventHandler(this.Lift_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(690, 144);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(160, 160);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(673, 392);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(159, 159);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // timerUp
            // 
            this.timerUp.Tick += new System.EventHandler(this.timerUp_Tick);
            // 
            // timerDown
            // 
            this.timerDown.Tick += new System.EventHandler(this.timerDown_Tick);
            // 
            // Left_Door
            // 
            this.Left_Door.BackColor = System.Drawing.Color.Silver;
            this.Left_Door.Image = ((System.Drawing.Image)(resources.GetObject("Left_Door.Image")));
            this.Left_Door.Location = new System.Drawing.Point(184, 460);
            this.Left_Door.Name = "Left_Door";
            this.Left_Door.Size = new System.Drawing.Size(82, 285);
            this.Left_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Left_Door.TabIndex = 3;
            this.Left_Door.TabStop = false;
            this.Left_Door.Click += new System.EventHandler(this.Left_Door_Click);
            // 
            // Right_Door
            // 
            this.Right_Door.BackColor = System.Drawing.Color.Silver;
            this.Right_Door.Image = ((System.Drawing.Image)(resources.GetObject("Right_Door.Image")));
            this.Right_Door.Location = new System.Drawing.Point(266, 460);
            this.Right_Door.Name = "Right_Door";
            this.Right_Door.Size = new System.Drawing.Size(81, 285);
            this.Right_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Right_Door.TabIndex = 4;
            this.Right_Door.TabStop = false;
            // 
            // timerOpen
            // 
            this.timerOpen.Tick += new System.EventHandler(this.timerOpen_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.Location = new System.Drawing.Point(521, 277);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(164, 150);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(838, 264);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(174, 150);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // First_Floor_Left
            // 
            this.First_Floor_Left.BackColor = System.Drawing.Color.Silver;
            this.First_Floor_Left.Image = ((System.Drawing.Image)(resources.GetObject("First_Floor_Left.Image")));
            this.First_Floor_Left.Location = new System.Drawing.Point(184, 40);
            this.First_Floor_Left.Name = "First_Floor_Left";
            this.First_Floor_Left.Size = new System.Drawing.Size(82, 285);
            this.First_Floor_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.First_Floor_Left.TabIndex = 7;
            this.First_Floor_Left.TabStop = false;
            // 
            // First_Floor_Right
            // 
            this.First_Floor_Right.BackColor = System.Drawing.Color.Silver;
            this.First_Floor_Right.Image = ((System.Drawing.Image)(resources.GetObject("First_Floor_Right.Image")));
            this.First_Floor_Right.Location = new System.Drawing.Point(266, 40);
            this.First_Floor_Right.Name = "First_Floor_Right";
            this.First_Floor_Right.Size = new System.Drawing.Size(82, 285);
            this.First_Floor_Right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.First_Floor_Right.TabIndex = 8;
            this.First_Floor_Right.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 429);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 316);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(170, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 320);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 762);
            this.Controls.Add(this.First_Floor_Right);
            this.Controls.Add(this.First_Floor_Left);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.Right_Door);
            this.Controls.Add(this.Left_Door);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.Lift);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Floor_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Floor_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Lift;
        private Button buttonUp;
        private Button buttonDown;
        private System.Windows.Forms.Timer timerUp;
        private System.Windows.Forms.Timer timerDown;
        private PictureBox Left_Door;
        private PictureBox Right_Door;
        private System.Windows.Forms.Timer timerOpen;
        private System.Windows.Forms.Timer timerClose;
        private Button buttonOpen;
        private Button buttonClose;
        private PictureBox First_Floor_Left;
        private PictureBox First_Floor_Right;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
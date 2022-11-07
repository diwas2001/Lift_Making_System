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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.log = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Left_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Right_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Floor_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.First_Floor_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // 
            // buttonUp
            // 
            this.buttonUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(507, 118);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(118, 96);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(507, 329);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(118, 104);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click_1);
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
            this.buttonOpen.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen.Image")));
            this.buttonOpen.Location = new System.Drawing.Point(430, 220);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(119, 90);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = " Open";
            this.buttonOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(585, 220);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 90);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(170, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvData.Location = new System.Drawing.Point(780, 83);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 29;
            this.dgvData.Size = new System.Drawing.Size(708, 442);
            this.dgvData.TabIndex = 11;
            this.dgvData.VirtualMode = true;
            this.dgvData.Visible = false;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.log.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.SystemColors.Highlight;
            this.log.Location = new System.Drawing.Point(966, 555);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(153, 51);
            this.log.TabIndex = 12;
            this.log.Text = "Log Show";
            this.log.UseVisualStyleBackColor = false;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Hide.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Hide.Location = new System.Drawing.Point(1185, 555);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(127, 53);
            this.Hide.TabIndex = 13;
            this.Hide.Text = "Hide";
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(395, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(353, 591);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1049, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Log Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1739, 881);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.log);
            this.Controls.Add(this.dgvData);
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
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridView dgvData;
        private Button log;
        private Button Hide;
        private PictureBox pictureBox3;
        private Label label1;
    }
}
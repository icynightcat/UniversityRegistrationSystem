﻿using CollegeRegistrationApp.SQL;
using CollegeRegistrationApp.StudentControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeRegistrationApp.SQL;

namespace CollegeRegistrationApp
{
    public partial class StudentMainForm : Form
    {
        StudentNaviControl studentNaviControl;
        NaviButtons naviButtons;

        Color buttonDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color buttonSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);

        private string student_id = "";
        private DBConnection connection;

        public StudentMainForm(string input, DBConnection input_connection)
        {
            connection= input_connection;
            student_id = input;
            InitializeComponent();
            InitializeNavigationControl(student_id,connection);
            InitializeNaviButton();
            
        }

        private void InitializeNavigationControl(string input, DBConnection input_connection)
        {
            List<string> cart = new List<string>();
            List<UserControl> userControls = new List<UserControl>()
            { new UserControl1(input,input_connection,cart), new UserControl2(input,input_connection,cart), new UserControl3(input,input_connection,cart)};

            studentNaviControl = new StudentNaviControl(userControls,panel2);
            studentNaviControl.Display(0);
        }

        private void InitializeNaviButton()
        {
            List<Button> buttons = new List<Button>()
            { button1,button2, button3 };
            naviButtons = new NaviButtons(buttons, buttonDefaultColor, buttonSelectedColor);
            naviButtons.Highlight(button1);
        }
        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentNaviControl.Display(0);
            naviButtons.Highlight(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentNaviControl.Display(1);
            naviButtons.Highlight(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentNaviControl.Display(2);
            naviButtons.Highlight(button3);
        }

       
    }
}

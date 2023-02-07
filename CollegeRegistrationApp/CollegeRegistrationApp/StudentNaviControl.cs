﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistrationApp
{
    public class StudentNaviControl
    {
        List<UserControl> userControlList= new List<UserControl>();
        Panel panel;

        public StudentNaviControl(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for(int i=0;i <userControlList.Count;i++)
            {
                userControlList[i].Dock= DockStyle.Fill;
                panel.Controls.Add(userControlList[i]);
            }
        }
        public void Display(int index)
        {
            userControlList[index].BringToFront();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeRegistrationApp
{
    public class NaviButtons
    {
        List<Button> buttons;
        Color defaultColor;
        Color selectedColor;

        public NaviButtons(List<Button> buttons, Color defaultColor, Color selectedColor)
        {
            this.buttons = buttons;
            this.defaultColor = defaultColor;
            this.selectedColor = selectedColor;
            SetButtonColor();
        }   
        private void SetButtonColor()
        {
            foreach(Button button in buttons)
            {
                button.BackColor= defaultColor;
            }
        }
        public void Highlight(Button selectedButton)
        {
            foreach(Button button in buttons)
            {
                if(button == selectedButton)
                {
                    selectedButton.BackColor= selectedColor;
                }
                else
                {
                    button.BackColor= defaultColor;
                }
            }
        }
    }
}

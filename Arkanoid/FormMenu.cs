﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
  public partial class FormMenu : Form
  {

    FormGame game = new FormGame();
    public FormMenu()
    {
      InitializeComponent();
    }

    private void ButtonStart_Click(object sender, EventArgs e)
    {
      
      game.ShowDialog();
      //if (levels.SelectedItem() == 's')
    }

    private void levels_SelectedIndexChanged(object sender, EventArgs e)
    {
      string level = levels.SelectedItem.ToString();
      switch (level)
      {
        case "Level 1": game.next_level = 1; break;
        case "Level 2": game.next_level = 2; break;
        case "Level 3": game.next_level = 3; break;
        case "Level 4": game.next_level = 4; break;
        case "Level 5": game.next_level = 5; break;
      }



    }
  }
}

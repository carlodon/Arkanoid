using System;
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
 
  public partial class FormGame : Form
  {
    bool launch_mouse_game = false;
    bool launch_keyboard_game = false;

    static Random rand = new Random();
    int racket_x, racket_y;
    int racket_shift_x = 2;

    int ball_x, ball_y;
    int ball_shift_x = 4; //max ball shift
    int ball_shift_y = 3;
    int ball_sx, //current ball shift
        ball_sy;

 
    int side_lx, //left x
        side_rx, //right x
        side_uy; //up y

    int total_bricks;
    Label[] array;
    int score_count = 0;

    int pX = 0, pY = 0;
    
    private void init_game()
    {
      racket_x = racket.Location.X;
      racket_y = racket.Location.Y;
      side_lx = label_left.Location.X + label_left.Width;
      side_rx = label_right.Location.X;
      side_uy = label_top.Location.X + label_top.Height;
      ball_x = ball.Location.X;
      ball_y = ball.Location.Y;
      ball_sx = ball_shift_x;
      ball_sy = -ball_shift_y;
      total_bricks = 21;

    }

    public FormGame()
    {
      InitializeComponent();
      array = new Label[] {brick1, brick2, brick3, brick4, brick5, brick6, brick7, brick8, brick9, brick10,
                           brick11, brick12, brick13, brick14, brick15, brick16, brick17, brick18, brick19, brick20, brick21
                          };
    }

    private void FormGame_Shown(object sender, EventArgs e)
    {
      init_game();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      move_ball();
     
    }

    private void move_ball()
    {
      int bx1, by1,
          bx2, by2;
      bx1 = ball_x;
      bx2 = ball_x + ball.Width;
      by1 = ball_y;
      by2 = ball_y + ball.Height;


      if (bx1 + ball_sx < side_lx)
        ball_sx = ball_shift_x;
      if (bx2 + ball_sx > side_rx)
        ball_sx = -ball_shift_x;
      if (by1 + ball_sy < side_uy)
        ball_sy = ball_shift_y;
      if (by2 + ball_sy > racket_y)
      {
        int bx0, by0;
        bx0 = (bx1 + bx2) / 2;
        by0 = (by1 + by2) / 2;
        int rx1, rx2;
        rx1 = racket_x;
        rx2 = racket_x + racket.Width;
        if (rx1 <= bx0 && bx0 <= rx2)
        {
          ball_sy = -ball_shift_y + rand.Next(-1, 2);
        }
        else
          if (rx1 <= bx2 + ball.Width && bx2 + ball.Width <= rx2)
        {
          ball_sy = -ball_shift_y + rand.Next(-1, 2);
          ball_sx = -ball_shift_x + rand.Next(-1, 2);
        }
        else
          if (rx1 <= bx1 - ball.Width && bx1 - ball.Width <= rx2)
        {
          ball_sy = -ball_shift_y + rand.Next(-1, 2);
          ball_sx = ball_shift_x + rand.Next(-1, 2);
        }
        else
          loss_ball();
      }
      
 
     ball_x += ball_sx;
     ball_y += ball_sy;
     ball.Location = new Point(ball_x, ball_y);
     
      for (int i = 0; i < array.Length; i++)
      {
        if (cross_brick(array[i]))
        {
          array[i].Visible = false;
          score_count++;
          score.Text = String.Format("SCORE: {0}", score_count);
        }
        
      }

    }

    private void FormGame_MouseMove(object sender, MouseEventArgs e)
    {
      if (launch_mouse_game)
      {
        int x = e.X;
        int y = e.Y;
        int deltaX = pX - x;
        int deltaY = pY - y;
        if (deltaX > 0)
        {
          //значит по X идет движение влево 
          shift_racket(-racket_shift_x);
        }
        else if (deltaX < 0)
        {
          //значит по X идет движение вправо 
          shift_racket(+racket_shift_x);
        }
        pX = x;
        pY = y;
      }
      
    }

    private bool cross_brick(Label brick)
    {
      if (!brick.Visible) return false;
      int bx1, bx2, bx0,
          by1, by2, by0;
      int rx1, rx2,
          ry1, ry2;

      bx1 = ball_x;
      bx2 = ball_x + ball.Width;
      bx0 = (bx1 + bx2) / 2;
      by1 = ball_y;
      by2 = ball_y + ball.Height;
      by0 = (by1 + by2) / 2;
      rx1 = brick.Location.X;
      rx2 = rx1 + brick.Width;
      ry1 = brick.Location.Y;
      ry2 = ry1 + brick.Height;

      if (rx1 <= bx0 && bx0 <= rx2 && 
        ry1 <= by2 && by2 <= ry2)
      {
        drop_brick(brick);
        ball_sy = -ball_sy;
        return true;
      }

      if (rx1 <= bx0 && bx0 <= rx2 &&
        ry1 <= by1 && by1 <= ry2)
      {
        drop_brick(brick);
        ball_sy = -ball_sy;
        return true;
      }

      if (rx1 <= bx2 && bx2 <= rx2 &&
        ry1 <= by0 && by0 <= ry2)
      {
        drop_brick(brick);
        ball_sx = -ball_sx;
        return true;
      }

      if (rx1 <= bx1 && bx1 <= rx2 &&
        ry1 <= by0 && by0 <= ry2)
      {
        drop_brick(brick);
        ball_sx = -ball_sx;
        return true;
      }
      else return false;
    }

    private void drop_brick(Label brick)
    {
      brick.Visible = false;
      total_bricks--;
      if (total_bricks == 0)
      {
        timer.Enabled = false;
        MessageBox.Show("Вы победили!", "Игра окончена!");
        DialogResult = System.Windows.Forms.DialogResult.OK;
      }
    }
    private void loss_ball()
    {
      timer.Enabled = false;
      MessageBox.Show("Шарик потерян!", "Проигрыш!");
      DialogResult = System.Windows.Forms.DialogResult.Abort;
    }

 


    private void FormGame_KeyDown(object sender, KeyEventArgs e)
    {
      Keys key = e.KeyCode;
      switch (key)
      {
        //case Keys.Left: shift_racket(-racket_shift_x); break;
        //case Keys.Right: shift_racket(+racket_shift_x); break;
        //case Keys.A: shift_racket(-racket_shift_x); break;
        //case Keys.D: shift_racket(+racket_shift_x); break;
        case Keys.Space: timer.Enabled = true; launch_mouse_game = true; label_pause.Visible = false; break;
        case Keys.Escape: timer.Enabled = false; label_pause.Visible = true; launch_mouse_game = false; break;
      }
    }

    

    private void shift_racket (int sx)
    {
      int ax1 = racket_x += sx;
      int ax2 = ax1 + racket.Width;
      if (side_lx > ax1) ax1 = side_lx;
      if (side_rx < ax2) ax1 = side_rx - racket.Width;
      racket_x = ax1;
      racket.Location = new Point(racket_x, racket_y);
    }
 
  }
}

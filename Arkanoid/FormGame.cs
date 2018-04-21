using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Arkanoid
{

  public partial class FormGame : Form
  {
    bool launch_mouse_game = true;
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
    int score_count = 0;

    int pX = 0, pY = 0;

    int N, M;
    int[,] Level;
    int next_level = 1;
    int count_lifes = 0;
    bool loss = false;
    bool pause = false;
    bool moveL, moveR;
    List<Label> array2 = new List<Label>();
   
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
      load_level(next_level);

     
    }



    private void load_level(int number)
    {
      array2.Clear();
      StreamReader sr = new StreamReader(Convert.ToString(number) + ".txt");
      string Str;
      Str = sr.ReadLine();
      N = Convert.ToInt32(Str);
      M = Convert.ToInt32(sr.ReadLine());
      Level = new int[N, M];
      for (int j = 0; j < M; j++)
      {
        Str = sr.ReadLine();
        for (int i = 0; i < N; i++)
          Level[i, j] = Convert.ToInt32("0" + Str[i]);
      }
      int Dx = 720 / N;
      int Dy = 360 / M;
      for (int i = 1; i < N; i++)
      {
        for (int j = 1; j < M; j++)
        {
          int rand_color = rand.Next(0, 2);
          if (Level[i, j] == 1)
          {
            Label brick = new Label();
            brick.Name = "brick" + i;
            brick.Location = new Point(i * Dx, j * Dy);
           
            if (rand_color == 1)
              brick.BackColor = Color.Green;
            else
              brick.BackColor = Color.Blue;
           
            if (next_level == 3)
            {
              ball_shift_x = 6;
              ball_shift_y = 4;
              brick.Height = 22;
              brick.Width = 35;
            }
            else
            {
              brick.Height = 22;
              brick.Width = 72;
            }
            
            this.Controls.Add(brick);
            array2.Add(brick);
          }
        }

      }
      sr.Close();
      if (next_level == 3)
      {
        array2[22].Enabled = false;
        array2[22].BackColor = Color.Red;
        array2[29].Enabled = false;
        array2[29].BackColor = Color.Red;
      }
      else
      {
        int rand_life = rand.Next(1, N);
        array2[rand_life].Enabled = false;
        array2[rand_life].BackColor = Color.Red;
      }
      
      total_bricks = array2.Count;
    }

    public FormGame()
    {
      InitializeComponent();

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
      loss = false;
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
        {
          loss_ball();
        }
        loss_lifes_count();
      }
      
 
     ball_x += ball_sx;
     ball_y += ball_sy;
     ball.Location = new Point(ball_x, ball_y);
     
      for (int i = 0; i < array2.Count; i++)
      {
        if (cross_brick(array2[i]))
        {
          array2[i].BackColor = Color.Green;
          if (array2[i].Visible == false)
            score_count++;
          score.Text = String.Format("SCORE: {0}", score_count);
        }
        
      }

    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (control_mouse.Checked == false && control_keyboard.Checked == false)  //по умолчанию
      {
        switch (keyData)
        {
          case Keys.Space:
            timer_racket.Enabled = true;
            timer.Enabled = true;
            label_pause.Visible = false;
            launch_keyboard_game = true;
            control_keyboard.Checked = true;
            control_keyboard.Enabled = true;
            ball.Visible = true;
            pause = false;
            break;
        }
      }
      switch (keyData)
      {
        case Keys.Space:
          timer_racket.Enabled = true;
          timer.Enabled = true;
          label_pause.Visible = false;
          control_mouse.Enabled = false;
          control_keyboard.Enabled = false;
          ball.Visible = true;
          pause = false;
          if (control_mouse.Checked)
            launch_mouse_game = true;
          return true;
        case Keys.Escape:
          timer.Enabled = false;
          label_pause.Visible = true;
          control_mouse.Enabled = true;
          control_keyboard.Enabled = true;
          pause = true;
          launch_mouse_game = false;
          return true;
        default:
          //для всех остальных клавиш оставляем базовую обработку
          return base.ProcessCmdKey(ref msg, keyData);
      }
    }

    private void control_mouse_CheckedChanged(object sender, EventArgs e)
    {
      if (pause)
        launch_mouse_game = false;
      launch_keyboard_game = false;
    }

 
    private void control_keyboard_CheckedChanged(object sender, EventArgs e)
    {
      launch_mouse_game = false;
      launch_keyboard_game = true;
    }

    private void FormGame_KeyUp(object sender, KeyEventArgs e)
    {
      Keys key = e.KeyCode;
      if (launch_keyboard_game)
      {
        switch (key)
        {
          case Keys.Left: moveL = false; break;
          case Keys.Right: moveR = false; break;
          case Keys.A: moveL = false; break;
          case Keys.D: moveR = false; break;
        }
      }
    }

    private void timer_racket_Tick(object sender, EventArgs e)
    {
      racket_shift_x = 15;
      if (moveL)
      {
        shift_racket(-racket_shift_x);
       
      }
       
      if (moveR)
      {
        shift_racket(+racket_shift_x);
      }
       

    }
  

    private void FormGame_MouseMove(object sender, MouseEventArgs e)
    {
     

      if (launch_mouse_game)
      {
        racket_shift_x = 2;
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
        if (brick.BackColor == Color.Green)
          drop_brick(brick);
        ball_sy = -ball_sy;
        return true;
      }

      if (rx1 <= bx0 && bx0 <= rx2 &&
        ry1 <= by1 && by1 <= ry2)
      {
        if (brick.BackColor == Color.Green)
          drop_brick(brick);
        ball_sy = -ball_sy;
        return true;
      }

      if (rx1 <= bx2 && bx2 <= rx2 &&
        ry1 <= by0 && by0 <= ry2)
      {
        if (brick.BackColor == Color.Green)
          drop_brick(brick);
        ball_sx = -ball_sx;
        return true;
      }

      if (rx1 <= bx1 && bx1 <= rx2 &&
        ry1 <= by0 && by0 <= ry2)
      {
        if (brick.BackColor == Color.Green)
          drop_brick(brick);
        ball_sx = -ball_sx;
        return true;
      }
      else return false;
    }

    private void drop_brick(Label brick)
    {
      brick.Visible = false;
      if (brick.Enabled == false)
      {
        extra_life.Visible = true;
        if (life4.Visible == true)
          {
            if (life5.Visible == true)
            {
              if (life6.Visible == true)
                count_lifes -= 1;
              else
              {
                life6.Visible = true;
                count_lifes -= 1;
              }
            }
            else
            {
              life5.Visible = true;
              count_lifes -= 1;
            }
        
          }
        else
        {
          life4.Visible = true;
          count_lifes -= 1;
        }
      }
      total_bricks--;
      if (total_bricks == 0)
      {
        timer.Enabled = false;
        ball_x = 372;
        ball_y = 427;
        racket_x = 320;
        racket_y = 453;
        label_win_loss.Text = "You win!";
        label_win_loss.ForeColor = Color.Green;
        label_win_loss.Visible = true;
        if (next_level == 3)
        { 
          MessageBox.Show("You win!", String.Format("YOU SCORE: {0}", next_level));
          DialogResult = System.Windows.Forms.DialogResult.OK;
          this.Close();
        }
        else 
        {
          extra_life.Visible = false;
          next_level += 1;
          ball.Location = new System.Drawing.Point(372, 427);
          MessageBox.Show("Сongratulation! Next level", "Next level");
          label_win_loss.Visible = false;
          load_level(next_level);
          level.Text = String.Format("Level: {0}", next_level);
          this.Refresh();
          this.Show();
        }
      }
    }
    private void loss_ball()
    {
      loss = true;
      
      if (count_lifes == 2)
      {
        life1.Visible = false;
        timer.Enabled = false;
        label_win_loss.Text = "You loss!";
        label_win_loss.ForeColor = Color.Red;
        label_win_loss.Visible = true;
        MessageBox.Show("You loss!", "Game over!");
        DialogResult = System.Windows.Forms.DialogResult.Abort;
      }
      
    
     // ball.Location = new System.Drawing.Point(372, 427);
     // label4.Text = Convert.ToString(lives);


    }

 


    private void FormGame_KeyDown(object sender, KeyEventArgs e)
    {
      /* 
       Keys key = e.KeyCode;

       if (launch_keyboard_game)
       {
         racket_shift_x = 20;
         switch (key)
         {
           case Keys.Left: shift_racket(-racket_shift_x); break;
           case Keys.Right: shift_racket(+racket_shift_x); break;
           case Keys.A: shift_racket(-racket_shift_x); break;
           case Keys.D: shift_racket(+racket_shift_x); break;
         }
       }
       */
      Keys key = e.KeyCode;
      if (launch_keyboard_game)
      {
        switch (key)
        {
          case Keys.Left: moveL = true; break;
          case Keys.Right: moveR = true; break;
          case Keys.A: moveL = true; break;
          case Keys.D: moveR = true; break;
        }
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
      if (timer.Enabled == false)
      {
        ball_x = racket_x + racket.Width / 2;
        ball.Location = new System.Drawing.Point(ball_x, ball_y);
      }
    

      /*
        if (timer.Enabled == false && ball_x == 377)
      {
        ball_x = racket_x + racket.Width / 2;
        ball.Location = new Point(ball_x, ball_y);
      }
       */

    }

    public void loss_lifes()
    {
      count_lifes += 1;
      loss = false;
      ball.Location = new System.Drawing.Point(372, 427);
      timer.Enabled = false;
      ball_x = 372;
      ball_y = 427;
    }

    public void loss_lifes_count()
    {
      if (loss)
      {
        if (life6.Visible == false)
        {
          if (life5.Visible == false)
          {
            if (life4.Visible == false)
            {
              if (life3.Visible == false)
              {
                life2.Visible = false;
                loss_lifes();
              }
              else
              {
                life3.Visible = false;
                loss_lifes();
              }
            }
            else
            {
              life4.Visible = false;
              loss_lifes();
            }

          }
          else
          {
            life5.Visible = false;
            loss_lifes();
          }
        }
        else
        {
          life6.Visible = false;
          loss_lifes();
        }


      }
    }
  }
}

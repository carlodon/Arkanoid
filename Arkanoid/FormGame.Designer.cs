namespace Arkanoid
{
  partial class FormGame
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
      this.label_top = new System.Windows.Forms.Label();
      this.label_left = new System.Windows.Forms.Label();
      this.label_right = new System.Windows.Forms.Label();
      this.racket = new System.Windows.Forms.Button();
      this.ball = new System.Windows.Forms.RadioButton();
      this.brick1 = new System.Windows.Forms.Label();
      this.brick2 = new System.Windows.Forms.Label();
      this.brick3 = new System.Windows.Forms.Label();
      this.brick4 = new System.Windows.Forms.Label();
      this.brick5 = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.score = new System.Windows.Forms.Label();
      this.brick6 = new System.Windows.Forms.Label();
      this.brick8 = new System.Windows.Forms.Label();
      this.brick9 = new System.Windows.Forms.Label();
      this.brick7 = new System.Windows.Forms.Label();
      this.brick10 = new System.Windows.Forms.Label();
      this.brick12 = new System.Windows.Forms.Label();
      this.brick13 = new System.Windows.Forms.Label();
      this.brick14 = new System.Windows.Forms.Label();
      this.brick11 = new System.Windows.Forms.Label();
      this.brick15 = new System.Windows.Forms.Label();
      this.brick17 = new System.Windows.Forms.Label();
      this.brick18 = new System.Windows.Forms.Label();
      this.brick19 = new System.Windows.Forms.Label();
      this.brick20 = new System.Windows.Forms.Label();
      this.brick16 = new System.Windows.Forms.Label();
      this.brick21 = new System.Windows.Forms.Label();
      this.control_mouse = new System.Windows.Forms.RadioButton();
      this.control_keyboard = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label_pause = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label_top
      // 
      this.label_top.BackColor = System.Drawing.Color.Navy;
      this.label_top.Location = new System.Drawing.Point(-1, 0);
      this.label_top.Name = "label_top";
      this.label_top.Size = new System.Drawing.Size(723, 15);
      this.label_top.TabIndex = 0;
      // 
      // label_left
      // 
      this.label_left.BackColor = System.Drawing.Color.Navy;
      this.label_left.Location = new System.Drawing.Point(-1, 0);
      this.label_left.Name = "label_left";
      this.label_left.Size = new System.Drawing.Size(15, 473);
      this.label_left.TabIndex = 1;
      // 
      // label_right
      // 
      this.label_right.BackColor = System.Drawing.Color.Navy;
      this.label_right.Location = new System.Drawing.Point(707, 0);
      this.label_right.Name = "label_right";
      this.label_right.Size = new System.Drawing.Size(15, 473);
      this.label_right.TabIndex = 2;
      // 
      // racket
      // 
      this.racket.BackColor = System.Drawing.Color.Black;
      this.racket.Enabled = false;
      this.racket.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.racket.Location = new System.Drawing.Point(301, 453);
      this.racket.Name = "racket";
      this.racket.Size = new System.Drawing.Size(117, 20);
      this.racket.TabIndex = 3;
      this.racket.Text = "--------------";
      this.racket.UseVisualStyleBackColor = false;
      // 
      // ball
      // 
      this.ball.AutoSize = true;
      this.ball.Checked = true;
      this.ball.Cursor = System.Windows.Forms.Cursors.Default;
      this.ball.Enabled = false;
      this.ball.Location = new System.Drawing.Point(353, 435);
      this.ball.Name = "ball";
      this.ball.Size = new System.Drawing.Size(14, 13);
      this.ball.TabIndex = 4;
      this.ball.TabStop = true;
      this.ball.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.ball.UseVisualStyleBackColor = true;
      // 
      // brick1
      // 
      this.brick1.BackColor = System.Drawing.Color.Red;
      this.brick1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick1.Location = new System.Drawing.Point(316, 241);
      this.brick1.Name = "brick1";
      this.brick1.Size = new System.Drawing.Size(82, 22);
      this.brick1.TabIndex = 5;
      // 
      // brick2
      // 
      this.brick2.BackColor = System.Drawing.Color.Red;
      this.brick2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick2.Location = new System.Drawing.Point(254, 199);
      this.brick2.Name = "brick2";
      this.brick2.Size = new System.Drawing.Size(82, 22);
      this.brick2.TabIndex = 6;
      // 
      // brick3
      // 
      this.brick3.BackColor = System.Drawing.Color.Red;
      this.brick3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick3.Location = new System.Drawing.Point(379, 199);
      this.brick3.Name = "brick3";
      this.brick3.Size = new System.Drawing.Size(82, 22);
      this.brick3.TabIndex = 7;
      // 
      // brick4
      // 
      this.brick4.BackColor = System.Drawing.Color.Red;
      this.brick4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick4.Location = new System.Drawing.Point(198, 154);
      this.brick4.Name = "brick4";
      this.brick4.Size = new System.Drawing.Size(82, 22);
      this.brick4.TabIndex = 8;
      // 
      // brick5
      // 
      this.brick5.BackColor = System.Drawing.Color.Red;
      this.brick5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick5.Location = new System.Drawing.Point(316, 154);
      this.brick5.Name = "brick5";
      this.brick5.Size = new System.Drawing.Size(82, 22);
      this.brick5.TabIndex = 9;
      // 
      // timer
      // 
      this.timer.Interval = 5;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // score
      // 
      this.score.AutoSize = true;
      this.score.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.score.Location = new System.Drawing.Point(728, 0);
      this.score.Name = "score";
      this.score.Size = new System.Drawing.Size(96, 26);
      this.score.TabIndex = 10;
      this.score.Text = "Score: ";
      // 
      // brick6
      // 
      this.brick6.BackColor = System.Drawing.Color.Red;
      this.brick6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick6.Location = new System.Drawing.Point(428, 154);
      this.brick6.Name = "brick6";
      this.brick6.Size = new System.Drawing.Size(82, 22);
      this.brick6.TabIndex = 11;
      // 
      // brick8
      // 
      this.brick8.BackColor = System.Drawing.Color.Red;
      this.brick8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick8.Location = new System.Drawing.Point(254, 112);
      this.brick8.Name = "brick8";
      this.brick8.Size = new System.Drawing.Size(82, 22);
      this.brick8.TabIndex = 12;
      // 
      // brick9
      // 
      this.brick9.BackColor = System.Drawing.Color.Red;
      this.brick9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick9.Location = new System.Drawing.Point(379, 112);
      this.brick9.Name = "brick9";
      this.brick9.Size = new System.Drawing.Size(82, 22);
      this.brick9.TabIndex = 13;
      // 
      // brick7
      // 
      this.brick7.BackColor = System.Drawing.Color.Red;
      this.brick7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick7.Location = new System.Drawing.Point(129, 112);
      this.brick7.Name = "brick7";
      this.brick7.Size = new System.Drawing.Size(82, 22);
      this.brick7.TabIndex = 14;
      // 
      // brick10
      // 
      this.brick10.BackColor = System.Drawing.Color.Red;
      this.brick10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick10.Location = new System.Drawing.Point(499, 112);
      this.brick10.Name = "brick10";
      this.brick10.Size = new System.Drawing.Size(82, 22);
      this.brick10.TabIndex = 15;
      // 
      // brick12
      // 
      this.brick12.BackColor = System.Drawing.Color.Red;
      this.brick12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick12.Location = new System.Drawing.Point(198, 66);
      this.brick12.Name = "brick12";
      this.brick12.Size = new System.Drawing.Size(82, 22);
      this.brick12.TabIndex = 16;
      // 
      // brick13
      // 
      this.brick13.BackColor = System.Drawing.Color.Red;
      this.brick13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick13.Location = new System.Drawing.Point(316, 66);
      this.brick13.Name = "brick13";
      this.brick13.Size = new System.Drawing.Size(82, 22);
      this.brick13.TabIndex = 17;
      // 
      // brick14
      // 
      this.brick14.BackColor = System.Drawing.Color.Red;
      this.brick14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick14.Location = new System.Drawing.Point(428, 66);
      this.brick14.Name = "brick14";
      this.brick14.Size = new System.Drawing.Size(82, 22);
      this.brick14.TabIndex = 18;
      // 
      // brick11
      // 
      this.brick11.BackColor = System.Drawing.Color.Red;
      this.brick11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick11.Location = new System.Drawing.Point(73, 66);
      this.brick11.Name = "brick11";
      this.brick11.Size = new System.Drawing.Size(82, 22);
      this.brick11.TabIndex = 19;
      // 
      // brick15
      // 
      this.brick15.BackColor = System.Drawing.Color.Red;
      this.brick15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick15.Location = new System.Drawing.Point(548, 66);
      this.brick15.Name = "brick15";
      this.brick15.Size = new System.Drawing.Size(82, 22);
      this.brick15.TabIndex = 20;
      // 
      // brick17
      // 
      this.brick17.BackColor = System.Drawing.Color.Red;
      this.brick17.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick17.Location = new System.Drawing.Point(129, 25);
      this.brick17.Name = "brick17";
      this.brick17.Size = new System.Drawing.Size(82, 22);
      this.brick17.TabIndex = 21;
      // 
      // brick18
      // 
      this.brick18.BackColor = System.Drawing.Color.Red;
      this.brick18.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick18.Location = new System.Drawing.Point(254, 25);
      this.brick18.Name = "brick18";
      this.brick18.Size = new System.Drawing.Size(82, 22);
      this.brick18.TabIndex = 22;
      // 
      // brick19
      // 
      this.brick19.BackColor = System.Drawing.Color.Red;
      this.brick19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick19.Location = new System.Drawing.Point(379, 25);
      this.brick19.Name = "brick19";
      this.brick19.Size = new System.Drawing.Size(82, 22);
      this.brick19.TabIndex = 23;
      // 
      // brick20
      // 
      this.brick20.BackColor = System.Drawing.Color.Red;
      this.brick20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick20.Location = new System.Drawing.Point(499, 25);
      this.brick20.Name = "brick20";
      this.brick20.Size = new System.Drawing.Size(82, 22);
      this.brick20.TabIndex = 24;
      // 
      // brick16
      // 
      this.brick16.BackColor = System.Drawing.Color.Red;
      this.brick16.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick16.Location = new System.Drawing.Point(20, 25);
      this.brick16.Name = "brick16";
      this.brick16.Size = new System.Drawing.Size(82, 22);
      this.brick16.TabIndex = 25;
      // 
      // brick21
      // 
      this.brick21.BackColor = System.Drawing.Color.Red;
      this.brick21.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick21.Location = new System.Drawing.Point(606, 25);
      this.brick21.Name = "brick21";
      this.brick21.Size = new System.Drawing.Size(82, 22);
      this.brick21.TabIndex = 26;
      // 
      // control_mouse
      // 
      this.control_mouse.AutoSize = true;
      this.control_mouse.Enabled = false;
      this.control_mouse.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.control_mouse.Location = new System.Drawing.Point(732, 105);
      this.control_mouse.Name = "control_mouse";
      this.control_mouse.Size = new System.Drawing.Size(77, 22);
      this.control_mouse.TabIndex = 27;
      this.control_mouse.Text = "Mouse";
      this.control_mouse.UseVisualStyleBackColor = true;
      // 
      // control_keyboard
      // 
      this.control_keyboard.AutoSize = true;
      this.control_keyboard.Enabled = false;
      this.control_keyboard.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.control_keyboard.Location = new System.Drawing.Point(732, 133);
      this.control_keyboard.Name = "control_keyboard";
      this.control_keyboard.Size = new System.Drawing.Size(109, 22);
      this.control_keyboard.TabIndex = 28;
      this.control_keyboard.Text = "Keyboard";
      this.control_keyboard.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(747, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 21);
      this.label1.TabIndex = 29;
      this.label1.Text = "Control:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(728, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(132, 21);
      this.label2.TabIndex = 30;
      this.label2.Text = "Space - play";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(728, 81);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(120, 21);
      this.label3.TabIndex = 31;
      this.label3.Text = "Esc - pause";
      // 
      // label_pause
      // 
      this.label_pause.AutoSize = true;
      this.label_pause.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_pause.ForeColor = System.Drawing.Color.Red;
      this.label_pause.Location = new System.Drawing.Point(725, 158);
      this.label_pause.Name = "label_pause";
      this.label_pause.Size = new System.Drawing.Size(134, 41);
      this.label_pause.TabIndex = 32;
      this.label_pause.Text = "PAUSE";
      this.label_pause.Visible = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.ErrorImage = global::Arkanoid.Properties.Resources.ball_white;
      this.pictureBox1.Image = global::Arkanoid.Properties.Resources.ball_white;
      this.pictureBox1.Location = new System.Drawing.Point(475, 405);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(20, 17);
      this.pictureBox1.TabIndex = 33;
      this.pictureBox1.TabStop = false;
      // 
      // FormGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(865, 475);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label_pause);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.control_keyboard);
      this.Controls.Add(this.control_mouse);
      this.Controls.Add(this.brick21);
      this.Controls.Add(this.brick16);
      this.Controls.Add(this.brick20);
      this.Controls.Add(this.brick19);
      this.Controls.Add(this.brick18);
      this.Controls.Add(this.brick17);
      this.Controls.Add(this.brick15);
      this.Controls.Add(this.brick11);
      this.Controls.Add(this.brick14);
      this.Controls.Add(this.brick13);
      this.Controls.Add(this.brick12);
      this.Controls.Add(this.brick10);
      this.Controls.Add(this.brick7);
      this.Controls.Add(this.brick9);
      this.Controls.Add(this.brick8);
      this.Controls.Add(this.brick6);
      this.Controls.Add(this.score);
      this.Controls.Add(this.brick5);
      this.Controls.Add(this.brick4);
      this.Controls.Add(this.brick3);
      this.Controls.Add(this.brick2);
      this.Controls.Add(this.brick1);
      this.Controls.Add(this.ball);
      this.Controls.Add(this.racket);
      this.Controls.Add(this.label_right);
      this.Controls.Add(this.label_left);
      this.Controls.Add(this.label_top);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FormGame";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "FormGame";
      this.Shown += new System.EventHandler(this.FormGame_Shown);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGame_MouseMove);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_top;
    private System.Windows.Forms.Label label_left;
    private System.Windows.Forms.Label label_right;
    private System.Windows.Forms.Button racket;
    private System.Windows.Forms.RadioButton ball;
    private System.Windows.Forms.Label brick1;
    private System.Windows.Forms.Label brick2;
    private System.Windows.Forms.Label brick3;
    private System.Windows.Forms.Label brick4;
    private System.Windows.Forms.Label brick5;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Label score;
    private System.Windows.Forms.Label brick6;
    private System.Windows.Forms.Label brick8;
    private System.Windows.Forms.Label brick9;
    private System.Windows.Forms.Label brick7;
    private System.Windows.Forms.Label brick10;
    private System.Windows.Forms.Label brick12;
    private System.Windows.Forms.Label brick13;
    private System.Windows.Forms.Label brick14;
    private System.Windows.Forms.Label brick11;
    private System.Windows.Forms.Label brick15;
    private System.Windows.Forms.Label brick17;
    private System.Windows.Forms.Label brick18;
    private System.Windows.Forms.Label brick19;
    private System.Windows.Forms.Label brick20;
    private System.Windows.Forms.Label brick16;
    private System.Windows.Forms.Label brick21;
    private System.Windows.Forms.RadioButton control_mouse;
    private System.Windows.Forms.RadioButton control_keyboard;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label_pause;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}
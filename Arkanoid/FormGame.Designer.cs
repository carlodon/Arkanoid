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
      this.brick2 = new System.Windows.Forms.Label();
      this.brick3 = new System.Windows.Forms.Label();
      this.brick4 = new System.Windows.Forms.Label();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.score = new System.Windows.Forms.Label();
      this.brick6 = new System.Windows.Forms.Label();
      this.brick8 = new System.Windows.Forms.Label();
      this.brick9 = new System.Windows.Forms.Label();
      this.brick10 = new System.Windows.Forms.Label();
      this.brick12 = new System.Windows.Forms.Label();
      this.brick13 = new System.Windows.Forms.Label();
      this.brick14 = new System.Windows.Forms.Label();
      this.brick15 = new System.Windows.Forms.Label();
      this.brick17 = new System.Windows.Forms.Label();
      this.brick18 = new System.Windows.Forms.Label();
      this.brick19 = new System.Windows.Forms.Label();
      this.brick20 = new System.Windows.Forms.Label();
      this.brick21 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label_pause = new System.Windows.Forms.Label();
      this.racket = new System.Windows.Forms.Button();
      this.label_win_loss = new System.Windows.Forms.Label();
      this.control_mouse = new System.Windows.Forms.RadioButton();
      this.control_keyboard = new System.Windows.Forms.RadioButton();
      this.brick1 = new System.Windows.Forms.Label();
      this.brick22 = new System.Windows.Forms.Label();
      this.brick23 = new System.Windows.Forms.Label();
      this.brick24 = new System.Windows.Forms.Label();
      this.brick25 = new System.Windows.Forms.Label();
      this.brick26 = new System.Windows.Forms.Label();
      this.brick27 = new System.Windows.Forms.Label();
      this.brick28 = new System.Windows.Forms.Label();
      this.brick29 = new System.Windows.Forms.Label();
      this.brick30 = new System.Windows.Forms.Label();
      this.brick31 = new System.Windows.Forms.Label();
      this.brick32 = new System.Windows.Forms.Label();
      this.level = new System.Windows.Forms.Label();
      this.life1 = new System.Windows.Forms.PictureBox();
      this.ball = new System.Windows.Forms.PictureBox();
      this.life2 = new System.Windows.Forms.PictureBox();
      this.life3 = new System.Windows.Forms.PictureBox();
      this.life4 = new System.Windows.Forms.PictureBox();
      this.life5 = new System.Windows.Forms.PictureBox();
      this.life6 = new System.Windows.Forms.PictureBox();
      this.extra_life = new System.Windows.Forms.Label();
      this.timer_racket = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.life4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.life5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.life6)).BeginInit();
      this.SuspendLayout();
      // 
      // label_top
      // 
      this.label_top.BackColor = System.Drawing.Color.Navy;
      this.label_top.Location = new System.Drawing.Point(-1, 0);
      this.label_top.Name = "label_top";
      this.label_top.Size = new System.Drawing.Size(753, 15);
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
      this.label_right.Location = new System.Drawing.Point(737, 0);
      this.label_right.Name = "label_right";
      this.label_right.Size = new System.Drawing.Size(15, 473);
      this.label_right.TabIndex = 2;
      // 
      // brick2
      // 
      this.brick2.BackColor = System.Drawing.Color.Red;
      this.brick2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick2.Location = new System.Drawing.Point(119, 128);
      this.brick2.Name = "brick2";
      this.brick2.Size = new System.Drawing.Size(82, 22);
      this.brick2.TabIndex = 6;
      this.brick2.Visible = false;
      // 
      // brick3
      // 
      this.brick3.BackColor = System.Drawing.Color.Red;
      this.brick3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick3.Location = new System.Drawing.Point(207, 128);
      this.brick3.Name = "brick3";
      this.brick3.Size = new System.Drawing.Size(82, 22);
      this.brick3.TabIndex = 7;
      this.brick3.Visible = false;
      // 
      // brick4
      // 
      this.brick4.BackColor = System.Drawing.Color.Red;
      this.brick4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick4.Location = new System.Drawing.Point(295, 97);
      this.brick4.Name = "brick4";
      this.brick4.Size = new System.Drawing.Size(82, 22);
      this.brick4.TabIndex = 8;
      this.brick4.Visible = false;
      // 
      // timer
      // 
      this.timer.Interval = 1;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // score
      // 
      this.score.AutoSize = true;
      this.score.Font = new System.Drawing.Font("Algerian", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.score.ForeColor = System.Drawing.Color.Green;
      this.score.Location = new System.Drawing.Point(787, 34);
      this.score.Name = "score";
      this.score.Size = new System.Drawing.Size(150, 35);
      this.score.TabIndex = 10;
      this.score.Text = "Score:  0";
      // 
      // brick6
      // 
      this.brick6.BackColor = System.Drawing.Color.Red;
      this.brick6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick6.Location = new System.Drawing.Point(29, 128);
      this.brick6.Name = "brick6";
      this.brick6.Size = new System.Drawing.Size(82, 22);
      this.brick6.TabIndex = 11;
      this.brick6.Visible = false;
      // 
      // brick8
      // 
      this.brick8.BackColor = System.Drawing.Color.Red;
      this.brick8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick8.Location = new System.Drawing.Point(29, 97);
      this.brick8.Name = "brick8";
      this.brick8.Size = new System.Drawing.Size(82, 22);
      this.brick8.TabIndex = 12;
      this.brick8.Visible = false;
      // 
      // brick9
      // 
      this.brick9.BackColor = System.Drawing.Color.Red;
      this.brick9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick9.Location = new System.Drawing.Point(119, 97);
      this.brick9.Name = "brick9";
      this.brick9.Size = new System.Drawing.Size(82, 22);
      this.brick9.TabIndex = 13;
      this.brick9.Visible = false;
      // 
      // brick10
      // 
      this.brick10.BackColor = System.Drawing.Color.Red;
      this.brick10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick10.Location = new System.Drawing.Point(207, 97);
      this.brick10.Name = "brick10";
      this.brick10.Size = new System.Drawing.Size(82, 22);
      this.brick10.TabIndex = 15;
      this.brick10.Visible = false;
      // 
      // brick12
      // 
      this.brick12.BackColor = System.Drawing.Color.Red;
      this.brick12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick12.Location = new System.Drawing.Point(29, 65);
      this.brick12.Name = "brick12";
      this.brick12.Size = new System.Drawing.Size(82, 22);
      this.brick12.TabIndex = 16;
      this.brick12.Visible = false;
      // 
      // brick13
      // 
      this.brick13.BackColor = System.Drawing.Color.Red;
      this.brick13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick13.Location = new System.Drawing.Point(119, 65);
      this.brick13.Name = "brick13";
      this.brick13.Size = new System.Drawing.Size(82, 22);
      this.brick13.TabIndex = 17;
      this.brick13.Visible = false;
      // 
      // brick14
      // 
      this.brick14.BackColor = System.Drawing.Color.Red;
      this.brick14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick14.Location = new System.Drawing.Point(207, 65);
      this.brick14.Name = "brick14";
      this.brick14.Size = new System.Drawing.Size(82, 22);
      this.brick14.TabIndex = 18;
      this.brick14.Visible = false;
      // 
      // brick15
      // 
      this.brick15.BackColor = System.Drawing.Color.Red;
      this.brick15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick15.Location = new System.Drawing.Point(295, 65);
      this.brick15.Name = "brick15";
      this.brick15.Size = new System.Drawing.Size(82, 22);
      this.brick15.TabIndex = 20;
      this.brick15.Visible = false;
      // 
      // brick17
      // 
      this.brick17.BackColor = System.Drawing.Color.Red;
      this.brick17.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick17.Location = new System.Drawing.Point(29, 35);
      this.brick17.Name = "brick17";
      this.brick17.Size = new System.Drawing.Size(82, 22);
      this.brick17.TabIndex = 21;
      this.brick17.Visible = false;
      // 
      // brick18
      // 
      this.brick18.BackColor = System.Drawing.Color.Red;
      this.brick18.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick18.Location = new System.Drawing.Point(119, 35);
      this.brick18.Name = "brick18";
      this.brick18.Size = new System.Drawing.Size(82, 22);
      this.brick18.TabIndex = 22;
      this.brick18.Visible = false;
      // 
      // brick19
      // 
      this.brick19.BackColor = System.Drawing.Color.Red;
      this.brick19.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick19.Location = new System.Drawing.Point(207, 35);
      this.brick19.Name = "brick19";
      this.brick19.Size = new System.Drawing.Size(82, 22);
      this.brick19.TabIndex = 23;
      this.brick19.Visible = false;
      // 
      // brick20
      // 
      this.brick20.BackColor = System.Drawing.Color.Red;
      this.brick20.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick20.Location = new System.Drawing.Point(295, 35);
      this.brick20.Name = "brick20";
      this.brick20.Size = new System.Drawing.Size(82, 22);
      this.brick20.TabIndex = 24;
      this.brick20.Visible = false;
      // 
      // brick21
      // 
      this.brick21.BackColor = System.Drawing.Color.Red;
      this.brick21.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick21.Location = new System.Drawing.Point(383, 35);
      this.brick21.Name = "brick21";
      this.brick21.Size = new System.Drawing.Size(82, 22);
      this.brick21.TabIndex = 26;
      this.brick21.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(790, 69);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(134, 30);
      this.label1.TabIndex = 29;
      this.label1.Text = "Control:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(774, 95);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(187, 30);
      this.label2.TabIndex = 30;
      this.label2.Text = "Space - play";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(774, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(167, 30);
      this.label3.TabIndex = 31;
      this.label3.Text = "Esc - pause";
      // 
      // label_pause
      // 
      this.label_pause.AutoSize = true;
      this.label_pause.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_pause.ForeColor = System.Drawing.Color.Red;
      this.label_pause.Location = new System.Drawing.Point(803, 388);
      this.label_pause.Name = "label_pause";
      this.label_pause.Size = new System.Drawing.Size(134, 41);
      this.label_pause.TabIndex = 32;
      this.label_pause.Text = "PAUSE";
      this.label_pause.Visible = false;
      // 
      // racket
      // 
      this.racket.BackColor = System.Drawing.Color.Black;
      this.racket.Enabled = false;
      this.racket.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.racket.Location = new System.Drawing.Point(320, 453);
      this.racket.Name = "racket";
      this.racket.Size = new System.Drawing.Size(120, 20);
      this.racket.TabIndex = 3;
      this.racket.Text = "--------------";
      this.racket.UseVisualStyleBackColor = false;
      // 
      // label_win_loss
      // 
      this.label_win_loss.AutoSize = true;
      this.label_win_loss.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_win_loss.ForeColor = System.Drawing.Color.Green;
      this.label_win_loss.Location = new System.Drawing.Point(758, 227);
      this.label_win_loss.Name = "label_win_loss";
      this.label_win_loss.Size = new System.Drawing.Size(80, 41);
      this.label_win_loss.TabIndex = 34;
      this.label_win_loss.Text = "Win";
      this.label_win_loss.Visible = false;
      // 
      // control_mouse
      // 
      this.control_mouse.AutoSize = true;
      this.control_mouse.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.control_mouse.Location = new System.Drawing.Point(779, 154);
      this.control_mouse.Name = "control_mouse";
      this.control_mouse.Size = new System.Drawing.Size(116, 34);
      this.control_mouse.TabIndex = 35;
      this.control_mouse.Text = "MOUSE";
      this.control_mouse.UseVisualStyleBackColor = true;
      this.control_mouse.CheckedChanged += new System.EventHandler(this.control_mouse_CheckedChanged);
      // 
      // control_keyboard
      // 
      this.control_keyboard.AutoSize = true;
      this.control_keyboard.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.control_keyboard.Location = new System.Drawing.Point(779, 190);
      this.control_keyboard.Name = "control_keyboard";
      this.control_keyboard.Size = new System.Drawing.Size(170, 34);
      this.control_keyboard.TabIndex = 36;
      this.control_keyboard.Text = "keyboard";
      this.control_keyboard.UseVisualStyleBackColor = true;
      this.control_keyboard.CheckedChanged += new System.EventHandler(this.control_keyboard_CheckedChanged);
      // 
      // brick1
      // 
      this.brick1.BackColor = System.Drawing.Color.Red;
      this.brick1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick1.Location = new System.Drawing.Point(295, 128);
      this.brick1.Name = "brick1";
      this.brick1.Size = new System.Drawing.Size(82, 22);
      this.brick1.TabIndex = 5;
      this.brick1.Visible = false;
      // 
      // brick22
      // 
      this.brick22.BackColor = System.Drawing.Color.Red;
      this.brick22.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick22.Location = new System.Drawing.Point(383, 65);
      this.brick22.Name = "brick22";
      this.brick22.Size = new System.Drawing.Size(82, 22);
      this.brick22.TabIndex = 37;
      this.brick22.Visible = false;
      // 
      // brick23
      // 
      this.brick23.BackColor = System.Drawing.Color.Red;
      this.brick23.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick23.Location = new System.Drawing.Point(383, 97);
      this.brick23.Name = "brick23";
      this.brick23.Size = new System.Drawing.Size(82, 22);
      this.brick23.TabIndex = 38;
      this.brick23.Visible = false;
      // 
      // brick24
      // 
      this.brick24.BackColor = System.Drawing.Color.Red;
      this.brick24.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick24.Location = new System.Drawing.Point(383, 128);
      this.brick24.Name = "brick24";
      this.brick24.Size = new System.Drawing.Size(82, 22);
      this.brick24.TabIndex = 39;
      this.brick24.Visible = false;
      // 
      // brick25
      // 
      this.brick25.BackColor = System.Drawing.Color.Red;
      this.brick25.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick25.Location = new System.Drawing.Point(471, 35);
      this.brick25.Name = "brick25";
      this.brick25.Size = new System.Drawing.Size(82, 22);
      this.brick25.TabIndex = 40;
      this.brick25.Visible = false;
      // 
      // brick26
      // 
      this.brick26.BackColor = System.Drawing.Color.Red;
      this.brick26.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick26.Location = new System.Drawing.Point(471, 65);
      this.brick26.Name = "brick26";
      this.brick26.Size = new System.Drawing.Size(82, 22);
      this.brick26.TabIndex = 41;
      this.brick26.Visible = false;
      // 
      // brick27
      // 
      this.brick27.BackColor = System.Drawing.Color.Red;
      this.brick27.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick27.Location = new System.Drawing.Point(471, 97);
      this.brick27.Name = "brick27";
      this.brick27.Size = new System.Drawing.Size(82, 22);
      this.brick27.TabIndex = 42;
      this.brick27.Visible = false;
      // 
      // brick28
      // 
      this.brick28.BackColor = System.Drawing.Color.Red;
      this.brick28.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick28.Location = new System.Drawing.Point(471, 128);
      this.brick28.Name = "brick28";
      this.brick28.Size = new System.Drawing.Size(82, 22);
      this.brick28.TabIndex = 43;
      this.brick28.Visible = false;
      // 
      // brick29
      // 
      this.brick29.BackColor = System.Drawing.Color.Red;
      this.brick29.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick29.Location = new System.Drawing.Point(559, 35);
      this.brick29.Name = "brick29";
      this.brick29.Size = new System.Drawing.Size(82, 22);
      this.brick29.TabIndex = 44;
      this.brick29.Visible = false;
      // 
      // brick30
      // 
      this.brick30.BackColor = System.Drawing.Color.Red;
      this.brick30.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick30.Location = new System.Drawing.Point(559, 65);
      this.brick30.Name = "brick30";
      this.brick30.Size = new System.Drawing.Size(82, 22);
      this.brick30.TabIndex = 45;
      this.brick30.Visible = false;
      // 
      // brick31
      // 
      this.brick31.BackColor = System.Drawing.Color.Red;
      this.brick31.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick31.Location = new System.Drawing.Point(559, 97);
      this.brick31.Name = "brick31";
      this.brick31.Size = new System.Drawing.Size(82, 22);
      this.brick31.TabIndex = 46;
      this.brick31.Visible = false;
      // 
      // brick32
      // 
      this.brick32.BackColor = System.Drawing.Color.Red;
      this.brick32.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick32.Location = new System.Drawing.Point(559, 128);
      this.brick32.Name = "brick32";
      this.brick32.Size = new System.Drawing.Size(82, 22);
      this.brick32.TabIndex = 47;
      this.brick32.Visible = false;
      // 
      // level
      // 
      this.level.AutoSize = true;
      this.level.Font = new System.Drawing.Font("Algerian", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.level.Location = new System.Drawing.Point(788, 0);
      this.level.Name = "level";
      this.level.Size = new System.Drawing.Size(149, 35);
      this.level.TabIndex = 48;
      this.level.Text = "Level:  1";
      // 
      // life1
      // 
      this.life1.Image = global::Arkanoid.Properties.Resources.life;
      this.life1.Location = new System.Drawing.Point(758, 442);
      this.life1.Name = "life1";
      this.life1.Size = new System.Drawing.Size(31, 31);
      this.life1.TabIndex = 49;
      this.life1.TabStop = false;
      // 
      // ball
      // 
      this.ball.Image = global::Arkanoid.Properties.Resources.black_ball;
      this.ball.Location = new System.Drawing.Point(372, 427);
      this.ball.Name = "ball";
      this.ball.Size = new System.Drawing.Size(20, 20);
      this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.ball.TabIndex = 33;
      this.ball.TabStop = false;
      // 
      // life2
      // 
      this.life2.Image = global::Arkanoid.Properties.Resources.life;
      this.life2.Location = new System.Drawing.Point(795, 442);
      this.life2.Name = "life2";
      this.life2.Size = new System.Drawing.Size(31, 31);
      this.life2.TabIndex = 50;
      this.life2.TabStop = false;
      // 
      // life3
      // 
      this.life3.Image = global::Arkanoid.Properties.Resources.life;
      this.life3.Location = new System.Drawing.Point(832, 442);
      this.life3.Name = "life3";
      this.life3.Size = new System.Drawing.Size(31, 31);
      this.life3.TabIndex = 51;
      this.life3.TabStop = false;
      // 
      // life4
      // 
      this.life4.Image = global::Arkanoid.Properties.Resources.life;
      this.life4.Location = new System.Drawing.Point(869, 442);
      this.life4.Name = "life4";
      this.life4.Size = new System.Drawing.Size(31, 31);
      this.life4.TabIndex = 52;
      this.life4.TabStop = false;
      this.life4.Visible = false;
      // 
      // life5
      // 
      this.life5.Image = global::Arkanoid.Properties.Resources.life;
      this.life5.Location = new System.Drawing.Point(906, 442);
      this.life5.Name = "life5";
      this.life5.Size = new System.Drawing.Size(31, 31);
      this.life5.TabIndex = 53;
      this.life5.TabStop = false;
      this.life5.Visible = false;
      // 
      // life6
      // 
      this.life6.Image = global::Arkanoid.Properties.Resources.life;
      this.life6.Location = new System.Drawing.Point(943, 442);
      this.life6.Name = "life6";
      this.life6.Size = new System.Drawing.Size(31, 31);
      this.life6.TabIndex = 54;
      this.life6.TabStop = false;
      this.life6.Visible = false;
      // 
      // extra_life
      // 
      this.extra_life.AutoSize = true;
      this.extra_life.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.extra_life.ForeColor = System.Drawing.Color.Red;
      this.extra_life.Location = new System.Drawing.Point(758, 277);
      this.extra_life.Name = "extra_life";
      this.extra_life.Size = new System.Drawing.Size(235, 41);
      this.extra_life.TabIndex = 55;
      this.extra_life.Text = "Extra Life!";
      this.extra_life.Visible = false;
      // 
      // timer_racket
      // 
      this.timer_racket.Interval = 1;
      this.timer_racket.Tick += new System.EventHandler(this.timer_racket_Tick);
      // 
      // FormGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Azure;
      this.ClientSize = new System.Drawing.Size(988, 475);
      this.Controls.Add(this.extra_life);
      this.Controls.Add(this.life6);
      this.Controls.Add(this.life5);
      this.Controls.Add(this.life4);
      this.Controls.Add(this.life3);
      this.Controls.Add(this.life2);
      this.Controls.Add(this.life1);
      this.Controls.Add(this.level);
      this.Controls.Add(this.brick32);
      this.Controls.Add(this.brick31);
      this.Controls.Add(this.brick30);
      this.Controls.Add(this.brick29);
      this.Controls.Add(this.brick28);
      this.Controls.Add(this.brick27);
      this.Controls.Add(this.brick26);
      this.Controls.Add(this.brick25);
      this.Controls.Add(this.brick24);
      this.Controls.Add(this.brick23);
      this.Controls.Add(this.brick22);
      this.Controls.Add(this.control_keyboard);
      this.Controls.Add(this.control_mouse);
      this.Controls.Add(this.label_win_loss);
      this.Controls.Add(this.ball);
      this.Controls.Add(this.label_pause);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.brick21);
      this.Controls.Add(this.brick20);
      this.Controls.Add(this.brick19);
      this.Controls.Add(this.brick18);
      this.Controls.Add(this.brick17);
      this.Controls.Add(this.brick15);
      this.Controls.Add(this.brick14);
      this.Controls.Add(this.brick13);
      this.Controls.Add(this.brick12);
      this.Controls.Add(this.brick10);
      this.Controls.Add(this.brick9);
      this.Controls.Add(this.brick8);
      this.Controls.Add(this.brick6);
      this.Controls.Add(this.score);
      this.Controls.Add(this.brick4);
      this.Controls.Add(this.brick3);
      this.Controls.Add(this.brick2);
      this.Controls.Add(this.brick1);
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
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyUp);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormGame_MouseMove);
      ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.life4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.life5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.life6)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_top;
    private System.Windows.Forms.Label label_left;
    private System.Windows.Forms.Label label_right;
    private System.Windows.Forms.Label brick1;
    private System.Windows.Forms.Label brick2;
    private System.Windows.Forms.Label brick3;
    private System.Windows.Forms.Label brick4;
    private System.Windows.Forms.Timer timer;
    private System.Windows.Forms.Label score;
    private System.Windows.Forms.Label brick6;
    private System.Windows.Forms.Label brick8;
    private System.Windows.Forms.Label brick9;
    private System.Windows.Forms.Label brick10;
    private System.Windows.Forms.Label brick12;
    private System.Windows.Forms.Label brick13;
    private System.Windows.Forms.Label brick14;
    private System.Windows.Forms.Label brick15;
    private System.Windows.Forms.Label brick17;
    private System.Windows.Forms.Label brick18;
    private System.Windows.Forms.Label brick19;
    private System.Windows.Forms.Label brick20;
    private System.Windows.Forms.Label brick21;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label_pause;
    private System.Windows.Forms.Button racket;
    private System.Windows.Forms.PictureBox ball;
    private System.Windows.Forms.Label label_win_loss;
    private System.Windows.Forms.RadioButton control_mouse;
    private System.Windows.Forms.RadioButton control_keyboard;
    private System.Windows.Forms.Label brick22;
    private System.Windows.Forms.Label brick23;
    private System.Windows.Forms.Label brick24;
    private System.Windows.Forms.Label brick25;
    private System.Windows.Forms.Label brick26;
    private System.Windows.Forms.Label brick27;
    private System.Windows.Forms.Label brick28;
    private System.Windows.Forms.Label brick29;
    private System.Windows.Forms.Label brick30;
    private System.Windows.Forms.Label brick31;
    private System.Windows.Forms.Label brick32;
    private System.Windows.Forms.Label level;
    private System.Windows.Forms.PictureBox life1;
    private System.Windows.Forms.PictureBox life2;
    private System.Windows.Forms.PictureBox life3;
    private System.Windows.Forms.PictureBox life4;
    private System.Windows.Forms.PictureBox life5;
    private System.Windows.Forms.PictureBox life6;
    private System.Windows.Forms.Label extra_life;
    private System.Windows.Forms.Timer timer_racket;
  }
}
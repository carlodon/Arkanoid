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
      this.SuspendLayout();
      // 
      // label_top
      // 
      this.label_top.BackColor = System.Drawing.SystemColors.ControlText;
      this.label_top.Location = new System.Drawing.Point(-1, -1);
      this.label_top.Name = "label_top";
      this.label_top.Size = new System.Drawing.Size(723, 23);
      this.label_top.TabIndex = 0;
      // 
      // label_left
      // 
      this.label_left.BackColor = System.Drawing.SystemColors.ControlText;
      this.label_left.Location = new System.Drawing.Point(-1, 22);
      this.label_left.Name = "label_left";
      this.label_left.Size = new System.Drawing.Size(24, 93);
      this.label_left.TabIndex = 1;
      // 
      // label_right
      // 
      this.label_right.BackColor = System.Drawing.SystemColors.ControlText;
      this.label_right.Location = new System.Drawing.Point(698, 22);
      this.label_right.Name = "label_right";
      this.label_right.Size = new System.Drawing.Size(24, 93);
      this.label_right.TabIndex = 2;
      // 
      // racket
      // 
      this.racket.Enabled = false;
      this.racket.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.racket.Location = new System.Drawing.Point(323, 509);
      this.racket.Name = "racket";
      this.racket.Size = new System.Drawing.Size(72, 23);
      this.racket.TabIndex = 3;
      this.racket.Text = "--------------";
      this.racket.UseVisualStyleBackColor = true;
      // 
      // ball
      // 
      this.ball.AutoSize = true;
      this.ball.Checked = true;
      this.ball.Enabled = false;
      this.ball.Location = new System.Drawing.Point(351, 499);
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
      this.brick1.Location = new System.Drawing.Point(58, 56);
      this.brick1.Name = "brick1";
      this.brick1.Size = new System.Drawing.Size(82, 22);
      this.brick1.TabIndex = 5;
      // 
      // brick2
      // 
      this.brick2.BackColor = System.Drawing.Color.Red;
      this.brick2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick2.Location = new System.Drawing.Point(320, 56);
      this.brick2.Name = "brick2";
      this.brick2.Size = new System.Drawing.Size(82, 22);
      this.brick2.TabIndex = 6;
      // 
      // brick3
      // 
      this.brick3.BackColor = System.Drawing.Color.Red;
      this.brick3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick3.Location = new System.Drawing.Point(572, 56);
      this.brick3.Name = "brick3";
      this.brick3.Size = new System.Drawing.Size(82, 22);
      this.brick3.TabIndex = 7;
      // 
      // brick4
      // 
      this.brick4.BackColor = System.Drawing.Color.Red;
      this.brick4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick4.Location = new System.Drawing.Point(181, 136);
      this.brick4.Name = "brick4";
      this.brick4.Size = new System.Drawing.Size(82, 22);
      this.brick4.TabIndex = 8;
      // 
      // brick5
      // 
      this.brick5.BackColor = System.Drawing.Color.Red;
      this.brick5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.brick5.Location = new System.Drawing.Point(384, 194);
      this.brick5.Name = "brick5";
      this.brick5.Size = new System.Drawing.Size(113, 42);
      this.brick5.TabIndex = 9;
      // 
      // timer
      // 
      this.timer.Interval = 5;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // FormGame
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.ClientSize = new System.Drawing.Size(720, 535);
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
  }
}
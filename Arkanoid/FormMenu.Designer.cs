namespace Arkanoid
{
  partial class FormMenu
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
      this.ButtonStart = new System.Windows.Forms.Button();
      this.levels = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // ButtonStart
      // 
      this.ButtonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ButtonStart.Location = new System.Drawing.Point(225, 514);
      this.ButtonStart.Name = "ButtonStart";
      this.ButtonStart.Size = new System.Drawing.Size(449, 43);
      this.ButtonStart.TabIndex = 0;
      this.ButtonStart.Text = "Start Game";
      this.ButtonStart.UseVisualStyleBackColor = false;
      this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
      // 
      // levels
      // 
      this.levels.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.levels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      this.levels.FormattingEnabled = true;
      this.levels.ItemHeight = 35;
      this.levels.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5"});
      this.levels.Location = new System.Drawing.Point(225, 329);
      this.levels.Name = "levels";
      this.levels.Size = new System.Drawing.Size(449, 179);
      this.levels.TabIndex = 1;
      this.levels.SelectedIndexChanged += new System.EventHandler(this.levels_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.label1.Location = new System.Drawing.Point(330, 291);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(242, 35);
      this.label1.TabIndex = 2;
      this.label1.Text = "Select Level:";
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Arkanoid.Properties.Resources.back;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.ClientSize = new System.Drawing.Size(877, 569);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.levels);
      this.Controls.Add(this.ButtonStart);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Arkanoid";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button ButtonStart;
    private System.Windows.Forms.ListBox levels;
    private System.Windows.Forms.Label label1;
  }
}


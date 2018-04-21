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
      this.SuspendLayout();
      // 
      // ButtonStart
      // 
      this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ButtonStart.Location = new System.Drawing.Point(304, 386);
      this.ButtonStart.Name = "ButtonStart";
      this.ButtonStart.Size = new System.Drawing.Size(303, 38);
      this.ButtonStart.TabIndex = 0;
      this.ButtonStart.Text = "Start Game";
      this.ButtonStart.UseVisualStyleBackColor = true;
      this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = global::Arkanoid.Properties.Resources.image_start;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.ClientSize = new System.Drawing.Size(861, 436);
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

    }

    #endregion

    private System.Windows.Forms.Button ButtonStart;
  }
}


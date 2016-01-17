namespace ButtonGame
{
  partial class MainForm
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
      this.gameScreen1 = new ButtonGame.GameScreen();
      this.SuspendLayout();
      // 
      // gameScreen1
      // 
      this.gameScreen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.gameScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gameScreen1.Location = new System.Drawing.Point(10, 10);
      this.gameScreen1.Name = "gameScreen1";
      this.gameScreen1.Size = new System.Drawing.Size(558, 261);
      this.gameScreen1.TabIndex = 0;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(578, 281);
      this.Controls.Add(this.gameScreen1);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private GameScreen gameScreen1;

  }
}


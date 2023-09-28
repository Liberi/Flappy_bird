namespace Flappy_bird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pipe3 = new System.Windows.Forms.PictureBox();
            this.pipe1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipe2 = new System.Windows.Forms.PictureBox();
            this.pipe4 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.Fail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.Black;
            this.ScoreText.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.ForeColor = System.Drawing.Color.White;
            this.ScoreText.Location = new System.Drawing.Point(12, 9);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(120, 30);
            this.ScoreText.TabIndex = 3;
            this.ScoreText.Text = "Score: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappy_bird.Properties.Resources.background2;
            this.pictureBox1.Location = new System.Drawing.Point(-195, 413);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1371, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pipe3
            // 
            this.pipe3.Image = global::Flappy_bird.Properties.Resources.pipedown;
            this.pipe3.Location = new System.Drawing.Point(648, -17);
            this.pipe3.Name = "pipe3";
            this.pipe3.Size = new System.Drawing.Size(120, 190);
            this.pipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe3.TabIndex = 1;
            this.pipe3.TabStop = false;
            // 
            // pipe1
            // 
            this.pipe1.Image = global::Flappy_bird.Properties.Resources.pipedown;
            this.pipe1.Location = new System.Drawing.Point(165, -17);
            this.pipe1.Name = "pipe1";
            this.pipe1.Size = new System.Drawing.Size(120, 229);
            this.pipe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe1.TabIndex = 1;
            this.pipe1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-15, 557);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(838, 98);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // pipe2
            // 
            this.pipe2.Image = global::Flappy_bird.Properties.Resources.pipe;
            this.pipe2.Location = new System.Drawing.Point(165, 384);
            this.pipe2.Name = "pipe2";
            this.pipe2.Size = new System.Drawing.Size(120, 187);
            this.pipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe2.TabIndex = 1;
            this.pipe2.TabStop = false;
            // 
            // pipe4
            // 
            this.pipe4.Image = global::Flappy_bird.Properties.Resources.pipe;
            this.pipe4.Location = new System.Drawing.Point(648, 341);
            this.pipe4.Name = "pipe4";
            this.pipe4.Size = new System.Drawing.Size(120, 258);
            this.pipe4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipe4.TabIndex = 1;
            this.pipe4.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = global::Flappy_bird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(60, 235);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(72, 62);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // Fail
            // 
            this.Fail.AutoSize = true;
            this.Fail.BackColor = System.Drawing.Color.Transparent;
            this.Fail.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fail.ForeColor = System.Drawing.Color.Red;
            this.Fail.Location = new System.Drawing.Point(174, 215);
            this.Fail.Name = "Fail";
            this.Fail.Size = new System.Drawing.Size(472, 91);
            this.Fail.TabIndex = 3;
            this.Fail.Text = "Game Over";
            this.Fail.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(802, 648);
            this.Controls.Add(this.Fail);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.pipe3);
            this.Controls.Add(this.pipe1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipe2);
            this.Controls.Add(this.pipe4);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipe4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipe1;
        private System.Windows.Forms.PictureBox pipe2;
        private System.Windows.Forms.PictureBox pipe3;
        private System.Windows.Forms.PictureBox pipe4;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Fail;
        private System.Windows.Forms.Timer gameTimer;
    }
}


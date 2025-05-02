namespace PersonalInterestApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer animationTimer;
        private int currentAnimationFrame = 0;
        private bool isLoaded = false;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnPlaces = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(90)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 60);
            this.panelTop.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("ariel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(94, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Personal Interest Catalog";
            // 
            // btnMusic
            // 
            this.btnMusic.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMusic.FlatAppearance.BorderSize = 0;
            this.btnMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusic.ForeColor = System.Drawing.Color.Black;
            this.btnMusic.Location = new System.Drawing.Point(50, 100);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(300, 50);
            this.btnMusic.TabIndex = 0;
            this.btnMusic.Text = "🎵 Music Collection";
            this.btnMusic.UseVisualStyleBackColor = false;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            this.btnMusic.MouseEnter += new System.EventHandler(this.btnHoverEffect_MouseEnter);
            this.btnMusic.MouseLeave += new System.EventHandler(this.btnHoverEffect_MouseLeave);
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnMovies.Location = new System.Drawing.Point(50, 170);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(300, 50);
            this.btnMovies.TabIndex = 1;
            this.btnMovies.Text = "🎬 Movie Collection";
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            this.btnMovies.MouseEnter += new System.EventHandler(this.btnHoverEffect_MouseEnter);
            this.btnMovies.MouseLeave += new System.EventHandler(this.btnHoverEffect_MouseLeave);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnBooks.Location = new System.Drawing.Point(50, 240);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(300, 50);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "📚 Book Collection";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            this.btnBooks.MouseEnter += new System.EventHandler(this.btnHoverEffect_MouseEnter);
            this.btnBooks.MouseLeave += new System.EventHandler(this.btnHoverEffect_MouseLeave);
            // 
            // btnPlaces
            // 
            this.btnPlaces.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlaces.FlatAppearance.BorderSize = 0;
            this.btnPlaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaces.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.btnPlaces.Location = new System.Drawing.Point(50, 310);
            this.btnPlaces.Name = "btnPlaces";
            this.btnPlaces.Size = new System.Drawing.Size(300, 50);
            this.btnPlaces.TabIndex = 3;
            this.btnPlaces.Text = "🌍 Travel Destinations";
            this.btnPlaces.UseVisualStyleBackColor = false;
            this.btnPlaces.Click += new System.EventHandler(this.btnPlaces_Click);
            this.btnPlaces.MouseEnter += new System.EventHandler(this.btnHoverEffect_MouseEnter);
            this.btnPlaces.MouseLeave += new System.EventHandler(this.btnHoverEffect_MouseLeave);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnPlaces);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Interest Catalog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnPlaces;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;

        // Animation and UI effect methods
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Start with all buttons hidden
            btnMusic.Left = -btnMusic.Width;
            btnMovies.Left = -btnMovies.Width;
            btnBooks.Left = -btnBooks.Width;
            btnPlaces.Left = -btnPlaces.Width;
            
            // Start animation timer
            isLoaded = true;
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, System.EventArgs e)
        {
            // Animate buttons sliding in one after another
            if (currentAnimationFrame < 12)
            {
                if (currentAnimationFrame >= 0 && btnMusic.Left < 50)
                    btnMusic.Left += 30;
            }
            
            if (currentAnimationFrame >= 3 && currentAnimationFrame < 15)
            {
                if (btnMovies.Left < 50)
                    btnMovies.Left += 30;
            }
            
            if (currentAnimationFrame >= 6 && currentAnimationFrame < 18)
            {
                if (btnBooks.Left < 50)
                    btnBooks.Left += 30;
            }
            
            if (currentAnimationFrame >= 9 && currentAnimationFrame < 21)
            {
                if (btnPlaces.Left < 50)
                    btnPlaces.Left += 30;
            }
            
            // Stop timer when animation is complete
            if (currentAnimationFrame >= 21 && 
                btnMusic.Left >= 50 && 
                btnMovies.Left >= 50 && 
                btnBooks.Left >= 50 && 
                btnPlaces.Left >= 50)
            {
                animationTimer.Stop();
            }
            
            currentAnimationFrame++;
        }

        private void btnHoverEffect_MouseEnter(object sender, System.EventArgs e)
        {
            if (!isLoaded) return;
            
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                // Scale button slightly on hover
                btn.Size = new System.Drawing.Size(btn.Width + 10, btn.Height);
                btn.Left -= 5;
            }
        }

        private void btnHoverEffect_MouseLeave(object sender, System.EventArgs e)
        {
            if (!isLoaded) return;
            
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            if (btn != null)
            {
                // Return to original size when not hovering
                btn.Size = new System.Drawing.Size(btn.Width - 10, btn.Height);
                btn.Left += 5;
            }
        }
    }
}
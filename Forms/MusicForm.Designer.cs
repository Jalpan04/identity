namespace PersonalInterestApp.Forms
{
    partial class MusicForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Timer animationTimer;
        private int colorShift = 0;

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
            this.lstMusic = new System.Windows.Forms.ListBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnDeleteMusic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstMusic
            // 
            this.lstMusic.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lstMusic.ForeColor = System.Drawing.Color.White;
            this.lstMusic.FormattingEnabled = true;
            this.lstMusic.Location = new System.Drawing.Point(12, 12);
            this.lstMusic.Name = "lstMusic";
            this.lstMusic.Size = new System.Drawing.Size(300, 186);
            this.lstMusic.TabIndex = 0;
            this.lstMusic.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.lstMusic.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(80, 210);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(232, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtTitle.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtArtist
            // 
            this.txtArtist.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.txtArtist.ForeColor = System.Drawing.Color.White;
            this.txtArtist.Location = new System.Drawing.Point(80, 236);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(232, 20);
            this.txtArtist.TabIndex = 2;
            this.txtArtist.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtArtist.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtGenre
            // 
            this.txtGenre.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.txtGenre.ForeColor = System.Drawing.Color.White;
            this.txtGenre.Location = new System.Drawing.Point(80, 262);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(232, 20);
            this.txtGenre.TabIndex = 3;
            this.txtGenre.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtGenre.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.txtYear.ForeColor = System.Drawing.Color.White;
            this.txtYear.Location = new System.Drawing.Point(80, 288);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(232, 20);
            this.txtYear.TabIndex = 4;
            this.txtYear.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtYear.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.FlatStyle = System.Windows .Forms.FlatStyle.Flat;
            this.btnAddMusic.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnAddMusic.ForeColor = System.Drawing.Color.White;
            this.btnAddMusic.Location = new System.Drawing.Point(80, 314);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(75, 23);
            this.btnAddMusic.TabIndex = 5;
            this.btnAddMusic.Text = "Add Music";
            this.btnAddMusic.UseVisualStyleBackColor = false;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            this.btnAddMusic.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAddMusic.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnDeleteMusic
            // 
            this.btnDeleteMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteMusic.BackColor = System.Drawing.Color.FromArgb(178, 34, 34);
            this.btnDeleteMusic.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMusic.Location = new System.Drawing.Point(237, 314);
            this.btnDeleteMusic.Name = "btnDeleteMusic";
            this.btnDeleteMusic.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMusic.TabIndex = 6;
            this.btnDeleteMusic.Text = "Delete Music";
            this.btnDeleteMusic.UseVisualStyleBackColor = false;
            this.btnDeleteMusic.Click += new System.EventHandler(this.btnDeleteMusic_Click);
            this.btnDeleteMusic.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDeleteMusic.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 200, 200);
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(200, 150, 255);
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0);
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(220, 20, 60);
            this.label4.Location = new System.Drawing.Point(12, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // MusicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.ClientSize = new System.Drawing.Size(324, 349);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteMusic);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lstMusic);
            this.Name = "MusicForm";
            this.Text = "Manage Music";
            this.Load += new System.EventHandler(this.MusicForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.ListBox lstMusic;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnDeleteMusic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private void MusicForm_Load(object sender, System.EventArgs e)
        {
            // Start the animation timer
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, System.EventArgs e)
        {
            // Create a subtle color shift animation for the form border
            colorShift = (colorShift + 1) % 360;
            
            // Use HSL to RGB conversion for smooth color transitions
            System.Drawing.Color borderColor = HslToRgb(colorShift, 0.7f, 0.5f);
            
            // Apply the border effect
            this.ForeColor = borderColor;
        }

        private void Control_MouseEnter(object sender, System.EventArgs e)
        {
            // Subtle zoom animation on control focus
            if (sender is System.Windows.Forms.Control control)
            {
                control.Tag = control.Size;
                control.Size = new System.Drawing.Size(control.Width + 2, control.Height + 2);
                control.Location = new System.Drawing.Point(control.Left - 1, control.Top - 1);
            }
        }

        private void Control_MouseLeave(object sender, System.EventArgs e)
        {
            // Restore original size
            if (sender is System.Windows.Forms.Control control && control.Tag is System.Drawing.Size)
            {
                control.Size = (System.Drawing.Size)control.Tag;
                control.Location = new System.Drawing.Point(control.Left + 1, control.Top + 1);
            }
        }

        private void Button_MouseEnter(object sender, System.EventArgs e)
        {
            // Button glow effect
            if (sender is System.Windows.Forms.Button button)
            {
                button.FlatAppearance.BorderColor = System.Drawing.Color.White;
                button.FlatAppearance.BorderSize = 2;
            }
        }

        private void Button_MouseLeave(object sender, System.EventArgs e)
        {
            // Remove glow effect
            if (sender is System.Windows.Forms.Button button)
            {
                button.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
                button.FlatAppearance.BorderSize = 1;
            }
        }

        // Helper method to convert HSL to RGB for color animations
        private System.Drawing.Color HslToRgb(float h, float s, float l)
        {
            float r, g, b;

            if (s == 0)
            {
                r = g = b = l; // achromatic
            }
            else
            {
                float q = l < 0.5f ? l * (1 + s) : l + s - l * s;
                float p = 2 * l - q;
                r = HueToRgb(p, q, h / 360f + 1f / 3f);
                g = HueToRgb(p, q, h / 360f);
                b = HueToRgb(p, q, h / 360f - 1f / 3f);
            }

            return System.Drawing.Color.FromArgb(
                (int)(r * 255),
                (int)(g * 255),
                (int)(b * 255));
        }

        private float HueToRgb(float p, float q, float t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;
            if (t < 1f/6f) return p + (q - p) * 6 * t;
            if (t < 1f/2f) return q;
            if (t < 2f/3f) return p + (q - p) * (2f/3f - t) * 6;
            return p;
        }
    }
}
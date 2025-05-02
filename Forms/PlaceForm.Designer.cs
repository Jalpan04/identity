namespace PersonalInterestApp.Forms
{
    partial class PlaceForm
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
            this.lstPlaces = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnAddPlace = new System.Windows.Forms.Button();
            this.btnDeletePlace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstPlaces
            // 
            this.lstPlaces.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lstPlaces.ForeColor = System.Drawing.Color.White;
            this.lstPlaces.FormattingEnabled = true;
            this.lstPlaces.Location = new System.Drawing.Point(12, 12);
            this.lstPlaces.Name = "lstPlaces";
            this.lstPlaces.Size = new System.Drawing.Size(300, 186);
            this.lstPlaces.TabIndex = 0;
            this.lstPlaces.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.lstPlaces.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(80, 210);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 1;
            this.txtName.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtName.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.txtLocation.ForeColor = System.Drawing.Color.White;
            this.txtLocation.Location = new System.Drawing.Point(80, 236);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(232, 20);
            this.txtLocation.TabIndex = 2;
            this.txtLocation.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtLocation.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.txtType.ForeColor = System.Drawing.Color.White;
            this.txtType.Location = new System.Drawing.Point(80, 262);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(232, 20);
            this.txtType.TabIndex = 3;
            this.txtType.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.txtType.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // btnAddPlace
            // 
            this.btnAddPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlace.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.btnAddPlace.ForeColor = System.Drawing.Color.White;
            this.btnAddPlace.Location = new System.Drawing.Point(80, 288);
            this.btnAddPlace.Name = "btnAddPlace";
            this.btnAddPlace.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlace.TabIndex = 4;
            this.btnAddPlace.Text = "Add Place";
            this.btnAddPlace.UseVisualStyleBackColor = false;
            this.btnAddPlace.Click += new System.EventHandler(this.btnAddPlace_Click);
            this.btnAddPlace.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnAddPlace.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnDeletePlace
            // 
            this.btnDeletePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlace.BackColor = System.Drawing.Color.FromArgb(178, 34, 34);
            this.btnDeletePlace.ForeColor = System.Drawing.Color.White;
            this.btnDeletePlace.Location = new System.Drawing.Point(237, 288);
            this.btnDeletePlace.Name = "btnDeletePlace";
            this.btnDeletePlace.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePlace.TabIndex = 5;
            this.btnDeletePlace.Text = "Delete Place";
            this.btnDeletePlace.UseVisualStyleBackColor = false;
            this.btnDeletePlace.Click += new System.EventHandler(this.btnDeletePlace_Click);
            this.btnDeletePlace.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDeletePlace.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 200, 200);
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(200, 150, 255);
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(255, 140, 0);
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // PlaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.ClientSize = new System.Drawing.Size(324, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeletePlace);
            this.Controls.Add(this.btnAddPlace);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstPlaces);
            this.Name = "PlaceForm";
            this.Text = "Manage Places";
            this.Load += new System.EventHandler(this.PlaceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox lstPlaces;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnAddPlace;
        private System.Windows.Forms.Button btnDeletePlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private void PlaceForm_Load(object sender, System.EventArgs e)
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
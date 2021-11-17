
namespace RegexApp
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.theme_dark_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.theme_light_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pink_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.orange_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.green_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.blue_rb = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.text_black = new MaterialSkin.Controls.MaterialRadioButton();
            this.text_white = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.save_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 140);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(778, 276);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.theme_dark_rb);
            this.tabPage1.Controls.Add(this.theme_light_rb);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "THEME COLOR";
            // 
            // theme_dark_rb
            // 
            this.theme_dark_rb.AutoSize = true;
            this.theme_dark_rb.Depth = 0;
            this.theme_dark_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.theme_dark_rb.Location = new System.Drawing.Point(369, 111);
            this.theme_dark_rb.Margin = new System.Windows.Forms.Padding(0);
            this.theme_dark_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.theme_dark_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.theme_dark_rb.Name = "theme_dark_rb";
            this.theme_dark_rb.Ripple = true;
            this.theme_dark_rb.Size = new System.Drawing.Size(66, 30);
            this.theme_dark_rb.TabIndex = 2;
            this.theme_dark_rb.TabStop = true;
            this.theme_dark_rb.Text = "Dark";
            this.theme_dark_rb.UseVisualStyleBackColor = true;
            this.theme_dark_rb.CheckedChanged += new System.EventHandler(this.theme_dark_rb_CheckedChanged);
            // 
            // theme_light_rb
            // 
            this.theme_light_rb.AutoSize = true;
            this.theme_light_rb.Depth = 0;
            this.theme_light_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.theme_light_rb.Location = new System.Drawing.Point(240, 111);
            this.theme_light_rb.Margin = new System.Windows.Forms.Padding(0);
            this.theme_light_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.theme_light_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.theme_light_rb.Name = "theme_light_rb";
            this.theme_light_rb.Ripple = true;
            this.theme_light_rb.Size = new System.Drawing.Size(69, 30);
            this.theme_light_rb.TabIndex = 1;
            this.theme_light_rb.TabStop = true;
            this.theme_light_rb.Text = "Light";
            this.theme_light_rb.UseVisualStyleBackColor = true;
            this.theme_light_rb.Click += new System.EventHandler(this.theme_light_rb_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(46, 114);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(121, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Theme color:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.pink_rb);
            this.tabPage2.Controls.Add(this.orange_rb);
            this.tabPage2.Controls.Add(this.green_rb);
            this.tabPage2.Controls.Add(this.blue_rb);
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SKIN COLOR";
            // 
            // pink_rb
            // 
            this.pink_rb.AutoSize = true;
            this.pink_rb.Depth = 0;
            this.pink_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.pink_rb.Location = new System.Drawing.Point(438, 126);
            this.pink_rb.Margin = new System.Windows.Forms.Padding(0);
            this.pink_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pink_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.pink_rb.Name = "pink_rb";
            this.pink_rb.Ripple = true;
            this.pink_rb.Size = new System.Drawing.Size(64, 30);
            this.pink_rb.TabIndex = 7;
            this.pink_rb.TabStop = true;
            this.pink_rb.Text = "Pink";
            this.pink_rb.UseVisualStyleBackColor = true;
            this.pink_rb.CheckedChanged += new System.EventHandler(this.pink_rb_CheckedChanged);
            // 
            // orange_rb
            // 
            this.orange_rb.AutoSize = true;
            this.orange_rb.Depth = 0;
            this.orange_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.orange_rb.Location = new System.Drawing.Point(274, 126);
            this.orange_rb.Margin = new System.Windows.Forms.Padding(0);
            this.orange_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.orange_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.orange_rb.Name = "orange_rb";
            this.orange_rb.Ripple = true;
            this.orange_rb.Size = new System.Drawing.Size(86, 30);
            this.orange_rb.TabIndex = 6;
            this.orange_rb.TabStop = true;
            this.orange_rb.Text = "Orange";
            this.orange_rb.UseVisualStyleBackColor = true;
            this.orange_rb.CheckedChanged += new System.EventHandler(this.orange_rb_CheckedChanged);
            // 
            // green_rb
            // 
            this.green_rb.AutoSize = true;
            this.green_rb.Depth = 0;
            this.green_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.green_rb.Location = new System.Drawing.Point(438, 57);
            this.green_rb.Margin = new System.Windows.Forms.Padding(0);
            this.green_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.green_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.green_rb.Name = "green_rb";
            this.green_rb.Ripple = true;
            this.green_rb.Size = new System.Drawing.Size(76, 30);
            this.green_rb.TabIndex = 5;
            this.green_rb.TabStop = true;
            this.green_rb.Text = "Green";
            this.green_rb.UseVisualStyleBackColor = true;
            this.green_rb.Click += new System.EventHandler(this.green_rb_Click);
            // 
            // blue_rb
            // 
            this.blue_rb.AutoSize = true;
            this.blue_rb.Depth = 0;
            this.blue_rb.Font = new System.Drawing.Font("Roboto", 10F);
            this.blue_rb.Location = new System.Drawing.Point(274, 57);
            this.blue_rb.Margin = new System.Windows.Forms.Padding(0);
            this.blue_rb.MouseLocation = new System.Drawing.Point(-1, -1);
            this.blue_rb.MouseState = MaterialSkin.MouseState.HOVER;
            this.blue_rb.Name = "blue_rb";
            this.blue_rb.Ripple = true;
            this.blue_rb.Size = new System.Drawing.Size(64, 30);
            this.blue_rb.TabIndex = 4;
            this.blue_rb.TabStop = true;
            this.blue_rb.Text = "Blue";
            this.blue_rb.UseVisualStyleBackColor = true;
            this.blue_rb.Click += new System.EventHandler(this.blue_rb_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(78, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Skin color:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.text_black);
            this.tabPage3.Controls.Add(this.text_white);
            this.tabPage3.Controls.Add(this.materialLabel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(783, 234);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TEXT COLOR";
            // 
            // text_black
            // 
            this.text_black.AutoSize = true;
            this.text_black.Depth = 0;
            this.text_black.Font = new System.Drawing.Font("Roboto", 10F);
            this.text_black.Location = new System.Drawing.Point(395, 71);
            this.text_black.Margin = new System.Windows.Forms.Padding(0);
            this.text_black.MouseLocation = new System.Drawing.Point(-1, -1);
            this.text_black.MouseState = MaterialSkin.MouseState.HOVER;
            this.text_black.Name = "text_black";
            this.text_black.Ripple = true;
            this.text_black.Size = new System.Drawing.Size(73, 30);
            this.text_black.TabIndex = 5;
            this.text_black.TabStop = true;
            this.text_black.Text = "Black";
            this.text_black.UseVisualStyleBackColor = true;
            this.text_black.Click += new System.EventHandler(this.text_black_Click);
            // 
            // text_white
            // 
            this.text_white.AutoSize = true;
            this.text_white.Depth = 0;
            this.text_white.Font = new System.Drawing.Font("Roboto", 10F);
            this.text_white.Location = new System.Drawing.Point(275, 71);
            this.text_white.Margin = new System.Windows.Forms.Padding(0);
            this.text_white.MouseLocation = new System.Drawing.Point(-1, -1);
            this.text_white.MouseState = MaterialSkin.MouseState.HOVER;
            this.text_white.Name = "text_white";
            this.text_white.Ripple = true;
            this.text_white.Size = new System.Drawing.Size(74, 30);
            this.text_white.TabIndex = 4;
            this.text_white.TabStop = true;
            this.text_white.Text = "White";
            this.text_white.UseVisualStyleBackColor = true;
            this.text_white.Click += new System.EventHandler(this.text_white_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(100, 74);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Text color:";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-1, 80);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(811, 54);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // save_btn
            // 
            this.save_btn.Depth = 0;
            this.save_btn.Location = new System.Drawing.Point(579, 431);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(207, 42);
            this.save_btn.TabIndex = 2;
            this.save_btn.Text = "Save and exit";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRadioButton theme_dark_rb;
        private MaterialSkin.Controls.MaterialRadioButton theme_light_rb;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRadioButton green_rb;
        private MaterialSkin.Controls.MaterialRadioButton blue_rb;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRadioButton text_black;
        private MaterialSkin.Controls.MaterialRadioButton text_white;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRadioButton pink_rb;
        private MaterialSkin.Controls.MaterialRadioButton orange_rb;
        private MaterialSkin.Controls.MaterialRaisedButton save_btn;
    }
}
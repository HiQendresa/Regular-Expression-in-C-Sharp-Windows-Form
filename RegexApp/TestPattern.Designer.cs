
namespace RegexApp
{
    partial class TestPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPattern));
            this.pattern_txt = new System.Windows.Forms.TextBox();
            this.replace_txt = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.text_txtfield = new System.Windows.Forms.TextBox();
            this.result_txtfield = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.match_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.nextmatch_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.replace_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.split_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rightToLeft_chbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mainpage_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.exit_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // pattern_txt
            // 
            this.pattern_txt.Location = new System.Drawing.Point(213, 110);
            this.pattern_txt.Name = "pattern_txt";
            this.pattern_txt.Size = new System.Drawing.Size(890, 34);
            this.pattern_txt.TabIndex = 0;
            // 
            // replace_txt
            // 
            this.replace_txt.Location = new System.Drawing.Point(213, 180);
            this.replace_txt.Name = "replace_txt";
            this.replace_txt.Size = new System.Drawing.Size(890, 34);
            this.replace_txt.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 120);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(98, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "PATTERN:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 190);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "REPLACE WITH:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 309);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(60, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "TEXT:";
            // 
            // text_txtfield
            // 
            this.text_txtfield.Location = new System.Drawing.Point(213, 239);
            this.text_txtfield.Multiline = true;
            this.text_txtfield.Name = "text_txtfield";
            this.text_txtfield.Size = new System.Drawing.Size(890, 180);
            this.text_txtfield.TabIndex = 5;
            // 
            // result_txtfield
            // 
            this.result_txtfield.Location = new System.Drawing.Point(213, 517);
            this.result_txtfield.Multiline = true;
            this.result_txtfield.Name = "result_txtfield";
            this.result_txtfield.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_txtfield.Size = new System.Drawing.Size(890, 180);
            this.result_txtfield.TabIndex = 7;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 583);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 24);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "RESULT:";
            // 
            // match_btn
            // 
            this.match_btn.Depth = 0;
            this.match_btn.Location = new System.Drawing.Point(213, 451);
            this.match_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.match_btn.Name = "match_btn";
            this.match_btn.Primary = true;
            this.match_btn.Size = new System.Drawing.Size(98, 41);
            this.match_btn.TabIndex = 8;
            this.match_btn.Text = "MATCH";
            this.match_btn.UseVisualStyleBackColor = true;
            this.match_btn.Click += new System.EventHandler(this.match_btn_Click);
            // 
            // nextmatch_btn
            // 
            this.nextmatch_btn.Depth = 0;
            this.nextmatch_btn.Location = new System.Drawing.Point(331, 451);
            this.nextmatch_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextmatch_btn.Name = "nextmatch_btn";
            this.nextmatch_btn.Primary = true;
            this.nextmatch_btn.Size = new System.Drawing.Size(124, 41);
            this.nextmatch_btn.TabIndex = 9;
            this.nextmatch_btn.Text = "Next Match";
            this.nextmatch_btn.UseVisualStyleBackColor = true;
            this.nextmatch_btn.Click += new System.EventHandler(this.nextmatch_btn_Click);
            // 
            // replace_btn
            // 
            this.replace_btn.Depth = 0;
            this.replace_btn.Location = new System.Drawing.Point(473, 451);
            this.replace_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.replace_btn.Name = "replace_btn";
            this.replace_btn.Primary = true;
            this.replace_btn.Size = new System.Drawing.Size(98, 41);
            this.replace_btn.TabIndex = 10;
            this.replace_btn.Text = "REPLACE";
            this.replace_btn.UseVisualStyleBackColor = true;
            this.replace_btn.Click += new System.EventHandler(this.replace_btn_Click);
            // 
            // split_btn
            // 
            this.split_btn.Depth = 0;
            this.split_btn.Location = new System.Drawing.Point(603, 451);
            this.split_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.split_btn.Name = "split_btn";
            this.split_btn.Primary = true;
            this.split_btn.Size = new System.Drawing.Size(98, 41);
            this.split_btn.TabIndex = 11;
            this.split_btn.Text = "SPLIT";
            this.split_btn.UseVisualStyleBackColor = true;
            this.split_btn.Click += new System.EventHandler(this.split_btn_Click);
            // 
            // rightToLeft_chbox
            // 
            this.rightToLeft_chbox.Depth = 0;
            this.rightToLeft_chbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.rightToLeft_chbox.Location = new System.Drawing.Point(919, 458);
            this.rightToLeft_chbox.Margin = new System.Windows.Forms.Padding(0);
            this.rightToLeft_chbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rightToLeft_chbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.rightToLeft_chbox.Name = "rightToLeft_chbox";
            this.rightToLeft_chbox.Ripple = true;
            this.rightToLeft_chbox.Size = new System.Drawing.Size(184, 30);
            this.rightToLeft_chbox.TabIndex = 12;
            this.rightToLeft_chbox.Text = "Right To Left (Text)";
            this.rightToLeft_chbox.UseVisualStyleBackColor = true;
            this.rightToLeft_chbox.CheckedChanged += new System.EventHandler(this.rightToLeft_chbox_CheckedChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 721);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1118, 3);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mainpage_btn
            // 
            this.mainpage_btn.Depth = 0;
            this.mainpage_btn.Location = new System.Drawing.Point(866, 740);
            this.mainpage_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainpage_btn.Name = "mainpage_btn";
            this.mainpage_btn.Primary = true;
            this.mainpage_btn.Size = new System.Drawing.Size(115, 41);
            this.mainpage_btn.TabIndex = 14;
            this.mainpage_btn.Text = "Main Page";
            this.mainpage_btn.UseVisualStyleBackColor = true;
            this.mainpage_btn.Click += new System.EventHandler(this.mainpage_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Depth = 0;
            this.exit_btn.Location = new System.Drawing.Point(1006, 740);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(98, 41);
            this.exit_btn.TabIndex = 15;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // TestPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 793);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.mainpage_btn);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.rightToLeft_chbox);
            this.Controls.Add(this.split_btn);
            this.Controls.Add(this.replace_btn);
            this.Controls.Add(this.nextmatch_btn);
            this.Controls.Add(this.match_btn);
            this.Controls.Add(this.result_txtfield);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.text_txtfield);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.replace_txt);
            this.Controls.Add(this.pattern_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TestPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test The Pattern";
            this.Load += new System.EventHandler(this.TestPattern_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pattern_txt;
        private System.Windows.Forms.TextBox replace_txt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox text_txtfield;
        private System.Windows.Forms.TextBox result_txtfield;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton match_btn;
        private MaterialSkin.Controls.MaterialRaisedButton nextmatch_btn;
        private MaterialSkin.Controls.MaterialRaisedButton replace_btn;
        private MaterialSkin.Controls.MaterialRaisedButton split_btn;
        private MaterialSkin.Controls.MaterialCheckBox rightToLeft_chbox;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton mainpage_btn;
        private MaterialSkin.Controls.MaterialRaisedButton exit_btn;
    }
}
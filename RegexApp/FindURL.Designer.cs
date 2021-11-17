
namespace RegexApp
{
    partial class FindURL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindURL));
            this.match_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.text_txtBox = new System.Windows.Forms.TextBox();
            this.result_txtBox = new System.Windows.Forms.TextBox();
            this.testpattern_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.settings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.close_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.loaddata_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clear_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.nextmatch_btn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // match_btn
            // 
            this.match_btn.Depth = 0;
            this.match_btn.Location = new System.Drawing.Point(382, 370);
            this.match_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.match_btn.Name = "match_btn";
            this.match_btn.Primary = true;
            this.match_btn.Size = new System.Drawing.Size(147, 44);
            this.match_btn.TabIndex = 0;
            this.match_btn.Text = "Match";
            this.match_btn.UseVisualStyleBackColor = true;
            this.match_btn.Click += new System.EventHandler(this.match_btn_Click);
            // 
            // text_txtBox
            // 
            this.text_txtBox.Location = new System.Drawing.Point(161, 82);
            this.text_txtBox.Multiline = true;
            this.text_txtBox.Name = "text_txtBox";
            this.text_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_txtBox.Size = new System.Drawing.Size(929, 233);
            this.text_txtBox.TabIndex = 1;
            // 
            // result_txtBox
            // 
            this.result_txtBox.Location = new System.Drawing.Point(161, 436);
            this.result_txtBox.Multiline = true;
            this.result_txtBox.Name = "result_txtBox";
            this.result_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result_txtBox.Size = new System.Drawing.Size(929, 220);
            this.result_txtBox.TabIndex = 2;
            // 
            // testpattern_btn
            // 
            this.testpattern_btn.Depth = 0;
            this.testpattern_btn.Location = new System.Drawing.Point(27, 685);
            this.testpattern_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.testpattern_btn.Name = "testpattern_btn";
            this.testpattern_btn.Primary = true;
            this.testpattern_btn.Size = new System.Drawing.Size(175, 43);
            this.testpattern_btn.TabIndex = 3;
            this.testpattern_btn.Text = "Test The Pattern";
            this.testpattern_btn.UseVisualStyleBackColor = true;
            this.testpattern_btn.Click += new System.EventHandler(this.testpattern_btn_Click);
            // 
            // settings
            // 
            this.settings.Depth = 0;
            this.settings.Location = new System.Drawing.Point(231, 685);
            this.settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.settings.Name = "settings";
            this.settings.Primary = true;
            this.settings.Size = new System.Drawing.Size(184, 43);
            this.settings.TabIndex = 4;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // close_btn
            // 
            this.close_btn.Depth = 0;
            this.close_btn.Location = new System.Drawing.Point(966, 685);
            this.close_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.close_btn.Name = "close_btn";
            this.close_btn.Primary = true;
            this.close_btn.Size = new System.Drawing.Size(124, 43);
            this.close_btn.TabIndex = 5;
            this.close_btn.Text = "Exit";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 662);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1115, 3);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 168);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(115, 24);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "YOUR DATA:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 494);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 24);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "RESULT:";
            // 
            // loaddata_btn
            // 
            this.loaddata_btn.Depth = 0;
            this.loaddata_btn.Location = new System.Drawing.Point(161, 317);
            this.loaddata_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loaddata_btn.Name = "loaddata_btn";
            this.loaddata_btn.Primary = true;
            this.loaddata_btn.Size = new System.Drawing.Size(164, 37);
            this.loaddata_btn.TabIndex = 9;
            this.loaddata_btn.Text = "Load Data";
            this.loaddata_btn.UseVisualStyleBackColor = true;
            this.loaddata_btn.Click += new System.EventHandler(this.loaddata_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Depth = 0;
            this.clear_btn.Location = new System.Drawing.Point(932, 317);
            this.clear_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Primary = true;
            this.clear_btn.Size = new System.Drawing.Size(158, 37);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // nextmatch_btn
            // 
            this.nextmatch_btn.Depth = 0;
            this.nextmatch_btn.Location = new System.Drawing.Point(573, 370);
            this.nextmatch_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextmatch_btn.Name = "nextmatch_btn";
            this.nextmatch_btn.Primary = true;
            this.nextmatch_btn.Size = new System.Drawing.Size(158, 44);
            this.nextmatch_btn.TabIndex = 11;
            this.nextmatch_btn.Text = "match details";
            this.nextmatch_btn.UseVisualStyleBackColor = true;
            this.nextmatch_btn.Click += new System.EventHandler(this.nextmatch_btn_Click);
            // 
            // FindURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 740);
            this.Controls.Add(this.nextmatch_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.loaddata_btn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.testpattern_btn);
            this.Controls.Add(this.result_txtBox);
            this.Controls.Add(this.text_txtBox);
            this.Controls.Add(this.match_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindURL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGEX APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton match_btn;
        private System.Windows.Forms.TextBox text_txtBox;
        private System.Windows.Forms.TextBox result_txtBox;
        private MaterialSkin.Controls.MaterialRaisedButton testpattern_btn;
        private MaterialSkin.Controls.MaterialRaisedButton settings;
        private MaterialSkin.Controls.MaterialRaisedButton close_btn;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton loaddata_btn;
        private MaterialSkin.Controls.MaterialRaisedButton clear_btn;
        private MaterialSkin.Controls.MaterialRaisedButton nextmatch_btn;
    }
}


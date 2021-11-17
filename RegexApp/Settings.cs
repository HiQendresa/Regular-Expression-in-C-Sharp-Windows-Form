using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexApp
{
    public partial class Settings : MaterialSkin.Controls.MaterialForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        MaterialSkin.MaterialSkinManager sm;
        MaterialSkin.Primary primary_color = MaterialSkin.Primary.Blue400;
        MaterialSkin.Primary dark_color = MaterialSkin.Primary.Blue700;
        MaterialSkin.TextShade text_color = MaterialSkin.TextShade.WHITE;
        RegexApp.myclass.style_settings my_style = new myclass.style_settings();

        private void settings_Load(object sender, EventArgs e)
        {
            sm = MaterialSkin.MaterialSkinManager.Instance;

            sm.AddFormToManage(this);


            /*====  Change Colors ======*/

            sm.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
                                                         MaterialSkin.Primary.Blue700,
                                                         MaterialSkin.Primary.Blue100,
                                                         MaterialSkin.Accent.DeepPurple700,
                                                         MaterialSkin.TextShade.WHITE);

            /*===== Change the Theme=====*/
            my_style.theme_color(theme_light_rb, theme_dark_rb, sm);


            //============= restore skin color ==============

            my_style.skin_color_restore(ref primary_color, ref dark_color, this.blue_rb, this.green_rb, this.orange_rb, this.pink_rb);

            //===== text color========
            my_style.text_color_restore(this.text_white, this.text_black, ref text_color);


            //=================== my classes===========
            my_style.color_changer(primary_color, dark_color, text_color, sm);

        }

        void color_skin_changer()
        {
            RegexApp.Properties.Settings.Default.skin_color_blue = this.blue_rb.Checked;
            RegexApp.Properties.Settings.Default.skin_color_green = this.green_rb.Checked;
            RegexApp.Properties.Settings.Default.skin_color_orange = this.orange_rb.Checked;
            RegexApp.Properties.Settings.Default.skin_color_pink = this.pink_rb.Checked;
            RegexApp.Properties.Settings.Default.Save();
        }

        private void theme_light_rb_Click(object sender, EventArgs e)
        {
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            RegexApp.Properties.Settings.Default.theme_light_rb = this.theme_light_rb.Checked;
            RegexApp.Properties.Settings.Default.theme_dark_rb = this.theme_dark_rb.Checked;
            RegexApp.Properties.Settings.Default.Save();

        }

        private void theme_dark_rb_CheckedChanged(object sender, EventArgs e)
        {
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            RegexApp.Properties.Settings.Default.theme_dark_rb = this.theme_dark_rb.Checked;
            RegexApp.Properties.Settings.Default.theme_light_rb = this.theme_light_rb.Checked;
            RegexApp.Properties.Settings.Default.Save();

        }

        private void blue_rb_Click(object sender, EventArgs e)
        {
            primary_color = MaterialSkin.Primary.Blue400;
            dark_color = MaterialSkin.Primary.Blue700;

            my_style.color_changer(primary_color, dark_color, text_color, sm);

            //======== save color =======
            color_skin_changer();
        }

        private void green_rb_Click(object sender, EventArgs e)
        {
            primary_color = MaterialSkin.Primary.Green400;
            dark_color = MaterialSkin.Primary.Green700;

            my_style.color_changer(primary_color, dark_color, text_color, sm);

            color_skin_changer();
        }

        private void orange_rb_CheckedChanged(object sender, EventArgs e)
        {
            primary_color = MaterialSkin.Primary.Orange400;
            dark_color = MaterialSkin.Primary.Orange700;

            my_style.color_changer(primary_color, dark_color, text_color, sm);

            color_skin_changer();
        }

        private void pink_rb_CheckedChanged(object sender, EventArgs e)
        {
            primary_color = MaterialSkin.Primary.Pink400;
            dark_color = MaterialSkin.Primary.Pink700;

            my_style.color_changer(primary_color, dark_color, text_color, sm);

            color_skin_changer();
        }

        private void text_white_Click(object sender, EventArgs e)
        {
            text_color = MaterialSkin.TextShade.WHITE;

            RegexApp.Properties.Settings.Default.text_color_white = this.text_white.Checked;
            RegexApp.Properties.Settings.Default.text_color_black = this.text_black.Checked;
            RegexApp.Properties.Settings.Default.Save();
            my_style.color_changer(primary_color, dark_color, text_color, sm);

        }

        private void text_black_Click(object sender, EventArgs e)
        {
            text_color = MaterialSkin.TextShade.BLACK;
            RegexApp.Properties.Settings.Default.text_color_white = this.text_white.Checked;
            RegexApp.Properties.Settings.Default.text_color_black = this.text_black.Checked;
            RegexApp.Properties.Settings.Default.Save();
            my_style.color_changer(primary_color, dark_color, text_color, sm);

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

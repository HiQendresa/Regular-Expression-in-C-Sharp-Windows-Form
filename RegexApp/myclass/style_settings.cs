using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexApp.myclass
{
    class style_settings
    {
        public void color_changer(MaterialSkin.Primary primary_color, MaterialSkin.Primary dark_color, MaterialSkin.TextShade text_color, MaterialSkin.MaterialSkinManager sm)

        {
            sm.ColorScheme = new MaterialSkin.ColorScheme(primary_color,
                                                       dark_color,
                                                       MaterialSkin.Primary.Pink100,
                                                       MaterialSkin.Accent.Red200,
                                                       text_color);

        }


        public void theme_color(MaterialSkin.Controls.MaterialRadioButton theme_light_rb, MaterialSkin.Controls.MaterialRadioButton theme_dark_rb, MaterialSkin.MaterialSkinManager sm)
        {
            Boolean b;
            b = RegexApp.Properties.Settings.Default.theme_light_rb;

            if (b == true)
            {
                theme_light_rb.Checked = true;
                theme_dark_rb.Checked = false;
                sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;


            }
            else
            {
                theme_light_rb.Checked = false;
                theme_dark_rb.Checked = true;
                sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            }

        }

        public void skin_color_restore(ref MaterialSkin.Primary primary_color,
                                      ref MaterialSkin.Primary dark_color,
                                       MaterialSkin.Controls.MaterialRadioButton blue_rb,
                                       MaterialSkin.Controls.MaterialRadioButton green_rb,
                                       MaterialSkin.Controls.MaterialRadioButton orange_rb,
                                       MaterialSkin.Controls.MaterialRadioButton pink_rb)
        {
            Boolean b;
            b = RegexApp.Properties.Settings.Default.skin_color_blue;
            blue_rb.Checked = b;

            if (b == true)
            {
                primary_color = MaterialSkin.Primary.Blue400;
                dark_color = MaterialSkin.Primary.Blue700;
            }

            b = RegexApp.Properties.Settings.Default.skin_color_green;
            green_rb.Checked = b;
            if (b == true)
            {
                primary_color = MaterialSkin.Primary.Green400;
                dark_color = MaterialSkin.Primary.Green700;
            }


            b = RegexApp.Properties.Settings.Default.skin_color_orange;
            orange_rb.Checked = b;

            if (b == true)
            {

                primary_color = MaterialSkin.Primary.Orange400;
                dark_color = MaterialSkin.Primary.Orange700;
            }


            b = RegexApp.Properties.Settings.Default.skin_color_pink;
            pink_rb.Checked = b;
            if (b == true)
            {
                primary_color = MaterialSkin.Primary.Pink400;
                dark_color = MaterialSkin.Primary.Pink700;
            }

        }
        public void text_color_restore(MaterialSkin.Controls.MaterialRadioButton text_white,
                                        MaterialSkin.Controls.MaterialRadioButton text_black,
                                        ref MaterialSkin.TextShade text_color)

        {
            Boolean b;
            b = RegexApp.Properties.Settings.Default.text_color_white;
            text_white.Checked = b;
            if (b == true)
            {

                text_color = MaterialSkin.TextShade.WHITE;
            }

            b = RegexApp.Properties.Settings.Default.text_color_black;
            text_black.Checked = b;
            if (b == true)
            {

                text_color = MaterialSkin.TextShade.BLACK;

            }
        }
    }
}

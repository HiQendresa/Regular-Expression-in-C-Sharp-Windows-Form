using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics; //=======

namespace RegexApp
{
    public partial class TestPattern : MaterialSkin.Controls.MaterialForm
    {
        public TestPattern()
        {
            InitializeComponent();
        }

        MaterialSkin.Primary primary_color = MaterialSkin.Primary.Blue400;
        MaterialSkin.Primary dark_color = MaterialSkin.Primary.Blue700;
        MaterialSkin.TextShade text_color = MaterialSkin.TextShade.WHITE;
        RegexApp.myclass.style_settings my_style = new myclass.style_settings();


        Regex _regex = null;
        Match _match = null;
        RegexOptions _regexOptions = RegexOptions.None;

        private void TestPattern_Load(object sender, EventArgs e)
        {
           
            MaterialSkin.MaterialSkinManager sm;
            sm = MaterialSkin.MaterialSkinManager.Instance;

            sm.AddFormToManage(this);

            /*===== Change the Theme=====*/
            sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            /*====  Change Colors ======*/

            sm.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue400,
                                                         MaterialSkin.Primary.Blue700,
                                                         MaterialSkin.Primary.Blue100,
                                                         MaterialSkin.Accent.DeepPurple700,
                                                         MaterialSkin.TextShade.WHITE);


            //---------------Load Theme-----------------------//

            MaterialSkin.Controls.MaterialRadioButton rb = new MaterialSkin.Controls.MaterialRadioButton();

            /*===== Change the Theme=====*/
            my_style.theme_color(rb, rb, sm);


            //============= restore skin color ==============

            my_style.skin_color_restore(ref primary_color, ref dark_color, rb, rb, rb, rb);

            //===== text color========
            my_style.text_color_restore(rb, rb, ref text_color);


            //=================== my classes===========
            my_style.color_changer(primary_color, dark_color, text_color, sm);

            //=========================Regex===========================
           

        }

        private void mainpage_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            FindURL mainpage = new FindURL();
            mainpage.ShowDialog();
            mainpage.Dispose();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void match_btn_Click(object sender, EventArgs e)
        {
            result_txtfield.Text = "Value,Index,Length,ElapsedTime(s)" + Environment.NewLine;

            try
            {
                _regex = null;
                _match = null;
                /******************
                //
                // Note: Use Static Regex methods as much as possible
                // In this tool, Regex instance is instantiated primarily to retrieve group names.
                // Instantiating Regex instance for every click is a bad idea!  Do not use this approach for production code :-)
                // Since this is an interactive tool with pattern possibly changing between
                // every execution, Regex instance is created for every call.
                *******************/
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                _regex = new Regex(pattern_txt.Text, _regexOptions);
                _match = _regex.Match(text_txtfield.Text);

                stopWatch.Stop();
                highLightMatch(stopWatch.Elapsed);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
        }


        private void highLightMatch(TimeSpan elapsed)
        {
            if (_regex != null && _match != null && _match.Success)
            {
                text_txtfield.Focus();
                text_txtfield.Select(_match.Index, _match.Length);

                StringBuilder sb = new StringBuilder();
                sb.Append($"{_match.Value},{_match.Index},{_match.Length}, {elapsed.TotalSeconds:0.##}");
                sb.AppendLine();

                // Group 0 is default group that matches the complete expression
                if (_match.Groups.Count > 1)
                {
                    for (int i = 0; i < _match.Groups.Count; i++)
                    {
                        sb.Append($"  Group Index:{i}, Name:{_regex.GroupNameFromNumber(i)}, Value:{_match.Groups[i].Value}");
                        sb.AppendLine();
                    }
                }

                result_txtfield.Text += sb.ToString();
            }
            else
            {
                result_txtfield.Text += string.Format($"End. Elapsed Time: {elapsed.TotalSeconds:0.##}{Environment.NewLine}");
            }
        }

        private void nextmatch_btn_Click(object sender, EventArgs e)
        {

            if (_regex != null && _match != null)
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                _match = _match.NextMatch();

                stopWatch.Stop();
                highLightMatch(stopWatch.Elapsed);
            }
        }

        private void replace_btn_Click(object sender, EventArgs e)
        {
            result_txtfield.Text = string.Empty;

            try
            {
               
               string newText = Regex.Replace(text_txtfield.Text, pattern_txt.Text, replace_txt.Text, _regexOptions);
                //(?<!\r)\n
                // no carriage return infront of new line, add it.  windows requires
                // carriage return and newline \r\n to display new line
                newText = Regex.Replace(newText, @"(?<!\r)\n", Environment.NewLine);
                result_txtfield.Text = newText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
        }

        private void split_btn_Click(object sender, EventArgs e)
        {
            result_txtfield.Text = string.Empty;

            try
            {
                string[] split = Regex.Split(text_txtfield.Text, pattern_txt.Text, _regexOptions);

                StringBuilder sb = new StringBuilder();
                foreach (string s in split)
                {
                    sb.Append(s);
                    sb.Append(Environment.NewLine);
                }

                result_txtfield.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.ToString());
            }
        }

        private void rightToLeft_chbox_CheckedChanged(object sender, EventArgs e)
        {
            if (rightToLeft_chbox.Checked)
                _regexOptions = RegexOptions.RightToLeft;
            else
                _regexOptions = RegexOptions.None;
        }
    }
}

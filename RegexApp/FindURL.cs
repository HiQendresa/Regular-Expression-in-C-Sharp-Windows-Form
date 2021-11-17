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
using System.Diagnostics;

namespace RegexApp
{
    public partial class FindURL : MaterialSkin.Controls.MaterialForm
    { 
        public FindURL()
        {
            InitializeComponent();
        }
        Match _match = null;
        Regex _regex = null;
        RegexOptions _regexOptions = RegexOptions.None;

        MaterialSkin.Primary primary_color = MaterialSkin.Primary.Blue400;
        MaterialSkin.Primary dark_color = MaterialSkin.Primary.Blue700;
        MaterialSkin.TextShade text_color = MaterialSkin.TextShade.WHITE;
        RegexApp.myclass.style_settings my_style = new myclass.style_settings();

        private void Form1_Load(object sender, EventArgs e)
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

        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings settingsform = new Settings();
            settingsform.ShowDialog();
            settingsform.Dispose();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void testpattern_btn_Click(object sender, EventArgs e)
        {
           

            TestPattern test_pattern_form = new TestPattern();
            test_pattern_form.ShowDialog();
            test_pattern_form.Dispose();
            this.Hide();
        }

        private void loaddata_btn_Click(object sender, EventArgs e)
        {
            string data;

            data = System.IO.File.ReadAllText("C:\\Users\\qendr\\Desktop\\REGEX# FINAL\\RegexAppFinal\\MyData\\myData.txt", Encoding.UTF8);
            this.text_txtBox.Text = data;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            this.text_txtBox.Clear();
            this.result_txtBox.Clear();
            
        }

        private void match_btn_Click(object sender, EventArgs e)
        {
            string pattern = @"(?<Schema>https?:\/\/)?(?<Host>[www\.]?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6})\b(?<Path>[-a-zA-Z0-9()@&//=]*)?(?<Query>\?.*)?";
            
            string text = text_txtBox.Text;

            MatchCollection matchColl = Regex.Matches(text, pattern);
            
            _match = Regex.Match(text, pattern);
            _regex = new Regex(pattern, _regexOptions);

            result_txtBox.Text = $"Total matches: {matchColl.Count}" + Environment.NewLine;


            foreach (Match match in matchColl)
            {


                result_txtBox.Text += ($"Found matches: {match.Value} {Environment.NewLine}");


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



        private void highLightMatch(TimeSpan elapsed)
        {
            if (_regex != null && _match != null && _match.Success)
            {
                text_txtBox.Focus();
                text_txtBox.Select(_match.Index, _match.Length);

                StringBuilder sb = new StringBuilder();
                sb.AppendLine();

                sb.Append($"The found match:{_match.Value}{ Environment.NewLine}");
                if (_match.Groups.Count > 1)
                {
                    for (int i = 0; i < _match.Groups.Count; i++)

                    {
                        sb.Append($"Group Index: {i}, Name: {_regex.GroupNameFromNumber(i)}, Value: {_match.Groups[i].Value}");
                        sb.AppendLine();

                    }
                }

                result_txtBox.Text += sb.ToString();
            }
            else
            {
                result_txtBox.Text += string.Format($"End. Elapsed Time: {elapsed.TotalSeconds:0.##}{Environment.NewLine}");
            }



        }
    }
}

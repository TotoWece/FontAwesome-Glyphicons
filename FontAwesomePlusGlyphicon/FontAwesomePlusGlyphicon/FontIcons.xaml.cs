using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FontAwesomePlusGlyphicon
{
	public partial class FontIcons : ContentPage
	{
		public FontIcons ()
		{
			InitializeComponent ();
		}

        async void InputButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fontAwesomeEntry.Text) || fontAwesomeEntry.Text.Length == 4)
            {
                try
                {
                    var fontAwesome = Regex.Unescape(@"\u" + fontAwesomeEntry.Text);
                    fontAwesomeSpan.Text = fontAwesome;
                }
                catch
                {
                    fontAwesomeSpan.Text = "Error";
                }
            }
            else
            {
                fontAwesomeSpan.Text = "Error";
            }

            if (string.IsNullOrEmpty(glyphiconEntry.Text) || glyphiconEntry.Text.Length == 4)
            {
                try
                {
                    var glyphicon = Regex.Unescape(@"\u" + glyphiconEntry.Text);
                    glyphiconSpan.Text = glyphicon;             
                }
                catch
                {
                    glyphiconSpan.Text = "Error";
                }
            }
            else
            {
                glyphiconSpan.Text = "Error";
            }
        }

        async void RandomButton_Clicked(object sender, EventArgs e)
        {
            var rand = new Random();
            var fontAwesomeRand = rand.Next(65535).ToString("X4");
            var glyphiconRand = rand.Next(65535).ToString("X4");

            var fontAwesome = Regex.Unescape(@"\u" + fontAwesomeRand);
            fontAwesomeSpan.Text = fontAwesome;
            fontAwesomeEntry.Text = fontAwesomeRand.ToLower();

            var glyphicon = Regex.Unescape(@"\u" + glyphiconRand);
            glyphiconSpan.Text = glyphicon;
            glyphiconEntry.Text = glyphiconRand.ToLower();
        }
    }
}
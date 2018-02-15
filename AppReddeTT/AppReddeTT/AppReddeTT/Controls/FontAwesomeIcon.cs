using Xamarin.Forms;

namespace AppReddeTT.Controls
{
    public class FontAwesomeIcon : Label
    {
        public const string Typeface = "FontAwesome";

        public FontAwesomeIcon()
        {
            FontFamily = Typeface;
        }

    }
}
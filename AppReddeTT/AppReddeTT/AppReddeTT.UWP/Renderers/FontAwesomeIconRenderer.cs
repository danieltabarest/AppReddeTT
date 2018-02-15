using Windows.UI.Xaml.Media;
using AppReddeTT.UWP.Renderers;
using AppReddeTT.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(FontAwesomeIconRenderer))]
namespace AppReddeTT.UWP.Renderers
{
    /// <summary>
    /// Add the FontAwesome.ttf to the Assets folder and mark as "Android Asset"
    /// </summary>
    public class FontAwesomeIconRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                //The ttf in /Assets is CaseSensitive, so name it FontAwesome.ttf
                Control.FontFamily = new FontFamily("ms-appx:///Assets/FontAwesome.ttf#FontAwesome");
            }
        }
    }
}
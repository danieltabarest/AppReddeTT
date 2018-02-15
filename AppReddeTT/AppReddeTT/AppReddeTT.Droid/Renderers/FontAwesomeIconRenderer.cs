using Android.Graphics;
using AppReddeTT.Droid.Renderers;
using AppReddeTT.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Label = System.Reflection.Emit.Label;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(FontAwesomeIconRenderer))]
namespace AppReddeTT.Droid.Renderers
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
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, FontAwesomeIcon.Typeface + ".ttf");
            }
        }
    }
}
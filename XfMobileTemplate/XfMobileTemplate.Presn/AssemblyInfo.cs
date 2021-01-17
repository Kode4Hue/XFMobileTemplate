using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

//Give the fonts a unique alias
[assembly: ExportFont("font-awesome-pro-light.ttf", Alias = "fa-light")]
[assembly: ExportFont("font-awesome-pro-regular.ttf", Alias = "fa-regular")]
[assembly: ExportFont("font-awesome-pro-solid.ttf", Alias = "fa-solid")]
[assembly: ExportFont("font-awesome-pro-brands.ttf", Alias = "fa-brands")]

/// <summary>
/// Fix for record issue for using c#9
/// Link: https://montemagno.com/enabling-c-9-in-xamarin-net-standard-projects/
/// </summary>
namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { }
}
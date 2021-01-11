using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

/// <summary>
/// Fix for record issue for using c#9
/// Link: https://montemagno.com/enabling-c-9-in-xamarin-net-standard-projects/
/// </summary>
namespace System.Runtime.CompilerServices
{
    public class IsExternalInit { }
}
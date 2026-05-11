using Microsoft.AspNetCore.Components;

namespace BlazorApp_Bootstrap.Client.Pages
{
    public class BootstrapBase : ComponentBase
    {
        #region public properties Parameter
        [Parameter]
        public int Section { get; set; }
        [Parameter]
        public string? Partie { get; set; }
        #endregion

    }
}

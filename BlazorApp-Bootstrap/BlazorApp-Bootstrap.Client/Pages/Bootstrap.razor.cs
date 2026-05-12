using BlazorApp_Bootstrap.Models.DTO;
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
        [Parameter]
        public int? Exemple { get; set; }
        #endregion

        #region protected properties view
        [CascadingParameter(Name = "Login")]
        protected LoginDTO Login { get; set; } = new ();
        #endregion

    }
}

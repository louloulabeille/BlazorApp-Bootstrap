using BlazorApp_Bootstrap.Interface;
using BlazorApp_Bootstrap.Models.DTO;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace BlazorApp_Bootstrap.Client.Pages
{
    public class BootstrapBase : ComponentBase
    {
        #region private inject properties
        [Inject]
        public IManageForm? ManageForm { get; set; } = default;
        #endregion

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

        #region protected override method 
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        #endregion

        #region protected  method 
        protected async Task SaveLogin()
        {
            ManageForm?.Save(Login);
        }
        #endregion
    }
}

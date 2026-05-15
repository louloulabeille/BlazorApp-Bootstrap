using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;

namespace BlazorApp_Bootstrap.Client.Layout.Section3
{
    /// <summary>
    /// Pour le boostrap Tooltip - il faut  mettre en place du jascript pour le faire marcher
    /// c'est à dire qu'il faut les créer en javascript manuellement au niveau de la page
    /// après la fin du rendu de la page
    /// </summary>
    public class BootstrapTooltipBase : ComponentBase 
    {
        #region public inject properties
        [Inject] IJSRuntime JSRuntime { get; set; } = default!;

        #endregion

        #region protected override method
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("initTooltips");
            }
            await base.OnAfterRenderAsync(firstRender);
        }
        #endregion
    }
}

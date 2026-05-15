using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;

namespace BlazorApp_Bootstrap.Client.Layout.Section3
{
    public class BootstrapScrollspyBase : ComponentBase, IDisposable
    {
        /// <summary>
        /// tout cela pour faire marcher le scrollspy de bootstrap dans l'application blazor
        /// il faut faire appel de 2 fonction javascript car le systeme blazor intercepte les lien href
        /// des balises <a> pour faire du routage
        /// </summary>
        #region properties inject 
        [Inject] public IJSRuntime JSRuntime { get; set; } = default!;
        [Inject] public NavigationManager Nav { get; set; } = default!;
        #endregion

        #region protected override method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstRender"></param>
        /// <returns></returns>
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            try
            {
                await JSRuntime.InvokeVoidAsync("initScrollSpy");
                Nav.LocationChanged += OnLocationChanged;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
        }
        #endregion

        #region private method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLocationChanged(object? sender, LocationChangedEventArgs e)
        {
            _ = JSRuntime.InvokeVoidAsync("refreshScrollSpy");
        }
        #endregion

        #region public method
        public void Dispose()
        {
            Nav.LocationChanged -= OnLocationChanged;
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}

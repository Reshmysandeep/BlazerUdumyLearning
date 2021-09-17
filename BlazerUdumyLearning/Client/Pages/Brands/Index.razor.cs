using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BlazerUdumyLearning.Shared.Domain;
using System.Net.Http.Json;
using BlazerUdumyLearning.Client.Settings;
using BlazerUdumyLearning.Client.Services;

namespace BlazerUdumyLearning.Client.Pages.Brands
{
    public partial class Index:IDisposable
    {
        [Inject] HttpClient _brandClient { get; set; }
        [Inject] IJSRuntime _js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }
        [Parameter] public int id { get; set; }
        VehicleColor colour = new VehicleColor();

        private List<Brand> BrandModel;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.monitorEvents();
            BrandModel = await _brandClient.GetFromJsonAsync<List<Brand>>($"{EndPoints.BrandEndPoints}");// ("api/Brands");
        }
        async Task DeleteBrand(int BrandId)
        {
            var Brand = BrandModel.Find(b => b.Id == BrandId);
            var confirm = await _js.InvokeAsync<bool>("confirm", $"Do you want to delete { Brand.BrandName } ?");
            if (confirm)
            {
                _interceptor.monitorEvents();
                await _brandClient.DeleteAsync($"{EndPoints.BrandEndPoints}/{BrandId}");
                await OnInitializedAsync();
            }
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}

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

namespace BlazerUdumyLearning.Client.Pages.Brands
{
    public partial class Index
    {
        [Inject] HttpClient _brandClient { get; set; }
        [Inject] IJSRuntime _js { get; set; }

        [Parameter] public int id { get; set; }
        VehicleColor colour = new VehicleColor();

        private List<Brand> BrandModel;

        protected async override Task OnInitializedAsync()
        {
            BrandModel = await _brandClient.GetFromJsonAsync<List<Brand>>($"{EndPoints.BrandEndPoints}");// ("api/Brands");
        }
        async Task DeleteBrand(int BrandId)
        {
            var Brand = BrandModel.Find(b => b.Id == BrandId);
            var confirm = await _js.InvokeAsync<bool>("confirm", $"Do you want to delete { Brand.BrandName } ?");
            if (confirm)
            {
                await _brandClient.DeleteAsync($"{EndPoints.BrandEndPoints}/{BrandId}");
                await OnInitializedAsync();
            }
        }
    }
}

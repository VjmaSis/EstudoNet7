using Microsoft.AspNetCore.Components;
using Radzen;
using System.Net.Http.Json;

namespace EstudoBlazor.Client.Pages.Categoria
{
    public partial class Editar
    {
        [Inject]
        HttpClient _http { get; set; }

        [Inject]
        NavigationManager _navigation { get; set; }
        
        [Inject]
        NotificationService _notificationService { get; set; }


        EstudoBlazor.Shared.Models.Categoria? categoria = new();


        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            categoria = await _http.GetFromJsonAsync<EstudoBlazor.Shared.Models.Categoria?>($"api/categoria/{Id}");
        }

        async void EditarCategoria()
        {
            await _http.PutAsJsonAsync<EstudoBlazor.Shared.Models.Categoria>("api/categoria", categoria);
            ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Atualização", Detail = "Categoria atualizada com sucesso", Duration = 5000 });
            Voltar();
        }

        void ShowNotification(NotificationMessage message)
        {
            _notificationService.Notify(message);
        }

        void Voltar()
        {
            _navigation.NavigateTo("/categoria");
        }
    }
}

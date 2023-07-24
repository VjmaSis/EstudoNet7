using Microsoft.AspNetCore.Components;
using Radzen;
using System.Net.Http.Json;

namespace EstudoBlazor.Client.Pages.Categoria
{
    public partial class Inserir
    {
        [Inject]
        HttpClient _http { get; set; }

        [Inject]
        NavigationManager _navigation { get; set; }

        [Inject]
        NotificationService _notificationService { get; set; }
        
        private EstudoBlazor.Shared.Models.Categoria categoria = new();

        async void InserirCategoria()
        {
            await _http.PostAsJsonAsync<EstudoBlazor.Shared.Models.Categoria>("api/categoria", categoria);
            ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Cadastro", Detail = "Categoria cadastrada com sucesso", Duration = 5000 });
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

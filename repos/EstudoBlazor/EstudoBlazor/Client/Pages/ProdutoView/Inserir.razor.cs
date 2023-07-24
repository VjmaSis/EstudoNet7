using EstudoBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using Radzen;
using System.Net.Http.Json;

namespace EstudoBlazor.Client.Pages.ProdutoView
{
    public partial class Inserir
    {
        [Inject]
        HttpClient _http { get; set; }

        [Inject]
        NavigationManager _navigation { get; set; }

        [Inject]
        NotificationService _notificationService { get; set; }

        private Produto produto = new();
        public List<EstudoBlazor.Shared.Models.Categoria> Categorias { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Categorias = await _http.GetFromJsonAsync<List<EstudoBlazor.Shared.Models.Categoria>>("api/categoria");
        }

        async void InserirProduto()
        {
            await _http.PostAsJsonAsync<Produto>("api/produto", produto);
            ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Success, Summary = "Cadastro", Detail = "Produto cadastrado com sucesso", Duration = 5000 });
            Voltar();
        }

        void ShowNotification(NotificationMessage message)
        {
            _notificationService.Notify(message);

        }

        void Voltar()
        {
            _navigation.NavigateTo("/produtos");
        }
    }
}

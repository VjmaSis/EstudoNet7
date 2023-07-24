using Microsoft.AspNetCore.Components;
using Radzen;
using System.Net.Http.Json;


namespace EstudoBlazor.Client.Pages.Categoria
{
    public partial class Listar
    {
        [Inject]
        HttpClient _http { get; set; }
        
        [Inject]
        NavigationManager _navigation { get; set; }
        
        [Inject]
        DialogService _dialogService { get; set; }
        
        [Inject]
        NotificationService _notificationService { get; set; }

        List<EstudoBlazor.Shared.Models.Categoria>? categorias;

        int categoriaid;

        string pagingSummaryFormat = "Página {0} de {1} (total {2} registros)";

        private void NavegarParaIserir()
        {
            _navigation.NavigateTo("/categoria/inserir");
        }

        private void EditarCategoria(int id)
        {
            _navigation.NavigateTo($"/categoria/editar/{id}");
        }

        protected override async Task OnInitializedAsync()
        {
            await CarregarCategorias();
        }


        async Task CarregarCategorias()
        {
            categorias = await _http.GetFromJsonAsync<List<EstudoBlazor.Shared.Models.Categoria>>("api/categoria");
        }

        async Task Deletar(int id)
        {
            categoriaid = id;

            var result = await _dialogService.Confirm("Deseja realmente excluir a categoria?", "Exclusão Categoraia", new ConfirmOptions() { OkButtonText = "Sim", CancelButtonText = "Não" });
            if (result.HasValue && result.Value)
            {
                await ConfirmaDeletar();
            }

        }

        async Task ConfirmaDeletar()
        {
            await _http.DeleteAsync($"api/categoria/{categoriaid}");
            await CarregarCategorias();
            ShowNotification(new NotificationMessage { Severity = NotificationSeverity.Info, Summary = "Exclusão", Detail = "Categoria excluída com sucesso", Duration = 5000 });
        }

        void ShowNotification(NotificationMessage message)
        {
            _notificationService.Notify(message);
        }
    }
}

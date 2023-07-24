using EstudoBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace EstudoBlazor.Client.Pages.ProdutoView
{
    public partial class Listar
    {
        [Inject]
        public HttpClient Http { get; set; }

        [Inject]
        public NavigationManager Navigation { get; set; }

        List<Produto>? Produtos { get; set; }

        string pagingSummaryFormat = "Página {0} de {1} (total {2} registros)";

        protected override async Task OnInitializedAsync()
        {
            Produtos = await Http.GetFromJsonAsync<List<Produto>>("api/produto");
        }
        private void EditarProduto(int id)
        {
            //_navigation.NavigateTo($"/categoria/editar/{id}");
        }
        async Task Deletar(int id)
        {

        }
        private void NavegarParaIserir()
        {
            Navigation.NavigateTo("/produto/inserir");
        }
    }
}

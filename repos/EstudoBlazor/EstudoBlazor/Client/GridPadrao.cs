using Radzen;
using Radzen.Blazor;

namespace EstudoBlazor.Client
{
    public static class GridPadrao<T> where T : class
    {
        public static RadzenDataGrid<T> Configurar()
        {
            var test = new RadzenDataGrid<T>();

            test.AllowFiltering = true;
            test.AllowColumnResize = true;
            test.AllowAlternatingRows = false;
            test.AllowSorting = true;
            test.PageSize = 5;
            test.AllowPaging = true;
            test.FilterCaseSensitivity = FilterCaseSensitivity.CaseInsensitive;
            test.FilterText = "Filtro";
            test.ApplyFilterText = "Buscar";
            test.AndOperatorText = "E";
            test.OrOperatorText = "Ou";
            test.ClearFilterText = "Limpar";
            test.EqualsText = "Igual";
            test.NotEqualsText = "Não igual";
            test.LessThanText = "Menor que";
            test.LessThanOrEqualsText = "Menor ou igual que";
            test.GreaterThanText = "Maior que";
            test.GreaterThanOrEqualsText = "Maior ou igual que";
            test.EndsWithText = "Termina com";
            test.ContainsText = "Contem";
            test.DoesNotContainText = "Não contém";
            test.StartsWithText = "Inicia com";
            test.IsNotNullText = "Não é nulo";
            test.IsNullText = "É nulo";
            test.IsEmptyText = "É vazio";
            test.IsNotEmptyText = "Não é vazio";
            test.PagingSummaryFormat = "Página {0} de {1} (total {2} registros)";
            test.ShowPagingSummary = true;

            return test;
        }
    }
}

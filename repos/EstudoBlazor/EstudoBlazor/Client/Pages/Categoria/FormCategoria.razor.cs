using Microsoft.AspNetCore.Components;

namespace EstudoBlazor.Client.Pages.Categoria
{
    public partial class FormCategoria
    {
        [Parameter] 
        public EventCallback SubmitCategoria { get; set; }
        [Parameter] 
        public EventCallback Retorno { get; set; }
        [Parameter] 
        public EstudoBlazor.Shared.Models.Categoria? Categoria { get; set; }
        [Parameter] 
        public string Titulo { get; set; } = "Inserir nova categoria";
    }
}

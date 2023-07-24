using EstudoBlazor.Shared.Models;
using Microsoft.AspNetCore.Components;
using Radzen;
using System;

namespace EstudoBlazor.Client.Pages.ProdutoView
{
    public partial class FormProduto
    {
        [Parameter]
        public EventCallback SubmitProduto { get; set; }
        [Parameter]
        public EventCallback Retorno { get; set; }
        [Parameter]
        public Produto? Produto { get; set; }
        [Parameter]
        public string Titulo { get; set; } = "Inserir novo produto";

        [Parameter]
        public List<EstudoBlazor.Shared.Models.Categoria>? Categorias { get; set; }

        string fileName;
        long? fileSize;

        void OnChange(string value, string name)
        {
            //console.Log($"{name} value changed");
        }

        void OnError(UploadErrorEventArgs args, string name)
        {
            //console.Log($"{args.Message}");
        }
    }
}

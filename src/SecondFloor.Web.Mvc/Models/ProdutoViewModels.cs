﻿using System.ComponentModel.DataAnnotations;

namespace SecondFloor.Web.Mvc.Models
{
    public class ProdutoViewModels
    {
        public string Id { get; set; }

        [Display(Name = "Produto / Serviço")]
        public string NomeProduto { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Referência")]
        public string Referencia { get; set; }

        [Display(Name = "Fabricante")]
        public string Fabricante { get; set; }
        
        [Display(Name = "Valor")]
        public string Valor { get; set; }

        public string AnuncianteId { get; set; }

        //TODO: terminar as mensagens de erro
    }
}
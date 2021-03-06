﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SecondFloor.DataContracts.DTO;
using SecondFloor.Web.Mvc.Models;

namespace SecondFloor.Web.Mvc.Services
{
    public static class ProdutoViewModelExtensionMethod
    {
        public static ProdutoViewModels ConvertToProdutoViewModel(this ProdutoDto produtoDto)
        {
            var produtoViewModel = new ProdutoViewModels();

            produtoViewModel.Id = produtoDto.Id;
            produtoViewModel.NomeProduto = produtoDto.NomeProduto;
            produtoViewModel.Descricao = produtoDto.Descricao;
            produtoViewModel.Referencia = produtoDto.Referencia;
            produtoViewModel.Fabricante = produtoDto.Fabricante;
            produtoViewModel.Valor = produtoDto.Valor;
            produtoViewModel.AnuncianteId = produtoDto.AnuncianteId; //facilitar a identificacao do Parent deste objeto

            return produtoViewModel;
        }

        public static ProdutoDto ConvertToProdutoDto(this ProdutoViewModels produtoViewModel)
        {
            var produtoDto = new ProdutoDto();

            produtoDto.Id = produtoViewModel.Id;
            produtoDto.NomeProduto = produtoViewModel.NomeProduto;
            produtoDto.Descricao = produtoViewModel.Descricao;
            produtoDto.Referencia = produtoViewModel.Referencia;
            produtoDto.Fabricante = produtoViewModel.Fabricante;
            produtoDto.Valor = produtoViewModel.Valor;

            return produtoDto;
        }

        public static IList<ProdutoViewModels> ConvertToListaProdutosViewModel(this IList<ProdutoDto> produtosDto)
        {
            var produtosViewModel = produtosDto.Select(x => x.ConvertToProdutoViewModel()).ToList();

            return produtosViewModel;
        }

        
    }
}
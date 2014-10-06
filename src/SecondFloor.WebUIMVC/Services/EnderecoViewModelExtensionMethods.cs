﻿using System.Collections.Generic;
using System.Linq;
using SecondFloor.DataContracts.DTO;
using SecondFloor.WebUIMVC.Models;

namespace SecondFloor.WebUIMVC.Services
{
    public static class EnderecoViewModelExtensionMethods
    {
        public static EnderecoViewModels ConvertToEnderecoViewModel(this EnderecoDto enderecoDto)
        {
            var enderecoViewModel = new EnderecoViewModels();
            enderecoViewModel.Logradouro = enderecoDto.Logradouro;
            enderecoViewModel.Numero = int.Parse(enderecoDto.Numero);
            enderecoViewModel.Complemento = enderecoDto.Complemento;
            enderecoViewModel.Bairro = enderecoDto.Bairro;
            enderecoViewModel.Cidade = enderecoDto.Cidade;
            enderecoViewModel.Estado = enderecoDto.Estado;
            enderecoViewModel.Cep = enderecoDto.Cep;

            return enderecoViewModel;
        }

        public static EnderecoDto ConvertToEnderecoDto(this EnderecoViewModels enderecoViewModel)
        {
            var enderecoDto = new EnderecoDto();
            enderecoDto.Logradouro = enderecoViewModel.Logradouro;
            enderecoDto.Numero = enderecoViewModel.Numero.ToString();
            enderecoDto.Complemento = enderecoViewModel.Complemento;
            enderecoDto.Bairro = enderecoViewModel.Bairro;
            enderecoDto.Cidade = enderecoViewModel.Cidade;
            enderecoDto.Estado = enderecoViewModel.Estado;
            enderecoDto.Cep = enderecoViewModel.Cep;

            return enderecoDto;
        }

        public static IList<EnderecoViewModels> ConvertToListaEnderecosViewModel(this IList<EnderecoDto> enderecosDto)
        {
            var enderecosViewModel = enderecosDto.Select(x => x.ConvertToEnderecoViewModel()).ToList();

            return enderecosViewModel;
        }
    }
}
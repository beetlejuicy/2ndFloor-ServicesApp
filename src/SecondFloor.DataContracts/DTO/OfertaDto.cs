﻿namespace SecondFloor.DataContracts.DTO
{
    public class OfertaDto
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public EnderecoDto Endereco { get; set; }
    }
}
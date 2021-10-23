using System;

namespace UStart.Domain.Commands
{
    public class ClienteCommand
    {
        public Guid Id {get; private set; }
        public string CodigoExterno {get; private set; }
        public bool Ativo {get; private set; }
        public String Nome {get; private set; }
        public String RazaoSocial {get; private set; }
        public String CPF {get; private set; }
        public String CNPJ {get; private set; }
        public String Rua {get; private set; }
        public String Numero {get; private set; }
        public String Complemento {get; private set; }
        public String Bairro {get; private set; }
        public String EstadoId {get; private set; }
        public String CidadeId {get; private set; }
        public String CidadeNome {get; private set; }
        public String CEP {get; private set; }
        public String Fone {get; private set; }
        public String Email {get; private set; }
        public Decimal LimiteDeCredito {get; private set; }
    }
}
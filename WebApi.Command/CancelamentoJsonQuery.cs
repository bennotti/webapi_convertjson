using System;

namespace WebApi.Command
{
    public class CancelamentoJsonCommand : ICommand
    {
        public string CPF { get; set; }
        public string NumeroAvaliacao { get; set; }
    }
}

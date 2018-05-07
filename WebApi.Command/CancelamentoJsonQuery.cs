using System;

namespace WebApi.Command
{
    public class CancelamentoJsonCommand : ICommandQuery
    {
        public string CPF { get; set; }
        public string NumeroAvaliacao { get; set; }
    }
}

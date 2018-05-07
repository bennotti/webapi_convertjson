using System;

namespace WebApi.Command
{
    public class CancelamentoJsonComand : ICommandQuery
    {
        public string CPF { get; set; }
        public string NumeroAvaliacao { get; set; }
    }
}

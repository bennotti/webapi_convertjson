using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WebApi.Query.Result;

namespace WebApi.Query.Handler
{
    public class ObterCancelamentosPendentesQueryHandler : IQueryHandler<ObterCancelamentoPendentesQuery, IEnumerable<ObterCancelamentoPendentesQueryResult>>
    {
        public IList<ObterCancelamentoPendentesQueryResult> Result;

        public ObterCancelamentosPendentesQueryHandler()
        {
            Result = new List<ObterCancelamentoPendentesQueryResult>();
        }

        public IEnumerable<ObterCancelamentoPendentesQueryResult> Handle(ObterCancelamentoPendentesQuery query)
        {
            var fileEntries = Directory.GetFiles(query.PathModulo);
            foreach (var file in fileEntries)
            {
                Result.Add(JsonConvert.DeserializeObject<ObterCancelamentoPendentesQueryResult>(File.ReadAllText(file)));
            }

            return Result;
        }
    }
}

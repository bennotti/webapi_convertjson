using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Web.Http;
using WebApi.Command;
using WebApi.Command.Handler;
using WebApi.Presentation.ViewModel;
using WebApi.Query;
using WebApi.Query.Handler;

namespace WebApi.Presentation.Controllers
{
    public class CancelamentoController : ApiController
    {
        
        private ObterCancelamentosPendentesQueryHandler queryHandler;
        private string processamentoDados;
        private string pathModulo;
        public CancelamentoController()
        {
            processamentoDados = HostingEnvironment.MapPath("~/ProcessamentoDados");
            pathModulo = Path.Combine(processamentoDados, "Cancelamento", "Processar");
            queryHandler = new ObterCancelamentosPendentesQueryHandler();
        }

        // GET: api/Cancelamento
        public HttpResponseMessage Get()
        {
            var result = queryHandler.Handle(new ObterCancelamentoPendentesQuery(pathModulo));
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        // POST: api/Cancelamento
        public HttpResponseMessage Post(CancelamentoViewModel cancelamento)
        {
            var guid = Guid.NewGuid();
            var caminhoArquivo = Path.Combine(pathModulo, guid + ".json");

            try
            {
                var CancelamentoCommandHandler = new CancelamentoCommandHandler(new CancelamentoJsonCommand
                {
                    CPF = cancelamento.CPF,
                    NumeroAvaliacao = cancelamento.NumeroAvaliacao
                }, caminhoArquivo);

                Task.Run(() => CancelamentoCommandHandler.SaveObjectJson());

                return Request.CreateResponse(HttpStatusCode.Created, new
                {
                    queueId = guid
                });
            }
            catch (HttpRequestException ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new
                {
                    Error = ex
                });
            }
        }

        // PUT: api/Cancelamento/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cancelamento/5
        public void Delete(int id)
        {
        }
    }
}

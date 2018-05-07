using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Command.Handler
{
    public interface ICommandHandler<ICommandQuery>
    {
        void Handler();
    }
}

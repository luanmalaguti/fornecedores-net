using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebService.Controllers;
using WebService.Models;

namespace WebService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IWsFornecedores" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IWsFornecedores.svc or IWsFornecedores.svc.cs at the Solution Explorer and start debugging.
    public class IWsFornecedores : IIWsFornecedores
    {
        FornecedoresController controller = new FornecedoresController();

        public FornecedorDB[] GetAll()
        {
            return controller.getAll();
        }
    }
}

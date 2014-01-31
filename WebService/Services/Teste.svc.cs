using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Teste" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Teste.svc or Teste.svc.cs at the Solution Explorer and start debugging.
    public class Teste : ITeste
    {
        public string Print()
        {
            return "Djeison gay";
        }
    }
}

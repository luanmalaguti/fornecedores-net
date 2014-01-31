using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using WebService.Models;

namespace WebService.Controllers
{
    interface IController<T, E>
    {
        E[] getAll();

        E ToDataMember(T t);
    }
}

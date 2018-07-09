using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using codeFirst2.DataLayer.Repositories;

namespace codeFirst2.DataLayer.HttpHelper
{
    public class TestHendler : HttpHendlerRequestGeneric<Layer>
    {
        public TestHendler(GenericRepository<Layer> repository) : base(repository)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeExample
{
    public class AbstractFileClass : IDisposable
    {
        public void Dispose()
        {

        }

        protected virtual void Dispose(bool isDisposing)
        {

        }
    }
}

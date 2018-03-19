using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exception
{
  [Serializable]
  public class ApontamentoException : System.Exception
  {
    public ApontamentoException()
    {
    }

    public ApontamentoException(string message) : base(message)
    {
    }

    public ApontamentoException(string message, System.Exception innerException) : base(message, innerException)
    {
    }

    protected ApontamentoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }

}

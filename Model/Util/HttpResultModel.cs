using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Util
{
  public class HttpResultModel
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="HttpResultModel" /> class.
    /// </summary>
    /// <param name="operationSuccess">Indicates whether operation was executed with success</param>
    /// <param name="message">Result message</param>
    public HttpResultModel(bool operationSuccess, string message)
    {
      this.OperationSuccess = operationSuccess;
      this.ResultMessage = message;
      this.Data = null;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="HttpResultModel" /> class.
    /// </summary>
    /// <param name="operationSuccess">Indicates whether operation was executed with success</param>
    /// <param name="message">Result message</param>
    /// <param name="data">Object returned by operation</param>
    public HttpResultModel(bool operationSuccess, string message, object data)
    {
      this.OperationSuccess = operationSuccess;
      this.ResultMessage = message;
      this.Data = data;
    }

    /// <summary> Gets or sets a value indicating whether operation was success (even if the Http is 200, the operation can fail) </summary>
    public bool OperationSuccess { get; set; }

    /// <summary> Gets or sets the message of the Http Result </summary>
    public string ResultMessage { get; set; }

    /// <summary> Gets or sets the data object of the Http Result </summary>
    public object Data { get; set; }
  }
}

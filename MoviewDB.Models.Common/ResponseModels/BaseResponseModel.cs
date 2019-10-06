using System.Net;
using System.Runtime.Serialization;

namespace MoviewDB.Models.Common.ResponseModels
{

    public class BaseResponseModel
    {

        [DataMember]
        public HttpStatusCode HttpStatusCode { get; set; }

        [DataMember]
        public string ExeptionMessage { get; set; }

        [DataMember]
        public object Data { get; set; }
    }



}






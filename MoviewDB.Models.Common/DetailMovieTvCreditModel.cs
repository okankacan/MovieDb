using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MoviewDB.Models.Common
{
    [DataContract]
    public class DetailMovieTvCreditModel
    {
        [DataMember]
        public List<Cast> cast { get; set; }

        [DataMember]
        public List<Crew> crew { get; set; }
    }
    [DataContract]
    public class Crew
    {
        [DataMember]

        public string credit_id { get; set; }
        [DataMember]

        public string department { get; set; }
        [DataMember]

        public int id { get; set; }
        [DataMember]

        public string name { get; set; }
        [DataMember]

        public int? gender { get; set; }
        [DataMember]

        public string profile_path { get; set; }
        [DataMember]

        public int order { get; set; }
    }

    [DataContract]
    public class Cast
    {
        [DataMember]
        public string character { get; set; }
        [DataMember]
        public string credit_id { get; set; }
        [DataMember]

        public int? gender { get; set; }
        [DataMember]

        public string name { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string profile_path { get; set; }
        [DataMember]

        public int order { get; set; }
    }
}
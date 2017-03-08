using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace xjob.HelperClasses
{
    public class FacebookDataContract
    {
        [DataContract]
        public class Data
        {
            [DataMember]
            public bool is_silhouette { get; set; }
            [DataMember]
            public string url { get; set; }
        }
        [DataContract]
        public class Picture
        {
            [DataMember]
            public Data data { get; set; }
        }
        [DataContract]
        public class RootObject
        {
            [DataMember]
            public Picture picture { get; set; }
            [DataMember]
            public string id { get; set; }
        }
    }
}

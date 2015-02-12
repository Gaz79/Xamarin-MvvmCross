using System;
using System.Runtime.Serialization;

namespace XamCross.Models
{
    [DataContract]
    public class Menu
    {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Icon { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public Type ViewModelType { get; set; }
    }
}
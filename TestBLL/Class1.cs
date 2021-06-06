using Newtonsoft.Json;
using System;

namespace TestBLL
{
    public class Class1
    {
        [JsonProperty(PropertyName ="SomethingProp")]
        public int Something { get; set; }
    }
}

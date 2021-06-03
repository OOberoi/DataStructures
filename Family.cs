using Newtonsoft.Json;
using System.Text.Json;

namespace Models
{
    public class Family
    {
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("addressLine")]
        public string AddressLine { get; set; }

        [JsonProperty("citys")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipCodes")]
        public string ZipCode { get; set; }

        [JsonProperty("fatherName")]
        public string FatherName { get; set; }

        [JsonProperty("motherName")]
        public string MotherName { get; set; }

        [JsonProperty("firstChild")]
        public string FirstChild { get; set; }

        [JsonProperty("secondChild")]
        public string SecondChild { get; set; }

        [JsonProperty("thirdChilds")]
        public string ThirdChild { get; set; }

        [JsonProperty("fourthChild")]
        public string FourthChild { get; set; }

        [JsonProperty("fifthChild")]
        public string FifthChild { get; set; }

        [JsonProperty("firstPet")]
        public string FirstPet { get; set; }

        [JsonProperty("secondPet")]
        public string SecondPet { get; set; }

        [JsonProperty("thirdPet")]
        public string ThirdPet { get; set; }
    }
}

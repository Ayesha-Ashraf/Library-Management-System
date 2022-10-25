using System.Text.Json;
using System.Text.Json.Serialization;
namespace Library_Management__System.Model
{
    public class Book
    {
        [JsonPropertyName("id")]
        public int book_id { get; set; }
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }
        //save the Data Back To file????
        public override string ToString()
        {
            return JsonSerializer.Serialize<Book>(this);
        }
    }
}


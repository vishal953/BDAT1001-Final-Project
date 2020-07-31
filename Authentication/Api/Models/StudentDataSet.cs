using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Api.Models
{
    public class StudentDataSet  
    {
        public StudentDataSet() {
            this.studentResults= JsonConvert.DeserializeObject <List<StudentResult>>(File.ReadAllText(@"Dataset.json"));
        }
       public List <StudentResult> studentResults { get; set; }
    }
}

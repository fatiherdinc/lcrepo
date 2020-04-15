using System.Collections.Generic;
using Amazon.Lambda.Core;
using Entities;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace CrudService
{
    public class Get
    {
        public List<Person> GetList()
        {
            var list = new List<Person>();
            
            list.Add(new Person
            {
                Name = "Fatih",
                Surname = "Erdinç"
            });
            
            list.Add(new Person
            {
                Name = "Yavuz",
                Surname = "Erdinç"
            });

            return list;
        }
    }
}
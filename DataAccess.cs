using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;


namespace DapperPractice
{
    class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            // open connection but 'using' means will dipose after receiving data
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("SampledB"));
            {
                // return connection.Query<Person>($"select * from People where LastName = '{ lastName }'").ToList();
                return connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValue("SampledB"));
            {
                //Person newPerson = new Person
                //{
                //    FirstName = firstName,
                //    LastName = lastName,
                //    EmailAddress = emailAddress,
                //    PhoneNumber = phoneNumber
                //};

                // create list of people to be inserted
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });

                // insert into database
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }
    }
}

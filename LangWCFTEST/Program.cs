using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LangWCFTEST.ServiceQ;

namespace LangWCFTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            LangWCFTEST.ServiceQ.QuestionsServiceClient client=new QuestionsServiceClient();
            Session session = client.MakeSession(DateTime.Now,
                new Student()
                {
                    ForName = "sdf",
                    Id = 1,
                    Name = "dfd",
                    Password = "dsfdsf",
                    StudentNbr = "5446",
                    Username = "benoit"
                });
            Console.WriteLine(session.Student.StudentNbr);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employer : User
    {
        private string post;
        public string Post
        {
            get { return post; }
            set
            {
                if (!(String.IsNullOrWhiteSpace(value)))
                {
                    post = value;
                }
                else
                {
                    throw new AggregateException("Post error");
                }
            }
        }
        private int experience;
        public int Experience
        {
            get { return experience; }
            set
            {
                if (value > 0)
                {
                    experience = value;
                }
                else
                {
                    throw new AggregateException("Post error");
                }
            }
        }
        public void GetInformation(Employer employer)
        {
            User user = employer;
            GetInformation(user);
            Console.WriteLine("|{0,-20}|{1,-10}|", "Post", employer.Post);
            Console.WriteLine(new string('-', 33));
            Console.WriteLine("|{0,-20}|{1,-10}|", "Experience", employer.Experience);
            Console.WriteLine(new string('-', 33));
        }
        public Employer(string name, string secondName, DateTime dateTime,int experience, string post)
            : base(name,dateTime, secondName)
        {
            Experience = experience;
            Post = post;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadShot
{
    class Contact
    {
        string name;
        string email;
        string question;
  

        void setName(string name) { this.name = name; }
        string getName() { return this.name; }

        void setEmail(string em) { this.email = em; }
        string getEmail() { return this.email; }

        void setQuestion(string quest) { this.question = quest; }
        string getQuestion() { return this.question; }




    }
}

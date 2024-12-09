using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Demo1.Data
{
    public class ContactService
    {

        List<Contact> contacts = new List<Contact>()
        {
            new Contact{ID=1,Name="Om",Address="Mumbai"},
            new Contact{ID=2,Name="Pm",Address="Mumbai"},
            new Contact{ID=3,Name="LM",Address="Mumbai"},
            new Contact{ID=4,Name="Om",Address="Mumbai"},

        };


        public List<Contact>GetContacts()
        {
            return contacts;
        }
    }
}

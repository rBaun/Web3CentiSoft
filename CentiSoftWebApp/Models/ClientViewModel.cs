using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentiSoftWebApp.Models
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }

        public ClientViewModel()
        {

        }

        public ClientViewModel(int id, string name, string token)
        {
            Id = id;
            Name = name;
            Token = token;
        }
    }
}

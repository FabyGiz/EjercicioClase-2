using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cat : Animal //hereda de animal. En caso de querer usar una interfaz se pone , y el nombre de la interfaz
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime BirthDate { get; set; }


        public Cat() { }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWinForm.Paterns
{
    
    class MyCity
    {
        public static List<City> lst;
        static MyCity MyInstance;
        private MyCity()
        {

        }
        public static MyCity CreateOrGetInstanse(int Id = 0, string Name = "")
        {
            if (MyInstance == null)
            {
                MyInstance = new MyCity();
                lst = new List<City>()
                {
                    new City{Id = 1, Name = "Astana"},
                    new City{Id = 2, Name = "Almaty"},
                    new City{Id = 3, Name = "Shymkent"}
                };
                return MyInstance;
            }

            lst.Add(new City { Id = Id, Name = Name });
            return MyInstance;
        }
    }

    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models.Data
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<Student> StudentsList;
        private Singleton()
        {
            StudentsList = new List<Student>();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}

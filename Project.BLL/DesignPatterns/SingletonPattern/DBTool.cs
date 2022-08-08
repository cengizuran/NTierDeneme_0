using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.SingletonPattern
{
    internal class DBTool
    {
        DBTool() { }

        public DBTool()
        {
            if (_dbInstance is null) _dbInstance = new MyContext();
            return _dbInstance;
        }

        public static MyContext DBInstance { get; set; }
    }
}

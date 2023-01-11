using Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Databases
{
    internal class MsSql : Database
    {
        public override void Create(Data data)
        {
            Console.WriteLine($"MsSql melumati elave etdi!");
            var maxId = datas.Count > 0 ? datas.Max(d => d.Id) : 0;
            data.Id = ++maxId;
            datas.Add(data);
        }

        public override bool Delete(int id)
        {
            Console.WriteLine($"MsSql {id}li melumati sildi!");
            var data = datas.FirstOrDefault(d => d.Id == id);
            return datas.Remove(data);
        }

        public override Data? Read(int id)
        {
            Console.WriteLine($"MsSql {id}li melumati qaytardi!");
            return datas.FirstOrDefault(d => d.Id == id);
        }

        public override void Update(int id)
        {
            Console.WriteLine($"MsSql {id}li melumati deyishdirdi!");
        }
    }
}

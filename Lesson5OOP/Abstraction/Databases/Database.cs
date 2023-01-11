using Abstraction.Models;

namespace Abstraction.Databases
{
    internal abstract class Database
    {
        protected readonly static List<Data> datas = new();
        public abstract void Create(Data data);
        public abstract Data? Read(int id);
        public abstract void Update(int id);
        public abstract bool Delete(int id);
    }
}

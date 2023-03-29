using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    abstract class Animal
    {
        public abstract string Run();
    }

    abstract class Pet : Animal
    {
        public abstract string Feed();
    }

    class Wolf : Animal
    {
        public override string Run()
        {
            throw new NotImplementedException();
        }
    }

    class Dog : Pet
    {
        public override string Feed()
        {
            throw new NotImplementedException();
        }

        public override string Run()
        {
            throw new NotImplementedException();
        }
    }

    interface IAdmin : IUser
    {
        void DeleteUser();

    }

    interface IUser
    {
        void Like();
        void AddComment();
        void RemoveComment();
    }

    class User : IUser
    {
        public void AddComment()
        {
            throw new NotImplementedException();
        }

        public void Like()
        {
            throw new NotImplementedException();
        }

        public void RemoveComment()
        {
            throw new NotImplementedException();
        }
    }

    class Modertor { }

    class Admin : IAdmin
    {
        public void AddComment()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public void Like()
        {
            throw new NotImplementedException();
        }

        public void RemoveComment()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace WpfApp1
{

    public class UserRepository<T> : IUserRepository
    {
        protected readonly DbContext context;

        public UserRepository(ApplicationContext context)
        {
            this.context = context;
            //context.Set<T>.Add();
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Customers.ToList();
        }
        public User GetUserByID(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public void InsertUser(User customer)
        {
            context.Customers.Add(customer);
        }

        public void DeleteUser(int customerId)
        {
            User customer = context.Customers.Find(customerId);
            context.Customers.Remove(customer);
        }

        public void UpdateUser(User customer)
        {
            context.Entry(customer).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

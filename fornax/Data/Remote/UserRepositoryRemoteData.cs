using fornax.Core.Entities;
using fornax.Core.Repositories;
using fornax.Infra.DB.Models;
using System.Collections.Generic;
using System.Linq;

namespace fornax.Data.Remote
{
    public class UserRepositoryRemoteData : UserRepository
    {
        private readonly UserContext context;
        public override void create(User data)
        {
            context.Users.Add(data);
            context.SaveChanges();
        }

        public override void delete(int id)
        {
            var user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public override User get(int id)
        {
            return context.Users.Find(id);
        }

        public override List<User> getAll()
        {
            return context.Users.ToList<User>();
        }

        public override void update(int id, User data)
        {
            var userToUpdate = context.Users.Find(id);
            data.Id = id;
            if (userToUpdate != null)
            {
                userToUpdate.Name = data.Name;
                userToUpdate.Email = data.Email; 
                userToUpdate.Pass = data.Pass;
            }
            context.SaveChanges();
        }
    }
}

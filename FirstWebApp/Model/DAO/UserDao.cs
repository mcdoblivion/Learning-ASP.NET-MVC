using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EntityFramework;

namespace Model.DAO
{
    public class UserDao
    {
        private OnlineShopDbContext db = null;

        public UserDao()
        {
            db = new OnlineShopDbContext();
        }

        public long Insert(users user)
        {
            db.users.Add(user);
            db.SaveChanges();
            return user.ID;
        }

        public users GetByUserName(string userName)
        {
            return db.users.SingleOrDefault(x => x.UserName == userName);
        }

        public bool Login(string userName, string password)
        {
            var result = db.users.Count(x => x.UserName == userName && x.Password == password);
            if (result > 0) return true;
            return false;
        }
    }
}
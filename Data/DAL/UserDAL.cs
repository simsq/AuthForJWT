using Dapper;
using Kudi.Core.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class UserDAL
    {
        private readonly DbBase dbContext;
        public UserDAL(string connName)
        {
            dbContext = new DbBase(connName);
        }
        #region 增删改查
        public User Add(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException($"{nameof(user)} is null");
            }
            using (var conn = dbContext.DbConnecttion)
            {
                var sql = @"INSERT INTO User (Username,Password) VALUES (@Username,@Password);SELECT * from User where Username='@Username';";

                return conn.Query<User>(sql, user).FirstOrDefault();
            }
        }

        public bool Delete(int id, bool isPhysics = false)
        {
            using (var conn = dbContext.DbConnecttion)
            {
                var sql = isPhysics ? $"delete from User where Id={id};" : $"update User set isDelete =1 where Id ={id};";
                return conn.Execute(sql)>0;
            }
        }

        public User Update(User user)
        {
            using (var conn = dbContext.DbConnecttion)
            {

                    return null;
            }

        }
        #endregion
    }
}

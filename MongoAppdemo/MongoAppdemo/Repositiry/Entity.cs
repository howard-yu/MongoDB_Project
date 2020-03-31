using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;
using System.Data;
using System.Data.Entity;
using System.Web;

namespace MnogoApp.Repositiry
{
    public static class Entity<T> where T : class
    {
        private static string KeyName
        {
            get
            {
                return typeof(T).Name;
            }
        }

        public static T NewDb()
        {
            dynamic db = Activator.CreateInstance<T>();

            var dbContext = (DbContext)db;
            dbContext.Configuration.ProxyCreationEnabled = false;
            dbContext.Configuration.LazyLoadingEnabled = false;
            return dbContext as T;
        }

        public static void SetDb(DbContext db)
        {
            SetRequestDb(db);
        }

        public static T Db()
        {
            return GetPerWebRequestDb();
        }

        private static T GetPerWebRequestDb()
        {
            if (HttpContext.Current == null)
            {
                //if the web context is null (none web environment)
                //turn to use the Thread Context
                return GetPerThreadContextDb();
            }
            var dbContext = HttpContext.Current.Items[KeyName];
            if (dbContext != null)
            {
                return dbContext as T;
            }
            var db = NewDb();
            HttpContext.Current.Items[KeyName] = db;
            return db;
        }

        private static T GetPerThreadContextDb()
        {
            if (HttpContext.Current != null)
            {
                //In web environment and dbContext doesn't exist in Thread, use the HTTPContext first. 
                //We must consider some special IIS infra such as the Global.asax and IHTTPModule
                return GetPerWebRequestDb();
            }
            var dbContext = CallContext.GetData(KeyName);
            if (dbContext != null)
            {
                return dbContext as T;
            }
            var db = NewDb();
            CallContext.SetData(KeyName, db);
            return db;
        }

        private static void SetRequestDb(DbContext db)
        {
            if (HttpContext.Current == null)
            {
                CallContext.SetData(KeyName, db);
            }
            else
            {
                HttpContext.Current.Items[KeyName] = db;
            }
        }

        public static void Close()
        {
            T db = null;
            var keyName = typeof(T).Name;
            var currentContext = HttpContext.Current.Items[keyName];
            if (currentContext != null)
            {
                db = currentContext as T;
            }
            if (db != null)
            {
                var dbContext = Db() as DbContext;
                if (dbContext.Database.Connection.State == ConnectionState.Open)
                {
                    dbContext.Database.Connection.Close();
                }
            }
        }
    }
}

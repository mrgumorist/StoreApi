using StoreApi.DB;
using StoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StoreApi.Services
{
    public static class MyService
    {
        static DataContext context = new DataContext();
        public static List<Person> GetAllUsers()
        {
            return context.Users.ToList();
        }
        public async static Task<bool> Login(string login, string password)
        {
            if(context.Users.First(x=>x.Login==login).PassWord==password)
            {
                return true;
            }
            return false;
        }
        public async static Task SetLogin(string login, string password)
        {
            context.Users.First(x => x.Login == login && x.PassWord == password).LastLogin = DateTime.Now;
            await context.SaveChangesAsync();
        }
        public async static Task<string> GetTypeOfAccount(string login, string password)
        {
            return context.Users.First(x => x.Login == login && x.PassWord == password).Type;
        }
        public async static Task<string> GetID(string login, string password)
        {
            return context.Users.First(x => x.Login == login && x.PassWord == password).Id.ToString();
        }
    }
}
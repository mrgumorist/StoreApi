using StoreApi.DB;
using StoreApi.Models;
using StoreApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace StoreApi.Controllers
{
    public class ApiiController : ApiController
    {
        //[HttpPost]
        [HttpGet]
        public IEnumerable<string> Values()
        {
            return new string[] { "value1", "value2" };
        }
        public List<Person> GetStudents()
        {
            return MyService.GetAllUsers();
        }
        [HttpGet]
        public async Task<string> Login([FromBody]object jsonData)
        {
            var re = Request;
            var headers = re.Headers;

            if (headers.Contains("Authorization2"))
            {
                string token = "";
                token = headers.GetValues("Authorization2").First();
                if (token == "Basic dchZ2VudDM6cGFdGVzC5zc3dvmQ=")
                {
                    if (headers.Contains("Username") && headers.Contains("Password"))
                    {
                        string token1 = headers.GetValues("Username").First();
                        string token2 = headers.GetValues("Password").First();
                        if (await MyService.Login(token1, token2))
                        {
                            await MyService.SetLogin(token1, token2);
                            return "Succesfull";
                        }
                        return "Error";
                    }
                    else
                    {
                        return "Error";
                    }

                }
                else
                {
                    return "Error";
                }
            }

            return "Error";

            //}

            //var re = Request;
            //var headers = re.Headers;

            //if (headers.Contains("Custom"))
            //{
            //    string token = headers.GetValues("Custom").First();
            //    return token;
            //}

            //return null;
        }
        [HttpGet]
        public async Task<string> GetTypeOfAccount([FromBody]object jsonData)
        {
            var re = Request;
            var headers = re.Headers;

            if (headers.Contains("Authorization2"))
            {
                string token = "";
                token = headers.GetValues("Authorization2").First();
                if (token == "Basic dchZ2VudDM6cGFdGVzC5zc3dvmQ=")
                {
                    string token1 = headers.GetValues("Username").First();
                    string token2 = headers.GetValues("Password").First();
                    return await MyService.GetTypeOfAccount(token1, token2);
                }
                return "Error";
            }
            else
            {
                return "Error";
            }
        }
        [HttpGet]
        public async Task<string> GetID([FromBody]object jsonData)
        {
            var re = Request;
            var headers = re.Headers;

            if (headers.Contains("Authorization2"))
            {
                string token = "";
                token = headers.GetValues("Authorization2").First();
                if (token == "Basic dchZ2VudDM6cGFdGVzC5zc3dvmQ=")
                {
                    string token1 = headers.GetValues("Username").First();
                    string token2 = headers.GetValues("Password").First();
                    return await MyService.GetID(token1, token2);
                }
                return "Error";
            }
            else
            {
                return "Error";
            }
        }
    }
}

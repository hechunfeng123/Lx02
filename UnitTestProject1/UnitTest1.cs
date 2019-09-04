using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.UserInfo.Instance.UserCheck("Admin"));
        }
         [TestMethod]
        public void TestMethod2() {
            Model.UserInfo user = new Model.UserInfo { userName = "Guest", passWord = "sql.123", type = "管理员" };
            Console.WriteLine(DAL.UserInfo.Instance.Add(user));
            Console.WriteLine(JsonConvert.SerializeObject(DAL.UserInfo.Instance.GetAll()));
            user.qq = "104512708";
            Console.WriteLine(DAL.UserInfo.Instance.Update(user));
            var model = DAL.UserInfo.Instance.GetModel("Guest");
            Console.WriteLine(JsonConvert.SerializeObject(model));
            Console.WriteLine(DAL.UserInfo.Instance.Delete("Guest"));
            var page = DAL.UserInfo.Instance.GetPage(new Model.page { pageIndex = 2, pageSize = 2 });
            Console.WriteLine(JsonConvert.SerializeObject(page));
            Console.WriteLine(DAL.UserInfo.Instance.GetCount());
        }
    }
}

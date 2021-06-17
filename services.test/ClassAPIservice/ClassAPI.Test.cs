using ClassAPI.Controllers;
using ClassAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace services.test.ClassAPIservice
{
    public class ClassAPI
    {
        [Fact]
        public void GetClassTest()
        {
            ClassController classController = new ClassController();          
            var classControllerResponse = classController.Get();
          
            Assert.NotNull(classControllerResponse);
            Assert.IsType<Class>(classControllerResponse);
        }
    }
}

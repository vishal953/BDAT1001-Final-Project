using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentResultController : ControllerBase
    {
        /// <summary>
        /// Dataset 
        /// </summary>
        StudentDataSet studentDataSet { get; set; }
        public StudentResultController()

        {
             this.studentDataSet= new StudentDataSet();
        }
        [Authorize]
        [HttpGet]
        public List<StudentResult> Get()
        {
            return this.studentDataSet.studentResults;
        }


        [Authorize]
        [HttpGet("{id}")]
        public StudentResult Get(int id)
        {
            return this.studentDataSet.studentResults.FirstOrDefault<StudentResult>(d => d.sl_no == id);

        }
    }
}

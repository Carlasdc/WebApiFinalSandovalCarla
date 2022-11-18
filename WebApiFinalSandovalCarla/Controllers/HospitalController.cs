using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFinalSandovalCarla.Data;
using System.Linq;
using WebApiFinalSandovalCarla.Models;
using System.Collections.Generic;

namespace WebApiFinalSandovalCarla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        public DBHospitalAPIContext Context { get; set; }
        public HospitalController(DBHospitalAPIContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public IEnumerable<Hospital> Get()
        {
            //LinqtoEntities Todos los publishers

            List<Hospital> hospitales = (from h in Context.Hospitales
                                          select h).ToList();
            return hospitales;

        }


        [HttpGet("{num_Cama}")]
        public dynamic Get(int num_cama)
        {
            dynamic hospitales =
            (
            from h in Context.Hospitales
            where h.Num_Cama == num_cama
            select new { h.Nombre, h.Telefono, h.Num_Cama }
            );
            return hospitales;

        }

    }
}

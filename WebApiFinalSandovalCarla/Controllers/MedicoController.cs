using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiFinalSandovalCarla.Data;
using WebApiFinalSandovalCarla.Models;

namespace WebApiFinalSandovalCarla.Controllers
{
    [Route("api/medico")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        public DBHospitalAPIContext Context { get; set; }
        public MedicoController(DBHospitalAPIContext context)
        {
            this.Context = context;
        }

        //TRAER TODOS
        [HttpGet]
        public List<Doctor> Get()
        {
            //EF
            List<Doctor> doctores = Context.Doctores.ToList();
            return doctores;
        }

        //TRAER UNO
        [HttpGet("{medicoId}")]
        public Doctor Get(int medicoId)
        {
            //EF
            Doctor doctor = Context.Doctores.Find(medicoId);

            return doctor;
        }

        //INSERTAR 
        [HttpPost]
        public ActionResult Post(Doctor doctor)
        {
            //EF -- memoria
            Context.Doctores.Add(doctor);
            //EF - Guardar en la DB
            Context.SaveChanges();

            return Ok();
        }

        //Eliminar

        [HttpDelete("{id}")]
        public ActionResult<Doctor> Delete(int id)
        {
            //EF
            var doctor = Context.Doctores.Find(id);

            if (doctor == null)
            {
                return NotFound();
            }

            //EF
            Context.Doctores.Remove(doctor);
            Context.SaveChanges();

            return doctor;

        }

        //MODIFICAR
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Doctor doctor)
        {
            if (id != doctor.Doctor_No)
            {
                return BadRequest();
            }

            //EF para modificar en la DB
            Context.Entry(doctor).State = EntityState.Modified;
            Context.SaveChanges();

            return NoContent();
        }



    }
}

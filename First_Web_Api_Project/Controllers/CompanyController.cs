using First_Web_Api_Project.Data;
using First_Web_Api_Project.Models;
using First_Web_Api_Project.Models.DTOs;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace First_Web_Api_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly PharmacyContext db;
        public CompanyController(PharmacyContext _db)
        {
               db = _db;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            return Ok(db.Companies.ToList());
        }

        //[HttpPost]
        //public IActionResult CreateCompany(Company comp)
        //{
        //    if (comp == null)
        //    {
        //        return BadRequest();
        //    }

        //    db.Companies.Add(comp);
        //    db.SaveChanges();
        //    return Ok(comp);
        //}

        [HttpPost]
        public IActionResult AddCompany(CompanyDTO_s comp)
        {
            if (comp != null)
            {
                var company = new Company()
                {
                    CompanyName = comp.CompanyName,
                    Address = comp.Address,
                };

                var newAddCompany = db.Companies.Add(company);
                db.SaveChanges();
                return Ok(newAddCompany.Entity);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult EditCompany(int id,CompanyDTO_s comp)
        {
            if (comp != null && id != null)
            {
                var company = db.Companies.Find(id);
                company.CompanyName = comp.CompanyName;
                company.Address = comp.Address;
                var newAddCompany = db.Companies.Update(company);
                db.SaveChanges();
                return Ok(newAddCompany.Entity);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult DeleteCompany(int id)
        {
            if (id != null)
            {
                var company = db.Companies.Find(id);
                if (company != null)
                {
                    var newAddCompany = db.Companies.Remove(company);
                    db.SaveChanges();
                    return Ok(newAddCompany.Entity);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }

    }
}

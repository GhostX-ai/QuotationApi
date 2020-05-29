using System.Linq;
using Microsoft.AspNetCore.Mvc;
using QuotationApi.Models;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace QuotationApi.Controllers
{
    [ApiController]
    [Route("api/Quotation")]
    public class QuotantionController : ControllerBase
    {
        DataContext _context;
        public QuotantionController(DataContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var li = await _context.Quotations.OrderByDescending(p => p.PubDate).ToListAsync();
            return new JsonResult(li);
        }
        [HttpGet("{id}")]
        public async Task<JsonResult> QuotationInfo(int id)
        {
            var model = _context.Quotations.FirstAsync(q => q.Id == id);
            return new JsonResult(model);
        }
        [HttpPost]
        public ActionResult AddQuotation(Quotation model)
        {
            if (ModelState.IsValid)
            {
                _context.Quotations.Add(model);
                _context.SaveChanges();
                return Ok();
            }
            else
                return BadRequest();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> EditQuotation(Quotation model, int id)
        {
            try
            {
                var lmodel = await _context.Quotations.FirstAsync(p => p.Id == id);
                lmodel.Author = model.Author != "" ? model.Author : lmodel.Author;
                lmodel.QuotationText = model.QuotationText != "" ? model.QuotationText : lmodel.QuotationText;
                lmodel.PubDate = model.PubDate != null ? model.PubDate : lmodel.PubDate;
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteQuotation(int id)
        {
            try
            {
                var model = _context.Quotations.First(p => p.Id == id);
                _context.Quotations.Remove(model);
                _context.SaveChanges();
                return Ok();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}
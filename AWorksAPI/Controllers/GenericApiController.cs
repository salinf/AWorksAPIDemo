using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AWorksDataModels;
using AWorksAPIDemo.ORM;
using AWorksAPI.ExtensionMethods;
using System.Net;
using System.Net.Http;

namespace AWorksAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class GenericApiController<TEntity, TKey> : ControllerBase where TEntity: class, IBaseEntity<int>, new()
    {
        private readonly AdventureWorksContext _context;
        private readonly DbSet<TEntity> _dbset;
        public GenericApiController(AdventureWorksContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        [HttpGet("{id?}")]
        public IActionResult Get(int id)
        {            
            string test = id.ToString().EncodeBase64();
            
            return Ok(_dbset.Find(id));
        }

        [HttpGet("{id?}")]
        public IActionResult Get2(string encodedId)
        {            
            return Ok(_dbset.Find());
        }

        [HttpPut]
        public IActionResult Put(TEntity entity)
        {
            try
            {
                var rEntity = _dbset.Update(entity);
                _context.SaveChanges();
                return Ok(rEntity.Entity);
            }
            catch (Exception e)
            {

                throw e;
            }
           
        }

        [HttpPost]
        public IActionResult Post(TEntity entity)
        {
            try
            {
                var rEntity = _dbset.Add(entity);
                _context.SaveChanges();
                return Ok(rEntity.Entity);
            }
            catch (Exception e)
            {
                string message = e.Message;
                if (e.InnerException != null)
                {
                    message = e.InnerException.Message;
                }
                return Ok(e.Message);
            }
            
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            TEntity entity = new TEntity();

            return Ok(_dbset.Find(id));
        }
    }
}

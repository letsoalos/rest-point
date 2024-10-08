using Core.Entities._LookUps;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class GenderController(DataContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Gender>>> GetGenderList()
    {
        return await context.Genders.ToListAsync();
    }
}

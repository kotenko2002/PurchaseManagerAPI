using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PurchaseManagerAPI.Data.Repositories.Currencies;
using PurchaseManagerAPI.Data.Repositories.Users;
using PurchaseManagerAPI.DTOs;
using PurchaseManagerAPI.Entities;
using PurchaseManagerAPI.Infrastructure.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseManagerAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ICurrencyRepository _currencyRepository;
        public readonly IHttpContextAccessor _httpContextAccessor;
        public UserController(
            IUserRepository userRepository,
            ICurrencyRepository сurrencyRepository,
            IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _currencyRepository = сurrencyRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("currencies"), AllowAnonymous]
        public async Task<IEnumerable<Currency>> GetAllCurrencies()
        {
            return await _currencyRepository.GetAllCategories();
        }

        [HttpPost("changeCurrency")]
        public async Task<ActionResult> ChangeDefaultСurrency(DefaultCurrencyEditModel model)
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUserId();
            await _userRepository.ChangeUserDefaultСurrencyAsync(userId, model.CurrencyId);
            return Ok("Success");
        }
    }
}

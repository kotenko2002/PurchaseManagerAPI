using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PurchaseManagerAPI.Data.Repositories.Records;
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
    [Route("api/record")]
    public class RecordController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRecordRepository _recordRepository;
        private readonly IUserRepository _userRepository;
        public readonly IHttpContextAccessor _httpContextAccessor;

        public RecordController(
            IMapper mapper,
            IRecordRepository recordRepository,
            IUserRepository userRepository,
            IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _recordRepository = recordRepository;
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public async Task<ActionResult> AddRecord([FromBody] RecordAddModel model)
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUserId();
            if (model.CurrencyId == null)
            {
                model.CurrencyId = await _userRepository.GetUserDefaultСurrencyAsync(userId);
            }

            var record = _mapper.Map<Record>(model);
            record.UserId = userId;
            var recordId = await _recordRepository.AddRecordAsync(record);

            return Ok($"Success. RecordId = {recordId}");
        }

        [HttpGet("items")]
        public async Task<IEnumerable<RecordResponse>> GetRecordsByUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUserId();
            var records = await _recordRepository.GetRecordsByUserId(userId);

            return _mapper.Map<IEnumerable<RecordResponse>>(records);
        }

        [HttpGet("items/{categoryId}")]
        public async Task<IEnumerable<RecordResponse>> GetRecordsByUserIdAndCategoryId(int categoryId)
        {
            var userId = _httpContextAccessor.HttpContext.User.GetUserId();
            var records = await _recordRepository.GetRecordsByUserIdAndCategoryId(userId, categoryId);

            return _mapper.Map<IEnumerable<RecordResponse>>(records);
        }
    }
}

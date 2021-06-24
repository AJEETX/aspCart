using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspCart.Web.Models.ManageViewModels;
using aspCart.Infrastructure.EFModels;
using aspCart.Core.Interface.Services.User;
using aspCart.Core.Domain.User;
using AutoMapper;
using aspCart.Core.Interface.Services.Sale;
using aspCart.Web.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using aspCart.Core.Interface.Services.Messages;
using aspCart.Web.Areas.Admin.Models.Support;
using aspCart.Core.Domain.Messages;

namespace aspCart.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class ManageController : AdminController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IBillingAddressService _billingAddressService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IOrderService _orderService;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        private readonly IContactUsService _contactUsService;

        private ISession Session => _httpContextAccessor.HttpContext.Session;

        public ManageController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IBillingAddressService billingAddressService,
            IHttpContextAccessor httpContextAccessor,
            IOrderService orderService,
            ILoggerFactory loggerFactory,
            IContactUsService contactUsService,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _billingAddressService = billingAddressService;
            _httpContextAccessor = httpContextAccessor;
            _orderService = orderService;
            _contactUsService = contactUsService;
            _logger = loggerFactory.CreateLogger<ManageController>();
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var users = _billingAddressService.GetBillingAddresses();
            var usersModel = users.Select(b => new BillingAddressModel 
            { 
                FirstName=b.FirstName,
                LastName=b.LastName,
                Address=b.Address,
                City=b.City,
                Country=b.Country,
                ZipPostalCode=b.ZipPostalCode,
                 StateProvince=b.StateProvince,
                  Email=b.Email,
                   Telephone=b.Telephone
            });
            return View(usersModel.ToList());
        }


    }
}

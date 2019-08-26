using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobManagementSystem.Common;
using JobManagementSystem.Common.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobManagementSystem.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// Controller BaseController
    /// </summary>
    [Area(AreasNames.AreaAdmin)]
    [Route(RouteConfigs.AdminToController)]
    [Route(RouteConfigs.AdminToControllerToAction)]
    [Route(RouteConfigs.AdminToControllerToActionToId)]
    [Authorize(Policy = nameof(RoleEnum.Admin))]
    public class BaseController : Controller
    {
    }
}
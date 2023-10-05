
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using TopPriority.Web.Models;

namespace TopPriority.Web.Api
{
    [Route("api/Ticket")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class TicketController
        : BaseApiController<TopPriority.Data.Models.Ticket, TicketDtoGen, TopPriority.Data.AppDbContext>
    {
        public TicketController(CrudContext<TopPriority.Data.AppDbContext> context) : base(context)
        {
            GeneratedForClassViewModel = context.ReflectionRepository.GetClassViewModel<TopPriority.Data.Models.Ticket>();
        }

        [HttpGet("get/{id}")]
        [AllowAnonymous]
        public virtual Task<ItemResult<TicketDtoGen>> Get(
            int id,
            DataSourceParameters parameters,
            IDataSource<TopPriority.Data.Models.Ticket> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [AllowAnonymous]
        public virtual Task<ListResult<TicketDtoGen>> List(
            ListParameters parameters,
            IDataSource<TopPriority.Data.Models.Ticket> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [AllowAnonymous]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<TopPriority.Data.Models.Ticket> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<TicketDtoGen>> Save(
            [FromForm] TicketDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<TopPriority.Data.Models.Ticket> dataSource,
            IBehaviors<TopPriority.Data.Models.Ticket> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<TicketDtoGen>> Delete(
            int id,
            IBehaviors<TopPriority.Data.Models.Ticket> behaviors,
            IDataSource<TopPriority.Data.Models.Ticket> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);
    }
}

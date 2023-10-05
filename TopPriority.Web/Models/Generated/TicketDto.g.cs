using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace TopPriority.Web.Models
{
    public partial class TicketDtoGen : GeneratedDto<TopPriority.Data.Models.Ticket>
    {
        public TicketDtoGen() { }

        private int? _TicketId;
        private string _RequestorName;
        private string _Request;
        private string _Tenant;
        private System.DateTime? _CreatedDateTime;
        private System.DateTime? _StartDateTime;
        private System.DateTime? _CompletedDateTime;
        private bool? _IsCompleted;

        public int? TicketId
        {
            get => _TicketId;
            set { _TicketId = value; Changed(nameof(TicketId)); }
        }
        public string RequestorName
        {
            get => _RequestorName;
            set { _RequestorName = value; Changed(nameof(RequestorName)); }
        }
        public string Request
        {
            get => _Request;
            set { _Request = value; Changed(nameof(Request)); }
        }
        public string Tenant
        {
            get => _Tenant;
            set { _Tenant = value; Changed(nameof(Tenant)); }
        }
        public System.DateTime? CreatedDateTime
        {
            get => _CreatedDateTime;
            set { _CreatedDateTime = value; Changed(nameof(CreatedDateTime)); }
        }
        public System.DateTime? StartDateTime
        {
            get => _StartDateTime;
            set { _StartDateTime = value; Changed(nameof(StartDateTime)); }
        }
        public System.DateTime? CompletedDateTime
        {
            get => _CompletedDateTime;
            set { _CompletedDateTime = value; Changed(nameof(CompletedDateTime)); }
        }
        public bool? IsCompleted
        {
            get => _IsCompleted;
            set { _IsCompleted = value; Changed(nameof(IsCompleted)); }
        }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(TopPriority.Data.Models.Ticket obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            this.TicketId = obj.TicketId;
            this.RequestorName = obj.RequestorName;
            this.Request = obj.Request;
            this.Tenant = obj.Tenant;
            this.CreatedDateTime = obj.CreatedDateTime;
            this.StartDateTime = obj.StartDateTime;
            this.CompletedDateTime = obj.CompletedDateTime;
            this.IsCompleted = obj.IsCompleted;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(TopPriority.Data.Models.Ticket entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            if (ShouldMapTo(nameof(TicketId))) entity.TicketId = (TicketId ?? entity.TicketId);
            if (ShouldMapTo(nameof(RequestorName))) entity.RequestorName = RequestorName;
            if (ShouldMapTo(nameof(Request))) entity.Request = Request;
            if (ShouldMapTo(nameof(Tenant))) entity.Tenant = Tenant;
            if (ShouldMapTo(nameof(CreatedDateTime))) entity.CreatedDateTime = (CreatedDateTime ?? entity.CreatedDateTime);
            if (ShouldMapTo(nameof(StartDateTime))) entity.StartDateTime = StartDateTime;
            if (ShouldMapTo(nameof(CompletedDateTime))) entity.CompletedDateTime = CompletedDateTime;
        }

        /// <summary>
        /// Map from the current DTO instance to a new instance of the domain object.
        /// </summary>
        public override TopPriority.Data.Models.Ticket MapToNew(IMappingContext context)
        {
            var entity = new TopPriority.Data.Models.Ticket();
            MapTo(entity, context);
            return entity;
        }
    }
}

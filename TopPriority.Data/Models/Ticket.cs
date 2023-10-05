
using System.ComponentModel;

namespace TopPriority.Data.Models;

#nullable disable

//Class level trumps property level
[Read(PermissionLevel = SecurityPermissionLevels.AllowAll)]
[Create(PermissionLevel = SecurityPermissionLevels.AllowAll)]
public class Ticket
{
    public int TicketId { get; set; }

    [Required]
    public string RequestorName { get; set; }

    [Required]
    public string Request { get; set; }

    [Required]
    public string Tenant { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime? StartDateTime { get; set; }

    [Edit(Roles = "Admin")]
    public DateTime? CompletedDateTime { get; set; }

    public bool IsCompleted => CompletedDateTime is not null;

    [DefaultDataSource]
    public class DefaultSource : StandardDataSource<Ticket, AppDbContext>
    {
        public DefaultSource(CrudContext<AppDbContext> context) : base (context) { }

        public override IQueryable<Ticket> ApplyListDefaultSorting(IQueryable<Ticket> query)
        {
            return query.OrderByDescending(x => x.CompletedDateTime == null).ThenBy(x => x.CompletedDateTime);
        }

        //public override IQueryable<Ticket> ApplyListSorting(IQueryable<Ticket> query, IListParameters parameters)
        //{
        //    return base.ApplyListSorting(query, parameters);
        //}
    }
}

#nullable restore
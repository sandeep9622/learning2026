using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ChatterBoxWebContext(DbContextOptions<ChatterBoxWebContext> options) : IdentityDbContext<ChatterBox.Web.Data.ApplicationUser>(options)
{
}

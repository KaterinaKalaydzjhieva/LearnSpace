using LearnSpace.Core.Services;
using LearnSpace.Infrastructure.Database;
using LearnSpace.Infrastructure.Database.Entities.Account;
using LearnSpace.Infrastructure.Database.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//public class AdminServiceTests
//{
//    private LearnSpaceDbContext context;
//    private IRepository repository;
//    private UserManager<ApplicationUser> userManager;
//    private AdminService adminService;

//    [SetUp]
//    public void Setup()
//    {
//        var contextOptions = new DbContextOptionsBuilder<LearnSpaceDbContext>()
//            .UseInMemoryDatabase("LearnSpaceDbTest")
//            .Options;

//        context = new LearnSpaceDbContext(contextOptions);
//        context.Database.EnsureDeleted();
//        context.Database.EnsureCreated();

//        repository = new Repository(context);

//        userManager = new UserManager<ApplicationUser>(
//            new UserStore<ApplicationUser, IdentityRole<Guid>, LearnSpaceDbContext, Guid>(context),
//            null, null, null, null, null, null, null, null
//        );

//        adminService = new AdminService(userManager, repository);
//    }

//    [Test]
//    public async Task AddRoleAsync_ShouldAddRoleToUser()
//    {
//        // Arrange
//        var user = new ApplicationUser { Id = Guid.NewGuid(), UserName = "testuser" };
//        await context.Users.AddAsync(user);
//        await context.SaveChangesAsync();

//        var role = "Admin";
//        await context.Roles.AddAsync(new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = role, NormalizedName = role.ToUpper() });
//        await context.SaveChangesAsync();

//        // Act
//        await adminService.AddRoleAsync(user.Id.ToString(), role);

//        // Assert
//        var userRoles = await userManager.GetRolesAsync(user);
//        Assert.Contains(role, userRoles);
//    }

//    [Test]
//    public async Task DeleteRoleAsync_ShouldRemoveRoleFromUser()
//    {
//        // Arrange
//        var user = new ApplicationUser { Id = Guid.NewGuid(), UserName = "testuser" };
//        await context.Users.AddAsync(user);
//        await context.SaveChangesAsync();

//        var role = "Admin";
//        var roleEntity = new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = role, NormalizedName = role.ToUpper() };
//        await context.Roles.AddAsync(roleEntity);
//        await context.SaveChangesAsync();

//        await userManager.AddToRoleAsync(user, role);

//        // Act
//        await adminService.DeleteRoleAsync(user.Id.ToString(), role);

//        // Assert
//        var userRoles = await userManager.GetRolesAsync(user);
//        Assert.DoesNotContain(role, userRoles);
//    }

//    [Test]
//    public async Task DeleteUserAsync_ShouldDeleteUserFromRepository()
//    {
//        // Arrange
//        var user = new ApplicationUser { Id = Guid.NewGuid(), UserName = "testuser" };
//        await context.Users.AddAsync(user);
//        await context.SaveChangesAsync();

//        // Act
//        await adminService.DeleteUserAsync(user.Id.ToString());

//        // Assert
//        var deletedUser = await repository.GetByIdAsync<ApplicationUser>(user.Id);
//        Assert.Null(deletedUser);
//    }

//    [Test]
//    public async Task GetAllUsersAsync_ShouldReturnAllUsersWithRoles()
//    {
//        // Arrange
//        var user1 = new ApplicationUser { Id = Guid.NewGuid(), UserName = "user1", FirstName = "John", LastName = "Doe" };
//        var user2 = new ApplicationUser { Id = Guid.NewGuid(), UserName = "user2", FirstName = "Jane", LastName = "Smith" };
//        await context.Users.AddRangeAsync(user1, user2);
//        await context.SaveChangesAsync();

//        var roleAdmin = "Admin";
//        var roleUser = "User";

//        await context.Roles.AddRangeAsync(
//            new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = roleAdmin, NormalizedName = roleAdmin.ToUpper() },
//            new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = roleUser, NormalizedName = roleUser.ToUpper() }
//        );
//        await context.SaveChangesAsync();

//        await userManager.AddToRoleAsync(user1, roleAdmin);
//        await userManager.AddToRoleAsync(user2, roleUser);

//        // Act
//        var result = await adminService.GetAllUsersAsync();

//        // Assert
//        Assert.Equal(2, result.Count);
//        Assert.Contains(result, u => u.UserName == "user1" && u.Roles.Contains("Admin"));
//        Assert.Contains(result, u => u.UserName == "user2" && u.Roles.Contains("User"));
//    }

//    [TearDown]
//    public void TearDown()
//    {
//        context.Dispose();
//    }
//}

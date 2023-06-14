using gnohp18.quiz.Answers;
using gnohp18.quiz.Players;
using gnohp18.quiz.Questions;
using gnohp18.quiz.Results;
using gnohp18.quiz.TypeOfQuestions;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace gnohp18.quiz.Data;

public class quizDbContext : AbpDbContext<quizDbContext>
{
    public quizDbContext(DbContextOptions<quizDbContext> options)
        : base(options)
    {
    }

    public DbSet<Player> Players { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<TypeOfQuestion> TypeOfQuestions { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own entities here */
        builder.Entity<Player>(p =>
        {
            p.ToTable("Players");
            p.ConfigureByConvention();
        });

        builder.Entity<Answer>(p =>
        {
            p.ToTable("Answers");
            p.HasOne(p => p.Question).WithMany(q => q.Answers).HasForeignKey(p => p.QuestionId);
            p.ConfigureByConvention();
        });

        builder.Entity<Question>(p =>
        {
            p.ToTable("Questions");
            p.HasOne(p => p.TypeOfQuestion).WithMany(q => q.Questions).HasForeignKey(p => p.TypeOfQuestionId);
            p.ConfigureByConvention();
        });

        builder.Entity<Result>(p =>
        {
            p.ToTable("Results");
            p.HasOne(p => p.TypeOfQuestion).WithMany(p => p.Results).HasForeignKey(p => p.TypeOfQuestionId);
            p.ConfigureByConvention();
        });
    }
}

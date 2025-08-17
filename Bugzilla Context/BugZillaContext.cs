using Microsoft.EntityFrameworkCore;

namespace Segway.EF.DataFirst.Bugzilla;

public partial class BugZillaContext : DbContext
{
    public BugZillaContext()
    {
    }

    public BugZillaContext(DbContextOptions<BugZillaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AttachDatum> AttachData { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<Bug> Bugs { get; set; }

    public virtual DbSet<BugDistribution> BugDistributions { get; set; }

    public virtual DbSet<BugSeverity> BugSeverities { get; set; }

    public virtual DbSet<BugStatus> BugStatuses { get; set; }

    public virtual DbSet<BugsActivity> BugsActivities { get; set; }

    public virtual DbSet<Component> Components { get; set; }

    public virtual DbSet<Duplicate> Duplicates { get; set; }

    public virtual DbSet<FieldDef> FieldDefs { get; set; }

    public virtual DbSet<LongDesc> LongDescs { get; set; }

    public virtual DbSet<OpSy> OpSys { get; set; }

    public virtual DbSet<Priority> Priorities { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    public virtual DbSet<Resolution> Resolutions { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=BugZilla;Trusted_Connection=True;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AttachDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attach_Data");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Thedata).HasColumnName("THEDATA");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AttachId)
                .ValueGeneratedOnAdd()
                .HasColumnName("ATTACH_ID");
            entity.Property(e => e.BugId).HasColumnName("BUG_ID");
            entity.Property(e => e.CreationTs)
                .HasColumnType("datetime")
                .HasColumnName("CREATION_TS");
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Isobsolete).HasColumnName("ISOBSOLETE");
            entity.Property(e => e.Ispatch).HasColumnName("ISPATCH");
            entity.Property(e => e.Isprivate).HasColumnName("ISPRIVATE");
            entity.Property(e => e.Isurl).HasColumnName("ISURL");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("MIMETYPE");
            entity.Property(e => e.SubmitterId).HasColumnName("SUBMITTER_ID");
        });

        modelBuilder.Entity<Bug>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Alias)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALIAS");
            entity.Property(e => e.AssignedTo).HasColumnName("ASSIGNED_TO");
            entity.Property(e => e.BugFileLoc)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("BUG_FILE_LOC");
            entity.Property(e => e.BugId)
                .ValueGeneratedOnAdd()
                .HasColumnName("BUG_ID");
            entity.Property(e => e.BugSeverity)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BUG_SEVERITY");
            entity.Property(e => e.BugStatus)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("BUG_STATUS");
            entity.Property(e => e.BugType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BUG_TYPE");
            entity.Property(e => e.CclistAccessible).HasColumnName("CCLIST_ACCESSIBLE");
            entity.Property(e => e.ComponentId).HasColumnName("COMPONENT_ID");
            entity.Property(e => e.CreationTs)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("CREATION_TS");
            entity.Property(e => e.Deadline)
                .HasColumnType("datetime")
                .HasColumnName("DEADLINE");
            entity.Property(e => e.DeltaTs)
                .HasDefaultValueSql("(sysdatetime())")
                .HasColumnType("datetime")
                .HasColumnName("DELTA_TS");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("END_DATE");
            entity.Property(e => e.EstimatedTime).HasColumnName("ESTIMATED_TIME");
            entity.Property(e => e.Everconfirmed).HasColumnName("EVERCONFIRMED");
            entity.Property(e => e.Frequency)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FREQUENCY");
            entity.Property(e => e.ImplVersion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IMPL_VERSION");
            entity.Property(e => e.IsHidden).HasColumnName("IS_HIDDEN");
            entity.Property(e => e.Keywords)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("KEYWORDS");
            entity.Property(e => e.Lastdiffed)
                .HasColumnType("datetime")
                .HasColumnName("LASTDIFFED");
            entity.Property(e => e.LogsLoaded).HasColumnName("LOGS_LOADED");
            entity.Property(e => e.OccurranceTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("OCCURRANCE_TIMESTAMP");
            entity.Property(e => e.OpSys)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("OP_SYS");
            entity.Property(e => e.Priority)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PRIORITY");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.QaContact).HasColumnName("QA_CONTACT");
            entity.Property(e => e.RemainingTime).HasColumnName("REMAINING_TIME");
            entity.Property(e => e.RepPlatform)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("REP_PLATFORM");
            entity.Property(e => e.Reporter).HasColumnName("REPORTER");
            entity.Property(e => e.ReporterAccessible).HasColumnName("REPORTER_ACCESSIBLE");
            entity.Property(e => e.Resolution)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("RESOLUTION");
            entity.Property(e => e.Revision).HasColumnName("REVISION");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("SHORT_DESC");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("START_DATE");
            entity.Property(e => e.StatusWhiteboard)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("STATUS_WHITEBOARD");
            entity.Property(e => e.TargetMilestone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TARGET_MILESTONE");
            entity.Property(e => e.Version)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("VERSION");
            entity.Property(e => e.Votes).HasColumnName("VOTES");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("WORK_ORDER");
        });

        modelBuilder.Entity<BugDistribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bug_Distribution");

            entity.Property(e => e.BugId).HasColumnName("BUG_ID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Who).HasColumnName("WHO");
        });

        modelBuilder.Entity<BugSeverity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bug_Severity");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.SortKey).HasColumnName("SORT_KEY");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<BugStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bug_Status");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.SortKey).HasColumnName("SORT_KEY");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<BugsActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bugs_Activity");

            entity.Property(e => e.Added)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ADDED");
            entity.Property(e => e.AttachId).HasColumnName("ATTACH_ID");
            entity.Property(e => e.BugId).HasColumnName("BUG_ID");
            entity.Property(e => e.BugWhen)
                .HasColumnType("datetime")
                .HasColumnName("BUG_WHEN");
            entity.Property(e => e.Fieldid).HasColumnName("FIELDID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Removed)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("REMOVED");
            entity.Property(e => e.Who).HasColumnName("WHO");
        });

        modelBuilder.Entity<Component>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InitialOwner).HasColumnName("INITIAL_OWNER");
            entity.Property(e => e.InitialQaContact).HasColumnName("INITIAL_QA_CONTACT");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
        });

        modelBuilder.Entity<Duplicate>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Dupe).HasColumnName("DUPE");
            entity.Property(e => e.DupeOf).HasColumnName("DUPE_OF");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<FieldDef>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Field_Defs");

            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.FieldId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FIELD_ID");
            entity.Property(e => e.MailHead).HasColumnName("MAIL_HEAD");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Obsolete).HasColumnName("OBSOLETE");
            entity.Property(e => e.SortKey).HasColumnName("SORT_KEY");
        });

        modelBuilder.Entity<LongDesc>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AlreadyWrapped).HasColumnName("ALREADY_WRAPPED");
            entity.Property(e => e.BugId).HasColumnName("BUG_ID");
            entity.Property(e => e.BugWhen)
                .HasColumnType("datetime")
                .HasColumnName("BUG_WHEN");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsPrivate).HasColumnName("IS_PRIVATE");
            entity.Property(e => e.TheText)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("THE_TEXT");
            entity.Property(e => e.Who).HasColumnName("WHO");
            entity.Property(e => e.WorkTime).HasColumnName("WORK_TIME");
        });

        modelBuilder.Entity<OpSy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OP_Sys");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.SortKey).HasColumnName("SORT_KEY");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Priority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Priority");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.SortKey).HasColumnName("SORT_KEY");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClassificationId).HasColumnName("CLASSIFICATION_ID");
            entity.Property(e => e.Defaultmilestone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEFAULTMILESTONE");
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Disallownew).HasColumnName("DISALLOWNEW");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Maxvotesperbug).HasColumnName("MAXVOTESPERBUG");
            entity.Property(e => e.Milestoneurl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MILESTONEURL");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Votesperuser).HasColumnName("VOTESPERUSER");
            entity.Property(e => e.Votestoconfirm).HasColumnName("VOTESTOCONFIRM");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CryptPassword)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("CRYPT_PASSWORD");
            entity.Property(e => e.DisabledText)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("DISABLED_TEXT");
            entity.Property(e => e.ExternId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("EXTERN_ID");
            entity.Property(e => e.LoginName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("LOGIN_NAME");
            entity.Property(e => e.MybugsLink).HasColumnName("MYBUGS_LINK");
            entity.Property(e => e.RealName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("REAL_NAME");
            entity.Property(e => e.RefreshedWhen)
                .HasColumnType("datetime")
                .HasColumnName("REFRESHED_WHEN");
            entity.Property(e => e.UserId)
                .ValueGeneratedOnAdd()
                .HasColumnName("USER_ID");
        });

        modelBuilder.Entity<Resolution>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Resolution");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsActive).HasColumnName("IS_ACTIVE");
            entity.Property(e => e.SortKey).HasColumnName("SORT_KEY");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("VALUE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

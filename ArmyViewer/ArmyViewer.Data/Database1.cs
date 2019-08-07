﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "ArmyViewer.Web\Web.config"
//     Connection String Name: "DefaultConnection"
//     Connection String:      "Server=tcp:battle-hub.database.windows.net;Database=battle-hub;User ID=battle-hub-sa@battle-hub.database.windows.net;password=**zapped**;;Trusted_Connection=False;Encrypt=True;"
// ------------------------------------------------------------------------------------------------
// Database Edition        : SQL Azure
// Database Engine Edition : Azure
// Database Version        : 12.0.2000.8

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace ArmyViewer.Data
{
    using System.Linq;

    #region Unit of work

    public interface IBattleHubContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        System.Data.Entity.DbSet<Battle> Battles { get; set; } // Battle
        System.Data.Entity.DbSet<sys_DatabaseFirewallRule> sys_DatabaseFirewallRules { get; set; } // database_firewall_rules

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class BattleHubContext : System.Data.Entity.DbContext, IBattleHubContext
    {
        public System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        public System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        public System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        public System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        public System.Data.Entity.DbSet<Battle> Battles { get; set; } // Battle
        public System.Data.Entity.DbSet<sys_DatabaseFirewallRule> sys_DatabaseFirewallRules { get; set; } // database_firewall_rules

        static BattleHubContext()
        {
            System.Data.Entity.Database.SetInitializer<BattleHubContext>(null);
        }

        public BattleHubContext()
            : base("Name=DefaultConnection")
        {
        }

        public BattleHubContext(string connectionString)
            : base(connectionString)
        {
        }

        public BattleHubContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public BattleHubContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public BattleHubContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AspNetRoleConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration());
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration());
            modelBuilder.Configurations.Add(new BattleConfiguration());
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRuleConfiguration());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AspNetRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserClaimConfiguration(schema));
            modelBuilder.Configurations.Add(new AspNetUserLoginConfiguration(schema));
            modelBuilder.Configurations.Add(new BattleConfiguration(schema));
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRuleConfiguration(schema));
            return modelBuilder;
        }
    }
    #endregion

    #region Database context factory

    public class BattleHubContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<BattleHubContext>
    {
        public BattleHubContext Create()
        {
            return new BattleHubContext();
        }
    }

    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FakeBattleHubContext : IBattleHubContext
    {
        public System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; }
        public System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; }
        public System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public System.Data.Entity.DbSet<Battle> Battles { get; set; }
        public System.Data.Entity.DbSet<sys_DatabaseFirewallRule> sys_DatabaseFirewallRules { get; set; }

        public FakeBattleHubContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            AspNetRoles = new FakeDbSet<AspNetRole>("Id");
            AspNetUsers = new FakeDbSet<AspNetUser>("Id");
            AspNetUserClaims = new FakeDbSet<AspNetUserClaim>("Id");
            AspNetUserLogins = new FakeDbSet<AspNetUserLogin>("LoginProvider", "ProviderKey", "UserId");
            Battles = new FakeDbSet<Battle>("Id");
            sys_DatabaseFirewallRules = new FakeDbSet<sys_DatabaseFirewallRule>("Id", "Name", "StartIpAddress", "EndIpAddress", "CreateDate", "ModifyDate");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            var m = expression as System.Linq.Expressions.MethodCallExpression;
            if (m != null)
            {
                var resultType = m.Method.ReturnType; // it shoud be IQueryable<T>
                var tElement = resultType.GetGenericArguments()[0];
                var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(tElement);
                return (IQueryable) System.Activator.CreateInstance(queryType, expression);
            }
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            var queryType = typeof(FakeDbAsyncEnumerable<>).MakeGenericType(typeof(TElement));
            return (IQueryable<TElement>)System.Activator.CreateInstance(queryType, expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // AspNetRoles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetRole
    {
        public string Id { get; set; } // Id (Primary key) (length: 128)
        public string Name { get; set; } // Name (length: 256)

        // Reverse navigation

        /// <summary>
        /// Child AspNetUsers (Many-to-Many) mapped by table [AspNetUserRoles]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUser> AspNetUsers { get; set; } // Many to many mapping

        public AspNetRole()
        {
            AspNetUsers = new System.Collections.Generic.List<AspNetUser>();
        }
    }

    // AspNetUsers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetUser
    {
        public string Id { get; set; } // Id (Primary key) (length: 128)
        public string Email { get; set; } // Email (length: 256)
        public bool EmailConfirmed { get; set; } // EmailConfirmed
        public string PasswordHash { get; set; } // PasswordHash
        public string SecurityStamp { get; set; } // SecurityStamp
        public string PhoneNumber { get; set; } // PhoneNumber
        public bool PhoneNumberConfirmed { get; set; } // PhoneNumberConfirmed
        public bool TwoFactorEnabled { get; set; } // TwoFactorEnabled
        public System.DateTime? LockoutEndDateUtc { get; set; } // LockoutEndDateUtc
        public bool LockoutEnabled { get; set; } // LockoutEnabled
        public int AccessFailedCount { get; set; } // AccessFailedCount
        public string UserName { get; set; } // UserName (length: 256)

        // Reverse navigation

        /// <summary>
        /// Child AspNetRoles (Many-to-Many) mapped by table [AspNetUserRoles]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetRole> AspNetRoles { get; set; } // Many to many mapping
        /// <summary>
        /// Child AspNetUserClaims where [AspNetUserClaims].[UserId] point to this entity (FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims.FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
        /// <summary>
        /// Child AspNetUserLogins where [AspNetUserLogins].[UserId] point to this entity (FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins.FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId

        public AspNetUser()
        {
            AspNetUserClaims = new System.Collections.Generic.List<AspNetUserClaim>();
            AspNetUserLogins = new System.Collections.Generic.List<AspNetUserLogin>();
            AspNetRoles = new System.Collections.Generic.List<AspNetRole>();
        }
    }

    // AspNetUserClaims
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetUserClaim
    {
        public int Id { get; set; } // Id (Primary key)
        public string UserId { get; set; } // UserId (length: 128)
        public string ClaimType { get; set; } // ClaimType
        public string ClaimValue { get; set; } // ClaimValue

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [AspNetUserClaims].([UserId]) (FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; } // FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
    }

    // AspNetUserLogins
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetUserLogin
    {
        public string LoginProvider { get; set; } // LoginProvider (Primary key) (length: 128)
        public string ProviderKey { get; set; } // ProviderKey (Primary key) (length: 128)
        public string UserId { get; set; } // UserId (Primary key) (length: 128)

        // Foreign keys

        /// <summary>
        /// Parent AspNetUser pointed by [AspNetUserLogins].([UserId]) (FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId)
        /// </summary>
        public virtual AspNetUser AspNetUser { get; set; } // FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId
    }

    // Battle
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class Battle: ArmyViewer.Data.Interfaces.IBattleHubEntity
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name (length: 250)
        public string Description { get; set; } // Description
        public string Link { get; set; } // Link (length: 255)
        public int CreatedBy { get; set; } // CreatedBy
        public System.DateTime CreatedOn { get; set; } // CreatedOn
        public int? ModifiedBy { get; set; } // ModifiedBy
        public System.DateTime? ModifiedOn { get; set; } // ModifiedOn
        public int? DeletedBy { get; set; } // DeletedBy
        public System.DateTime? DeletedOn { get; set; } // DeletedOn
        public int Status { get; set; } // Status

        public Battle()
        {
            CreatedOn = System.DateTime.Now;
            Status = 1;
        }
    }

    // database_firewall_rules
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class sys_DatabaseFirewallRule
    {
        public int Id { get; set; } // id (Primary key)
        public string Name { get; set; } // name (Primary key) (length: 128)
        public string StartIpAddress { get; set; } // start_ip_address (Primary key) (length: 45)
        public string EndIpAddress { get; set; } // end_ip_address (Primary key) (length: 45)
        public System.DateTime CreateDate { get; set; } // create_date (Primary key)
        public System.DateTime ModifyDate { get; set; } // modify_date (Primary key)
    }

    #endregion

    #region POCO Configuration

    // AspNetRoles
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetRoleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetRole>
    {
        public AspNetRoleConfiguration()
            : this("dbo")
        {
        }

        public AspNetRoleConfiguration(string schema)
        {
            ToTable("AspNetRoles", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
            HasMany(t => t.AspNetUsers).WithMany(t => t.AspNetRoles).Map(m =>
            {
                m.ToTable("AspNetUserRoles", "dbo");
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
        }
    }

    // AspNetUsers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetUserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetUser>
    {
        public AspNetUserConfiguration()
            : this("dbo")
        {
        }

        public AspNetUserConfiguration(string schema)
        {
            ToTable("AspNetUsers", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Email).HasColumnName(@"Email").HasColumnType("nvarchar").IsOptional().HasMaxLength(256);
            Property(x => x.EmailConfirmed).HasColumnName(@"EmailConfirmed").HasColumnType("bit").IsRequired();
            Property(x => x.PasswordHash).HasColumnName(@"PasswordHash").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.SecurityStamp).HasColumnName(@"SecurityStamp").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.PhoneNumberConfirmed).HasColumnName(@"PhoneNumberConfirmed").HasColumnType("bit").IsRequired();
            Property(x => x.TwoFactorEnabled).HasColumnName(@"TwoFactorEnabled").HasColumnType("bit").IsRequired();
            Property(x => x.LockoutEndDateUtc).HasColumnName(@"LockoutEndDateUtc").HasColumnType("datetime").IsOptional();
            Property(x => x.LockoutEnabled).HasColumnName(@"LockoutEnabled").HasColumnType("bit").IsRequired();
            Property(x => x.AccessFailedCount).HasColumnName(@"AccessFailedCount").HasColumnType("int").IsRequired();
            Property(x => x.UserName).HasColumnName(@"UserName").HasColumnType("nvarchar").IsRequired().HasMaxLength(256);
        }
    }

    // AspNetUserClaims
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetUserClaimConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetUserClaim>
    {
        public AspNetUserClaimConfiguration()
            : this("dbo")
        {
        }

        public AspNetUserClaimConfiguration(string schema)
        {
            ToTable("AspNetUserClaims", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.ClaimType).HasColumnName(@"ClaimType").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.ClaimValue).HasColumnName(@"ClaimValue").HasColumnType("nvarchar(max)").IsOptional();

            // Foreign keys
            HasRequired(a => a.AspNetUser).WithMany(b => b.AspNetUserClaims).HasForeignKey(c => c.UserId); // FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId
        }
    }

    // AspNetUserLogins
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class AspNetUserLoginConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AspNetUserLogin>
    {
        public AspNetUserLoginConfiguration()
            : this("dbo")
        {
        }

        public AspNetUserLoginConfiguration(string schema)
        {
            ToTable("AspNetUserLogins", schema);
            HasKey(x => new { x.LoginProvider, x.ProviderKey, x.UserId });

            Property(x => x.LoginProvider).HasColumnName(@"LoginProvider").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProviderKey).HasColumnName(@"ProviderKey").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.AspNetUser).WithMany(b => b.AspNetUserLogins).HasForeignKey(c => c.UserId); // FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId
        }
    }

    // Battle
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class BattleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Battle>
    {
        public BattleConfiguration()
            : this("dbo")
        {
        }

        public BattleConfiguration(string schema)
        {
            ToTable("Battle", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("nvarchar").IsRequired().HasMaxLength(250);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Link).HasColumnName(@"Link").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("int").IsRequired();
            Property(x => x.CreatedOn).HasColumnName(@"CreatedOn").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("int").IsOptional();
            Property(x => x.ModifiedOn).HasColumnName(@"ModifiedOn").HasColumnType("datetime2").IsOptional();
            Property(x => x.DeletedBy).HasColumnName(@"DeletedBy").HasColumnType("int").IsOptional();
            Property(x => x.DeletedOn).HasColumnName(@"DeletedOn").HasColumnType("datetime2").IsOptional();
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("int").IsRequired();
        }
    }

    // database_firewall_rules
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class sys_DatabaseFirewallRuleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<sys_DatabaseFirewallRule>
    {
        public sys_DatabaseFirewallRuleConfiguration()
            : this("sys")
        {
        }

        public sys_DatabaseFirewallRuleConfiguration(string schema)
        {
            ToTable("database_firewall_rules", schema);
            HasKey(x => new { x.Id, x.Name, x.StartIpAddress, x.EndIpAddress, x.CreateDate, x.ModifyDate });

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"name").HasColumnType("nvarchar").IsRequired().HasMaxLength(128).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.StartIpAddress).HasColumnName(@"start_ip_address").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.EndIpAddress).HasColumnName(@"end_ip_address").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(45).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CreateDate).HasColumnName(@"create_date").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ModifyDate).HasColumnName(@"modify_date").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }

    #endregion

}
// </auto-generated>


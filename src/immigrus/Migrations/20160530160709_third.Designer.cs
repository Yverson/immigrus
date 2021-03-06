using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using immigrus.Models;

namespace immigrus.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160530160709_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("immigrus.Models.Actualite", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Description");

                    b.Property<string>("Etat");

                    b.Property<string>("Libelle");

                    b.Property<int>("Ordre")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Position");

                    b.Property<string>("Source");

                    b.Property<string>("images");

                    b.Property<bool>("isPublish");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("immigrus.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AdrPos");

                    b.Property<string>("AutresDip");

                    b.Property<string>("ClientsId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateCreation");

                    b.Property<DateTime>("DateNais");

                    b.Property<string>("Diplome");

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Etat");

                    b.Property<string>("LieuNais");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NbEnfts");

                    b.Property<string>("Nom");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("ParainIdf");

                    b.Property<string>("Password");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PaysEl");

                    b.Property<string>("PaysNais");

                    b.Property<string>("PaysRes");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Photo");

                    b.Property<string>("Prenoms");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Sexe");

                    b.Property<string>("Statut");

                    b.Property<string>("StatutMarital");

                    b.Property<string>("Tel1");

                    b.Property<string>("Tel2");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("immigrus.Models.Enfants", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ClientsId");

                    b.Property<DateTime>("DateNais");

                    b.Property<string>("LieuNais");

                    b.Property<string>("Nom")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Photo");

                    b.Property<string>("Prenoms");

                    b.Property<string>("Sexe");

                    b.Property<string>("Type");

                    b.Property<string>("idPays");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("immigrus.Models.Faq", b =>
                {
                    b.Property<string>("Id");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<string>("Etat");

                    b.Property<int>("Ordre")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Position");

                    b.Property<string>("Questions");

                    b.Property<string>("Source");

                    b.Property<bool>("isPublish");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("immigrus.Models.Inscription", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Annee");

                    b.Property<string>("ClientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfimationNumber");

                    b.Property<DateTime>("DateTrans");

                    b.Property<string>("Etat");

                    b.Property<string>("Resultat");

                    b.Property<string>("Statut");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("immigrus.Models.Pays", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descriptions");

                    b.Property<string>("Nationalite");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("immigrus.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("immigrus.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("immigrus.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}

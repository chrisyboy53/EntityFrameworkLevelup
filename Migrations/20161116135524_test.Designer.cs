using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EntityLevelup.DataAccess.EntityFramework;

namespace EntityLevelup.Migrations
{
    [DbContext(typeof(TeamContext))]
    [Migration("20161116135524_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("EntityLevelup.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Firstname")
                        .IsRequired();

                    b.Property<string>("Lastname")
                        .IsRequired();

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("EntityLevelup.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeamName");

                    b.HasKey("TeamId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("EntityLevelup.Models.TeamAllocation", b =>
                {
                    b.Property<int>("TeamAllocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PersonId");

                    b.Property<int?>("TeamId");

                    b.HasKey("TeamAllocationId");

                    b.HasIndex("PersonId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamAllocation");
                });

            modelBuilder.Entity("EntityLevelup.Models.TeamAllocation", b =>
                {
                    b.HasOne("EntityLevelup.Models.Person", "Person")
                        .WithMany("TeamAllocation")
                        .HasForeignKey("PersonId");

                    b.HasOne("EntityLevelup.Models.Team", "Team")
                        .WithMany("TeamAllocation")
                        .HasForeignKey("TeamId");
                });
        }
    }
}

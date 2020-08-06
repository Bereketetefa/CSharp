﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeddingPlanner.Models;

namespace WeddingPlanner.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200620083547_firstmigration")]
    partial class firstmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WeddingPlanner.Models.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("Planner");

                    b.Property<string>("WedderOne")
                        .IsRequired();

                    b.Property<string>("WedderTwo")
                        .IsRequired();

                    b.Property<DateTime>("WeddingDate");

                    b.HasKey("PlanId");

                    b.ToTable("weddPlans");
                });

            modelBuilder.Entity("WeddingPlanner.Models.RSVP", b =>
                {
                    b.Property<int>("RSVPId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserId");

                    b.Property<int>("WeddPlanId");

                    b.Property<int?>("WeddPlansPlanId");

                    b.HasKey("RSVPId");

                    b.HasIndex("UserId");

                    b.HasIndex("WeddPlansPlanId");

                    b.ToTable("rsvps");
                });

            modelBuilder.Entity("WeddingPlanner.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WeddingPlanner.Models.RSVP", b =>
                {
                    b.HasOne("WeddingPlanner.Models.User", "User")
                        .WithMany("Atending")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WeddingPlanner.Models.Plan", "WeddPlans")
                        .WithMany("GuestList")
                        .HasForeignKey("WeddPlansPlanId");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Lib;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(WebAppContext))]
    partial class WebAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("WebApp.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Characters")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("HiddenAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageData")
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RemoteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeenLock")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubjectId");

                    b.HasIndex("RemoteId");

                    b.HasIndex("UserId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("WebApp.Models.SubjectMeaning", b =>
                {
                    b.Property<int>("SubjectMeaningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AcceptedAnswer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Meaning")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Primary")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubjectMeaningId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectMeanings");
                });

            modelBuilder.Entity("WebApp.Models.SubjectReading", b =>
                {
                    b.Property<int>("SubjectReadingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AcceptedAnswer")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Primary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reading")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SubjectReadingId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectReadings");
                });

            modelBuilder.Entity("WebApp.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ApiKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AvailableLessonsCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AvailableReviewsCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.HasIndex("ApiKey");

                    b.HasIndex("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApp.Models.Subject", b =>
                {
                    b.HasOne("WebApp.Models.User", "User")
                        .WithMany("Subjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApp.Models.SubjectMeaning", b =>
                {
                    b.HasOne("WebApp.Models.Subject", "Subject")
                        .WithMany("Meanings")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("WebApp.Models.SubjectReading", b =>
                {
                    b.HasOne("WebApp.Models.Subject", "Subject")
                        .WithMany("Readings")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("WebApp.Models.Subject", b =>
                {
                    b.Navigation("Meanings");

                    b.Navigation("Readings");
                });

            modelBuilder.Entity("WebApp.Models.User", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CommentsDownloader.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CommentsDownloader.Migrations
{
    [DbContext(typeof(CommentsDownloaderDbContext))]
    partial class CommentsDownloaderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029");

            modelBuilder.Entity("CommentsDownloader.DTO.Entities.CommentsRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CommentsFetched");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime?>("Deleted");

                    b.Property<string>("Email");

                    b.Property<bool>("MailSent");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("RequestUrl");

                    b.Property<string>("TempFileDirectory");

                    b.Property<byte[]>("Version");

                    b.HasKey("Id");

                    b.ToTable("CommentRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
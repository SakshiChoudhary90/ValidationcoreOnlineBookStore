﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreOnlineBookStore.Models;

namespace coreOnlineBookStore.Migrations
{
    [DbContext(typeof(OnlineBookStoreDbContext))]
    partial class OnlineBookStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("coreOnlineBookStore.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorBiography")
                        .IsRequired();

                    b.Property<string>("AuthorImage")
                        .IsRequired();

                    b.Property<string>("AuthorName")
                        .IsRequired();

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("coreOnlineBookStore.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId");

                    b.Property<int?>("BookCategoryCategoryId");

                    b.Property<string>("BookImage")
                        .IsRequired();

                    b.Property<string>("BookName")
                        .IsRequired();

                    b.Property<float>("BookPrice");

                    b.Property<string>("BookType")
                        .IsRequired();

                    b.Property<int?>("PublicationId");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookCategoryCategoryId");

                    b.HasIndex("PublicationId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("coreOnlineBookStore.Models.BookCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .IsRequired();

                    b.Property<string>("CategoryName")
                        .IsRequired();

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("coreOnlineBookStore.Models.Publication", b =>
                {
                    b.Property<int>("PublicationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublicationDescription")
                        .IsRequired();

                    b.Property<string>("PublicationName")
                        .IsRequired();

                    b.HasKey("PublicationId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("coreOnlineBookStore.Models.Book", b =>
                {
                    b.HasOne("coreOnlineBookStore.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("coreOnlineBookStore.Models.BookCategory", "BookCategory")
                        .WithMany("Books")
                        .HasForeignKey("BookCategoryCategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("coreOnlineBookStore.Models.Publication", "Publication")
                        .WithMany("Books")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}

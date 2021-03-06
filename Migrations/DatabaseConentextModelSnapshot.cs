// <auto-generated />
using System;
using ImagineDreams.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImagineDreams.Migrations
{
    [DbContext(typeof(DatabaseConentext))]
    partial class DatabaseConentextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ImagineDreams.Models.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("ImagineDreams.Models.ProductEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CategoryEntityId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("Update_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryEntityId");

                    b.HasIndex("UserIdId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ImagineDreams.Models.SalesEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ProductIdId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StateIdId")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("float");

                    b.Property<int>("UserIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductIdId");

                    b.HasIndex("StateIdId");

                    b.HasIndex("UserIdId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("ImagineDreams.Models.StatesSale", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("StatesSale");
                });

            modelBuilder.Entity("ImagineDreams.Models.UserEntity", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ImagineDreams.Models.ProductEntity", b =>
                {
                    b.HasOne("ImagineDreams.Models.CategoryEntity", null)
                        .WithMany("Product")
                        .HasForeignKey("CategoryEntityId");

                    b.HasOne("ImagineDreams.Models.UserEntity", "UserId")
                        .WithMany("Product")
                        .HasForeignKey("UserIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("ImagineDreams.Models.SalesEntity", b =>
                {
                    b.HasOne("ImagineDreams.Models.ProductEntity", "ProductId")
                        .WithMany()
                        .HasForeignKey("ProductIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImagineDreams.Models.StatesSale", "StateId")
                        .WithMany("Sale")
                        .HasForeignKey("StateIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ImagineDreams.Models.UserEntity", "UserId")
                        .WithMany("Sale")
                        .HasForeignKey("UserIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductId");

                    b.Navigation("StateId");

                    b.Navigation("UserId");
                });

            modelBuilder.Entity("ImagineDreams.Models.CategoryEntity", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("ImagineDreams.Models.StatesSale", b =>
                {
                    b.Navigation("Sale");
                });

            modelBuilder.Entity("ImagineDreams.Models.UserEntity", b =>
                {
                    b.Navigation("Product");

                    b.Navigation("Sale");
                });
#pragma warning restore 612, 618
        }
    }
}

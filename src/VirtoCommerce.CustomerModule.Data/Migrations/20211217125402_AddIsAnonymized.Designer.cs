﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VirtoCommerce.CustomerModule.Data.Repositories;

namespace VirtoCommerce.CustomerModule.Data.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20211217125402_AddIsAnonymized")]
    partial class AddIsAnonymized
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.AddressEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("CountryCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DaytimePhoneNumber")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("EveningPhoneNumber")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("FaxNumber")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<bool>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("MemberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("OuterId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("RegionId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("StateProvince")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.EmailEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit");

                    b.Property<string>("MemberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("Address")
                        .HasName("IX_Email_Address");

                    b.HasIndex("MemberId");

                    b.ToTable("Email");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.MemberDynamicPropertyObjectValueEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<bool?>("BooleanValue")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeValue")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DecimalValue")
                        .HasColumnType("decimal(18,5)");

                    b.Property<string>("DictionaryItemId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int?>("IntegerValue")
                        .HasColumnType("int");

                    b.Property<string>("Locale")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("LongTextValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ObjectId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ObjectType")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PropertyId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PropertyName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ShortTextValue")
                        .HasColumnType("nvarchar(512)")
                        .HasMaxLength(512);

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.HasIndex("ObjectType", "ObjectId")
                        .HasName("IX_ObjectType_ObjectId");

                    b.ToTable("MemberDynamicPropertyObjectValue");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("MemberType")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("OuterId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("MemberType")
                        .HasName("IX_MemberType");

                    b.HasIndex("Name")
                        .HasName("IX_Member_Name");

                    b.ToTable("Member");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MemberEntity");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.MemberGroupEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("MemberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Group")
                        .HasName("IX_MemberGroup_Group");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberGroup");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.MemberRelationEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("AncestorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<int>("AncestorSequence")
                        .HasColumnType("int");

                    b.Property<string>("DescendantId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("RelationType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(64)")
                        .HasDefaultValueSql("'Membership'")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("AncestorId");

                    b.HasIndex("DescendantId");

                    b.ToTable("MemberRelation");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.NoteEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSticky")
                        .HasColumnType("bit");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifierName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("OuterId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.PhoneEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("MemberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.SeoInfoEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageAltDescription")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Keyword")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("MetaDescription")
                        .HasColumnType("nvarchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<string>("MetaKeywords")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StoreId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("MemberSeoInfo");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.ContactEntity", b =>
                {
                    b.HasBaseType("VirtoCommerce.CustomerModule.Data.Model.MemberEntity");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnName("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultBillingAddressId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("DefaultLanguage")
                        .HasColumnName("DefaultLanguage")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("DefaultShippingAddressId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("FullName")
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.Property<bool>("IsAnonymized")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("MiddleName")
                        .HasColumnName("MiddleName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PhotoUrl")
                        .HasColumnName("PhotoUrl")
                        .HasColumnType("nvarchar(2083)")
                        .HasMaxLength(2083);

                    b.Property<string>("PreferredCommunication")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("PreferredDelivery")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Salutation")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("TaxpayerId")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("TimeZone")
                        .HasColumnName("TimeZone")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.HasDiscriminator().HasValue("ContactEntity");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.EmployeeEntity", b =>
                {
                    b.HasBaseType("VirtoCommerce.CustomerModule.Data.Model.MemberEntity");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnName("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DefaultLanguage")
                        .HasColumnName("DefaultLanguage")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("FullName")
                        .HasColumnType("nvarchar(254)")
                        .HasMaxLength(254);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("MiddleName")
                        .HasColumnName("MiddleName")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("PhotoUrl")
                        .HasColumnName("PhotoUrl")
                        .HasColumnType("nvarchar(2083)")
                        .HasMaxLength(2083);

                    b.Property<string>("TimeZone")
                        .HasColumnName("TimeZone")
                        .HasColumnType("nvarchar(32)")
                        .HasMaxLength(32);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.HasDiscriminator().HasValue("EmployeeEntity");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.OrganizationEntity", b =>
                {
                    b.HasBaseType("VirtoCommerce.CustomerModule.Data.Model.MemberEntity");

                    b.Property<string>("BusinessCategory")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.HasDiscriminator().HasValue("OrganizationEntity");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.VendorEntity", b =>
                {
                    b.HasBaseType("VirtoCommerce.CustomerModule.Data.Model.MemberEntity");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(64)")
                        .HasMaxLength(64);

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.Property<string>("SiteUrl")
                        .HasColumnType("nvarchar(2048)")
                        .HasMaxLength(2048);

                    b.HasDiscriminator().HasValue("VendorEntity");
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.AddressEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Member")
                        .WithMany("Addresses")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.EmailEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Member")
                        .WithMany("Emails")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.MemberDynamicPropertyObjectValueEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Member")
                        .WithMany("DynamicPropertyObjectValues")
                        .HasForeignKey("ObjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.MemberGroupEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Member")
                        .WithMany("Groups")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.MemberRelationEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Ancestor")
                        .WithMany()
                        .HasForeignKey("AncestorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Descendant")
                        .WithMany("MemberRelations")
                        .HasForeignKey("DescendantId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.NoteEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Member")
                        .WithMany("Notes")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.PhoneEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Member")
                        .WithMany("Phones")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VirtoCommerce.CustomerModule.Data.Model.SeoInfoEntity", b =>
                {
                    b.HasOne("VirtoCommerce.CustomerModule.Data.Model.MemberEntity", "Member")
                        .WithMany("SeoInfos")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

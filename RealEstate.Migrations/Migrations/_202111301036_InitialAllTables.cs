using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Migrations
{
    [Migration(202111301036)]
    public class _202111301036_InitialAllTables : Migration
    {
        public override void Up()
        {
            Create.Table("Melks")
                  .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                  .WithColumn("RegistrationPlate").AsString(50).Nullable()
                  .WithColumn("CreateDate").AsDateTime().NotNullable()
                  .WithColumn("Size").AsInt32().NotNullable().NotNullable()
                  .WithColumn("DepositAmount").AsDecimal().Nullable()
                  .WithColumn("RentAmount").AsDecimal().Nullable()
                  .WithColumn("Price").AsDecimal().Nullable()
                  .WithColumn("Title").AsString(2000).NotNullable()
                  .WithColumn("Detail").AsString(2000).Nullable()
                  .WithColumn("Address_Title").AsString(1000).NotNullable()
                  .WithColumn("Address_Longitude").AsDouble().NotNullable()
                  .WithColumn("Address_Latitude").AsDouble().NotNullable()
                  .WithColumn("IsDeleted").AsBoolean().NotNullable().WithDefaultValue(false)
                  .WithColumn("IsActive").AsBoolean().NotNullable().WithDefaultValue(true);

            Create.Table("Apartmants")
                 .WithColumn("Id").AsInt32().PrimaryKey()
                 .ForeignKey("FK_Apartmants_Melks", "Melks", "Id")
                 .OnDelete(Rule.Cascade)
                .WithColumn("Age").AsByte().NotNullable()
                .WithColumn("RoomCount").AsByte().NotNullable()
                .WithColumn("Floor").AsByte().NotNullable()
                .WithColumn("HasElevator").AsBoolean().Nullable().WithDefaultValue(false)
                .WithColumn("HasLoan").AsBoolean().Nullable().WithDefaultValue(false)
                .WithColumn("HasStoreRoom").AsBoolean().Nullable().WithDefaultValue(false)
                .WithColumn("HasParking").AsBoolean().Nullable().WithDefaultValue(false);

            Create.Table("ApartmentComplexes")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .ForeignKey("FK_ApartmentComplexes_Melks", "Melks", "Id")
                .OnDelete(Rule.Cascade)
               .WithColumn("Age").AsByte().NotNullable()
               .WithColumn("NumberOfFloors").AsByte().NotNullable()
               .WithColumn("HasElevator").AsBoolean().Nullable().WithDefaultValue(false)
               .WithColumn("HasLoan").AsBoolean().Nullable().WithDefaultValue(false)
               .WithColumn("HasStoreRoom").AsBoolean().Nullable().WithDefaultValue(false)
               .WithColumn("HasParking").AsBoolean().Nullable().WithDefaultValue(false);

            Create.Table("AgroIndustries")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .ForeignKey("FK_AgroIndustries_Melks", "Melks", "Id")
                .OnDelete(Rule.Cascade)
                .WithColumn("BuildingSize").AsInt16().NotNullable();

            Create.Table("CommercialShops")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .ForeignKey("FK_CommercialShops_Melks", "Melks", "Id")
                .OnDelete(Rule.Cascade)
                .WithColumn("OnTheShop").AsInt16().NotNullable();

            Create.Table("Factories")
                .WithColumn("Id").AsInt32().PrimaryKey()
                .ForeignKey("FK_Factories_Melks", "Melks", "Id")
                .OnDelete(Rule.Cascade)
                .WithColumn("BuildingSize").AsInt16().NotNullable();

            Create.Table("Gardens")
               .WithColumn("Id").AsInt32().PrimaryKey()
               .ForeignKey("FK_Gardens_Melks", "Melks", "Id")
               .OnDelete(Rule.Cascade);

            Create.Table("Lands")
               .WithColumn("Id").AsInt32().PrimaryKey()
               .ForeignKey("FK_Lands_Melks", "Melks", "Id")
               .OnDelete(Rule.Cascade)
                .WithColumn("OnEarth").AsInt32().NotNullable()
                 .WithColumn("TransPassWidth").AsInt32().Nullable();

            Create.Table("ParticipationConstructions")
               .WithColumn("Id").AsInt32().PrimaryKey()
               .ForeignKey("FK_ParticipationConstructions_Melks", "Melks", "Id")
               .OnDelete(Rule.Cascade)
                .WithColumn("LengthOfLength").AsInt32().NotNullable()
                .WithColumn("NumberOfFloors").AsInt16().NotNullable()
                 .WithColumn("TransPassWidth").AsInt32().Nullable();

            Create.Table("MelkImageDocuments")
                    .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                    .WithColumn("MelkId").AsInt32().NotNullable()
                        .ForeignKey("FK_MelkImageDocuments_Melks", "Melks", "Id")
                    .WithColumn("DocumentId").AsGuid().NotNullable()
                    .WithColumn("Extension").AsString(10).NotNullable();


            Create.Table("MelkVideoDocuments")
                    .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                    .WithColumn("MelkId").AsInt32().NotNullable()
                        .ForeignKey("FK_MelkVideoDocuments_Melks", "Melks", "Id")
                    .WithColumn("DocumentId").AsGuid().NotNullable()
                    .WithColumn("Extension").AsString(10).NotNullable();

            Create.Table("Villas")
                .WithColumn("Id").AsInt32().PrimaryKey()
                    .ForeignKey("FK_Villas_Melks", "Melks", "Id")
                    .OnDelete(Rule.Cascade)
                .WithColumn("Age").AsByte().NotNullable()
                .WithColumn("RoomCount").AsByte().NotNullable()
                .WithColumn("BuildingSize").AsInt16().NotNullable()
                .WithColumn("TransPassWidth").AsInt16().Nullable();
            Create.Table("Documents")
           .WithColumn("Id").AsGuid().PrimaryKey().NotNullable()
           .WithColumn("Data").AsBinary(Int32.MaxValue)
           .WithColumn("FileName").AsString(50).Nullable()
           .WithColumn("Extension").AsString(10).Nullable()
           .WithColumn("CreationDate").AsDateTime().NotNullable();


        }
        public override void Down()
        {
            Delete.Table("Docs");
            Delete.Table("Villas");
            Delete.Table("MelkVideoDocs");
            Delete.Table("MelkImageDocs");
            Delete.Table("ParticipationConstructions");
            Delete.Table("Lands");
            Delete.Table("Gardens");
            Delete.Table("Factories");
            Delete.Table("CommercialShops");
            Delete.Table("AgroIndustries");
            Delete.Table("ApartmentComplexes");
            Delete.Table("Apartmants");
            Delete.Table("Melks");
        }
}
}

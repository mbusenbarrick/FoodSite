﻿// <auto-generated />
using FoodSite.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FoodSite.Migrations
{
    [DbContext(typeof(IngredientContext))]
    partial class IngredientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodSite.Models.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<int>("Carbs");

                    b.Property<int>("Fat");

                    b.Property<string>("Name");

                    b.Property<int>("Protein");

                    b.Property<int>("ServingSize");

                    b.Property<string>("ServingSizeUnit");

                    b.HasKey("ID");

                    b.ToTable("Ingredient");
                });
#pragma warning restore 612, 618
        }
    }
}

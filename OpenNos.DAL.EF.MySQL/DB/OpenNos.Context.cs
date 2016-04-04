﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OpenNosContainer : DbContext
    {
        public OpenNosContainer()
            : base("name=OpenNosContainer")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> account { get; set; }
        public virtual DbSet<Character> character { get; set; }
        public virtual DbSet<Portal> portal { get; set; }
        public virtual DbSet<GeneralLog> generallog { get; set; }
        public virtual DbSet<Map> map { get; set; }
        public virtual DbSet<Item> item { get; set; }
        public virtual DbSet<NpcMonster> npcmonster { get; set; }
        public virtual DbSet<InventoryItem> inventoryitem { get; set; }
        public virtual DbSet<Inventory> inventory { get; set; }
        public virtual DbSet<ShopItem> shopitem { get; set; }
        public virtual DbSet<Shop> shop { get; set; }
        public virtual DbSet<Respawn> respawn { get; set; }
        public virtual DbSet<Teleporter> teleporter { get; set; }
        public virtual DbSet<MapMonster> mapmonster { get; set; }
        public virtual DbSet<MapNpc> mapnpc { get; set; }
        public virtual DbSet<Recipe> recipe { get; set; }
        public virtual DbSet<RecipeItem> recipeitem { get; set; }
        public virtual DbSet<Drop> drop { get; set; }
        public virtual DbSet<Skill> skill { get; set; }
        public virtual DbSet<CharacterSkill> characterskill { get; set; }
        public virtual DbSet<ShopSkill> shopskill { get; set; }
        public virtual DbSet<NpcMonsterSkill> npcmonsterskill { get; set; }
        public virtual DbSet<CharacterQuicklist> characterquicklist { get; set; }
    }
}

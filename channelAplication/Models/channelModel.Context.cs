﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace channelAplication.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DefaultConnection : DbContext
    {
        public DefaultConnection()
            : base("name=DefaultConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Channels_SRs> Channels_SRs { get; set; }
        public virtual DbSet<ChannelsType> ChannelsTypes { get; set; }
        public virtual DbSet<CoveringArea> CoveringAreas { get; set; }
        public virtual DbSet<Frequencies_Owners> Frequencies_Owners { get; set; }
        public virtual DbSet<LogosLink> LogosLinks { get; set; }
        public virtual DbSet<Satellites_> Satellites_ { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
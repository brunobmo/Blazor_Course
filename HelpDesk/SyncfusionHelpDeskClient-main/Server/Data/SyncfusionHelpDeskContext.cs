﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SyncfusionHelpDesk.Data
{
    public partial class SyncfusionHelpDeskContext : DbContext
    {
        public SyncfusionHelpDeskContext()
        {
        }

        public SyncfusionHelpDeskContext(DbContextOptions<SyncfusionHelpDeskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HelpDeskTicketDetails> HelpDeskTicketDetails { get; set; }
        public virtual DbSet<HelpDeskTickets> HelpDeskTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HelpDeskTicketDetails>(entity =>
            {
                entity.Property(e => e.TicketDescription).IsRequired();

                entity.Property(e => e.TicketDetailDate).HasColumnType("datetime");

                entity.HasOne(d => d.HelpDeskTicket)
                    .WithMany(p => p.HelpDeskTicketDetails)
                    .HasForeignKey(d => d.HelpDeskTicketId)
                    .HasConstraintName("FK_HelpDeskTicketDetails_HelpDeskTickets");
            });

            modelBuilder.Entity<HelpDeskTickets>(entity =>
            {
                entity.Property(e => e.TicketDate).HasColumnType("datetime");

                entity.Property(e => e.TicketDescription).IsRequired();

                entity.Property(e => e.TicketGuid)
                    .IsRequired()
                    .HasColumnName("TicketGUID")
                    .HasMaxLength(500);

                entity.Property(e => e.TicketRequesterEmail)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TicketStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
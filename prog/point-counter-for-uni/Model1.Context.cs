﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace point_counter_for_uni
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class point_counterEntities1 : DbContext
    {
        public point_counterEntities1()
            : base("name=point_counterEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Max_type_points> Max_type_points { get; set; }
        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<point_types> point_types { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentxUniversity> StudentxUniversities { get; set; }
        public virtual DbSet<StudxSub> StudxSubs { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Subject_name> Subject_name { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<University> Universities { get; set; }
    }
}

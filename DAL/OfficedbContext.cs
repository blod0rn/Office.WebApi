using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Office.Web.DAL.Entities;
using Office.Web.Domain.Models;


namespace Office.Web.DAL;

public class OfficedbContext : DbContext
{
    

    public OfficedbContext(DbContextOptions<OfficedbContext> options)
        : base(options)
    {
    }

    public  DbSet<DepartamentEntity> Departaments { get; set; }

    public  DbSet<EmployeeEntity> Employees { get; set; }

    public  DbSet<EmployeesProjectEntity> EmployeesProjects { get; set; }

    public  DbSet<ProjectEntity> Projects { get; set; }

    public  DbSet<UserEntity> Users { get; set; }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=officeDb;Username=postgres;Password=admin");

    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }

   


}

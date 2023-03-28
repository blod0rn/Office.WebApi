using System.Collections.Generic;
using AutoMapper;
using Office.Web.DAL.Entities;
using Office.Web.Domain.Models;


namespace Office.Web.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<List<T>, List<T>>();
            CreateMap<DepartamentEntity, DepartamentModel>();
            CreateMap<DepartamentModel, DepartamentEntity>();

            CreateMap<EmployeeEntity, EmployeeModel>();
            CreateMap<EmployeeModel, EmployeeEntity>();

            CreateMap<EmployeesProjectEntity, EmployeesProjectModel>();
            CreateMap<EmployeesProjectModel, EmployeesProjectEntity>();

            CreateMap<ProjectEntity, ProjectModel>();
            CreateMap<ProjectModel, ProjectEntity>();

            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();

            CreateMap<WorkloadEntity, WorkloadModel>();
            CreateMap<WorkloadModel, WorkloadEntity>();


        }
    }
}
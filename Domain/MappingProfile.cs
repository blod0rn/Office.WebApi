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
            CreateMap<DepartamentEntity, DepartamentDto>();
            CreateMap<DepartamentDto, DepartamentEntity>();

            CreateMap<EmployeeEntity, EmployeeDto>();
            CreateMap<EmployeeDto, EmployeeEntity>();
           // CreateMap<List<EmployeeEntity>, List<EmployeeModel>>();
           // CreateMap<List<EmployeeModel>, List<EmployeeEntity>>();

            CreateMap<EmployeesProjectEntity, EmployeesProjectModel>();
            CreateMap<EmployeesProjectModel, EmployeesProjectEntity>();

            CreateMap<EmployeesProjectEntity, EmployeeProjectDto>();
            CreateMap<EmployeeProjectDto, EmployeesProjectEntity>();

            CreateMap<ProjectEntity, ProjectModel>();
            CreateMap<ProjectModel, ProjectEntity>();

            CreateMap<UserEntity, UserModel>();
            CreateMap<UserModel, UserEntity>();

            CreateMap<WorkloadEntity, WorkloadModel>();
            CreateMap<WorkloadModel, WorkloadEntity>();


        }
    }
}
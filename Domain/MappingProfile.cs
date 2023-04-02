using AutoMapper;
using Office.Web.DAL.Entities;
using Office.Web.Domain.Models;


namespace Office.Web.Domain
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {           
            CreateMap<DepartamentEntity, DepartamentDto>().ReverseMap();
            
            CreateMap<EmployeeEntity, EmployeeDto>().ReverseMap();            
            CreateMap<EmployeeEntity, EmployeeInfoDto>().ReverseMap();
            
            CreateMap<ProjectEntity, ProjectEmployeeDto>().ReverseMap();
            CreateMap<ProjectEntity, ProjectDepartamentDto>().ReverseMap();

            CreateMap<EmployeesProjectEntity, EmployeesProjectModel>().ReverseMap();            
            CreateMap<EmployeesProjectEntity, EmployeeProjectDto>().ReverseMap();
                                    
            CreateMap<UserEntity, UserModel>().ReverseMap();
            
            CreateMap<WorkloadEntity, WorkloadModel>().ReverseMap();            
        }
    }
}
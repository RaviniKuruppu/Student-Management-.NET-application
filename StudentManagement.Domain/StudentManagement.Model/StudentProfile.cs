using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement.Domain;
using System.Globalization;
using StudentManagement.Model.HelperFunction;


namespace StudentManagement.Model
{
    public class StudentProfile :Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDTO>()
                .ForMember(
                dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                dest => dest.DOB,
                    opt => opt.MapFrom(src => src.DOB.ToString("MM/dd/yyyy")))
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DOB.GetCurrentAge())
                    );
            //opt => opt.MapFrom(src => src.DOB)) ;

            CreateMap<StudentCreateDTO, Student>();
            /*.ForMember(
            dest => dest.DOB,
                opt => opt.MapFrom(src => DateTime.ParseExact(src.DOB, "yyyy-mm-dd", CultureInfo.InvariantCulture)));*/


            CreateMap<Student, StudentCreateDTO>()
            .ForMember(
            dest => dest.DOB,
                opt => opt.MapFrom(src => src.DOB.ToString("MM/dd/yyyy")))
            .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DOB.GetCurrentAge())
                    );





        }
    }
}

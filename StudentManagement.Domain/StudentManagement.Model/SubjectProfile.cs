using AutoMapper;
using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public class SubjectProfile: Profile
    {
        public SubjectProfile()
        {
            CreateMap<Subject, SubjectDTO>()
               .ForMember(
               dest => dest.ID,
                  opt => opt.MapFrom(src => src.ID))
               .ForMember(
               dest => dest.Name,
                   opt => opt.MapFrom(src => src.Name));

            CreateMap<SubjectDTO, Subject>();
        }
    }
}

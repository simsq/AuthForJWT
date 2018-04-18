using AutoMapper;
using Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public interface IAutoMappingConfiguration
    {
        void CreateMaps();

    }
    public class AutoMappingConfiguration : Profile, IAutoMappingConfiguration
    {
        public void CreateMaps()
        {
            CreateMap<AuthorizationOutput, AuthorizationInput>();
            CreateMap<AuthorizationInput, AuthorizationOutput>();
            Initialize();
        }

        private void Initialize()
        {
            Mapper.Initialize(configuration =>
            {
                configuration.AddProfile(this);
            });
        }
    }
}

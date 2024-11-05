﻿using ApplicationForTrainingWEB.Application.Mapping;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForTrainingWEB.Application.ViewModels.PostVm
{
    public class PostForListVm : IMapFrom<ApplicationForTrainingWEB.Domain.Model.Post>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public byte[] Image { get; set; }
        public string UserId { get; set; }
        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<ApplicationForTrainingWEB.Domain.Model.Post, PostForListVm>();
        }

    }
}

﻿using ApplicationForTrainingWEB.Application.Mapping;
using ApplicationForTrainingWEB.Application.ViewModels.ReadyRecipesVm;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForTrainingWEB.Application.ViewModels.ReadyPlanWorkoutVm
{
    public class ReadyPlanWorkoutForListVm :  IMapFrom<ApplicationForTrainingWEB.Domain.Model.ReadyPlanWorkout>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public string Difficulty { get; set; }
        public string PlanType {  get; set; }
        public string PlanDetails {  get; set; }
        public void ConfigureMapping(Profile profile)
        {
            profile.CreateMap<ApplicationForTrainingWEB.Domain.Model.ReadyPlanWorkout, ReadyPlanWorkoutForListVm>();
        }
    }
}

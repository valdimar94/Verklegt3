﻿using MooshakPP.Models;
using MooshakPP.Models.Entities;
using MooshakPP.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MooshakPP.Services
{
    public class TeacherService
    {
        private ApplicationDbContext db;

        public TeacherService()
        {
            db = new ApplicationDbContext();
        }

        public CreateAssignmentViewModel AddAssignment(Course model)
        {


            return null;
        }

    }
}
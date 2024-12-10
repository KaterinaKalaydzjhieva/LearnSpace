﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSpace.Core.Models.Assignment
{
    public class AllAssignmentsViewModel
    {
        public List<AssignmentServiceModel> Assignments { get; set; } = new List<AssignmentServiceModel>();
        public int AssignmentCount
        {
            get => Assignments.Count;
        }
    }
}

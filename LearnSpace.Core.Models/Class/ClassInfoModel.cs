﻿namespace LearnSpace.Core.Models.Class
{
	public class ClassInfoModel
	{
		public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string TeacherName { get; set; } = string.Empty;
        public int AssignmentCount { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSpace.Core.Models.Submission
{
    public class SubmissionFileModel
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public byte[] FileContent { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackOverflowAPI.Models.POST
{
    public class AnswerQuestion
    {
        public string answer { set; get; }
        public string answeredBy { set; get; }
        public string answeredByName { set; get; }
        public int question_id { set; get; }
    }
}

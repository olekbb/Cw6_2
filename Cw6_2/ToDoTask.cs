﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw6_2
{
    public class ToDoTask
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string OwnerId { get; set; }
        public string CreatedAt { get; set; }

        public ToDoTask(string Title, string Value)
        {
            this.Title = Title;
            this.Value = Value;
        }

    }


}

﻿using System.Collections.Generic;
using Xamarin.Forms;

namespace XCalendarFormsSample.Models
{
    public class Example
    {
        public Page Page { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}

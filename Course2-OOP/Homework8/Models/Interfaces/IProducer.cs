﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8.Models.Interfaces
{
    interface IProducer
    {
        public string Name { get; }
        public Guid ProducerId { get;  }
    }
}

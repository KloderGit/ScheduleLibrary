﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SheduleLibrary
{
    public class Place : Item, ILink
    {
        /// <summary>
        /// Ссылка на запись в 1С
        /// </summary>
        public Guid? Link { get; set; }
    }
}
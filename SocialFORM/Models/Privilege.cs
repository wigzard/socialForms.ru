﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialFORM.Models
{
    public class Privilege
    {
        public int Id { get; set; }
        public int UPrivilege { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
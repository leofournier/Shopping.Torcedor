﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Torcedor.Domain.Security
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
        public User Users { get; set; }
    }
}

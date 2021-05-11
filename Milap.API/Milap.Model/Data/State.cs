using System;
using System.Collections.Generic;

#nullable disable

namespace Milap.API.Milap.Model.Data
{
    public partial class State
    {
        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }

        public virtual Country Country { get; set; }
    }
}

using System.Collections.Generic;
using com.mehmet.oracle.entities.BaseClasses;
using NHibernate.Mapping;

namespace com.mehmet.proje.MVCWebUI.Models
{
    public class TumSinyaller
    {
        private IEnumerable<Sinyaller> _sinyaller { get; set; }
        public IEnumerable<IslenmisSinyaller> _islenmisSinyal { get; set; }

    }
}
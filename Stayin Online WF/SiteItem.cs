using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stayin_Online_WF
{
    class SiteItem
    {
        Boolean _active;
        String _target;
        String _interval;
        String _status;

        public SiteItem(Boolean active, String target, String status, String interval)
        {
            _active = active;
            _target = target;
            _status = status;
            _interval = interval;
        }

        public Boolean Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }

        public String Target
        {
            get
            {
                return _target;
            }
            set
            {
                _target = value;
            }
        }

        public String Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        public String Interval
        {
            get
            {
                return _interval;
            }
            set
            {
                _interval = value;
            }
        }

    }
}

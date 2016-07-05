using System;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace Stayin_Online_WF
{
    class SiteItem
    {
        Boolean _active;
        String _target;
        String _interval;
        String _status;
        Int32 _tick;
        Int32 _position;

        public event EventHandler StatusChanged;

        protected virtual void OnStatusChanged()
        {
            if(StatusChanged != null)
                StatusChanged.Invoke(this, EventArgs.Empty);
        }

        public SiteItem(Boolean active, String target, String status, String interval, Int32 position)
        {
            _active = active;
            _target = target;
            _status = status;
            _interval = interval;
            _position = position;
        }

        public Boolean Active
        {
            get
            {
                return _active;
            }
            set
            {
                if (_interval == "" || _target == "")
                {
                    throw new MissingFieldException("Please fill in the interval and target fields before making a row active.");
                }
                _active = value;
                _tick = 12;
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
                string pattern = @"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)";
                bool match = Regex.IsMatch(_target, pattern);
                if (match)
                {
                    _target = value;
                }
                else
                {
                    throw new WebException("Input target was not a valid URL");
                }
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

        public Int32 Tick
        {
            get
            {
                return _tick;
            }
            set
            {
                _tick = value;
                if (_interval != "") {
                    Int32 interval = Int32.Parse(new String(_interval.ToCharArray().Where(c => Char.IsDigit(c)).ToArray()));
                    if (_tick >= interval / 5)
                    {
                        bool online = Ping(_target);
                        String curStatus = (online == true) ? "Online" : "Offline";
                        if (_status != curStatus)
                        {
                            _status = curStatus;
                            OnStatusChanged();
                        }
                        _tick = 0;
                    }
                }
            }
        }

        public Int32 Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        private bool Ping(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Timeout = 3000;
                request.AllowAutoRedirect = false;
                request.Method = "HEAD";

                using (var response = request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}

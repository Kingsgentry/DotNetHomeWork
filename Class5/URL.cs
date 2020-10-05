using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    public class URL
    {
        private int index;
        public int Index { get { return index; } }

        private string url;
        public string Url { get { return url; } }

        public URL(int index, string url)
        {
            this.index = index;
            this.url = url;
        }
    }
}

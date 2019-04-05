using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBookManager.Helper
{
    public class Document
    {
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public DateTime LastAccessed { get; set; }
        public DateTime Created { get; set; }
        public string FilePath { get; set; }
        public string FilzeSize { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set;  }
        public string Publisher { get; set; }
        public String Author { get; set; }
        public DateTime PublishDate { get; set; }
        public DeweyDecimal Classification { get; set; }
        public string Category { get; set; }
    }
}

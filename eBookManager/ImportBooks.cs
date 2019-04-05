using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBookManager.Helper;
using System.IO;
using static eBookManager.Helper.ExtensionMethods;
using static System.Math;

namespace eBookManager
{
    public partial class ImportBooks : Form
    {
        private string _jsonPath;
        private List<StorageSpace> spaces;
        private enum StorageSpecSelection { New = -9999, NoSelection = -1 }

        public ImportBooks()
        {
            InitializeComponent();
            _jsonPath = Path.Combine(Application.StartupPath, "bookData.txt");
            spaces = spaces.ReadFromDataStore(_jsonPath);
        }
    }
}

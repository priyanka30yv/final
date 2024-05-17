using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoConsoleDemos
{
    internal class Voter
    {
        public int VoterId {  get; set; }
        public int PartNo {  get; set; }
        public string PartName {  get; set; }
        public int serialNo {  get; set; }
    }
    struct ChangeInfo
    {
        public string prevPartName;
        public string newPartName;
    }
}

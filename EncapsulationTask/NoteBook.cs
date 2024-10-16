using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class NoteBook:Product
    {
        public string OpSystem;
        public string Processor;
        public bool HasGraphicCard;
        public NoteBook(string brandName, string modelName, decimal price, decimal cost, int count,string opsystem,string processor,bool hasgraphiccard=false):base(brandName, modelName, price, cost, count)
        {
            OpSystem = opsystem;
            Processor = processor;
            HasGraphicCard = hasgraphiccard;
        }
        
    }
}

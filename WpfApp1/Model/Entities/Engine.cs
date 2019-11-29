using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.Entities
{
    public class Engine
    {
        public int ID { get; set; }
        public enum EngineTypes {Дизельний,бензиновий }
        public int Volume { get; set; }
        public EngineTypes? EngineType { get; set; }
    }
}

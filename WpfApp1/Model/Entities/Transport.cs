using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Model.Entities
{
    public class Transport
    {
        public int ID { get; set; }
        public enum TypeOfTransport { Машина, мотоцикл, квадроцикл, Вантажівка, Скутер }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int EngineID { get; set; }
        public Engine Engine{ get; set; }
    }
}

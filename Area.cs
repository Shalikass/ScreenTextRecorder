using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ScreenTextRecorder
{
    public class Area
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public Point Position { get; set; }
        [XmlIgnore]
        public string? LastReadData { get; set; }
        [XmlIgnore]
        public Image? Image { get; set; }
        public Area()
        {
            Name = "New Area";
            Size = new Size();
            Position = new Point();
        }
        public Area(string name, Size size, Point position)
        {
            Name = name;
            Size = size;
            Position = position;
        }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}", Name, String.IsNullOrEmpty(LastReadData) ? "" : " | ", LastReadData);
        }
    }
}

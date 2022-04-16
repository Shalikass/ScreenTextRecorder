using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTextRecorder
{
    public class Area
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
        public Point Position { get; set; }
        public string LastReadData { get; set; }
        public Image? Image { get; set; }
        public Area(string name, Size size, Point position)
        {
            Id = Guid.NewGuid();
            Name = name;
            Size = size;
            Position = position;
            LastReadData= String.Empty;
            Image = null;
        }

        public override string ToString()
        {
            return String.Format("{0}{1}{2}", Name, String.IsNullOrEmpty(LastReadData) ? "" : " | ", LastReadData);
        }
    }
}

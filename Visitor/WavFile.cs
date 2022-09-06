using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class WavFile
    {
        private List<Segment> segments = new List<Segment>();

        public static WavFile read(String fileName)
        {
            // Simulate reading a wav file and building the segments
            var wavFile = new WavFile();
            wavFile.segments.Add(new FormatSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());
            wavFile.segments.Add(new FactSegment());

            return wavFile;
        }

        public void Execute(IOperation operation) 
        {
            foreach (var s in segments) 
            {
                s.Execute(operation);
            }
        }

    }
}

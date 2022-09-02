using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class VideoEditor
    {
        private float contrast = 0.5f;
        private String text;

        public void setText(String text)
        {
            this.text = text;
        }

        public string getText() 
        {
            return this.text;
        } 

        public void removeText()
        {
            this.text = "";
        }

        public float getContrast()
        {
            return contrast;
        }

        public void setContrast(float contrast)
        {
            this.contrast = contrast;
        }

        
        public String GetCurrentState()
        {
            return "VideoEditor{" +
                    "contrast=" + contrast +
                    ", text='" + text + '\'' +
                    '}';
        }
    }
}

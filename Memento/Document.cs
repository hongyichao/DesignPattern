using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Document
    {
        private String content;
        private String fontName;
        private int fontSize;

        public DocumentState CreateState() 
        {
            return new DocumentState()
            {
                content = content,
                fontName = fontName,
                fontSize = fontSize
            };
        }

        public void RestoreState(DocumentState prevState) 
        {
            this.content = prevState.content;
            this.fontName = prevState.fontName;
            this.fontSize = prevState.fontSize;
        }


        public String getContent()
        {
            return content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }

        public String getFontName()
        {
            return fontName;
        }

        public void setFontName(String fontName)
        {
            this.fontName = fontName;
        }

        public int getFontSize()
        {
            return fontSize;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        
        public override String ToString()
        {
            return "Document{" +
                    "content='" + content + '\'' +
                    ", fontName='" + fontName + '\'' +
                    ", fontSize=" + fontSize +
                    '}';
        }
    }
}

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO;
using System.Text;

namespace IntegraDesigner
{
    /// <summary>
    /// Clase que extiende StringWriter para poder pasarle un encoding
    /// diferente a UTF16
    /// </summary>
    public class StringWriterWithEncoding : StringWriter
    {
        private Encoding _enc;

        public StringWriterWithEncoding(Encoding NewEncoding)
            : base()
        {
            _enc = NewEncoding;
        }

        public override System.Text.Encoding Encoding
        {
            get
            {
                return _enc;
            }
        }
    }
}

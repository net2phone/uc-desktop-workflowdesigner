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
using System.Collections;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace IntegraDesigner
{
    public class XMLObjectConverter
    {
        /// <summary>
        /// Metodo para serializar una Lista de objetos en un XML simple
        /// </summary>
        /// <param name="thelist"> la lista de tipo List<T> </param>
        /// <returns></returns>
        public static string List2XML(IList thelist)
        {
            string xml = "";

            try
            {


                XmlSerializer xmlSer = new XmlSerializer(thelist.GetType());
                StringWriterWithEncoding sWriter = new StringWriterWithEncoding(Encoding.UTF8);

                XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
                xsn.Add(String.Empty, "");

                xmlSer.Serialize(sWriter, thelist, xsn);

                xml = sWriter.ToString();

              



            }
            catch (Exception e)
            {
               
            }

            return xml;
        }

        /// <summary>
        /// Deserializa un string xml en un objeto conocido
        /// </summary>
        /// <param name="xml">string xml</param>
        /// <param name="t"> tipo de objeto</param>
        /// <returns></returns>
        public static IList XML2List(string xml, Type t)
        {
            try
            {
                XmlSerializer xmlSer = new XmlSerializer(t);


                StringReader x = new StringReader(xml);

               
                return (IList)xmlSer.Deserialize(x);



            }
            catch (Exception e)
            {

                return null;
            }
        }

        /// <summary>
        /// Metodo para serializar un objeto en un XML simple
        /// </summary>
        /// <param name="theobject"> un objeto cualquiera</param>
        /// <returns></returns>
        public static string Object2XML(Object theobject)
        {
            string xml = "";

            try
            {


                XmlSerializer xmlSer = new XmlSerializer(theobject.GetType());
                StringWriterWithEncoding sWriter = new StringWriterWithEncoding(Encoding.UTF8);

                XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
                xsn.Add(String.Empty, "");

              
                xmlSer.Serialize(sWriter, theobject, xsn);


                xml = sWriter.ToString();


            }
            catch (Exception e)
            {

            }


            return xml;

        }

        /// <summary>
        /// Deserializa un string xml en un objeto conocido
        /// </summary>
        /// <param name="xml"> string xml </param>
        /// <param name="t"> tipo del objeto </param>
        /// <returns></returns>
        public static object XML2Object(string xml, Type t)
        {
            try
            {
                XmlSerializer xmlSer = new XmlSerializer(t);

                StringReader x = new StringReader(xml);



                return (object)xmlSer.Deserialize(x);
            }
            catch (Exception e)
            {
                return null;
            }
        }


    }
}

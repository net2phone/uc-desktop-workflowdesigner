using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace IntegraDesigner
{
    static class DialPlanBuilder
    {
        public static string Dialplan;
        public static string DNIS;
        public static string Context;
        private static List<IActivity> DialPlanList = new List<IActivity>();
      


       

        public static void GenerateDialPlan(DesignerCanvas d)
        {

            
                StartActivity s = null;
                Connection position = null;
                DialPlanList.Clear();

                IEnumerable<Connection> connections = d.Children.OfType<Connection>();
                IEnumerable<DesignerItem> designerItems = d.Children.OfType<DesignerItem>();

                //Busco Actividad inicial para arrancar por ella
                //Obtengo contexto y DNIS de ella
                foreach (Connection item in connections)
                {
                    if (item.Source.ParentDesignerItem.Activity.AppName == "StartActivity")
                    {
                        position = item;
                        s = (StartActivity)item.Source.ParentDesignerItem.Activity;
                        DNIS = s.exten;
                        Context = s.context;
                        DialPlanList.Add(item.Source.ParentDesignerItem.Activity);
                    }
                }


                BuildPlanLines(position, d);

          
            //pongo used en falso para permitir una nueva recorrida de 0
            foreach (DesignerItem item in designerItems)
            {
                Connection c = new Connection(null,null);

                if (item.GetType() != c.GetType())
                item.Activity.Used = false;
            }

            Dialplan = "";
            foreach (var item in DialPlanList)
            {
                if (item.prio != 0 && item.AppName != "include")
                {
                    Dialplan = Dialplan + "exten=> " + DNIS + "," + item.prio + "," + item.ToString() + "\n";
                }
                else if (item.AppName == "include")
                {
                    Dialplan = Dialplan + item.ToString() + "\n";
                }

            }
         

        }
   

      



        private static void BuildPlanLines(Connection position, DesignerCanvas d)
        {

            Connection nextposition;

            if (position != null)
            {
                if (!position.Sink.ParentDesignerItem.Activity.Used)
                {

                    Guid actual = position.Sink.ParentDesignerItem.ID;
                    position.Sink.ParentDesignerItem.Activity.Used = true;


                    DialPlanList.Add(position.Sink.ParentDesignerItem.Activity);
                    position.Sink.ParentDesignerItem.Activity.prio = DialPlanList.Count - 1;


                    //si es una actividad sin condicional
                    if (position.Sink.ParentDesignerItem.Activity.MaxConectors == 1)
                    {

                        nextposition = GetNextDefault(d, actual);
                        BuildPlanLines(nextposition, d);
                    }
                    else
                    {



                        nextposition = GetNextNotDefault(d, actual);
                        if (nextposition != null)
                        {
                            BuildPlanLines(nextposition, d);
                            position.Sink.ParentDesignerItem.Activity.AlternativePath = nextposition.Sink.ParentDesignerItem.Activity.prio;
                        }

                        nextposition = GetNextDefault(d, actual);
                        if (nextposition != null)
                        {
                            BuildPlanLines(nextposition, d);
                            position.Sink.ParentDesignerItem.Activity.DefaultPath = nextposition.Sink.ParentDesignerItem.Activity.prio;
                        }


                    }
                }
                
                //si ya estaba usada la actividad a la que voy y la actual no es condicional o sea no puede saltar sola
                else if (position.Sink.ParentDesignerItem.Activity.Used && position.Source.ParentDesignerItem.Activity.MaxConectors == 1)
                {

                    Goto g = new Goto();
                    g.prio = DialPlanList.Count;
                    g.extension = "${EXTEN}";
                    g.context = Context;
                    g.pri = position.Sink.ParentDesignerItem.Activity.prio;
                    DialPlanList.Add(g);

                }
            }

        }

        private static Connection GetNextDefault(DesignerCanvas d, Guid actual)
        {
            IEnumerable<Connection> connections = d.Children.OfType<Connection>();
            
            foreach (Connection item in connections)
            {
                if (item.Source.ParentDesignerItem.ID == actual && item.DefaultPath)
                    return item;
            }
            
            return null;
        }

        private static Connection GetNextNotDefault(DesignerCanvas d, Guid actual)
        {
            IEnumerable<Connection> connections = d.Children.OfType<Connection>();

            foreach (Connection item in connections)
            {
                if (item.Source.ParentDesignerItem.ID == actual && !item.DefaultPath)
                    return item;
            }

            return null;
        }

     
    }
}

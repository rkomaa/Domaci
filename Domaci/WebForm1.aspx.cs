using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Domaci
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Hrana> h = new List<Hrana>();
        public List<Pice> P = new List<Pice>();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {


                string path = Server.MapPath("~/Meni.xml");

                IspisiXMLJELO(path);
                IspisiXMLPICE(path);

            }
            catch (Exception ex)
            {
                {
                    ErrorLabel.Text = "SERVER ERROR";
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);


                }


            }
        }
        public void IspisiXMLJELO(string path)
        {

            string id = "";
            string naziv = "";
            string cena = "";
            string sastojci="";

            using (XmlReader reader = XmlReader.Create(path))
            {
                while (reader.Read())
                {
                    
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "jelo")
                    {
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.NodeType == XmlNodeType.Attribute && reader.Name == "id")
                                    id = reader.Value;
                            }
                            reader.MoveToElement();
                        }
                    }
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "naziv")
                    {

                        reader.Read();
                        naziv = reader.Value;
                        
                        
                        
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "cena")
                    {
                        reader.Read();   
                        cena = reader.Value;
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "sastojci")
                    {
                        
                        reader.Read();
                        
                        sastojci = reader.Value;
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "jelo")
                    {
                        Hrana hr=new Hrana(id,naziv,cena,sastojci);
                        h.Add(hr);
                    }
                }
                

            }
            GridView1.DataSource= h;
            GridView1.DataBind();
        }
        public void IspisiXMLPICE(string path)
        {

            string id = "";
            string naziv = "";
            string cena = "";
            string proizvodjac = "";

            using (XmlReader reader = XmlReader.Create(path))
            {
                
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "pice")
                    {
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                if (reader.NodeType == XmlNodeType.Attribute && reader.Name == "id")
                                    id = reader.Value;
                            }
                            reader.MoveToElement();
                        }
                    }
                    if (reader.NodeType == XmlNodeType.Attribute && reader.Name == "id")
                    {
                        reader.Read();
                        id=reader.Value;
                    }
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "naziv")
                    {

                        reader.Read();
                        naziv = reader.Value;



                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "cena")
                    {
                        reader.Read();
                        cena = reader.Value;
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "sastojci")
                    {

                        reader.Read();

                        proizvodjac = reader.Value;
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "pice")
                    {
                        Pice p = new Pice(id, naziv, cena, proizvodjac);
                        P.Add(p);
                    }
                }


            }
            GridView2.DataSource = P;
            GridView2.DataBind();
        }
    }
}
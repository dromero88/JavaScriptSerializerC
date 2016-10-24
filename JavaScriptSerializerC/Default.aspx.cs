using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Reflection;

namespace JavaScriptSerializerC
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            JavaScriptSerializer jsonSerializer = new JavaScriptSerializer();
            jsonSerializer.MaxJsonLength = 50000000;
            cliente singlePerson = jsonSerializer.Deserialize<cliente>(TextBox1.Text);
            string s = jsonSerializer.Serialize(singlePerson);

            object obj = jsonSerializer.DeserializeObject(TextBox1.Text);

            //cli = DictionaryToObject<cliente>();
            //cli = (cliente)obj;

            //cli = jsonSerializer.Deserialize<cli>(TextBox1.Text);
            //Label1.Text = cli.sClass();
        }
        
    }

    public class cliente
    {
        private datos_generales _datos_generales;
        private encuestaA _encuestaA;
        private encuestaB _encuestaB;

        public datos_generales datos_generales
        {get { return this._datos_generales; }set { this._datos_generales = value; }}
        public encuestaA encuestaA
        { get { return this._encuestaA; } set { this._encuestaA = value; } }
        public encuestaB encuestaB
        { get { return this._encuestaB; } set { this._encuestaB = value; } }
    }

    public class datos_generales
    {
        private string _nombre;
        private string _apellido;
        public string nombre
        {get { return this._nombre; }set { this._nombre = value;}}
        public string apellido
        { get { return this._apellido; }set { this._apellido = value;}}
        public string sClass()
        {return "Nombre=" + nombre + " || Apellido=" + apellido;}
    }

    public class encuestaA
    {
        private string _resp1;
        private string _resp2;
        public string resp1
        { get { return this._resp1; } set { this._resp1 = value; } }
        public string resp2
        { get { return this._resp2; } set { this._resp2 = value; } }
        public encuestaA() { }

        public string sClass()
        { return "Resp1=" + resp1 + " || Resp2=" + resp2; }
    }

    public class encuestaB
    {
        private string _resp3;
        public string resp3
        { get { return this._resp3; } set { this._resp3 = value; } }
        public encuestaB() { }
        public string sClass()
        { return "Resp3=" + resp3; }
    }
}

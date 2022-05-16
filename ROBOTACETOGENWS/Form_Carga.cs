using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ROBOTACETOGENWS.Modelo;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace ROBOTACETOGENWS
{
    public partial class Form_Carga : DevExpress.XtraEditors.XtraForm
    { 
        //request cuando consumo y mando parametros
        //response 
        List<string> listar = new List<string>();
        List<string> ListaLineas = new List<string>();
        private const string URL = "http://186.10.112.100/apirestful_proteknica/public/nvv-aceto/";
        private string token = "MfOB1ni8dsfxX4C6FeP4KmeTDaAbf4RUjy9D7OacIaja7RE1KxKPVXapeSau6231";
        bool bandera = false;
        bool BanderaFTP = false;

        public Form_Carga()
        {
            InitializeComponent();
        }

        private void simpleButton_Carga_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                bandera = true;
                //lista();
                Conectar();
                bandera = false;
            }
            else
            {
                return;
            }
        }

        public void lista()
        {
            try
            {
                DateTime fecha_Actu = DateTime.Now;
                textEdit_Date.Text = fecha_Actu.ToString();
                //Metodo Para obtener todas las ordenes mediante un group by y agregarlas a una lista
                DBDataContext linq = new DBDataContext();
                int g = 0;
                string UltmArchivo = "";
                var query = from datos in linq.ACETOGEN_Picking where datos.Id_Estado == 1 group datos by datos.Numero_Orden into ho select ho;
                foreach (var item in query)
                {
                    listar.Add(item.Key);
                }
                //recorrer la lista con todas las ordenes 
                foreach (var item in listar)
                {
                    g++;
                    UltmArchivo = item;
                    //hacer query con cada una de las ordenes,para obtener todas las lineas de la orden
                    var query2 = from datos in linq.ACETOGEN_Picking where datos.Numero_Orden == item select datos;
                    foreach (var item2 in query2)
                    {
                        string empresa = item2.Codigo_Empresa;
                        string Documento = item2.Codigo_Documento.Trim();
                        string numeroOrden = item2.Numero_Orden;
                        string CodProductio = item2.Codigo_Producto;
                        string cantidad = item2.Cantidad_Picking.ToString();
                        string fecha = item2.FechaTransaccion.ToString();
                        long tipoDoc = Convert.ToInt64(item2.TipoDoc);
                        //agregamos las lineas de la orden en una lista aparte para poder ingresarla en el txt
                        ListaLineas.Add(empresa+ ";" + Documento+ ";" + numeroOrden+ ";" + CodProductio + ";" + cantidad + ";" + fecha+";"+tipoDoc.ToString());
                        //linq.ACETOGEN_Picking_UpdKey(item2.Id_Orden);
                        linq.ACETOGEN_Picking_UpdKey(item2.Id_Orden);
                    }
                    //usamos el streamreader para crear y escribir el archivo
                    using (StreamWriter txt = new StreamWriter("./" + item + ".txt"))
                    {
                        //recorremos la lita que contiene laslineas de la orden
                        foreach (var itemLineas in ListaLineas)
                        {
                            //ingresamos el contenido de la lista al txt
                            txt.WriteLine(itemLineas);
                        }
                        //limpiamos la lista con las lineas asignadas a la orden para ocuparla en otra orden
                        ListaLineas.Clear();
                    }
                    //generamos el metodo para subir el txt al ftp
                    Subida(item);
                    File.Delete("./" + item + ".txt");
                }
                textEdit_CantOrden.Text = g.ToString();
                textEdit_UltmOrden.Text = UltmArchivo.ToString();
            }
            catch (Exception ex)
            {
                bandera = false;
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void Subida(string nombre)
        {
            try
            {
                string archivo = "./" + nombre + ".txt";
                FileInfo file = new FileInfo(archivo);
                string carpeta = "ftp://186.10.112.100/wms_txt/";
                string usuario = "WMS";
                string password = "Corp2020.,";
                NetworkCredential credenciales = new NetworkCredential(usuario, password);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(carpeta + file.Name);
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = credenciales;

                Stream stream = request.GetRequestStream();
                FileStream files = File.OpenRead(archivo);
                int lenght = 1024;
                byte[] buffer = new byte[lenght];
                int bytesRead = 0;
                do
                {
                    bytesRead = files.Read(buffer, 0, lenght);
                    stream.Write(buffer, 0, bytesRead);
                } while (bytesRead != 0);
                files.Close();
                stream.Close();
            }
            catch (Exception ex)
            {
                bandera = false;
                MessageBox.Show(ex.Message.ToString());
            }

        }

        public HttpClient GetClient(string token)
        {
            var authValue = new AuthenticationHeaderValue("Bearer", token);

            var client = new HttpClient()
            {
                DefaultRequestHeaders = { Authorization = authValue }

            };
            return client;
        }

        public void _EnvioCorreo(string _Subject, string _Mensaje)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add("panchox46@gmail.com");
            //msg.To.Add("soporte@loditec.cl");
            msg.Subject = _Subject; // "Ejemplo Archivos Salientes";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "";
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new System.Net.Mail.MailAddress("interface@loditec.cl");

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            cliente.Credentials = new System.Net.NetworkCredential("interface@loditec.cl", "Interface2020");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";

            try
            {
                cliente.Send(msg);
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message.ToString());
            }
        }

        public void Conectar()
        {
            try
            {
                DBDataContext linq = new DBDataContext();
                try
                {
                    var cliente = GetClient(token);
                    cliente.BaseAddress = new Uri(URL);
                    long estado = 1;
                    HttpResponseMessage resp = cliente.GetAsync(URL).Result;
                    if (resp.IsSuccessStatusCode == true)
                    {
                        linq.ACETOGEN_TXTINLOG_InsKey("Inicia Conexion WS","Conexion WS");
                        int g = 0;
                        string ultmArch = "";
                        var resultstring = resp.Content.ReadAsStringAsync().Result;
                        JObject result = JObject.Parse(resultstring);
                        var clietearray = result["data"].Value<JArray>();
                        List<Orden> or = clietearray.ToObject<List<Orden>>();
                        //DBDataContext linq = new DBDataContext();
                        //_EnvioCorreo("robot","Acetogen");
                        if (or.Count() > 0)
                        {
                            linq.ACETOGEN_JSON_InsKey(resultstring);
                            linq.ACETOGEN_Delete_Temporal(estado);
                            foreach (var item in or)
                            {
                                g++;
                                ultmArch = item.NUM_ORDEN;
                                DateTime fecha = Convert.ToDateTime(item.FECHA);
                                string cantidad = item.CANT_SOLICITADA;
                                int index = cantidad.IndexOf(".");
                                if (index > 0)
                                {
                                    cantidad = cantidad.Substring(0, index);
                                    
                                    linq.ACETOGEN_OrdenesWS_InsKey(item.NUM_ORDEN, item.NUM_DOCUMENTO, item.CODIGO_CLIENTE, item.CODIGO_SUCURSAL, item.COD_DIREC, item.DIRECCION, item.COMUNA, item.region, fecha, item.OCC, item.NUM_REFERENCIA, item.FEC_SOLICITADA, item.FEC_DOCUMENTO, item.FEC_VENCIMIENTO, item.OBSERVAC, item.TRANSPORTE, item.COD_PRODUCTO, item.NOM_PRODUCTO, Convert.ToInt64(cantidad), Convert.ToInt64(item.EMPRESA), Convert.ToInt64(item.TIPO_DOCTO), item.NOM_CLIENTE, item.BODEGA);
                                }
                            }
                            linq.ACETOGEN_ACETOGEN_TXTIN_Carga(estado);
                        }
                        if (g > 0)
                        {
                            linq.ACETOGEN_TXTINLOG_InsKey("Se registran un total de '" + g.ToString() + "' lineas","Ingreso de Lineas"); ;
                        }
                        else
                        {
                            linq.ACETOGEN_TXTINLOG_InsKey("No se encontraron lineas para ingresar","Sin Lineas Para Ingresar");
                        }
                        textEdit_CantArchivo.Text = g.ToString();
                        textEdit_UltmArchivo.Text = ultmArch.ToString();
                        resp.Dispose();
                        linq.ACETOGEN_TXTINLOG_InsKey("Termina Conexion WS","Desconexion WS");
                    }
                    else
                    {
                        linq.ACETOGEN_TXTINLOG_InsKey("No se establece conexion con WS", "ERROR COnexion WS");
                    }
                }
                catch (Exception ex)
                {
                    bandera = false;
                    linq.ACETOGEN_TXTINLOG_InsKey(ex.Message.ToString(), "ERROR COnexion WS");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Sin Conexion Al servidor : " + ex.Message.ToString());
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                bandera = true;
                lista();
                Conectar();
                bandera = false;
            }
            else
            {
                return;
            }
        }
    }
}
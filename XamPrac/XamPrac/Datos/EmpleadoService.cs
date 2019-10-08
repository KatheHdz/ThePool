using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamPrac.Model;

namespace XamPrac.Datos
{
    public class EmpleadoService : IApiEmpleados
    {
        HttpClient _client; private List<EmpleadoModel> ListaItems { get; set; }
        string RutaApi;

        public EmpleadoService()
        {
            _client = new HttpClient(); RutaApi = "Tbl_empleados";
        }
        public async Task Borrar(int id)
        {
            var uri = new Uri(string.Format(Constants.DireccionURL + RutaApi + "/" + id.ToString(), string.Empty));
            try
            {
                var response = await _client.DeleteAsync(uri);
            }
            catch (Exception ex)
            {

            }

        }

        public async Task Guardar(EmpleadoModel empleados, bool EsNuevo = false)
        {
            try
            {
                var json = JsonConvert.SerializeObject(empleados); var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                if (EsNuevo)
                {
                    var uri = new Uri(string.Format(Constants.DireccionURL + RutaApi, string.Empty));
                    response = await _client.PostAsync(uri, content);
                }

                else
                {
                    var uri = new Uri(string.Format(Constants.DireccionURL + RutaApi + "/{0}", empleados.Id_Empleado, string.Empty));
                    response = await _client.PutAsync(uri, content);
                }

            }

            catch (Exception ex)
            {

            }

        }  

        public async Task<EmpleadoModel> ObtenerEmpleadosPorId(int Id)
        {
            EmpleadoModel Item = new EmpleadoModel();
            var uri = new Uri(string.Format(Constants.DireccionURL + RutaApi + "/" + Id.ToString(), string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                string content = await response.Content.ReadAsStringAsync();
                Item = JsonConvert.DeserializeObject<EmpleadoModel>(content);

            }
            catch (Exception ex)
            {

            }

            return Item;
        }

        public async Task<IList<EmpleadoModel>> ObtenerLista()
        {
            ListaItems = new List<EmpleadoModel>();
            var uri = new Uri(string.Format(Constants.DireccionURL + RutaApi, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);

                string content = await response.Content.ReadAsStringAsync();
                ListaItems = JsonConvert.DeserializeObject<List<EmpleadoModel>>(content);

            }
            catch (Exception ex)
            {

            }

            return ListaItems;
        }
    }
}

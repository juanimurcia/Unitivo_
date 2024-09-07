using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica.Constructores;

namespace Unitivo.Repositorio.Interfaces
{
    public interface ClienteInterface
    {
        public bool AgregarCliente(Cliente cliente);
        public bool EliminarCliente(int id);
        public bool ModificarCliente(Cliente cliente);
        public Cliente BuscarClientPorId(int id);

        public Cliente BuscarClientePorMail(string mail);   
        public List<Cliente> BuscarCliente(object parametro);
        public List<Cliente> ListarClientes();
        public List<Cliente> ListarClientesActivos();
    }
}
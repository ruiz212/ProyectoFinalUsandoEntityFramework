using SuperLaEspoeranzaEntityFrameworck.Data;
using SuperLaEspoeranzaEntityFrameworck.DOTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Controlador
{
    public class ProveedorDb
    {
        SuperLaEsperanzaDbContex SuperLaEsperanzaDbContex = new SuperLaEsperanzaDbContex();
        


        public void AgregarPreveedor(ProveedorDOT proveedorDOT)
        {
            var proveedorAgregar = new Models.Proveedor
            {
                IdProveedor = proveedorDOT.IdProveedor,
                Nombre = proveedorDOT.Nombre,
                Telefono = proveedorDOT.Telefono,
                Correo = proveedorDOT.Correo,
                Direccion = proveedorDOT.Direccion,
                Estado = true
            };
            SuperLaEsperanzaDbContex.Proveedor.Add(proveedorAgregar);
            SuperLaEsperanzaDbContex.SaveChanges();
        }
        public List<DOTs.ProveedorDOT> ObtenerProveedores()
        {
            var proveedores = SuperLaEsperanzaDbContex.Proveedor.OrderBy(c => c.Nombre).ToList();
            List<DOTs.ProveedorDOT> proveedorDtos = new List<DOTs.ProveedorDOT>();
            foreach (var proveedor in proveedores)
            {
                proveedorDtos.Add(new DOTs.ProveedorDOT
                {
                    IdProveedor = proveedor.IdProveedor,
                    Nombre = proveedor.Nombre,
                    Telefono = proveedor.Telefono,
                    Correo = proveedor.Correo,
                    Direccion = proveedor.Direccion,
                    Estado = proveedor.Estado
                });
            }
            return proveedorDtos;
        }
    }
}

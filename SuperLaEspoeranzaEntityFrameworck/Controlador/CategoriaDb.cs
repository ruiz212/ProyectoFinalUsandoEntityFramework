using SuperLaEspoeranzaEntityFrameworck.Data;
using SuperLaEspoeranzaEntityFrameworck.DOTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Controlador
{
    public class CategoriaDb
    {
        public SuperLaEsperanzaDbContex SuperLaEsperanzaDbContex = new SuperLaEsperanzaDbContex();
        public void AgregarCategoria(CategoraDOT categoriaDOT)
        {
            var categoriaAgregar = new Models.Categoria
            {
                IdCategoria = categoriaDOT.IdCategoria,
                Nombre = categoriaDOT.Nombre,

            };
            SuperLaEsperanzaDbContex.Categoria.Add(categoriaAgregar);
            SuperLaEsperanzaDbContex.SaveChanges();
        }

        public List<CategoraDOT> ObtenerCategorias()
        {
            var categorias = SuperLaEsperanzaDbContex.Categoria.OrderBy(c => c.Nombre).ToList();
            List<CategoraDOT> categoriaDtos = new List<CategoraDOT>();
            foreach (var categoria in categorias)
            {
                categoriaDtos.Add(new CategoraDOT
                {
                    IdCategoria = categoria.IdCategoria,
                    Nombre = categoria.Nombre,
                });
            }
            return categoriaDtos;
        }
    }
}

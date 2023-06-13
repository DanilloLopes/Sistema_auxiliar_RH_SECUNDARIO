using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Documentos

    {
        public string Documento { get; set; }
        public int Id { get; set; }

        public List<Documentos> TodosOsDocumentos()
        {
            var listaDocumentos = new List<Documentos>();
            
            listaDocumentos.Add(new Documentos { Documento = "Carteira de Identidade", Id = 01 });
            listaDocumentos.Add(new Documentos { Documento = "Carteira Nacional de Habilitação", Id = 02 });
            listaDocumentos.Add(new Documentos { Documento = "Carteira de Trabalho", Id = 03 });
            listaDocumentos.Add(new Documentos { Documento = "Carteira Profissional", Id = 04 });
            listaDocumentos.Add(new Documentos { Documento = "Carteira de Identificação Funcional", Id = 05 });
            listaDocumentos.Add(new Documentos { Documento = "Registro Nacional de Estrangeiro", Id = 06 });
            listaDocumentos.Add(new Documentos { Documento = "Passaporte", Id = 07 });

            return listaDocumentos;
        }
    }
}

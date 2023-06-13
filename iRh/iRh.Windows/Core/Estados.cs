using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRh.Windows.Core
{
    public class Estados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }

        public List<Estados> ObterTodosEstados()
        {
            var listaDeEstados = new List<Estados>();

            listaDeEstados.Add(new Estados
            {
                Id = 11,
                Nome = "Rondônia",
                Sigla = "RO"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 12,
                Nome = "Acre",
                Sigla = "AC"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 13,
                Nome = "Amazonas",
                Sigla = "AM"
            });
            listaDeEstados.Add(new Estados { 
                Id = 14, 
                Nome = "Roraíma",
                Sigla = "RR"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 15,
                Nome = "Pará",
                Sigla = "PA"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 16,
                Nome = "Amapá",
                Sigla = "AM"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 17,
                Nome = "Tocantins",
                Sigla = "TO"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 21,
                Nome = "Maranhão",
                Sigla = "MA"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 21,
                Nome = "Maranhão",
                Sigla = "MA"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 22,
                Nome = "Piauí",
                Sigla = "PI"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 23,
                Nome = "Ceará",
                Sigla = "CE"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 24,
                Nome = "Rio Grande do Norte",
                Sigla = "RN"
            });
            listaDeEstados.Add(new Estados
            {
                Id = 24,
                Nome = "Rio Grande do Norte",
                Sigla = "RN"
            });
            return listaDeEstados;
        }
    }
}

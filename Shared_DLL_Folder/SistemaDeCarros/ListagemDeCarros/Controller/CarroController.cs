using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    public class CarroController
    {
        SistemaCarrosContext sistemaCarrosContextObjeto = new SistemaCarrosContext();
        /// <summary>
        /// Método que retorna a lista de carros completa
        /// </summary>
        /// <returns></returns>
        public List<Carro> ListarInformacoes()
        {
            return sistemaCarrosContextObjeto.ListaCarrosPublica;
        }



    }
}

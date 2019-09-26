using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    class SistemaCarrosContext
    {
        private List<Carro> ListaCarros { get; set; }

        public SistemaCarrosContext()
        {
            ListaCarros.Add(new Carro() { Id = 1, Modelo = "Barrigudinho", Ano = 2015, Cilindradas = 157, Marca = "Toyota", Portas = 4 });
            ListaCarros.Add(new Carro() { Id = 2, Modelo = "Onça Pintada", Ano = 2017, Cilindradas = 16, Marca = "Tupperware", Portas = 4 });
            ListaCarros.Add(new Carro() { Id = 3, Modelo = "Apple Deusa", Ano = 2014, Cilindradas = 47, Marca = "De", Portas = 4 });
            ListaCarros.Add(new Carro() { Id = 4, Modelo = "Calo", Ano = 2018, Cilindradas = 16, Marca = "Lentes", Portas = 4 });
            ListaCarros.Add(new Carro() { Id = 5, Modelo = "Imposto é roubo", Ano = 2015, Cilindradas = 78, Marca = "Contato", Portas = 4 });
            ListaCarros.Add(new Carro() { Id = 6, Modelo = "Balaguijhonson", Ano = 2010, Cilindradas = 645, Marca = "Pepsi", Portas = 4 });
            ListaCarros.Add(new Carro() { Id = 7, Modelo = "Sofia", Ano = 2019, Cilindradas = 80, Marca = "Frozen", Portas = 2 });
            ListaCarros.Add(new Carro() { Id = 8, Modelo = "Psita", Ano = 2014, Cilindradas = 300, Marca = "Nesquik", Portas = 1 });
            ListaCarros.Add(new Carro() { Id = 9, Modelo = "Biridjin", Ano = 2015, Cilindradas = 16, Marca = "Fiona", Portas = 4 });
            ListaCarros.Add(new Carro() { Id = 10, Modelo = "Roxa", Ano = 2008, Cilindradas = 76, Marca = "Queria", Portas = 4 });
        }

        public List<Carro> ListaCarrosPublica { get { return ListaCarros; } }

    }
}

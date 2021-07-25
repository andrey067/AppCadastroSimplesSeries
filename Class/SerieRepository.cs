using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
    public class SerieRepository : IRepository<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(string id, Series entidade)
        {
            int indice = listaSeries.FindIndex(i => i.Id.Equals(id));
            listaSeries[indice] = entidade;
        }

        public void Exclui(string id)
        {
            int indice = listaSeries.FindIndex(i => i.Id.Equals(id));
            listaSeries[indice].Excluir();
        }

        public void Insere(Series entidade)
        {
            listaSeries.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listaSeries;
        }

        public string ProximoId()
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
        }

        public Series RetornaPorId(string id)
        {
            int indice = listaSeries.FindIndex(i => i.Id.Equals(id));
            return listaSeries[indice];
        }
    }
}
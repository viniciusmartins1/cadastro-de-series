using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;


namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            throw new NotImplementedException();
        }

        public void Eclui(int id)
        {
            throw new NotImplementedException();
        }

        public void Insere(Series entidade)
        {
            throw new NotImplementedException();
        }

        public List<Series> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Series RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
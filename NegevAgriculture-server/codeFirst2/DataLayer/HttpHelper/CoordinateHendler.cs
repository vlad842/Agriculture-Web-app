using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using codeFirst2.DataLayer.Repositories;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;

namespace codeFirst2.DataLayer.HttpHelper
{
    public class CoordinateHendler : HttpHendlerRequestGeneric<Coordinate>
    {
        public CoordinateHendler(GenericRepository<Coordinate> repository) : base(repository)
        {
        }
        //private CoordinateRepository m_CoordinateRepository;

        //public CoordinateHendler()
        //{
        //    m_CoordinateRepository = new CoordinateRepository();
        //}

        //public void DeleteRow(int i_ID, DbContext i_Context)
        //{
        //    m_CoordinateRepository.MyContext = i_Context;
        //    m_CoordinateRepository.DeleteRow(i_ID);
        //    m_CoordinateRepository.Save();
        //}

        //public IEnumerable<ITableEntity> GetAllTable(DbContext i_Context)
        //{
        //    m_CoordinateRepository.MyContext = i_Context;
        //    return m_CoordinateRepository.GetNegevEntityCollection();
        //}

        //public ITableEntity GetRowByID(int i_ID, DbContext i_Context)
        //{
        //    m_CoordinateRepository.MyContext = i_Context;
        //    return m_CoordinateRepository.GetRowByKey(i_ID);
        //}

        //public void PostNewRow(ITableEntity i_NewRow, DbContext i_Context)
        //{
        //    m_CoordinateRepository.MyContext = i_Context;
        //    m_CoordinateRepository.AddRow(i_NewRow as Coordinate);
        //    m_CoordinateRepository.Save();
        //}

        //public void UpdateRow(ITableEntity i_RowToUpdate, DbContext i_Context)
        //{
        //    m_CoordinateRepository.MyContext = i_Context;
        //    m_CoordinateRepository.UpdateRow(i_RowToUpdate as Coordinate);
        //    m_CoordinateRepository.Save();
        //}

    }
}
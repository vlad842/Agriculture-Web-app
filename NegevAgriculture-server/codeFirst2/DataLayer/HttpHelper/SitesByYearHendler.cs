using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using codeFirst2.DataLayer.Repositories;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;

namespace codeFirst2.DataLayer.HttpHelper
{
    public class SitesByYearHendler : HttpHendlerRequestGeneric<SiteByYear>
    {
        public SitesByYearHendler(GenericRepository<SiteByYear> repository) : base(repository)
        {
        }
        //private SiteByYearRepository m_SiteByYearRepository;

        //public SitesByYearHendler()
        //{
        //    m_SiteByYearRepository = new SiteByYearRepository();
        //}

        //public void DeleteRow(int i_ID, DbContext i_Context)
        //{
        //    m_SiteByYearRepository.MyContext = i_Context;
        //    m_SiteByYearRepository.DeleteRow(i_ID);
        //    m_SiteByYearRepository.Save();
        //}

        //public IEnumerable<ITableEntity> GetAllTable(DbContext i_Context)
        //{
        //    m_SiteByYearRepository.MyContext = i_Context;
        //    return m_SiteByYearRepository.GetNegevEntityCollection();
        //}

        //public ITableEntity GetRowByID(int i_ID, DbContext i_Context)
        //{
        //    m_SiteByYearRepository.MyContext = i_Context;
        //    return m_SiteByYearRepository.GetRowByKey(i_ID);
        //}

        //public void PostNewRow(ITableEntity i_NewRow, DbContext i_Context)
        //{
        //    m_SiteByYearRepository.MyContext = i_Context;
        //    m_SiteByYearRepository.AddRow(i_NewRow as SiteByYear);
        //    m_SiteByYearRepository.Save();
        //}

        //public void UpdateRow(ITableEntity i_RowToUpdate, DbContext i_Context)
        //{
        //    m_SiteByYearRepository.MyContext = i_Context;
        //    m_SiteByYearRepository.UpdateRow(i_RowToUpdate as SiteByYear);
        //    m_SiteByYearRepository.Save();
        //}

    }
}
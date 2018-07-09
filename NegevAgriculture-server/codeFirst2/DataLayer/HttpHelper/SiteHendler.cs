using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using codeFirst2.DataLayer.Repositories;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;

namespace codeFirst2.DataLayer.HttpHelper
{
    public class SiteHendler : HttpHendlerRequestGeneric<Site>
    {
        public SiteHendler(GenericRepository<Site> repository) : base(repository)
        {
        }
        //private SiteRepository m_SiteRepository;

        //public SiteHendler()
        //{
        //    m_SiteRepository = new SiteRepository();
        //}

        //public void DeleteRow(int i_ID, DbContext i_Context)
        //{
        //    m_SiteRepository.MyContext = i_Context;
        //    m_SiteRepository.DeleteRow(i_ID);
        //    m_SiteRepository.Save();
        //}

        //public IEnumerable<ITableEntity> GetAllTable(DbContext i_Context)
        //{
        //    m_SiteRepository.MyContext = i_Context;
        //    return m_SiteRepository.GetNegevEntityCollection() as List<Site>;
        //}

        //public ITableEntity GetRowByID(int i_ID, DbContext i_Context)
        //{
        //    m_SiteRepository.MyContext = i_Context;
        //    return m_SiteRepository.GetRowByKey(i_ID) as Site;
        //}

        //public void PostNewRow(ITableEntity i_NewRow, DbContext i_Context)
        //{
        //    m_SiteRepository.MyContext = i_Context;
        //    m_SiteRepository.AddRow(i_NewRow as Site);
        //    m_SiteRepository.Save();
        //}

        //public void UpdateRow(ITableEntity i_RowToUpdate, DbContext i_Context)
        //{
        //    m_SiteRepository.MyContext = i_Context;
        //    m_SiteRepository.UpdateRow(i_RowToUpdate as Site);
        //    m_SiteRepository.Save();
        //}

    }
}
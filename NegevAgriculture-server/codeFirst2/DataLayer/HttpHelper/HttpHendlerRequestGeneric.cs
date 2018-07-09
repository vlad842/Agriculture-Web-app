using codeFirst2.DataLayer.Repositories;
using System.Collections.Generic;
using System.Data.Entity;

namespace codeFirst2.DataLayer.HttpHelper
{
    public abstract class HttpHendlerRequestGeneric<T> where T : class
    {
        GenericRepository<T> m_Repository;

        public HttpHendlerRequestGeneric(GenericRepository<T> repository)
        {
            m_Repository = repository;
        }

        public void DeleteRow(int i_ID, DbContext i_Context)
        {
            m_Repository.MyContext = i_Context;
            m_Repository.DeleteRow(i_ID);
            m_Repository.Save();
        }

        public IEnumerable<T> GetAllTable(DbContext i_Context)
        {
            m_Repository.MyContext = i_Context;

            return m_Repository.GetNegevEntityCollection();
        }

        public T GetRowByID(int i_ID, DbContext i_Context)
        {
            m_Repository.MyContext = i_Context;

            return m_Repository.GetRowByKey(i_ID);
        }

        public void PostNewRow(T i_NewRow, DbContext i_Context)
        {
            m_Repository.MyContext = i_Context;
            m_Repository.AddRow(i_NewRow);
            m_Repository.Save();
        }

        public void UpdateRow(T i_RowToUpdate, DbContext i_Context)
        {
            m_Repository.MyContext = i_Context;
            m_Repository.UpdateRow(i_RowToUpdate);
            m_Repository.Save();
        }
    }
}
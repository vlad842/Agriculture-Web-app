using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using codeFirst2.DataLayer.Repositories;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;

namespace codeFirst2.DataLayer.HttpHelper
{
    public class CropHendler : HttpHendlerRequestGeneric<Crop>
    {
        public CropHendler(GenericRepository<Crop> repository) : base(repository)
        {
        }
        //private CropRepository m_CropRepository;

        //public CropHendler()
        //{
        //    m_CropRepository = new CropRepository();
        //}

        //public void DeleteRow(int i_ID, DbContext i_Context)
        //{
        //    m_CropRepository.MyContext = i_Context;
        //    m_CropRepository.DeleteRow(i_ID);
        //    m_CropRepository.Save();
        //}

        //public IEnumerable<ITableEntity> GetAllTable(DbContext i_Context)
        //{
        //    m_CropRepository.MyContext = i_Context;

        //    return m_CropRepository.GetNegevEntityCollection();
        //}

        //public ITableEntity GetRowByID(int i_ID, DbContext i_Context)
        //{
        //    m_CropRepository.MyContext = i_Context;

        //    return m_CropRepository.GetRowByKey(i_ID);
        //}

        //public void PostNewRow(ITableEntity i_NewRow, DbContext i_Context)
        //{
        //    m_CropRepository.MyContext = i_Context;
        //    m_CropRepository.AddRow(i_NewRow as Crop);
        //    m_CropRepository.Save();
        //}

        //public void UpdateRow(ITableEntity i_RowToUpdate, DbContext i_Context)
        //{
        //    m_CropRepository.MyContext = i_Context;
        //    m_CropRepository.UpdateRow(i_RowToUpdate as Crop);
        //    m_CropRepository.Save();
        //}

    }
}
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using codeFirst2.DataLayer.Repositories;
using System.Data.Entity;

namespace codeFirst2.DataLayer.HttpHelper
{
    public class LayerHendler : HttpHendlerRequestGeneric<Layer>
    {
        public LayerHendler(GenericRepository<Layer> repository) : base(repository)
        {
        }
        //private LayerRepository m_LayerRepository;

        //public LayerHendler()
        //{
        //    m_LayerRepository = new LayerRepository();
        //}

        //public void DeleteRow(int i_ID, DbContext i_Context)
        //{
        //    LayerRepository layerRepository = new LayerRepository(i_Context);
        //    layerRepository.DeleteRow(i_ID);
        //    layerRepository.Save();
        //}

        //public IEnumerable<ITableEntity> GetAllTable(DbContext i_Context)
        //{
        //    m_LayerRepository.MyContext = i_Context;
        //    return m_LayerRepository.GetNegevEntityCollection().ToList() as List<Layer>;
        //}

        //public ITableEntity GetRowByID(int i_ID, DbContext i_Context)
        //{
        //    m_LayerRepository.MyContext = i_Context;
        //    return m_LayerRepository.GetRowByKey(i_ID) as Layer;
        //}

        //public void PostNewRow(ITableEntity i_NewRow, DbContext i_Context)
        //{
        //    m_LayerRepository.MyContext = i_Context;
        //    m_LayerRepository.AddRow(i_NewRow as Layer);
        //    m_LayerRepository.Save();
        //}

        //public void UpdateRow(ITableEntity i_RowToUpdate, DbContext i_Context)
        //{
        //    m_LayerRepository.MyContext = i_Context;
        //    m_LayerRepository.UpdateRow(i_RowToUpdate as Layer);
        //    m_LayerRepository.Save();
        //}
    }
}
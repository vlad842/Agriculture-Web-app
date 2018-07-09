using codeFirst2.DataLayer;
using codeFirst2.DataLayer.HttpHelper;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;
using System.Collections.Generic;
using System.Web.Http;

namespace codeFirst2.Controllers
{
    public class LayerController : ApiController
    {
        private LayerHendler m_LayerHendler = new LayerHendler(new LayerRepository());

        [HttpGet]
        [Route("api/layer/getlayers")]
        public IHttpActionResult GetAllLayers()
        {
                using (EntitiesNegev4 context = new EntitiesNegev4())
                {
                    IHttpActionResult response = NotFound();
                    List<Layer> layersToSend = m_LayerHendler.GetAllTable(context) as List<Layer>;

                    if (layersToSend.Count > 0)
                    {
                        response = Ok(layersToSend);
                    }

                    return response;
                }
        }

        [HttpGet]
        [Route("api/layer/layerbyid")]
        public IHttpActionResult GetLayer(int i_LayerID)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                Layer layerToSend = null;
                layerToSend = m_LayerHendler.GetRowByID(i_LayerID, context) as Layer;

                if (layerToSend != null)
                {
                    response = Ok(layerToSend);
                }

                return response;
            }
        }

        [HttpPost]
        [Route("api/layer/postlayer")]
        public IHttpActionResult PostLayer(Layer i_PostedLayer)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_LayerHendler.PostNewRow(i_PostedLayer, context);
                }
                catch
                {
                    response = BadRequest("could not post...");
                }

                return response;
            }
        }

        [HttpPut]
        [Route("api/layer/updatelayer")]
        public IHttpActionResult UpdateLayer(Layer i_ModifideLayer)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_LayerHendler.UpdateRow(i_ModifideLayer, context);
                }
                catch
                {
                    response = BadRequest("could not update...");
                }

                return Ok();
            }
        }

        [HttpDelete]
        [Route("api/layer/deletelayer")]
        public IHttpActionResult DeleteLayer(int i_LayerID)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_LayerHendler.DeleteRow(i_LayerID, context);
                }
                catch
                {
                    response = BadRequest("could not delete");
                }

                return response;
            }
        }
    }
}

using codeFirst2.DataLayer;
using codeFirst2.DataLayer.HttpHelper;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;
using codeFirst2.Models.Factory;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace codeFirst2.Controllers
{
    public class CropController : ApiController
    {
        private CropHendler m_CropHendler = new CropHendler(new CropRepository());

        [HttpGet]
        [Route("api/crop/getcrops")]
        public IHttpActionResult GetAllCrops()
       {
            try
            {
                using (EntitiesNegev4 context = new EntitiesNegev4())
                {
                    IHttpActionResult response = NotFound();
                    List<Crop> cropsToSend = m_CropHendler.GetAllTable(context) as List<Crop>;

                    if (cropsToSend.Count > 0)
                    {
                        response = Ok(cropsToSend);
                    }

                    return response;
                }
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("api/crop/getcropbyid")]
        public IHttpActionResult GetCropByID(int id)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                Crop cropToSend = m_CropHendler.GetRowByID(id, context) as Crop;

                if(cropToSend != null)
                {
                    response = Ok(cropToSend);
                }

                return response;
            }
        }

        [HttpPost]
        [Route("api/crop/postcrop")]
        public IHttpActionResult PostNewCrop(Crop i_PostedCrop)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();
                IHttpHendlerRequest cropHendler = IHttpHendlerRequestFactory.CreateHttpRequestHendler("Crop");

                try
                {
                    cropHendler.PostNewRow(i_PostedCrop, context);
                }
                catch
                {
                    response = BadRequest("could not post...");
                }

                return response;
            }
        }

        [HttpPut]
        [Route("api/crop/updatecrop")]
        public IHttpActionResult UpdateCrop(Crop i_CropToBeModified)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_CropHendler.UpdateRow(i_CropToBeModified, context);
                }
                catch
                {
                    response = BadRequest("could not update...");
                }

                return response;
            }
        }

        [HttpDelete]
        [Route("api/crop/deletecrop")]
        public IHttpActionResult DeleteCrop(int i_CropID)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_CropHendler.DeleteRow(i_CropID, context);
                }
                catch
                {
                    response = BadRequest("could not delete...");
                }

                return response;
            }
        }
    }
}

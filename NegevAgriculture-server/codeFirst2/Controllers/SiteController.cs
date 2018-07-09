using codeFirst2.DataLayer;
using codeFirst2.DataLayer.HttpHelper;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;
using codeFirst2.Models.Factory;
using System.Collections.Generic;
using System.Web.Http;

namespace codeFirst2.Controllers
{
    public class SiteController : ApiController
    {
        private SiteHendler m_SiteHendler = new SiteHendler(new SiteRepository());

        [HttpGet]
        [Route("api/site/allsites")]
        public IHttpActionResult GetAllSites()
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                List<Site> sitesToSend = m_SiteHendler.GetAllTable(context) as List<Site>;

                if (sitesToSend.Count > 0)
                {
                    response = Ok(sitesToSend);
                }

                return response;
            }
        }

        [HttpGet]
        [Route("api/site/sitebyid")]
        public IHttpActionResult GetSite(int i_SiteID)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                Site siteToSend = null;
                siteToSend = m_SiteHendler.GetRowByID(i_SiteID, context) as Site;

                if(siteToSend != null)
                {
                    response = Ok(siteToSend);
                }

                return response;
            }
        }

        [HttpPost]
        [Route("api/site/postsite")]
        public IHttpActionResult PostSite(Site i_PostedSite)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_SiteHendler.PostNewRow(i_PostedSite, context);
                }
                catch
                {
                    response = BadRequest("could not post...");
                }

                return response;
            }
        }

        [HttpPut]
        [Route("api/site/updatesite")]
        public IHttpActionResult UpdateSite(Site i_ModifideSite)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_SiteHendler.UpdateRow(i_ModifideSite, context);
                }
                catch
                {
                    response = BadRequest("could not update...");
                }

                return response;
            }
        }

        [HttpDelete]
        [Route("api/site/deletesite")]
        public IHttpActionResult DeleteSite(int i_SiteID)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_SiteHendler.DeleteRow(i_SiteID, context);
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

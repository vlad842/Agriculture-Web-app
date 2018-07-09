using codeFirst2.DataLayer;
using codeFirst2.DataLayer.HttpHelper;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;
using codeFirst2.Models.Factory;
using System.Collections.Generic;
using System.Web.Http;

namespace codeFirst2.Controllers
{
    public class SiteByYearController : ApiController
    {
        private SitesByYearHendler m_SiteByYearHendler = new SitesByYearHendler(new SiteByYearRepository());

        [HttpGet]
        [Route("api/sitebyyear/getsitebyyearTable")]
        public IHttpActionResult GetAllSitesByYears()
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                List<SiteByYear> sitesByYearsToSend = m_SiteByYearHendler.GetAllTable(context) as List<SiteByYear>;

                if(sitesByYearsToSend.Count > 0)
                {
                    response = Ok(sitesByYearsToSend);
                }

                return response;
            }
        }

        [HttpGet]
        [Route("api/sitebyyear/getsitebyyearbyid")]
        public IHttpActionResult GetSiteByYear(int i_SiteByYearID)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                SiteByYear siteByYearToSend = m_SiteByYearHendler.GetRowByID(i_SiteByYearID, context) as SiteByYear;

                if(siteByYearToSend != null)
                {
                    response = Ok(siteByYearToSend);
                }

                return response;
            }
        }

        [HttpPost]
        [Route("api/sitebyyear/postsitebyyear")]
        public IHttpActionResult PostSiteByYear(SiteByYear i_PostedSiteByYear)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_SiteByYearHendler.PostNewRow(i_PostedSiteByYear, context);
                }
                catch
                {
                    response = BadRequest("could not post...");
                }

                return response;
            }
        }

        [HttpPut]
        [Route("api/sitebyyear/updatesitebyyear")]
        public IHttpActionResult UpdateSiteByYear(SiteByYear i_SiteByYearToModofied)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_SiteByYearHendler.UpdateRow(i_SiteByYearToModofied, context);
                }
                catch
                {
                    response = BadRequest("could not update...");
                }

                return response;
            }
        }

        [HttpDelete]
        [Route("api/sitebyyear/deletesitebyyear")]
        public IHttpActionResult DeleteSiteByYear(int i_SiteByYearID)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_SiteByYearHendler.DeleteRow(i_SiteByYearID, context);
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

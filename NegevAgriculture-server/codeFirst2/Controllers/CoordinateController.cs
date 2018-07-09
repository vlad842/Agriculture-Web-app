using codeFirst2.DataLayer;
using codeFirst2.DataLayer.HttpHelper;
using codeFirst2.DataLayer.Repositories.NegevEntitiesRepositories;
using codeFirst2.Models.Factory;
using System.Collections.Generic;
using System.Web.Http;

namespace codeFirst2.Controllers
{
    public class CoordinateController : ApiController
    {
        private CoordinateHendler m_CoordinateHendler = new CoordinateHendler(new CoordinateRepository());

        [HttpGet]
        [Route("api/coordinate/getcoordinates")]
        public IHttpActionResult GetAllCoordinates()
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                List<Coordinate> coordinatesToSend = m_CoordinateHendler.GetAllTable(context) as List<Coordinate>;

                if(coordinatesToSend.Count > 0)
                {
                    response = Ok(coordinatesToSend);
                }

                return response;
            }
        }

        [HttpGet]
        [Route("api/coordinate/getcoordinatebyid")]
        public IHttpActionResult GetCoordinate(int i_CoordinateID)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = NotFound();
                Coordinate coordinateToSend = m_CoordinateHendler.GetRowByID(i_CoordinateID, context) as Coordinate;

                if(coordinateToSend != null)
                {
                    response = Ok(coordinateToSend);
                }

                return response;
            }
        }

        [HttpPost]
        [Route("api/coordinate/postcoordinate")]
        public IHttpActionResult PostCoordinate(Coordinate i_PostedCoordinate)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_CoordinateHendler.PostNewRow(i_PostedCoordinate, context);
                }
                catch
                {
                    response = BadRequest("could not post");
                }

                return response;
            }
        }

        [HttpPut]
        [Route("api/coordinate/updatecoordinate")]
        public IHttpActionResult UpdateCoordinte(Coordinate i_CoordinteToModified)
        {
            using(EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_CoordinateHendler.UpdateRow(i_CoordinteToModified, context);
                }
                catch
                {
                    response = BadRequest("could not update...");
                }

                return response;
            }
        }

        [HttpDelete]
        [Route("api/coordinate/deletecoordinate")]
        public IHttpActionResult DeleteCoordinate(int i_CoordinateID)
        {
            using (EntitiesNegev4 context = new EntitiesNegev4())
            {
                IHttpActionResult response = Ok();

                try
                {
                    m_CoordinateHendler.DeleteRow(i_CoordinateID, context);
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

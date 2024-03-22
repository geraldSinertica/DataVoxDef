using DataVox.Models;
using Newtonsoft.Json;
using Repository.Models;
using Services.Servicess;
using Services.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace DataVox.Controllers
{
    [RoutePrefix("api/Report")]
    public class ReportApiController : ApiController
    {
        [HttpGet]
        [Route("Full")]
        public async Task<IHttpActionResult> getPersonReport(string identification)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                IServiceReporte service = new ServiceReport();

                Report reporte = await service.PersonReport(identification);

                if (reporte == null)
                {
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    response.Message = "Asset no encontrado verifique el id ";

                }
                else
                {
                    response.StatusCode = (int)HttpStatusCode.OK;
                    response.Message = "Reporte encontrado";
                    response.Data = reporte;
                }

                return Json(response);
            }
            catch (Exception e)
            {

                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                response.Message = e.Message;

                return Json(response);
            }
        }

        [HttpGet]
        [Route("XML")]
        public async Task<IHttpActionResult> getPersonReportXML(string identification)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                IServiceReporte service = new ServiceReport();

                Report reporte = await service.PersonReport(identification);

                if (reporte == null)
                {
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    response.Message = "Asset no encontrado verifique el id ";

                }
                else
                {
                    ReportToXmlConverter RC = new ReportToXmlConverter();
                    response.StatusCode = (int)HttpStatusCode.OK;
                    response.Message = "Reporte encontrado";
                    response.Data = RC.ConvertJsonToXml(JsonConvert.SerializeObject(reporte));
                }

                return Json(response);
            }
            catch (Exception e)
            {

                response.StatusCode = (int)HttpStatusCode.InternalServerError;
                response.Message = e.Message;

                return Json(response);
            }
        }
    }
}

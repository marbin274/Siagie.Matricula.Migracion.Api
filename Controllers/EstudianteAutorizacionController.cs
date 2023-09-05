using MediatR;
using Microsoft.AspNetCore.Mvc;
using Minedu.Fw.General.Response.Status;
using Siagie.Matricula.Migracion.Dto.Estudiante;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;

namespace Siagie.Matricula.Legacy.Api.Controllers.V1;

[ApiController]
[Route("[controller]")]
public class EstudianteAutorizacionController : ControllerBase
{

    public EstudianteAutorizacionController()
    {
    }

    [HttpGet("estudiantes")]
    [SwaggerOperation(Tags = new[] { "Recuperación - Lista de estudiantes" }, Summary = "Obtener lista de estudiantes por ie",
        OperationId = "GetEstudiantesByIeRequest")]
    [ProducesResponseType(typeof(StatusResponse<IEnumerable<GetEstudiantesByIeResponse>>), (int)HttpStatusCode.OK)]
    [ProducesResponseType(typeof(StatusResponse<IEnumerable<GetEstudiantesByIeResponse>>), (int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> Get([FromQuery] GetEstudiantesByIeRequest request)
    {
        var data = new { nombre=  "33"};
        if (data.nombre != request.GradoId) return NotFound(BuildResponse.Code40401(data));
        return Ok(BuildResponse.Code20001(data));
    
    }
}
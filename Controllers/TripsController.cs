using Microsoft.AspNetCore.Mvc;
using Trips.Data;

namespace Trips.Controllers
{
  [Route("api/[controller]")]
  public class TripsController : Controller
  {

    private ITripService _service;
    public TripsController(TripService service)
    {
      this._service = service;
    }
    [HttpGet("[action]")]
    public IActionResult GetTrips()
    {
      var allTrips = _service.GetTrips();
      return Ok();

    }
    [HttpPost("AddTrip")]
    public IActionResult AddTrip([FromBody] Trip trip)
    {
      if (trip != null)
      {
        _service.AddTrip(trip);
      }
      return Ok();

    }
    [HttpPut("UpdateTrip/{Id}")]
    public IActionResult UpdateTrip(int Id, [FromBody] Trip trip)
    {

      _service.UpdateTrip(Id, trip);
      return Ok(trip);

    }

    [HttpDelete("DeleteTrip/{id}")]

    public IActionResult DeleteTrip(int Id)
    {
      _service.DeleteTrip(Id)
      ; return Ok();
    }

    [HttpGet("SingleTrip/{Id}")]
    public IActionResult SingleTrip(int Id)
    {
      var trip = _service.GetTripById(Id);
      return Ok(trip);
    }

  }
}
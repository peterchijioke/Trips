
namespace Trips.Data
{
  public class TripService : ITripService
  {
    public void AddTrip(Trip trip)
    {
      Data.Trips.Add(trip);
    }

    public void DeleteTrip(int tripId)
    {
      var trip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
      if (trip != null)
      {
        Data.Trips.Remove(trip);
      }
    }

    public Trip GetTripById(int tripId)
    {
      var trip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
      if (trip != null)
      {
        return trip;

      }
      return null;
    }

    public List<Trip> GetTrips() => Data.Trips.ToList();

    public void UpdateTrip(int tripId, Trip trip)
    {
      var oldTrip = Data.Trips.FirstOrDefault(n => n.Id == tripId);
      if (oldTrip != null)
      {
        oldTrip.Name = trip.Name;
        oldTrip.Description = trip.Description;
        oldTrip.DateStarted = trip.DateStarted;
        oldTrip.DateCompleted = trip.DateCompleted;
      }

    }
  }
}
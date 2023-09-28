namespace Trips.Data
{
  public interface ITripService
  {
    List<Trip> GetTrips();
    Trip GetTripById(int tripId);
    void UpdateTrip(int tripId, Trip trip);
    void DeleteTrip(int tripId);
    void AddTrip(Trip trip);
  }
}
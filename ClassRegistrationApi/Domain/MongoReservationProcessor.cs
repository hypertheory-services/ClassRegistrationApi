using ClassRegistrationApi.Models;

namespace ClassRegistrationApi.Domain;

public class MongoReservationProcessor : ICreateReservations
{
    public Task<Models.Registration> CreateReservationForAsync(RegistrationRequest request)
    {
        throw new NotImplementedException();
    }
}

using DroneCop.Models;
using DroneCop.Models.CustomModel;

namespace DroneCop.Repository
{
    public interface IAuth
    {
        CustomResponse SignUp(User c);
    }
}

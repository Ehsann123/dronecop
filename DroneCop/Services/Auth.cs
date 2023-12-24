using DroneCop.Models;
using DroneCop.Models.CustomModel;
using DroneCop.Repository;

namespace DroneCop.Services
{
    public class Auth:IAuth
    {
       public CustomResponse SignUp(User c)
        {
            CustomResponse customResponse = new CustomResponse();
            try
            {
                using (var ctx = new DroneCopContext())
                {
                    ctx.Users.Add(c);
                    ctx.SaveChanges();
                }
                customResponse.Status = "Success";
                return customResponse;

            }catch (Exception ex)
            {
                throw;
            }
        
        }

      
    }
}

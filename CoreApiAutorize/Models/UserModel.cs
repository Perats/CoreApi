using CoreApi.Validators;

namespace CoreApi.Models
{
    //[Validator(typeof(UserValidator))]
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DeviceModel DeviceModel { get; set; }
    }
}

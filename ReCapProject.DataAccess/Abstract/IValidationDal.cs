using ReCapProject.Entities.Concrete;

namespace ReCapProject.DataAccess.Abstract
{
    public interface IValidationDal
    {
        bool Validate(Car car);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constants;
using ReCapProject.Business.ValidationRules.FluentValidation;
using ReCapProject.Core.Aspects.Validation;
using ReCapProject.Core.Entities.Concrete;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Concrete
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<User>> GetUsersByUserId(int userId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.UserId==userId));
        }

        public IDataResult<List<User>> GetByEmail(string email)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.Email==email));
        }

        public IDataResult<List<User>> GetByName(string name)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.FirstName==name));
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}

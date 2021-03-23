using System;
using System.Collections.Generic;
using System.Text;
using ReCapProject.Core.Utilities.Results;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.Abstract
{
    public interface IFakeCardService
    {
        IResult Add(FakeCard fakeCard);
        IResult Update(FakeCard fakeCard);
        IResult Delete(FakeCard fakeCard);
        IDataResult<List<FakeCard>> GetAll();
        IDataResult<FakeCard> GetById(int id);
        IDataResult<List<FakeCard>> GetByCardNumber(string cardNumber);
        IResult IsCardExist(FakeCard fakeCard);
    }
}

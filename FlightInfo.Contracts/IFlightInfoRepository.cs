using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FlightInfo.Models;

namespace FlightInfo.Contracts
{
  public interface IFlightInfoRepository
    {
        void Add(FlightIn flightInfo);
        FlightIn Get(int Id);
        IEnumerable<FlightIn> GetAll();
        void Update(FlightIn flightInfo);
        void Remove(int Id);
        IEnumerable<FlightIn> Find(Expression<Func<Expression, bool>> predicate);
    }
}

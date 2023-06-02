using Vehicle.InsurancePolicies.Contracts.MongoRepository;
using Vehicle.InsurancePolicies.Domain.Context;
using Vehicle.InsurancePolicies.Domain.Entities;

namespace Vehicle.InsurancePolicies.Domain.Repositories
{
  public interface IPolicyTermRepository : IRepository<VehicleInsurancePoliciesContext, PolicyTermEntity> { }
}
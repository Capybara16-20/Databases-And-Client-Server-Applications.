using System;
using System.Collections.Generic;
using Entities;
using StorageDAO;

namespace Actions
{
    public class BusinessLogic
    {
        EmployeeDAOdb employees = new EmployeeDAOdb();
        DealDAOdb deals = new DealDAOdb();
        PaymentDAOdb payments = new PaymentDAOdb();
        SpecialityDAOdb specialities = new SpecialityDAOdb();
        ExperienceDAOdb experiences = new ExperienceDAOdb();
        CustomerDAOdb customers = new CustomerDAOdb();
        HopelessnessLevelDAOdb hopelessnessLevels = new HopelessnessLevelDAOdb();
        AgreementTypeDAOdb agreementTypes = new AgreementTypeDAOdb();
        PaymentTypeDAOdb paymentTypes = new PaymentTypeDAOdb();
        StageDAOdb stages = new StageDAOdb();
        EndingStatusDAOdb endingStatus = new EndingStatusDAOdb();

        public List<Employee> GetEmployeesList()
        {
            return employees.GetEmployeesList();
        }

        public void AddEmployee(string fullName, int specialty, int experience)
        {
            Employee employee = new Employee(fullName, specialty, experience);
            employees.Add(employee);
        }

        public void EditEmployee(int id, string fullName, int specialty, int experience)
        {
            employees.Edit(id, fullName, specialty, experience);
        }

        public void DeleteEmployee(int id)
        {
            employees.Delete(id);
        }

        public List<Deal> GetDealsList()
        {
            return deals.GetDealsList();
        }

        public void EditDeal(int id, int? stage, int? status)
        {
            deals.Edit(id, stage, status);
        }

        public void DeleteDeal(int id)
        {
            deals.Delete(id);
        }

        public void AddDeal(int customer, int employee, int level, int type)
        {
            Deal deal = new Deal(customer, employee, level, type);
            deals.Add(deal);
        }

        public List<Payment> GetPaymentsList()
        {
            return payments.GetPaymentsList();
        }

        public List<Speciality> GetSpecialitiesList()
        {
            return specialities.GetSpecialitiesList();
        }

        public List<Experience> GetExperiencesList()
        {
            return experiences.GetExperiencesList();
        }

        public List<Customer> GetCustomersList()
        {
            return customers.GetCustomersList();
        }

        public List<HopelessnessLevel> GetHopelessnessLevelsList()
        {
            return hopelessnessLevels.GetHopelessnessLevelsList();
        }

        public List<AgreementType> GetAgreementTypesList()
        {
            return agreementTypes.GetAgreementTypesList();
        }

        public void EditPayment(int deal, int paymentType)
        {
            payments.Edit(deal, paymentType);
        }

        public List<PaymentType> GetPaymentTypesList()
        {
            return paymentTypes.GetPaymentTypesList();
        }

        public List<Stage> GetStagesList()
        {
            return stages.GetStagesList();
        }

        public List<EndingStatus> GetEndingStatusesList()
        {
            return endingStatus.GetEndingStatusesList();
        }
    }
}

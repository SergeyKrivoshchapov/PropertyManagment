using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyManagmentSystem.Application.DTOs;

namespace PropertyManagmentSystem.Application.Interfaces
{
    public interface IContractorService
    {
        // Общие методы для всех арендаторов
        ContractorDto GetContractorById(int id);
        IEnumerable<ContractorDto> GetAllContractors();
        void AddContractor(ContractorDto contractorDto);
        void UpdateContractor(ContractorDto contractorDto);
        void DeactivateContractor(int id, string reason);
        void ActivateContractor(int id);

        // Физические лица
        void AddIndividualContractor(IndividualContractorDto dto);
        void UpdateIndividualContractor(IndividualContractorDto dto);

        // Юридические лица
        void AddLegalEntityContractor(LegalEntityContractorDto dto);
        void UpdateLegalEntityContractor(LegalEntityContractorDto dto);

        // Договоры арендатора
        IEnumerable<AgreementDto> GetContractorAgreements(int contractorId);
        bool CanContractorCreateNewAgreement(int contractorId);
    }
}

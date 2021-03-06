using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.Models;

namespace Globomantics.Services.Interfaces
{
    public interface IProposalService
    {
        Task Add(ProposalModel model);
        Task<ProposalModel> Approve(int proposalId);
        Task<IEnumerable<ProposalModel>> GetAll(int conferenceId);
    }
}
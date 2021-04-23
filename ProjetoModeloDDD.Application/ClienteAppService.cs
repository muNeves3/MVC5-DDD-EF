using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClientService _clientService;

        public ClienteAppService(IClientService clientService) : base(clientService)
        {
            _clientService = clientService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clientService.ObterClientesEspeciais(_clientService.GetAll());
        }
    }
}

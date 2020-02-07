using Domain;
using Domain.Contratos;
using Repositorio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio()
        {

        }
    }
}

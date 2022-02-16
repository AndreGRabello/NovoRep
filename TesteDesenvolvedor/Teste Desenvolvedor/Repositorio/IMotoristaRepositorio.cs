using Teste_Desenvolvedor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Desenvolvedor.Repositorio
{
    public interface IMotoristaRepositorio
    {
        MotoristaModel ListarPorId(int id);
        List<MotoristaModel> BuscarTodos();
        MotoristaModel Adicionar(MotoristaModel motorista);
        MotoristaModel Atualizar(MotoristaModel motorista);
        bool Apagar(int id);
    }
}

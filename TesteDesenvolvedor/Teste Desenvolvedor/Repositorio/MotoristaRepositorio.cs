using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Desenvolvedor.Models;
using Teste_Desenvolvedor.Data;

namespace Teste_Desenvolvedor.Repositorio
{
    public class MotoristaRepositorio : IMotoristaRepositorio
    {
        private readonly Data.BancoContext _context;

        public MotoristaRepositorio(Data.BancoContext bancoContext)
        {
            this._context = bancoContext;
        }

        public MotoristaModel ListarPorId(int id)
        {
            return _context.Motoristas.FirstOrDefault(x => x.Id == id);
        }
        
        public List<MotoristaModel> BuscarTodos()
        {
            return _context.Motoristas.ToList();
        }
        
        public MotoristaModel Adicionar(MotoristaModel motorista)
        {
            _context.Motoristas.Add(motorista);
            _context.SaveChanges();
            return motorista;            
        }

        public MotoristaModel Atualizar(MotoristaModel motorista)
        {
            MotoristaModel motoristaDB = ListarPorId(motorista.Id);
            if (motoristaDB == null) throw new Exception("Erro na atualização");
            motoristaDB.Nome = motorista.Nome;
            motoristaDB.Sobrenome= motorista.Sobrenome;
            motoristaDB.MarcaDoCaminhao = motorista.MarcaDoCaminhao;
            motoristaDB.ModeloDoCaminhao= motorista.ModeloDoCaminhao;
            motoristaDB.PlacaDoCaminhao = motorista.PlacaDoCaminhao;
            motoristaDB.QuantidadeDeEixosDoCaminhao= motorista.QuantidadeDeEixosDoCaminhao;
            motoristaDB.EnderecoCompleto= motorista.EnderecoCompleto;

            _context.Motoristas.Update(motoristaDB);
            _context.SaveChanges();

            return motoristaDB;
        }

        public bool Apagar(int id)
        {
            MotoristaModel motoristaDB = ListarPorId(id);
            if (motoristaDB == null) throw new Exception("Erro ao apagar o registro");

            _context.Motoristas.Remove(motoristaDB);
            _context.SaveChanges();

            return true;
        }
    }
}

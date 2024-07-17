using Microsoft.EntityFrameworkCore;
using SistemasDeTarefas.Data;
using SistemasDeTarefas.Models;
using SistemasDeTarefas.Repositorios.Interfaces;

namespace SistemasDeTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasDBContext _dbContext;


        public UsuarioRepositorio(SistemaTarefasDBContext sistemaTarefasDBContext) 
        { 
             _dbContext = sistemaTarefasDBContext;
        }


        public async Task<UsuarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }


        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorID = await BuscarPorId(id);

            if (usuarioPorID == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontarado no banco de dados.");
            }

            usuarioPorID.Nome = usuario.Nome;
            usuarioPorID.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioPorID);
            await _dbContext.SaveChangesAsync();

            return usuarioPorID;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorID = await BuscarPorId(id);

            if (usuarioPorID == null)
            {
                throw new Exception($"Usuario para o ID: {id} não foi encontarado no banco de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorID);
            await _dbContext.SaveChangesAsync();

            return true;
        }


    }
}

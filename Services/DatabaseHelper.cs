using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Assistance.Services
{
    public class DatabaseHelper
    {
        readonly SQLiteAsyncConnection _db;

        public DatabaseHelper(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);

            // Criação das tabelas
            _db.CreateTableAsync<Classes.Paciente>().Wait();
            _db.CreateTableAsync<Classes.Profissional>().Wait();
            _db.CreateTableAsync<Classes.Estagiario>().Wait();
            _db.CreateTableAsync<Classes.Consultorios>().Wait();
            _db.CreateTableAsync<Classes.Servicos>().Wait();
            _db.CreateTableAsync<Classes.Consultas>().Wait();
        }

        // --- Métodos CRUD para Paciente ---
        public Task<int> AddPacienteAsync(Classes.Paciente p) => _db.InsertAsync(p);
        public Task<List<Classes.Paciente>> GetPacientesAsync() => _db.Table<Classes.Paciente>().ToListAsync();
        public Task<Classes.Paciente> GetPacienteByIdAsync(int id) => _db.Table<Classes.Paciente>().Where(x => x.Id == id).FirstOrDefaultAsync();
        public Task<int> UpdatePacienteAsync(Classes.Paciente p) => _db.UpdateAsync(p);
        public Task<int> DeletePacienteAsync(Classes.Paciente p) => _db.DeleteAsync(p);

        // --- Métodos CRUD para Profissional ---
        public Task<int> AddProfissionalAsync(Classes.Profissional p) => _db.InsertAsync(p);
        public Task<List<Classes.Profissional>> GetProfissionaisAsync() => _db.Table<Classes.Profissional>().ToListAsync();
        public Task<Classes.Profissional> GetProfissionalByIdAsync(int id) => _db.Table<Classes.Profissional>().Where(x => x.Id == id).FirstOrDefaultAsync();
        public Task<int> UpdateProfissionalAsync(Classes.Profissional p) => _db.UpdateAsync(p);
        public Task<int> DeleteProfissionalAsync(Classes.Profissional p) => _db.DeleteAsync(p);

        // --- Métodos CRUD para Estagiário ---
        public Task<int> AddEstagiarioAsync(Classes.Estagiario e) => _db.InsertAsync(e);
        public Task<List<Classes.Estagiario>> GetEstagiariosAsync() => _db.Table<Classes.Estagiario>().ToListAsync();
        public Task<Classes.Estagiario> GetEstagiarioByIdAsync(int id) => _db.Table<Classes.Estagiario>().Where(x => x.Id == id).FirstOrDefaultAsync();
        public Task<int> UpdateEstagiarioAsync(Classes.Estagiario p) => _db.UpdateAsync(p);
        public Task<int> DeleteEstagiarioAsync(Classes.Estagiario p) => _db.DeleteAsync(p);

        // --- Métodos CRUD para Consultórios ---
        public Task<int> AddConsultorioAsync(Classes.Consultorios c) => _db.InsertAsync(c);
        public Task<List<Classes.Consultorios>> GetConsultoriosAsync() => _db.Table<Classes.Consultorios>().ToListAsync();
        public Task<Classes.Consultorios> GetConsultorioByIdAsync(int id) => _db.Table<Classes.Consultorios>().Where(x => x.Id == id).FirstOrDefaultAsync();
        public Task<int> UpdateConsultorioAsync(Classes.Consultorios c) => _db.UpdateAsync(c);
        public Task<int> DeleteConsultorioAsync(Classes.Consultorios c) => _db.DeleteAsync(c);

        // --- Métodos CRUD para Serviços ---
        public Task<int> AddServicoAsync(Classes.Servicos s) => _db.InsertAsync(s);
        public Task<List<Classes.Servicos>> GetServicosAsync() => _db.Table<Classes.Servicos>().ToListAsync();
        public Task<Classes.Servicos> GetServicoByIdAsync(int id) => _db.Table<Classes.Servicos>().Where(x => x.Id == id).FirstOrDefaultAsync();
        public Task<int> UpdateServicoAsync(Classes.Servicos s) => _db.UpdateAsync(s);
        public Task<int> DeleteServicoAsync(Classes.Servicos s) => _db.DeleteAsync(s);

        // --- Métodos CRUD para Consultas ---
        public Task<int> AddConsultaAsync(Classes.Consultas c) => _db.InsertAsync(c);
        public Task<List<Classes.Consultas>> GetConsultasAsync() => _db.Table<Classes.Consultas>().ToListAsync();
        public Task<Classes.Consultas> GetConsultaByIdAsync(int id) => _db.Table<Classes.Consultas>().Where(x => x.Id == id).FirstOrDefaultAsync();
        public Task<int> UpdateConsultaAsync(Classes.Consultas c) => _db.UpdateAsync(c);
        public Task<int> DeleteConsultaAsync(Classes.Consultas c) => _db.DeleteAsync(c);

    }
}
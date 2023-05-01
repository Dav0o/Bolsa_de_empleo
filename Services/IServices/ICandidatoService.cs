using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IRepository
{
    public interface ICandidatoService
    {
        IEnumerable<Candidato> GetCandidatos();
        Candidato GetCandidatoById(int id);

        void AddCandidato(Candidato candidato);

        void UpdateCandidato(int id, Candidato candidato);

        void DeleteCandidato(int id);
    }
}

using GameStore.WebApi.Contexts;
using GameStore.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.WebApi.Repositories
{
    
    public class JogoRepository
    {
        JogosContext ctx = new JogosContext();

        public List<Jogo> ListarJogos()
        {
            try
            {
                return ctx.Jogo.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

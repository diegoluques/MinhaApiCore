using System.Collections.Generic;
using MinhaApiCore.Business.Notificacoes;

namespace MinhaApiCore.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
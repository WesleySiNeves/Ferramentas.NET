using Implanta.Common.Extensions;
using Implanta.Common.Propriedade.Atributos;
using Implanta.Common.Util;
using Implanta.Logon.Entity.Acesso;
using Implanta.Logon.Entity.Permissao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descriptografia.NET.Helper
{
    public class HelperDescriptografia
    {


        public List<PermissoesSistemasEntity> Descriptogradar(string texto, bool tipoPermissaoUsuario)
        {
            List<PermissoesSistemasEntity> permissoes = new List<PermissoesSistemasEntity>();

            SistemasImplantaEntity permissaoSistema;

            if (tipoPermissaoUsuario)
            {
                permissaoSistema = texto.FromXML<SistemasImplantaEntity>(true, true);
            }
            else
            {
                permissaoSistema = texto.FromXML<SistemasImplantaEntity>(true, true);
            }

            permissoes = GetPermissaoSistema(permissaoSistema);
        

            return permissoes;
        }

        private List<PermissoesSistemasEntity> GetPermissaoSistema(SistemasImplantaEntity sistemasImplanta)
        {
            List<PermissoesSistemasEntity> retorno = new List<PermissoesSistemasEntity>();

            foreach (var item in ImplantaLogonAttributeHelper.GetSistema(sistemasImplanta))
            {
                var sistema = new PermissoesSistemasEntity
                {
                    NomeSistema = item.Nome,
                    NomeInterno = item.NomeInterno,
                    Descricao = item.Descricao
                };

                sistema.Modulos = GetModulos(sistemasImplanta, sistema.NomeInterno);

                retorno.Add(sistema);
            }

            return retorno;
        }

        private List<PermissoesModulosEntity> GetModulos(SistemasImplantaEntity sistemasImplanta, string sistema)
        {
            var retorno = new List<PermissoesModulosEntity>();

            foreach (var modulo in ImplantaLogonAttributeHelper.GetModulo(sistemasImplanta, sistema))
            {
                var item = new PermissoesModulosEntity
                {
                    Nome = modulo.Nome,
                    NomeInterno = modulo.NomeInterno,
                    Descricao = modulo.Descricao
                };

                item.Funcionalidades = GetFuncionalidades(sistemasImplanta, sistema, item.NomeInterno);
                retorno.Add(item);
            }

            return retorno;
        }

        private List<PermissoesFuncionalidadesEntity> GetFuncionalidades(SistemasImplantaEntity sistemasImplanta, string sistema, string modulo)
        {
            var retorno = new List<PermissoesFuncionalidadesEntity>();

            foreach (var funcionalidade in ImplantaLogonAttributeHelper.GetFuncionalidade(sistemasImplanta, sistema, modulo))
            {
                var item = new PermissoesFuncionalidadesEntity(funcionalidade.Tipo == TipoPropriedade.CRUD)
                {
                    Nome = funcionalidade.Nome,
                    NomeInterno = funcionalidade.NomeInterno,
                    Descricao = funcionalidade.Descricao
                };

                var permissao = ImplantaLogonAttributeHelper.GetPermissao(sistemasImplanta, sistema, modulo, funcionalidade.NomeInterno).FirstOrDefault();

                if (funcionalidade.Tipo == TipoPropriedade.CRUD)
                {
                    if (permissao != null)
                    {
                        var crud = (CRUD)(permissao.ValorItem ?? new CRUD());
                        item.AcessoCrud = crud;
                    }
                }
                else
                {
                    if (permissao != null) item.AcessoBoleano = (bool)(permissao.ValorItem ?? false);
                    item.AcessoCrud = new CRUD();
                }

                retorno.Add(item);
            }

            return retorno;
        }
    }
}

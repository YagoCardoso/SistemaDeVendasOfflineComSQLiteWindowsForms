using System;
using Pdv.Infra;
using Pdv.Domain.Entidades;
using Dapper;
using Pdv.Domain.Repositories;

namespace Pdv.Data
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DbSession _session;

        public ClienteRepository(DbSession session)
        {
            _session = session;
        }

        public void InserirCliente(Cliente cliente)
        {
            string sql = @"
                            INSERT INTO cliente (
                                cpf, nome, dataNascimento, endereco, bairro
                              , cidade, cep, uf, rg, telefone) 
                            VALUES (@Cpf, @Nome, @DataNascimento, @Rua, @Bairo, @Cidade, @Cep, @Uf, @Rg, @Telefone)
                         ";
            _session.Connection.Query(sql, new
            {
                Rua = cliente.Endereco.Rua,
                Bairro = cliente.Endereco.Bairro,
                Cidade = cliente.Endereco.Cidade,
                Cep = cliente.Endereco.CodigoCep,
                Uf = cliente.Endereco.Uf
            });
        }

        public void AlterarCliente(Cliente cliente)
        {
            string sql = @"
                            UPDATE cliente c                                
                                nome = @Nome, 
                                dataNascimento = @DataNascimento,
                                endereco = @Rua, 
                                bairro = @Bairro,
                                cidade = @Cidade, 
                                cep = @Cep, 
                                uf = @Uf, 
                                rg = @Rg, 
                                telefone = @Telefone 
                            WHERE c.cpf = @Cpf
                         ";
            _session.Connection.Query(sql, new
            {
                Rua = cliente.Endereco.Rua,
                Bairro = cliente.Endereco.Bairro,
                Cidade = cliente.Endereco.Cidade,
                Cep = cliente.Endereco.CodigoCep,
                Uf = cliente.Endereco.Uf
            });
        }

        public Cliente ObterCliente(string cpf)
        {
            string sql = @"
                            SELECT 
                                cpf AS Cpf, 
                                nome AS Nome, 
                                dataNascimento AS DataNascimento, 
                                endereco AS Rua, 
                                bairro AS Bairo, 
                                cidade AS Cidade, 
                                cep AS Cep, 
                                uf AS Uf, 
                                rg AS Rg, 
                                telefone AS Telefone 
                            FROM cliente c
                                WHERE c.cpf = @Cpf 
                         ";
            return (Cliente) _session.Connection.Query<Cliente>(sql);
        }

        public void DeleteCliente(string cpf)
        {
            string sql = @"
                            DELETE FROM cliente
                                WHERE cpf = @Cpf
                         ";
            _session.Connection.Query(sql, new { Cpf = cpf });
        }
    }
}

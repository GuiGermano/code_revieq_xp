using BestHB.Domain.Entities;
using BestHB.Domain.Repositories;
using BestHB.Repository.InMemory;
using System;
using System.Threading.Tasks;
using BestHB.Domain.Queries;
using System.Collections.Generic;

namespace BestHB.Repository
{
    public class InstrumentInfoRepository : IRepository
    {
        public InstrumentInfoRepository()
        {
        }

        public Task<int> Add(Order order) //TODO: remover essa implementacao de add
        {
            throw new NotImplementedException();
        }

        public async Task<InstrumentInfo> Get(string symbol) //TODO: validacoes devem ser feitas na camada de serviço
        {
            var instrumentInfo = InMemoryIntrumentInfoRepository.Get(symbol);
            if(instrumentInfo == null)
            {
                Func<InstrumentInfo> mockedData = () => { return new InstrumentInfo {
                        Description = "PETROBRAS",
                        Exchange = "BOVESPA",
                        ISIN = "ABCDE12345",
                        LotStep = 100,
                        MaxLot = 1000000,
                        MinLot = 100,
                        Symbol = "PETR4",
                        Type = InstrumentType.Stock
                    };
                };

                instrumentInfo = await Task.Run(mockedData);

                if(instrumentInfo != null)
                {
                    InMemoryIntrumentInfoRepository.Add(instrumentInfo);
                }
            }

            return instrumentInfo;
        }

        public Task<List<Order>> Get(QueryOrders queryOrders) //TODO: Metodo get nao implementado em nenhum repositorio
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace BestHB.Domain.Commands
{
    public class CreateOrderCommand
    {
        public int UserId { get; set; }
        public string Symbol { get; set; }
        public decimal Quantity { get; set; }
        public OrderSide Side { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public decimal TriggerPrice { get; set; }
        public DateTime? ExpiresAt { get; set; }
    }

    public enum OrderSide //TODO: separar enums para facil localizacao e organizacao
    {
        Buy = 0,
        Sell
    }

    public enum OrderType
    {
        Limit = 0,
        Pending,
        Market,
        Stop
    }
        
}

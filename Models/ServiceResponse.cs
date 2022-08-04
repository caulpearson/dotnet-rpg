using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public T? Success { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using MongoDB.Driver.Core.Configuration;

namespace Supermarket.Models
{
    internal interface IPayModeRepository
    {

        void Add(PayModeModel payModeModel);

        void Edit(PayModeModel payModeModel);

        void Delete(int id);

        IEnumerable<PayModeModel> GetAll();

        IEnumerable<PayModeModel> GetByValue(string value);
    }
}

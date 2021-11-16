using Prodotto.EF.Entity;
using Prodotto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prodotto.Utile
{
    public static class Prog
    {
        internal static Products ProjectToDbModel(this ProductViewModel prodotto)
        {
            return new Products()
            {
                ProductId = prodotto.ProductId,
                ProductName = prodotto.ProductName,
                CategoryId = prodotto.CategoryId,
                UnitPrice = prodotto.UnitPrice,
                UnitsInStock = prodotto.UnitsInStock,
                Discontinued = prodotto.Discontinued,
                QuantityPerUnit = prodotto.QuantityPerUnit,
            };
        }
        internal static IEnumerable<ProductViewModel> ProjectToViewModel(this IEnumerable<Products> query)
        {
            return query.Select(x => new ProductViewModel()
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                CategoryId = x.CategoryId,
                UnitPrice = x.UnitPrice,
                UnitsInStock = x.UnitsInStock,
                Discontinued = x.Discontinued,
                QuantityPerUnit = x.QuantityPerUnit,
            });
        }
        internal static Products ProjectFromViewModel(this ProductViewModel prodotto)
        {
            return new Products()
            {
                ProductId = prodotto.ProductId,
                ProductName = prodotto.ProductName,
                CategoryId = prodotto.CategoryId,
                UnitPrice = prodotto.UnitPrice,
                UnitsInStock = prodotto.UnitsInStock,
                Discontinued = prodotto.Discontinued,
                QuantityPerUnit = prodotto.QuantityPerUnit,
            };
        }

    }
}

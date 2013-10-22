﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorks.Data.Queries
{
    public static partial class ProductExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.Product GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.Product> queryable, int productID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Product>;
            if (dbSet != null)
                return dbSet.Find(productID);
                
            return queryable.FirstOrDefault(p => p.ProductID == productID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.Product GetByName(this IQueryable<AdventureWorks.Data.Entities.Product> queryable, string name)
        {
            return queryable.FirstOrDefault(p => p.Name == name);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.Product GetByProductNumber(this IQueryable<AdventureWorks.Data.Entities.Product> queryable, string productNumber)
        {
            return queryable.FirstOrDefault(p => p.ProductNumber == productNumber);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.Product GetByRowguid(this IQueryable<AdventureWorks.Data.Entities.Product> queryable, System.Guid rowguid)
        {
            return queryable.FirstOrDefault(p => p.Rowguid == rowguid);
        }

        public static IQueryable<AdventureWorks.Data.Entities.Product> BySizeUnitMeasureCode(this IQueryable<AdventureWorks.Data.Entities.Product> queryable, string sizeUnitMeasureCode)
        {
            return queryable.Where(p => (p.SizeUnitMeasureCode == sizeUnitMeasureCode || (sizeUnitMeasureCode == null && p.SizeUnitMeasureCode == null)));
        }

        public static IQueryable<AdventureWorks.Data.Entities.Product> ByWeightUnitMeasureCode(this IQueryable<AdventureWorks.Data.Entities.Product> queryable, string weightUnitMeasureCode)
        {
            return queryable.Where(p => (p.WeightUnitMeasureCode == weightUnitMeasureCode || (weightUnitMeasureCode == null && p.WeightUnitMeasureCode == null)));
        }

        public static IQueryable<AdventureWorks.Data.Entities.Product> ByProductSubcategoryID(this IQueryable<AdventureWorks.Data.Entities.Product> queryable, int? productSubcategoryID)
        {
            return queryable.Where(p => (p.ProductSubcategoryID == productSubcategoryID || (productSubcategoryID == null && p.ProductSubcategoryID == null)));
        }

        public static IQueryable<AdventureWorks.Data.Entities.Product> ByProductModelID(this IQueryable<AdventureWorks.Data.Entities.Product> queryable, int? productModelID)
        {
            return queryable.Where(p => (p.ProductModelID == productModelID || (productModelID == null && p.ProductModelID == null)));
        }
    }
}

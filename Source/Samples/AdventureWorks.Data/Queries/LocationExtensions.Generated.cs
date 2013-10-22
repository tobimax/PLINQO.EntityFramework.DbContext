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
    public static partial class LocationExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.Location GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.Location> queryable, short locationID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.Location>;
            if (dbSet != null)
                return dbSet.Find(locationID);
                
            return queryable.FirstOrDefault(l => l.LocationID == locationID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.Location GetByName(this IQueryable<AdventureWorks.Data.Entities.Location> queryable, string name)
        {
            return queryable.FirstOrDefault(l => l.Name == name);
        }
    }
}

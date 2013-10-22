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
    public static partial class ContactTypeExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static AdventureWorks.Data.Entities.ContactType GetByKey(this System.Linq.IQueryable<AdventureWorks.Data.Entities.ContactType> queryable, int contactTypeID)
        {
            var dbSet = queryable as System.Data.Entity.IDbSet<AdventureWorks.Data.Entities.ContactType>;
            if (dbSet != null)
                return dbSet.Find(contactTypeID);
                
            return queryable.FirstOrDefault(c => c.ContactTypeID == contactTypeID);
        }

        /// <summary>
        /// Gets an instance by using a unique index.
        /// </summary>
        /// <returns>An instance of the entity or null if not found.</returns>
        public static AdventureWorks.Data.Entities.ContactType GetByName(this IQueryable<AdventureWorks.Data.Entities.ContactType> queryable, string name)
        {
            return queryable.FirstOrDefault(c => c.Name == name);
        }
    }
}

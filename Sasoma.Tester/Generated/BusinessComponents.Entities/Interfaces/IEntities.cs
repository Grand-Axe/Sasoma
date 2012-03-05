/**********************************************************************/
/* FrameworkGen (written by Lee Crowe)                                */
/* Elency Solutions - http://www.elencysolutions.co.uk                */
/*                                                                    */
/* This file was automatically generated using FrameworkGen v4.1.0.0. */
/* Any manual changes to this file will be overwritten.               */
/*                                                                    */
/* Date Generated: 16/02/2012 04:42:37                                */
/*                                                                    */
/**********************************************************************/
using System.Collections;

namespace Microdata.BusinessComponents.Entities
{

    /// <summary>
    /// Interface for Entity object collections
    /// </summary>
    public interface IEntities : IList
    {
		
		/// <summary>
        /// Gets entities by state
        /// </summary>
        /// <param name="entityState">Entity state</param>
        /// <returns>IEntities</returns>
        IEntities GetEntitiesByState(EntityState entityState);
        
        /// <summary>
        /// Restores pre-save values
        /// </summary>
        void RestorePreSaveValues();
        
        /// <summary>
        /// Stores pre-save values
        /// </summary>
        void StorePreSaveValues();
        
        /// <summary>
        /// Removes all deleted entitites from the collection
        /// </summary>
        void RemoveDeletedEntities();
        
        /// <summary>
        /// Indicates whether the collection has entities that need updating in the database
        /// </summary>
        /// <returns>True is entities need updating, otherwise false</returns>
        bool HasChanges
        {
            get;
        }
        
    }
    
}


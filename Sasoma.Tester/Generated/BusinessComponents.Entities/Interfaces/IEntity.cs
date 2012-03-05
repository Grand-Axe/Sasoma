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


namespace Microdata.BusinessComponents.Entities
{
    /// <summary>
    /// Interface for all entity objects
    /// </summary>
    public interface IEntity
    {
        
        /// <summary>
        /// Marks the entity as new.
        /// </summary>
        void SetNew();

        /// <summary>
        /// Marks the entity as existing.
        /// </summary>
        void SetExisting();
        
        /// <summary>
        /// Marks the entity as changed.
        /// </summary>
        void SetChanged();

        /// <summary>
        /// Marks the entity as deleted.
        /// </summary>
        void SetDeleted();
        
        /// <summary>
        /// Marks the entity as deleted.
        /// </summary>
        /// <param name="cascadeDeletions">If true deletions will be cascade to children.</param>
        void SetDeleted(bool cascadeDeletions);
        
        /// <summary>
        /// Restores pre-save values
        /// </summary>
        void RestorePreSaveValues();
        
        /// <summary>
        /// Stores pre-save values
        /// </summary>
        void StorePreSaveValues();
        
        /// <summary>
        /// Gets or sets the entity state
        /// </summary>
        EntityState EntityState
        {
            get;
        }

        /// <summary>
        /// Gets or sets whether the entity has changed
        /// </summary>
        bool HasChanges
        {
            get;
            set;
        }
    }

}

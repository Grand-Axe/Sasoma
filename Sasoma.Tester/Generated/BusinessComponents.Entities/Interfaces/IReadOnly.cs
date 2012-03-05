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
    /// IReadOnly interface
    /// </summary>
    public interface IReadOnly
    {
        /// <summary>
        /// Makes the entity object readonly
        /// </summary>
        void MakeReadOnly();

        /// <summary>
        /// Gets whether the entity is read only
        /// </summary>
        bool IsReadOnly { get; }
    }

    /// <summary>
    /// Generic IReadOnly interface
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public interface IReadOnly<TEntity>
    {

        /// <summary>
        /// Creates a writable clone
        /// </summary>
        /// <returns>T</returns>
        TEntity CreateWritableClone();
    }
}
/**********************************************************************/
/* FrameworkGen (written by Lee Crowe)                                */
/* Elency Solutions - http://www.elencysolutions.co.uk                */
/*                                                                    */
/* This file was automatically generated using FrameworkGen v4.1.0.0. */
/* Any manual changes to this file will be overwritten.               */
/*                                                                    */
/* Date Generated: 16/02/2012 04:42:39                                */
/*                                                                    */
/**********************************************************************/
namespace Microdata.DataComponents.Helpers
{

    /// <summary>
    /// Enum containing all available db helper types.
    /// </summary>
    public enum DbHelperType
    {
		/// <summary>
		/// Sql Server
		/// </summary>
        SqlServer
    }

    /// <summary>
    /// The DbHelperFactory class.
    /// </summary>
    static class DbHelperFactory
    {
		
        #region Methods

        /// <summary>
        /// Creates a new DbHelper based on the provided DbHelperType.
        /// </summary>
        /// <param name="type">DbHelperType.</param>
        /// <returns>DbHelper classed that implements the IDbHelper interface.</returns>
        /// <exception cref="DbHelperException">DbHelperException.</exception>
        public static IDbHelper Create(DbHelperType type)
        {
            IDbHelper helper;

            switch (type)
            {
                case DbHelperType.SqlServer :
                    helper = new SqlDbHelper();
                    break;
                default :
                    throw new DbHelperException("There is no object implementation for the helper type '" + type + "'.");
            }

            return helper;
        }

        #endregion Methods

    }
}

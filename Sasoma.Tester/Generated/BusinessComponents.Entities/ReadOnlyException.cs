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
using System;
using System.Runtime.Serialization;

namespace Microdata.BusinessComponents.Entities
{
	/// <summary>
	/// Exception class for read only exceptions
	/// </summary>
	[Serializable]
	public class ReadOnlyException : Exception
	{
	
		#region Constructors

		/// <summary>
		/// Default constructor implements base constructor.
		/// </summary>
		public ReadOnlyException()
		{

		}

		/// <summary>
		/// Initializes with a specified error message.
		/// </summary>
		/// <param name="message">A message that describes the error.</param>
		public ReadOnlyException(string message) : base(message) 
		{

		}

		/// <summary>
		/// Initializes with a specified error message and a reference to the inner exception
		/// that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="exception">The exception that is the cause of the current exception. 
		/// If the innerException parameter is not a null reference, the current exception 
		/// is raised in a catch block that handles the inner exception.</param>
		public ReadOnlyException(string message, Exception exception) : base(message, exception) 
		{

		}

		/// <summary>
		/// Initializes with serialized data.
		/// </summary>
		/// <param name="info">The object that holds the serialized object data.</param>
		/// <param name="context">The contextual information about the source or destination.</param>
		protected ReadOnlyException(SerializationInfo info, StreamingContext context) : base(info, context) 
		{

		}

		#endregion Constructors
		
	}
}

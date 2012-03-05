
namespace Microdata.BusinessComponents
{
	using Entities;

	/// <summary>
	/// Business Rules class for table 'Properties'.
	/// </summary>
	public sealed partial class PropertyManager
	{

		#region Members

		private bool _initialised;

		#endregion Members

		#region Methods

		/// <summary>
		/// Initialises the business component.
		/// </summary>
		protected void Initialise()
		{
			if (_initialised)
				return;

			_initialised = true;
		}


		#endregion Methods

	}

}

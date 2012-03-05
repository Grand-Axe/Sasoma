using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;
using Sasoma.Microdata.Interfaces;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// The model of the product.
	/// </summary>
	public class Model_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 140;
			}
		}

		public string Id
		{
			get
			{
				return "model";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "Model", typeof(Model_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{215};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{6};
			}
		}

	}
}
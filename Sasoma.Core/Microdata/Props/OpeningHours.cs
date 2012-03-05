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
	/// The opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.<br/>- Days are specified using the following two-letter combinations: <code>Mo</code>, <code>Tu</code>, <code>We</code>, <code>Th</code>, <code>Fr</code>, <code>Sa</code>, <code>Su</code>.<br/>- Times are specified using 24:00 time. For example, 3pm is specified as <code>15:00</code>. <br/>- Here is an example: <code>&lt;time itemprop=\openingHours\ datetime=\Tu,Th 16:00-20:00\&gt;Tuesdays and Thursdays 4-8pm&lt;/time&gt;</code>. <br/>- If a business is open 7 days a week, then it can be specified as <code>&lt;time itemprop=\openingHours\ datetime=\Mo-Su\&gt;Monday through Sunday, all day&lt;/time&gt;</code>.
	/// </summary>
	public class OpeningHours_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 152;
			}
		}

		public string Id
		{
			get
			{
				return "openingHours";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "OpeningHours", typeof(OpeningHours_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{155,62};
			}
		}

		public int[] Ranges
		{
			get
			{
				return new int[]{86};
			}
		}

	}
}
using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Types;

namespace Sasoma.Microdata.Properties
{
	/// <summary>
	/// The quality of the video.
	/// </summary>
	public class VideoQuality_Core : PropertyCore
	{
		public VideoQuality_Core()
		{
			this._PropertyId = 233;
			this._Id = "videoQuality";
			string label = "";
			GetLabel(out label, "VideoQuality", typeof(VideoQuality_Core));
			this._Label = label;
			this._Domains = new int[]{285};
			this._Ranges = new int[]{6};
		}
	}
}
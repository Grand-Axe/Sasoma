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
	/// The frame size of the video.
	/// </summary>
	public class VideoFrameSize_Core : PropertyCore
	{
		public VideoFrameSize_Core()
		{
			this._PropertyId = 232;
			this._Id = "videoFrameSize";
			string label = "";
			GetLabel(out label, "VideoFrameSize", typeof(VideoFrameSize_Core));
			this._Label = label;
			this._Domains = new int[]{285};
			this._Ranges = new int[]{6};
		}
	}
}
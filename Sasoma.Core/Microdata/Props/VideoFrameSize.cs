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
	/// The frame size of the video.
	/// </summary>
	public class VideoFrameSize_Core : PropertyCore, IProperty
	{
		public int PropertyId
		{
			get
			{
				return 232;
			}
		}

		public string Id
		{
			get
			{
				return "videoFrameSize";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "VideoFrameSize", typeof(VideoFrameSize_Core));
				return label;
			}
		}

		public int[] Domains
		{
			get
			{
				return new int[]{285};
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
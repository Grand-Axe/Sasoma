using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Interfaces;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// A listing that describes a job opening in a certain organization.
	/// </summary>
	public class JobPosting_Core : TypeCore, IIntangible
	{
		public int TypeId
		{
			get
			{
				return 144;
			}
		}

		public string Id
		{
			get
			{
				return "JobPosting";
			}
		}

		public string Schema_Org_Url
		{
			get
			{
				return "http://schema.org/JobPosting";
			}
		}

		private string label;
		public string Label
		{
			get
			{
				GetLabel(out label, "JobPosting", typeof(JobPosting_Core));
				return label;
			}
		}

		public int[] Ancestors
		{
			get
			{
				return new int[]{266,138};
			}
		}

		public int[] SubTypes
		{
			get
			{
				return new int[0];
			}
		}

		public int[] SuperTypes
		{
			get
			{
				return new int[]{138};
			}
		}

		public int[] Properties
		{
			get
			{
				return new int[]{67,108,143,229,27,28,63,73,78,87,103,112,113,124,149,181,193,200,209,212,221,236};
			}
		}


		/// <summary>
		/// The base salary of the job.
		/// </summary>
		public BaseSalary_Core BaseSalary { get; set; }

		/// <summary>
		/// Description of benefits associated with the job.
		/// </summary>
		public Benefits_Core Benefits { get; set; }

		/// <summary>
		/// Publication date for the job posting.
		/// </summary>
		public DatePosted_Core DatePosted { get; set; }

		/// <summary>
		/// A short description of the item.
		/// </summary>
		public Description_Core Description { get; set; }

		/// <summary>
		/// Educational background needed for the position.
		/// </summary>
		public EducationRequirements_Core EducationRequirements { get; set; }

		/// <summary>
		/// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
		/// </summary>
		public EmploymentType_Core EmploymentType { get; set; }

		/// <summary>
		/// Description of skills and experience needed for the position.
		/// </summary>
		public ExperienceRequirements_Core ExperienceRequirements { get; set; }

		/// <summary>
		/// Organization offering the job position.
		/// </summary>
		public HiringOrganization_Core HiringOrganization { get; set; }

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		public Image_Core Image { get; set; }

		/// <summary>
		/// Description of bonus and commission compensation aspects of the job.
		/// </summary>
		public Incentives_Core Incentives { get; set; }

		/// <summary>
		/// The industry associated with the job position.
		/// </summary>
		public Industry_Core Industry { get; set; }

		/// <summary>
		/// A (typically single) geographic location associated with the job position.
		/// </summary>
		public JobLocation_Core JobLocation { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		public Name_Core Name { get; set; }

		/// <summary>
		/// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
		/// </summary>
		public OccupationalCategory_Core OccupationalCategory { get; set; }

		/// <summary>
		/// Specific qualifications required for this role.
		/// </summary>
		public Qualifications_Core Qualifications { get; set; }

		/// <summary>
		/// Responsibilities associated with this role.
		/// </summary>
		public Responsibilities_Core Responsibilities { get; set; }

		/// <summary>
		/// The currency (coded using ISO 4217, http://en.wikipedia.org/wiki/ISO_4217 used for the main salary information in this job posting.
		/// </summary>
		public SalaryCurrency_Core SalaryCurrency { get; set; }

		/// <summary>
		/// Skills required to fulfill this role.
		/// </summary>
		public Skills_Core Skills { get; set; }

		/// <summary>
		/// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
		/// </summary>
		public SpecialCommitments_Core SpecialCommitments { get; set; }

		/// <summary>
		/// The title of the job.
		/// </summary>
		public Title_Core Title { get; set; }

		/// <summary>
		/// URL of the item.
		/// </summary>
		public Properties.URL_Core URL { get; set; }

		/// <summary>
		/// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
		/// </summary>
		public WorkHours_Core WorkHours { get; set; }

	}
}
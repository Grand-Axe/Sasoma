using System;
using System.Globalization;
using System.Collections.Generic;

using Sasoma.Utils;
using Sasoma.Microdata.Interfaces;
using Sasoma.Languages.Core;
using Sasoma.Microdata.Properties;

namespace Sasoma.Microdata.Types
{
	/// <summary>
	/// A listing that describes a job opening in a certain organization.
	/// </summary>
	public class JobPosting_Core : TypeCore, IIntangible
	{
		public JobPosting_Core()
		{
			this._TypeId = 144;
			this._Id = "JobPosting";
			this._Schema_Org_Url = "http://schema.org/JobPosting";
			string label = "";
			GetLabel(out label, "JobPosting", typeof(JobPosting_Core));
			this._Label = label;
			this._Ancestors = new int[]{266,138};
			this._SubTypes = new int[0];
			this._SuperTypes = new int[]{138};
			this._Properties = new int[]{67,108,143,229,27,28,63,73,78,87,103,112,113,124,149,181,193,200,209,212,221,236};

		}

		/// <summary>
		/// The base salary of the job.
		/// </summary>
		private BaseSalary_Core baseSalary;
		public BaseSalary_Core BaseSalary
		{
			get
			{
				return baseSalary;
			}
			set
			{
				baseSalary = value;
				SetPropertyInstance(baseSalary);
			}
		}

		/// <summary>
		/// Description of benefits associated with the job.
		/// </summary>
		private Benefits_Core benefits;
		public Benefits_Core Benefits
		{
			get
			{
				return benefits;
			}
			set
			{
				benefits = value;
				SetPropertyInstance(benefits);
			}
		}

		/// <summary>
		/// Publication date for the job posting.
		/// </summary>
		private DatePosted_Core datePosted;
		public DatePosted_Core DatePosted
		{
			get
			{
				return datePosted;
			}
			set
			{
				datePosted = value;
				SetPropertyInstance(datePosted);
			}
		}

		/// <summary>
		/// A short description of the item.
		/// </summary>
		private Description_Core description;
		public Description_Core Description
		{
			get
			{
				return description;
			}
			set
			{
				description = value;
				SetPropertyInstance(description);
			}
		}

		/// <summary>
		/// Educational background needed for the position.
		/// </summary>
		private EducationRequirements_Core educationRequirements;
		public EducationRequirements_Core EducationRequirements
		{
			get
			{
				return educationRequirements;
			}
			set
			{
				educationRequirements = value;
				SetPropertyInstance(educationRequirements);
			}
		}

		/// <summary>
		/// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
		/// </summary>
		private EmploymentType_Core employmentType;
		public EmploymentType_Core EmploymentType
		{
			get
			{
				return employmentType;
			}
			set
			{
				employmentType = value;
				SetPropertyInstance(employmentType);
			}
		}

		/// <summary>
		/// Description of skills and experience needed for the position.
		/// </summary>
		private ExperienceRequirements_Core experienceRequirements;
		public ExperienceRequirements_Core ExperienceRequirements
		{
			get
			{
				return experienceRequirements;
			}
			set
			{
				experienceRequirements = value;
				SetPropertyInstance(experienceRequirements);
			}
		}

		/// <summary>
		/// Organization offering the job position.
		/// </summary>
		private HiringOrganization_Core hiringOrganization;
		public HiringOrganization_Core HiringOrganization
		{
			get
			{
				return hiringOrganization;
			}
			set
			{
				hiringOrganization = value;
				SetPropertyInstance(hiringOrganization);
			}
		}

		/// <summary>
		/// URL of an image of the item.
		/// </summary>
		private Image_Core image;
		public Image_Core Image
		{
			get
			{
				return image;
			}
			set
			{
				image = value;
				SetPropertyInstance(image);
			}
		}

		/// <summary>
		/// Description of bonus and commission compensation aspects of the job.
		/// </summary>
		private Incentives_Core incentives;
		public Incentives_Core Incentives
		{
			get
			{
				return incentives;
			}
			set
			{
				incentives = value;
				SetPropertyInstance(incentives);
			}
		}

		/// <summary>
		/// The industry associated with the job position.
		/// </summary>
		private Industry_Core industry;
		public Industry_Core Industry
		{
			get
			{
				return industry;
			}
			set
			{
				industry = value;
				SetPropertyInstance(industry);
			}
		}

		/// <summary>
		/// A (typically single) geographic location associated with the job position.
		/// </summary>
		private JobLocation_Core jobLocation;
		public JobLocation_Core JobLocation
		{
			get
			{
				return jobLocation;
			}
			set
			{
				jobLocation = value;
				SetPropertyInstance(jobLocation);
			}
		}

		/// <summary>
		/// The name of the item.
		/// </summary>
		private Name_Core name;
		public Name_Core Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
				SetPropertyInstance(name);
			}
		}

		/// <summary>
		/// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
		/// </summary>
		private OccupationalCategory_Core occupationalCategory;
		public OccupationalCategory_Core OccupationalCategory
		{
			get
			{
				return occupationalCategory;
			}
			set
			{
				occupationalCategory = value;
				SetPropertyInstance(occupationalCategory);
			}
		}

		/// <summary>
		/// Specific qualifications required for this role.
		/// </summary>
		private Qualifications_Core qualifications;
		public Qualifications_Core Qualifications
		{
			get
			{
				return qualifications;
			}
			set
			{
				qualifications = value;
				SetPropertyInstance(qualifications);
			}
		}

		/// <summary>
		/// Responsibilities associated with this role.
		/// </summary>
		private Responsibilities_Core responsibilities;
		public Responsibilities_Core Responsibilities
		{
			get
			{
				return responsibilities;
			}
			set
			{
				responsibilities = value;
				SetPropertyInstance(responsibilities);
			}
		}

		/// <summary>
		/// The currency (coded using ISO 4217, http://en.wikipedia.org/wiki/ISO_4217 used for the main salary information in this job posting.
		/// </summary>
		private SalaryCurrency_Core salaryCurrency;
		public SalaryCurrency_Core SalaryCurrency
		{
			get
			{
				return salaryCurrency;
			}
			set
			{
				salaryCurrency = value;
				SetPropertyInstance(salaryCurrency);
			}
		}

		/// <summary>
		/// Skills required to fulfill this role.
		/// </summary>
		private Skills_Core skills;
		public Skills_Core Skills
		{
			get
			{
				return skills;
			}
			set
			{
				skills = value;
				SetPropertyInstance(skills);
			}
		}

		/// <summary>
		/// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
		/// </summary>
		private SpecialCommitments_Core specialCommitments;
		public SpecialCommitments_Core SpecialCommitments
		{
			get
			{
				return specialCommitments;
			}
			set
			{
				specialCommitments = value;
				SetPropertyInstance(specialCommitments);
			}
		}

		/// <summary>
		/// The title of the job.
		/// </summary>
		private Title_Core title;
		public Title_Core Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
				SetPropertyInstance(title);
			}
		}

		/// <summary>
		/// URL of the item.
		/// </summary>
		private Properties.URL_Core uRL;
		public Properties.URL_Core URL
		{
			get
			{
				return uRL;
			}
			set
			{
				uRL = value;
				SetPropertyInstance(uRL);
			}
		}

		/// <summary>
		/// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
		/// </summary>
		private WorkHours_Core workHours;
		public WorkHours_Core WorkHours
		{
			get
			{
				return workHours;
			}
			set
			{
				workHours = value;
				SetPropertyInstance(workHours);
			}
		}

	}
}
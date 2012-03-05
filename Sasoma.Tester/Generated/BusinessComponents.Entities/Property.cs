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
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Microdata.BusinessComponents.Entities
{

	/// <summary>
	/// Properties Entity class.
	/// </summary>
	[Serializable]
	[XmlType(TypeName = "Property")]
	public partial class Property : EntityBase<Property>, ICloneable, IReadOnly<Property>
	{

		#region Members

		private int _propertyId;
		private string _comment = string.Empty;
		private string _comment_Plain = string.Empty;
		private string _domains;
		private string _id = string.Empty;
		private string _label = string.Empty;
		private string _ranges;
		private Property _originalProperty;
		private bool _fireEvents = true;
		private static int _nextPropertyId;

		#endregion Members

		#region Events

		/// <summary>
		/// PropertyId Changed Delegate.
		/// </summary>
		public delegate void PropertyIdChangedDelegate(Property property);

		/// <summary>
		/// PropertyId Changed Event.
		/// </summary>
		public event PropertyIdChangedDelegate PropertyIdChanged;


		#endregion Events

		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Property()
		{
			EntityState = EntityState.New;
			if (_nextPropertyId == int.MinValue)
				_nextPropertyId = 0;

			_nextPropertyId--;
			_propertyId = _nextPropertyId;
		}

		/// <summary>
		/// Constructor that instantiates the object using the various parameters.
		/// </summary>
		/// <param name="propertyId">PropertyId.</param>
		/// <param name="comment">Comment.</param>
		/// <param name="comment_Plain">Comment_Plain.</param>
		/// <param name="domains">Domains.</param>
		/// <param name="id">Id.</param>
		/// <param name="label">Label.</param>
		/// <param name="ranges">Ranges.</param>
		public Property(int propertyId, string comment, string comment_Plain, string domains, string id, string label,
			string ranges)
		{
			EntityState = EntityState.New;
			_propertyId = propertyId;
			_comment = comment;
			_comment_Plain = comment_Plain;
			_domains = domains;
			_id = id;
			_label = label;
			_ranges = ranges;

		}

		#endregion Constructor

		#region Methods

		/// <summary>
		/// Implicitally convert a Property object to a Properties object
		/// </summary>
		/// <param name="property">Property entity</param>
		/// <returns>Properties object</returns>
		public static implicit operator Properties(Property property)
		{
			Properties properties = new Properties(property);
			return properties;
		}

		/// <summary>
		/// Gets a string representation of the object.
		/// </summary>
		/// <returns>String representation of current instance.</returns>
		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("[Property: ");
			builder.Append("PropertyId=" + PropertyId + ", ");
			builder.Append("Comment=" + Comment + ", ");
			builder.Append("Comment_Plain=" + Comment_Plain + ", ");
			builder.Append("Domains=" + Domains + ", ");
			builder.Append("Id=" + Id + ", ");
			builder.Append("Label=" + Label + ", ");
			builder.Append("Ranges=" + Ranges + ", ");
			builder.Append("HasChanges=" + HasChanges + ", ");
			builder.Append("FireEvents=" + EntityState + ", ");
			builder.Append("EntityState=" + EntityState);
			builder.Append("]");
			return builder.ToString();
		}

		/// <summary>
		/// Copies its values to another instance.
		/// </summary>
		public void CopyTo(Property property)
		{
			CopyTo(property, true);
		}

		/// <summary>
		/// Copies its values to another instance.
		/// </summary>
		public void CopyTo(Property entity, bool deep)
		{
			entity.EntityState = EntityState;
			entity.FireEvents = FireEvents;
			entity.PropertyId = PropertyId;
			entity.Comment = Comment;
			entity.Comment_Plain = Comment_Plain;
			entity.Domains = Domains;
			entity.Id = Id;
			entity.Label = Label;
			entity.Ranges = Ranges;
			entity.HasChanges = HasChanges;
		}


		/// <summary>
		/// Restores pre-save values
		/// </summary>
		public override void RestorePreSaveValues()
		{
			_originalProperty.CopyTo(this, false);
			_originalProperty = null;
		}

		/// <summary>
		/// Stores pre-save values
		/// </summary>
		public override void StorePreSaveValues()
		{
			_originalProperty = Clone(false) as Property;
		}

		/// <summary>
		/// Checks whether the specified instance is equal to this one.
		/// </summary>
		/// <returns>Property.</returns>
		public bool EqualTo(Property property)
		{
			return EqualTo(this, property);
		}

		/// <summary>
		/// Creates a new clone of the current instance.
		/// </summary>
		/// <returns>Property.</returns>
		public object Clone()
		{
			return Clone(true);
		}

		/// <summary>
		/// Creates a new clone of the current instance.
		/// </summary>
		/// <returns>Property.</returns>
		public object Clone(bool deep)
		{
			Property entityClone = new Property();
			CopyTo(entityClone, deep);
			return entityClone;
		}

		/// <summary>
		/// Marks the Property as deleted and will cascade deletions if there are child entities.
		/// </summary>
		public override void SetDeleted()
		{
			SetDeleted(true);
		}

		/// <summary>
		/// Marks the Property as deleted.
		/// </summary>
		/// <param name="cascadeDeletions">If true deletions will be cascade to children.</param>
		public override void SetDeleted(bool cascadeDeletions)
		{
			EntityState = EntityState.Deleted;
		}

		/// <summary>
		/// Creates a writable clone
		/// </summary>
		/// <returns>Property</returns>
		public Property CreateWritableClone()
		{
			return Clone(true) as Property;
		}

		/// <summary>
		/// Makes the entity read only
		/// </summary>
		public override void MakeReadOnly()
		{
			base.MakeReadOnly();

		}

		#endregion Methods

		#region Properties

		/// <summary>
		/// Gets and sets PropertyId.
		/// </summary>
		[XmlElement(ElementName = "PropertyId")]
		public int PropertyId
		{
			get
			{
				return _propertyId;
			}
			set
			{
				CanWrite();

				if (_propertyId != value)
				{
					HasChanges = true;
					_propertyId = value;
					if (PropertyIdChanged != null && FireEvents)
						PropertyIdChanged(this);
				}
			}
		}

		/// <summary>
		/// Gets and sets Comment.
		/// </summary>
		[XmlElement(ElementName = "Comment")]
		public string Comment
		{
			get
			{
				return _comment;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_comment, value))
					HasChanges = true;

				_comment = value;
			}
		}

		/// <summary>
		/// Gets and sets Comment_Plain.
		/// </summary>
		[XmlElement(ElementName = "Comment_Plain")]
		public string Comment_Plain
		{
			get
			{
				return _comment_Plain;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_comment_Plain, value))
					HasChanges = true;

				_comment_Plain = value;
			}
		}

		/// <summary>
		/// Gets and sets Domains.
		/// </summary>
		[XmlElement(ElementName = "Domains")]
		public string Domains
		{
			get
			{
				return _domains;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_domains, value))
					HasChanges = true;

				_domains = value;
			}
		}

		/// <summary>
		/// Gets and sets Id.
		/// </summary>
		[XmlElement(ElementName = "Id")]
		public string Id
		{
			get
			{
				return _id;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_id, value))
					HasChanges = true;

				_id = value;
			}
		}

		/// <summary>
		/// Gets and sets Label.
		/// </summary>
		[XmlElement(ElementName = "Label")]
		public string Label
		{
			get
			{
				return _label;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_label, value))
					HasChanges = true;

				_label = value;
			}
		}

		/// <summary>
		/// Gets and sets Ranges.
		/// </summary>
		[XmlElement(ElementName = "Ranges")]
		public string Ranges
		{
			get
			{
				return _ranges;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_ranges, value))
					HasChanges = true;

				_ranges = value;
			}
		}

		/// <summary>
		/// Gets or sets whether events should be fired.
		/// </summary>
		[XmlElement(ElementName = "FireEvents")]
		public bool FireEvents
		{
			get
			{
				return _fireEvents;
			}
			set
			{
				CanWrite();
				_fireEvents = value;
			}
		}

		#endregion Properties

	}

	/// <summary>
	/// Collection class for Property objects.
	/// </summary>
	[Serializable]
	[XmlType(TypeName = "Properties")]
	public partial class Properties : EntitiesBase<Property, Properties>, ICloneable, IReadOnly<Properties>
	{

		#region Members

		private bool _fireEvents = true;

		#endregion Members

		#region Events

		/// <summary>
		/// Property Added Delegate.
		/// </summary>
		public delegate void AddedDelegate(Property property);

		/// <summary>
		/// Property Added Event.
		/// </summary>
		public event AddedDelegate Added;

		/// <summary>
		/// Property Removed Delegate.
		/// </summary>
		public delegate void RemovedDelegate(Property property);

		/// <summary>
		/// Property Removed Event.
		/// </summary>
		public event RemovedDelegate Removed;

		/// <summary>
		/// PropertyId Changed Delegate.
		/// </summary>
		public delegate void PropertyIdChangedDelegate(Property property);

		/// <summary>
		/// PropertyId Changed Event.
		/// </summary>
		public event PropertyIdChangedDelegate PropertyIdChanged;

		#endregion Events

		#region Event handlers

		/// <summary>
		/// Fires when an entities primary key value changes
		/// </summary>
		/// <param name="property"></param>
		private void Property_PropertyIdChanged(Property property)
		{
			if (PropertyIdChanged != null && FireEvents)
				PropertyIdChanged(property);
		}

		#endregion Event handlers

		#region Constructors

		/// <summary>
		/// Initialises a new instance of the collection that is empty.
		/// </summary>
		public Properties()
		{
		}

		/// <summary>
		/// The collection whose elements are copied to the new list.
		/// </summary>
		/// <param name="properties">Properties</param>
		public Properties(Properties properties) : base(properties)
		{
		}

		/// <summary>
		/// The number of elements that the new list can initialy store.
		/// </summary>
		/// <param name="capacity">Capacity</param>
		public Properties(int capacity) : base(capacity)
		{
		}

		/// <summary>
		/// The 'Property' entity to add to the collection.
		/// </summary>
		/// <param name="property">Property</param>
		public Properties(Property property)
		{
			if (property != null)
				Add(property);
		}

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Gets a string representation of the object.
		/// </summary>
		/// <returns>String representation of current instance.</returns>
		public override string ToString()
		{
			return "[Properties: Count=" + Count + "]";
		}

		/// <summary>
		/// Creates a clone of the collection.
		/// </summary>
		/// <returns>Properties.</returns>
		public object Clone()
		{
			return Clone(true);
		}

		/// <summary>
		/// Creates a clone of the collection.
		/// </summary>
		/// <param name="deep">True if a deep clone should be performed, otherwise false.</param>
		/// <returns>Properties.</returns>
		public object Clone(bool deep)
		{
			Properties collection = new Properties();

			for (int i = 0; i < Count; i++)
			{
				Property entity = this[i];
				Property clone = entity.Clone(deep) as Property;
				Remove(clone);
				collection.Add(clone);
			}

			return collection;
		}

		/// <summary>
		/// Determines whether this instance is equal to the specified Properties instance.
		/// </summary>
		/// <param name="properties">Properties.</param>
		/// <returns>True if instances are equal, otherwise false.</returns>
		public bool EqualTo(Properties properties)
		{
			if (properties == null || properties.Count != Count)
				return false;

			bool entitiesEqual = true;

			for (int i = 0; i < Count; i++)
			{
				if (!this[i].EqualTo(properties[i]))
				{
					entitiesEqual = false;
					break;
				}
			}

			return entitiesEqual;
		}

		/// <summary>
		/// Finds an entity based on its primary key value.
		/// </summary>
		/// <param name="propertyId">PropertyId</param>
		/// <returns>Property if found otherwise null.</returns>
		public Property Find(int propertyId)
		{
			return Find(currentProperty => currentProperty != null && currentProperty.PropertyId == propertyId);
		}

		/// <summary>
		/// Retrieves all the elements that match the conditions defined by the specified predicate.
		/// </summary>
		/// <param name="match"></param>
		/// <returns>Matching Funds</returns>
		public new Properties FindAll(Predicate<Property> match)
		{
			Properties entities = new Properties();
			List<Property> foundEntities = base.FindAll(match);
			bool originalAddEntityIfAlreadyExists = AddEntityIfAlreadyExists;
			AddEntityIfAlreadyExists = true;
			entities.AddRange(foundEntities);
			AddEntityIfAlreadyExists = originalAddEntityIfAlreadyExists;
			return entities;
		}


		/// <summary>
		/// Gets all entities that match the specified EntityState
		/// </summary>
		/// <param name="entityState">EntityState</param>
		/// <returns>Properties</returns>
		public new Properties GetEntitiesByState(EntityState entityState)
		{
			return FindAll(currentProperty => currentProperty.EntityState == entityState);
		}

		/// <summary>
		/// Sets up events on the entity
		/// </summary>
		/// <param name="property">Property</param>
		protected override void SetEntityEventHandlers(Property property)
		{
			if (property != null)
			{
				property.PropertyIdChanged += Property_PropertyIdChanged;
			}

			if (FireEvents && Added != null)
				Added(property);
		}

		/// <summary>
		/// Adds a new Property entity to the collection
		/// </summary>
		/// <param name="property">Property</param>
		protected override void SetEntityParents(Property property)
		{
		}

		/// <summary>
		/// Removes entity event handlers
		/// </summary>
		/// <param name="entity"></param>
		protected override void RemoveEntityEventHandlers(Property entity)
		{
			if (entity == null)
				return;


			if (Removed != null && FireEvents)
				Removed(entity);

			entity.PropertyIdChanged -= Property_PropertyIdChanged;
		}

		/// <summary>
		/// Creates a writable clone
		/// </summary>
		/// <returns>Properties</returns>
		public Properties CreateWritableClone()
		{
			return Clone(true) as Properties;
		}


		/// <summary>
		/// Makes the collection read only
		/// </summary>
		public override void MakeReadOnly()
		{
			base.MakeReadOnly();

			foreach (Property entity in this)
				entity.MakeReadOnly();
		}


		#endregion Methods

		#region Properties

		/// <summary>
		/// Gets and sets whether events should be fired.
		/// </summary>
		[XmlElement(ElementName = "FireEvents")]
		public bool FireEvents
		{
			get
			{
				return _fireEvents;
			}
			set
			{
				CanWrite();
				_fireEvents = value;

				foreach (Property property in this)
					property.FireEvents = value;
			}
		}

		#endregion Properties

	}

}

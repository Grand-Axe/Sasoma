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
	/// Types Entity class.
	/// </summary>
	[Serializable]
	[XmlType(TypeName = "Type")]
	public partial class Type : EntityBase<Type>, ICloneable, IReadOnly<Type>
	{

		#region Members

		private int _typeId;
		private string _ancestors;
		private string _comment = string.Empty;
		private string _comment_Plain = string.Empty;
		private string _id = string.Empty;
		private string _instances;
		private string _label = string.Empty;
		private string _properties;
		private string _specific_Properties;
		private string _subTypes;
		private string _superTypes;
		private string _url = string.Empty;
		private bool? _isDataType;
		private Type _originalType;
		private bool _fireEvents = true;
		private static int _nextTypeId;

		#endregion Members

		#region Events

		/// <summary>
		/// TypeId Changed Delegate.
		/// </summary>
		public delegate void TypeIdChangedDelegate(Type type);

		/// <summary>
		/// TypeId Changed Event.
		/// </summary>
		public event TypeIdChangedDelegate TypeIdChanged;


		#endregion Events

		#region Constructor

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Type()
		{
			EntityState = EntityState.New;
			if (_nextTypeId == int.MinValue)
				_nextTypeId = 0;

			_nextTypeId--;
			_typeId = _nextTypeId;
		}

		/// <summary>
		/// Constructor that instantiates the object using the various parameters.
		/// </summary>
		/// <param name="typeId">TypeId.</param>
		/// <param name="ancestors">Ancestors.</param>
		/// <param name="comment">Comment.</param>
		/// <param name="comment_Plain">Comment_Plain.</param>
		/// <param name="id">Id.</param>
		/// <param name="instances">Instances.</param>
		/// <param name="label">Label.</param>
		/// <param name="properties">Properties.</param>
		/// <param name="specific_Properties">Specific_Properties.</param>
		/// <param name="subTypes">SubTypes.</param>
		/// <param name="superTypes">SuperTypes.</param>
		/// <param name="url">Url.</param>
		/// <param name="isDataType">IsDataType.</param>
		public Type(int typeId, string ancestors, string comment, string comment_Plain, string id, string instances,
			string label, string properties, string specific_Properties, string subTypes, string superTypes, string url,
			bool? isDataType)
		{
			EntityState = EntityState.New;
			_typeId = typeId;
			_ancestors = ancestors;
			_comment = comment;
			_comment_Plain = comment_Plain;
			_id = id;
			_instances = instances;
			_label = label;
			_properties = properties;
			_specific_Properties = specific_Properties;
			_subTypes = subTypes;
			_superTypes = superTypes;
			_url = url;
			_isDataType = isDataType;

		}

		#endregion Constructor

		#region Methods

		/// <summary>
		/// Implicitally convert a Type object to a Types object
		/// </summary>
		/// <param name="type">Type entity</param>
		/// <returns>Types object</returns>
		public static implicit operator Types(Type type)
		{
			Types types = new Types(type);
			return types;
		}

		/// <summary>
		/// Gets a string representation of the object.
		/// </summary>
		/// <returns>String representation of current instance.</returns>
		public override string ToString()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("[Type: ");
			builder.Append("TypeId=" + TypeId + ", ");
			builder.Append("Ancestors=" + Ancestors + ", ");
			builder.Append("Comment=" + Comment + ", ");
			builder.Append("Comment_Plain=" + Comment_Plain + ", ");
			builder.Append("Id=" + Id + ", ");
			builder.Append("Instances=" + Instances + ", ");
			builder.Append("Label=" + Label + ", ");
			builder.Append("Properties=" + Properties + ", ");
			builder.Append("Specific_Properties=" + Specific_Properties + ", ");
			builder.Append("SubTypes=" + SubTypes + ", ");
			builder.Append("SuperTypes=" + SuperTypes + ", ");
			builder.Append("Url=" + Url + ", ");
			builder.Append("IsDataType=" + IsDataType + ", ");
			builder.Append("HasChanges=" + HasChanges + ", ");
			builder.Append("FireEvents=" + EntityState + ", ");
			builder.Append("EntityState=" + EntityState);
			builder.Append("]");
			return builder.ToString();
		}

		/// <summary>
		/// Copies its values to another instance.
		/// </summary>
		public void CopyTo(Type type)
		{
			CopyTo(type, true);
		}

		/// <summary>
		/// Copies its values to another instance.
		/// </summary>
		public void CopyTo(Type entity, bool deep)
		{
			entity.EntityState = EntityState;
			entity.FireEvents = FireEvents;
			entity.TypeId = TypeId;
			entity.Ancestors = Ancestors;
			entity.Comment = Comment;
			entity.Comment_Plain = Comment_Plain;
			entity.Id = Id;
			entity.Instances = Instances;
			entity.Label = Label;
			entity.Properties = Properties;
			entity.Specific_Properties = Specific_Properties;
			entity.SubTypes = SubTypes;
			entity.SuperTypes = SuperTypes;
			entity.Url = Url;
			entity.IsDataType = IsDataType;
			entity.HasChanges = HasChanges;
		}


		/// <summary>
		/// Restores pre-save values
		/// </summary>
		public override void RestorePreSaveValues()
		{
			_originalType.CopyTo(this, false);
			_originalType = null;
		}

		/// <summary>
		/// Stores pre-save values
		/// </summary>
		public override void StorePreSaveValues()
		{
			_originalType = Clone(false) as Type;
		}

		/// <summary>
		/// Checks whether the specified instance is equal to this one.
		/// </summary>
		/// <returns>Type.</returns>
		public bool EqualTo(Type type)
		{
			return EqualTo(this, type);
		}

		/// <summary>
		/// Creates a new clone of the current instance.
		/// </summary>
		/// <returns>Type.</returns>
		public object Clone()
		{
			return Clone(true);
		}

		/// <summary>
		/// Creates a new clone of the current instance.
		/// </summary>
		/// <returns>Type.</returns>
		public object Clone(bool deep)
		{
			Type entityClone = new Type();
			CopyTo(entityClone, deep);
			return entityClone;
		}

		/// <summary>
		/// Marks the Type as deleted and will cascade deletions if there are child entities.
		/// </summary>
		public override void SetDeleted()
		{
			SetDeleted(true);
		}

		/// <summary>
		/// Marks the Type as deleted.
		/// </summary>
		/// <param name="cascadeDeletions">If true deletions will be cascade to children.</param>
		public override void SetDeleted(bool cascadeDeletions)
		{
			EntityState = EntityState.Deleted;
		}

		/// <summary>
		/// Creates a writable clone
		/// </summary>
		/// <returns>Type</returns>
		public Type CreateWritableClone()
		{
			return Clone(true) as Type;
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
		/// Gets and sets TypeId.
		/// </summary>
		[XmlElement(ElementName = "TypeId")]
		public int TypeId
		{
			get
			{
				return _typeId;
			}
			set
			{
				CanWrite();

				if (_typeId != value)
				{
					HasChanges = true;
					_typeId = value;
					if (TypeIdChanged != null && FireEvents)
						TypeIdChanged(this);
				}
			}
		}

		/// <summary>
		/// Gets and sets Ancestors.
		/// </summary>
		[XmlElement(ElementName = "Ancestors")]
		public string Ancestors
		{
			get
			{
				return _ancestors;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_ancestors, value))
					HasChanges = true;

				_ancestors = value;
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
		/// Gets and sets Instances.
		/// </summary>
		[XmlElement(ElementName = "Instances")]
		public string Instances
		{
			get
			{
				return _instances;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_instances, value))
					HasChanges = true;

				_instances = value;
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
		/// Gets and sets Properties.
		/// </summary>
		[XmlElement(ElementName = "Properties")]
		public string Properties
		{
			get
			{
				return _properties;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_properties, value))
					HasChanges = true;

				_properties = value;
			}
		}

		/// <summary>
		/// Gets and sets Specific_Properties.
		/// </summary>
		[XmlElement(ElementName = "Specific_Properties")]
		public string Specific_Properties
		{
			get
			{
				return _specific_Properties;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_specific_Properties, value))
					HasChanges = true;

				_specific_Properties = value;
			}
		}

		/// <summary>
		/// Gets and sets SubTypes.
		/// </summary>
		[XmlElement(ElementName = "SubTypes")]
		public string SubTypes
		{
			get
			{
				return _subTypes;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_subTypes, value))
					HasChanges = true;

				_subTypes = value;
			}
		}

		/// <summary>
		/// Gets and sets SuperTypes.
		/// </summary>
		[XmlElement(ElementName = "SuperTypes")]
		public string SuperTypes
		{
			get
			{
				return _superTypes;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_superTypes, value))
					HasChanges = true;

				_superTypes = value;
			}
		}

		/// <summary>
		/// Gets and sets Url.
		/// </summary>
		[XmlElement(ElementName = "Url")]
		public string Url
		{
			get
			{
				return _url;
			}
			set
			{
				CanWrite();

				if (!string.Equals(_url, value))
					HasChanges = true;

				_url = value;
			}
		}

		/// <summary>
		/// Gets and sets IsDataType.
		/// </summary>
		[XmlElement(ElementName = "IsDataType")]
		public bool? IsDataType
		{
			get
			{
				return _isDataType;
			}
			set
			{
				CanWrite();

				if (_isDataType != value)
					HasChanges = true;

				_isDataType = value;
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
	/// Collection class for Type objects.
	/// </summary>
	[Serializable]
	[XmlType(TypeName = "Types")]
	public partial class Types : EntitiesBase<Type, Types>, ICloneable, IReadOnly<Types>
	{

		#region Members

		private bool _fireEvents = true;

		#endregion Members

		#region Events

		/// <summary>
		/// Type Added Delegate.
		/// </summary>
		public delegate void AddedDelegate(Type type);

		/// <summary>
		/// Type Added Event.
		/// </summary>
		public event AddedDelegate Added;

		/// <summary>
		/// Type Removed Delegate.
		/// </summary>
		public delegate void RemovedDelegate(Type type);

		/// <summary>
		/// Type Removed Event.
		/// </summary>
		public event RemovedDelegate Removed;

		/// <summary>
		/// TypeId Changed Delegate.
		/// </summary>
		public delegate void TypeIdChangedDelegate(Type type);

		/// <summary>
		/// TypeId Changed Event.
		/// </summary>
		public event TypeIdChangedDelegate TypeIdChanged;

		#endregion Events

		#region Event handlers

		/// <summary>
		/// Fires when an entities primary key value changes
		/// </summary>
		/// <param name="type"></param>
		private void Type_TypeIdChanged(Type type)
		{
			if (TypeIdChanged != null && FireEvents)
				TypeIdChanged(type);
		}

		#endregion Event handlers

		#region Constructors

		/// <summary>
		/// Initialises a new instance of the collection that is empty.
		/// </summary>
		public Types()
		{
		}

		/// <summary>
		/// The collection whose elements are copied to the new list.
		/// </summary>
		/// <param name="types">Types</param>
		public Types(Types types) : base(types)
		{
		}

		/// <summary>
		/// The number of elements that the new list can initialy store.
		/// </summary>
		/// <param name="capacity">Capacity</param>
		public Types(int capacity) : base(capacity)
		{
		}

		/// <summary>
		/// The 'Type' entity to add to the collection.
		/// </summary>
		/// <param name="type">Type</param>
		public Types(Type type)
		{
			if (type != null)
				Add(type);
		}

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Gets a string representation of the object.
		/// </summary>
		/// <returns>String representation of current instance.</returns>
		public override string ToString()
		{
			return "[Types: Count=" + Count + "]";
		}

		/// <summary>
		/// Creates a clone of the collection.
		/// </summary>
		/// <returns>Types.</returns>
		public object Clone()
		{
			return Clone(true);
		}

		/// <summary>
		/// Creates a clone of the collection.
		/// </summary>
		/// <param name="deep">True if a deep clone should be performed, otherwise false.</param>
		/// <returns>Types.</returns>
		public object Clone(bool deep)
		{
			Types collection = new Types();

			for (int i = 0; i < Count; i++)
			{
				Type entity = this[i];
				Type clone = entity.Clone(deep) as Type;
				Remove(clone);
				collection.Add(clone);
			}

			return collection;
		}

		/// <summary>
		/// Determines whether this instance is equal to the specified Types instance.
		/// </summary>
		/// <param name="types">Types.</param>
		/// <returns>True if instances are equal, otherwise false.</returns>
		public bool EqualTo(Types types)
		{
			if (types == null || types.Count != Count)
				return false;

			bool entitiesEqual = true;

			for (int i = 0; i < Count; i++)
			{
				if (!this[i].EqualTo(types[i]))
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
		/// <param name="typeId">TypeId</param>
		/// <returns>Type if found otherwise null.</returns>
		public Type Find(int typeId)
		{
			return Find(currentType => currentType != null && currentType.TypeId == typeId);
		}

		/// <summary>
		/// Retrieves all the elements that match the conditions defined by the specified predicate.
		/// </summary>
		/// <param name="match"></param>
		/// <returns>Matching Funds</returns>
		public new Types FindAll(Predicate<Type> match)
		{
			Types entities = new Types();
			List<Type> foundEntities = base.FindAll(match);
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
		/// <returns>Types</returns>
		public new Types GetEntitiesByState(EntityState entityState)
		{
			return FindAll(currentType => currentType.EntityState == entityState);
		}

		/// <summary>
		/// Sets up events on the entity
		/// </summary>
		/// <param name="type">Type</param>
		protected override void SetEntityEventHandlers(Type type)
		{
			if (type != null)
			{
				type.TypeIdChanged += Type_TypeIdChanged;
			}

			if (FireEvents && Added != null)
				Added(type);
		}

		/// <summary>
		/// Adds a new Type entity to the collection
		/// </summary>
		/// <param name="type">Type</param>
		protected override void SetEntityParents(Type type)
		{
		}

		/// <summary>
		/// Removes entity event handlers
		/// </summary>
		/// <param name="entity"></param>
		protected override void RemoveEntityEventHandlers(Type entity)
		{
			if (entity == null)
				return;


			if (Removed != null && FireEvents)
				Removed(entity);

			entity.TypeIdChanged -= Type_TypeIdChanged;
		}

		/// <summary>
		/// Creates a writable clone
		/// </summary>
		/// <returns>Types</returns>
		public Types CreateWritableClone()
		{
			return Clone(true) as Types;
		}


		/// <summary>
		/// Makes the collection read only
		/// </summary>
		public override void MakeReadOnly()
		{
			base.MakeReadOnly();

			foreach (Type entity in this)
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

				foreach (Type type in this)
					type.FireEvents = value;
			}
		}

		#endregion Properties

	}

}

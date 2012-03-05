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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Microdata.BusinessComponents.Entities
{
    /// <summary>
    /// Base class for all entity collections
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TEntities">Entities type</typeparam>
    [Serializable]
    public class EntitiesBase<TEntity, TEntities> : List<TEntity>, IEntities, IReadOnly
		where TEntity : IEntity, new()
		where TEntities : IEntities, new()
    {

		#region Members and Constants

        private bool _addEntityIfItAlreadyExists = true;
        
        #endregion Members and Constants
        
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EntitiesBase()
        {

        }

        /// <summary>
        /// The number of elements that the new list can initialy store.
        /// </summary>
        /// <param name="capacity">Capacity</param>
        public EntitiesBase(int capacity) : base(capacity)
        {

        }

        /// <summary>
        /// The collection whose elements are copied to the new list.
        /// </summary>
        /// <param name="collection">Collection</param>
        public EntitiesBase(List<TEntity> collection) : base(collection)
        {

        }

        #endregion Constructors

        #region Methods
        
        /// <summary>
        /// Gets or sets an entity at the specified index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public new TEntity this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                CanWrite();
                base[index] = value;
            }
        }
        
        /// <summary>
		/// Adds a new entity to the collection
		/// </summary>
		/// <param name="entity">TEntity</param>
		public new void Add(TEntity entity)
		{
			AddEntity(entity);
		}
		
		/// <summary>
		/// Adds a collection of entities to the current collection
		/// </summary>
		/// <param name="entities">TEntities</param>
		public new void AddRange(IEnumerable<TEntity> entities)
		{
			foreach (TEntity entity in entities)
				Add(entity);
		}
        
        /// <summary>
		/// Adds a new entity to the collection
		/// </summary>
		/// <param name="entity">TEntity</param>
		private void AddEntity(TEntity entity)
		{
			if (AddEntityIfAlreadyExists || !Contains(entity))
				base.Add(entity);
			
			SetEntityParents(entity);
			SetEntityEventHandlers(entity);
		}
		
		/// <summary>
        /// Inserts an entity at the specified index
        /// </summary>
        /// <param name="index">Index</param>
        /// <param name="entity">TEntity</param>
        public new void Insert(int index, TEntity entity)
        {
            CanWrite();
            base.Insert(index, entity);
            SetEntityParents(entity);
            SetEntityEventHandlers(entity);
        }

        /// <summary>
        /// Inserts the elements of a collection into the collection at the specified index
        /// </summary>
        /// <param name="index">Index</param>
        /// <param name="entities">TEntities</param>
        public new void InsertRange(int index, IEnumerable<TEntity> entities)
        {
            CanWrite();
            base.InsertRange(index, entities);

            foreach (TEntity entity in entities)
            {
                SetEntityParents(entity);
                SetEntityEventHandlers(entity);
            }
        }
		
		/// <summary>
		/// Sets parent objects on the entity
		/// </summary>
		/// <param name="entity">TEntity</param>
		protected virtual void SetEntityParents(TEntity entity)
		{
		}
		
		/// <summary>
		/// Sets events on the entity
		/// </summary>
		/// <param name="entity">TEntity</param>
		protected virtual void SetEntityEventHandlers(TEntity entity)
		{
		}
        
        /// <summary>
        /// Removes an entity from the collection
        /// </summary>
        /// <param name="entity">TEntity</param>
        public new void Remove(TEntity entity)
        {
            CanWrite();
            base.Remove(entity);
            RemoveEntityEventHandlers(entity);
        }

        /// <summary>
        /// Removes an OrderHistory entity from the collection
        /// </summary>
        /// <param name="index">The index of the customer to remove</param>
        public new void RemoveAt(int index)
        {
            CanWrite();
            TEntity entity = this[index];
            base.RemoveAt(index);
            RemoveEntityEventHandlers(entity);
        }
        
        /// <summary>
        /// Removes a collection of entities from the current collection
        /// </summary>
        /// <param name="entities">TEntities</param>
        public void Remove(TEntities entities)
        {
            CanWrite();

            foreach (TEntity entity in entities)
                Remove(entity);
        }

        /// <summary>
        /// Removes a range of entities from the collection
        /// </summary>
        /// <param name="index">The starting index for the range of elements to remove </param>
        /// <param name="count">The number of entities to remove</param>
        public new void RemoveRange(int index, int count)
        {
            CanWrite();
            List<TEntity> entities = GetRange(index, count);

            foreach (TEntity entity in entities)
                Remove(entity);
        }

        /// <summary>
        /// Removes entity event handlers
        /// </summary>
        /// <param name="entity"></param>
        protected virtual void RemoveEntityEventHandlers(TEntity entity)
        {

        }
        
        /// <summary>
        /// Gets entities by the specified state
        /// </summary>
        /// <param name="entityState">EntityState</param>
        /// <returns>Entities that match specified state</returns>
        public IEntities GetEntitiesByState(EntityState entityState)
        {
            EntitiesBase<TEntity, TEntities> entities = new EntitiesBase<TEntity, TEntities>(0);

            foreach (TEntity entity in this)
            {
                if (entity.EntityState == entityState)
                    entities.Add(entity);
            }

            return entities;
        }
        
        /// <summary>
        /// Restores pre-save values
        /// </summary>
        public virtual void RestorePreSaveValues()
        {
            foreach (TEntity entity in this)
                entity.RestorePreSaveValues();
        }

        /// <summary>
        /// Restores pre-save values
        /// </summary>
        public virtual void StorePreSaveValues()
        {
            foreach (TEntity entity in this)
                entity.StorePreSaveValues();
        }
        
        /// <summary>
        /// Removes all deleted entitites from the collection
        /// </summary>
        public void RemoveDeletedEntities()
        {
            for (int i = 0; i < Count; i++)
            {
                TEntity entity = this[i];

                if (entity.EntityState != EntityState.Deleted)
                    continue;

                Remove(entity);
                i--;
            }
        }
        
        /// <summary>
        /// Gets all entities in the specified page.
        /// </summary>
        /// <param name="pageNumber">Page number.</param>
        /// <param name="pageSize">Page size.</param>
        /// <returns>Collection of entities</returns>
        public TEntities GetEntitiesInPage(int pageNumber, int pageSize)
        {
            TEntities entities = new TEntities();

            int startIndex = ((pageNumber * pageSize) - pageSize);
            if (startIndex > (Count - 1))
                startIndex = (Count - 1);

            int endIndex = startIndex + pageSize;
            if (endIndex > (Count - 1))
                endIndex = (Count - 1);

            for (int i = startIndex; i < endIndex; i++)
                entities.Add(this[i]);

            return entities;
        }
        
        /// <summary>
        /// Makes the object read only
        /// </summary>
        public virtual void MakeReadOnly()
        {
            IsReadOnly = true;
        }
        
        /// <summary>
        /// Determines whether the class is writable and if not throws a ReadOnlyException
        /// </summary>
        /// <exception cref="ReadOnlyException">ReadOnlyException</exception>
        protected void CanWrite()
        {
            if (!IsReadOnly)
                return;

            throw new ReadOnlyException(string.Format("The object {0} is read only, invoke CreateWritableClone to get a writable instance.", GetType().Name));
        }

        #endregion Methods
        
        #region Static methods

        /// <summary>
        /// Converts an object to Xml
        /// </summary>
        /// <param name="objectToSerialize">Object to serialize</param>
        /// <returns>Xml string</returns>
        /// <remarks>Properties marked with the XmlIgnore attribute will not be serialized</remarks>
        public static string ToXml(TEntities objectToSerialize)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(objectToSerialize.GetType());
                serializer.Serialize(writer, objectToSerialize);
                return writer.ToString();
            }
        }

        /// <summary>
        /// Converts an object from xml
        /// </summary>
        /// <param name="xml">Xml string</param>
        /// <returns>Object of type Entities</returns>
        public static TEntities FromXml(string xml)
        {
            using (StringReader reader = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(TEntities));
                return (TEntities)serializer.Deserialize(reader);
            }
        }


        /// <summary>
        /// Converts the object to a byte array
        /// </summary>
        /// <param name="objectToConvert">Object to convert</param>
        /// <returns>byte[]</returns>
        public static byte[] ToByteArray(TEntities objectToConvert)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, objectToConvert);
                byte[] bytes = new byte[stream.Length];
                stream.Position = 0;
                stream.Read(bytes, 0, (int)stream.Length);
                return bytes;
            }
        }

        /// <summary>
        /// Creates an object from a byte array
        /// </summary>
        /// <param name="bytes">byte[]</param>
        /// <returns>Object of type Entities</returns>
        public static TEntities FromByteArray(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(bytes, 0, bytes.Length);
                BinaryFormatter formatter = new BinaryFormatter();
                stream.Position = 0;
                return (TEntities)formatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Writes an object to a file
        /// </summary>
        /// <param name="objectToWrite">Object to write</param>
        /// <param name="fileName">File name</param>
        public static void ToFile(TEntities objectToWrite, string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Creates an object from a file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>Object of type Entities</returns>
        public static TEntities FromFile(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (TEntities)formatter.Deserialize(stream);
            }
        }

        #endregion Static methods
        
        #region Properties
        
        
        /// <summary>
        /// Indicates whether the collection has entities that need updating in the database
        /// </summary>
        /// <returns>True is entities need updating, otherwise false</returns>
        [XmlElement(ElementName = "HasChanges")]
        public bool HasChanges
        {
			get
			{
				foreach (IEntity entity in this)
				{
					if (entity == null)
						continue;

					if (entity.EntityState == EntityState.New || entity.EntityState == EntityState.Deleted || (entity.EntityState == EntityState.Existing && entity.HasChanges))
						return true;
				}
				
				return false;
			}
		}
		
		/// <summary>
        /// Indicates whether an entity should still be added if it already exists.
        /// </summary>
        /// <returns>True if it should be added, otherwise false.</returns>
        [XmlElement(ElementName = "AddEntityIfAlreadyExists")]
        public bool AddEntityIfAlreadyExists
        {
			get
			{
				return _addEntityIfItAlreadyExists;
			}
			set
			{
				CanWrite();
				_addEntityIfItAlreadyExists = value;
			}
		}
		
		/// <summary>
        /// Indicates whether an entity is in a read only state
        /// </summary>
        /// <returns>True if read only, otherwise false.</returns>
        [XmlElement(ElementName = "IsReadOnly")]
        public bool IsReadOnly { get; private set; }
        
        #endregion Properties

    }
}

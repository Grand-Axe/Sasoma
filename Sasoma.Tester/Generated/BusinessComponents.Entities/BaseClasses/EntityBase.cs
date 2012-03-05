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
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace Microdata.BusinessComponents.Entities
{
    /// <summary>
    /// Base class for all entities.
    /// </summary>
    /// <typeparam name="T">Entity type</typeparam>
    [Serializable]
    public abstract class EntityBase<T> : IEntity, IReadOnly
    {

        #region Members and Constants
		
		protected bool _hasChanges;
        protected EntityState _entityState = EntityState.New;
        
        #endregion Members and Constants

        #region Methods
        
        /// <summary>
        /// Checks whether entities are equal
        /// </summary>
        /// <param name="entity1">Entity 1</param>
        /// <param name="entity2">Entity 2</param>
        /// <returns>True if equal, otherwise false</returns>
        protected bool EqualTo(IEntity entity1, IEntity entity2)
        {
            List<object> comparedEntities = new List<object>(0);
            return EqualTo(entity1, entity2, comparedEntities);
        }

        /// <summary>
        /// Checks whether entities are equal
        /// </summary>
        /// <param name="entity1">Entity 1</param>
        /// <param name="entity2">Entity 2</param>
        /// <param name="comparedEntities">Compared entities</param>
        /// <returns>True if equal, otherwise false</returns>
        private bool EqualTo(IEntity entity1, IEntity entity2, List<object> comparedEntities)
        {
            bool equalTo = true;

            if (entity1 == null && entity2 == null)
                return true;

            if (entity1 == null || entity2 == null)
                return false;

            // Get all properties in the current entity
            PropertyInfo[] properties1 = entity1.GetType().GetProperties();
            PropertyInfo[] properties2 = entity2.GetType().GetProperties();

            for (int i = 0; i < properties1.Length; i++)
            {
                PropertyInfo property1 = properties1[i];
                PropertyInfo property2 = GetPropertyByName(properties2, property1.Name);

                if (property1.GetValue(entity1, null) == null && property2.GetValue(entity2, null) == null)
                    continue;

                if (property1.GetValue(entity1, null) == null || property2.GetValue(entity2, null) == null)
                    equalTo = false;

                if (!equalTo)
                    return false;

                // check if the proeprty is an entity
                if (property1.GetValue(entity1, null) is IEntity)
                {
                    if (!(comparedEntities.Contains(entity1) && comparedEntities.Contains(entity2)))
                    {
                        comparedEntities.Add(property1.GetValue(entity1, null));
                        comparedEntities.Add(property2.GetValue(entity2, null));
                        equalTo = EqualTo((IEntity)property1.GetValue(entity1, null), (IEntity)property2.GetValue(entity2, null), comparedEntities);
                    }
                }
                else if (property1.GetValue(entity1, null) is IEntities)
                {
                    IEntities entities1 = (IEntities)property1.GetValue(entity1, null);
                    IEntities entities2 = (IEntities)property2.GetValue(entity2, null);

                    if (entities1 != null && entities2 != null)
                    {
                        if (entities1.Count != entities2.Count)
                            return false;

                        for (int j = 0; j < entities1.Count; j++)
                        {
                            if (!(comparedEntities.Contains(entities1[j]) && comparedEntities.Contains(entities2[j])))
                            {
                                comparedEntities.Add(entities1[j]);
                                comparedEntities.Add(entities2[j]);
                                equalTo = EqualTo((IEntity)entities1[i], (IEntity)entities2[i], comparedEntities);

                                if (!equalTo)
                                    return false;
                            }
                        }
                    }
                    else if (entities1 == null && entities2 == null)
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (property1.GetValue(entity1, null) is byte[])
                    {
                        equalTo = CompareByteArrays((byte[])property1.GetValue(entity1, null), (byte[])property2.GetValue(entity2, null));
                    }
                    else
                    {
                        if (property1.GetValue(entity1, null) is IComparable)
                            equalTo = (((IComparable)property1.GetValue(entity1, null)).CompareTo(property2.GetValue(entity2, null)) == 0);
                        else
                            equalTo = (property1.GetValue(entity1, null).Equals(property2.GetValue(entity2, null)));
                    }
                }

                if (!equalTo)
                    return false;
            }

            return equalTo;
        }
        
        /// <summary>
        /// Compares a byte array
        /// </summary>
        /// <param name="array1">Byte array 1</param>
        /// <param name="array2">Byte array 2</param>
        /// <returns>True if array contents are the same, otherwise false</returns>
        private bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }
        
        /// <summary>
        /// Gets a property by its name
        /// </summary>
        /// <param name="properties">Properties</param>
        /// <param name="name">Name</param>
        /// <returns>PropertyInfo if found, otherwise null</returns>
        private static PropertyInfo GetPropertyByName(PropertyInfo[] properties, string name)
        {
            PropertyInfo propertyInfo = null;

            foreach (PropertyInfo property in properties)
            {
                if (property.Name == name)
                {
                    propertyInfo = property;
                    break;
                }
            }

            return propertyInfo;
        }
        
        /// <summary>
        /// Marks the entity as new.
        /// </summary>
        public void SetNew()
        {
            EntityState = EntityState.New;
        }

        /// <summary>
        /// Marks the entity as existing.
        /// </summary>
        public void SetExisting()
        {
            EntityState = EntityState.Existing;
        }
        
        /// <summary>
        /// Marks the entity as changed.
        /// </summary>
        public void SetChanged()
        {
            HasChanges = true;
        }

		/// <summary>
        /// Marks the entity as deleted.
        /// </summary>
        public virtual void SetDeleted()
        {
            EntityState = EntityState.Deleted;
        }
        
        /// <summary>
        /// Marks the entity as deleted.
        /// </summary>
        /// <param name="cascadeDeletions">If true deletions will be cascade to children.</param>
        public virtual void SetDeleted(bool cascadeDeletions)
        {
            EntityState = EntityState.Deleted;
        }
        
        /// <summary>
        /// Restores pre-save values
        /// </summary>
        public virtual void RestorePreSaveValues()
        {
        }
        
        /// <summary>
        /// Restores pre-save values
        /// </summary>
        public virtual void StorePreSaveValues()
        {
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
        public static string ToXml(T objectToSerialize)
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
        /// <returns>Object of type T</returns>
        public static T FromXml(string xml)
        {
            using (StringReader reader = new StringReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }


        /// <summary>
        /// Converts the object to a byte array
        /// </summary>
        /// <param name="objectToConvert">Object to convert</param>
        /// <returns>byte[]</returns>
        public static byte[] ToByteArray(T objectToConvert)
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
        /// <returns>Object of type T</returns>
        public static T FromByteArray(byte[] bytes)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(bytes, 0, bytes.Length);
                BinaryFormatter formatter = new BinaryFormatter();
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Writes an object to a file
        /// </summary>
        /// <param name="objectToWrite">Object to write</param>
        /// <param name="fileName">File name</param>
        public static void ToFile(T objectToWrite, string fileName)
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
        /// <returns>Object of type T</returns>
        public static T FromFile(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (T)formatter.Deserialize(stream);
            }
        }

        #endregion Static methods

        #region Properties
        
        /// <summary>
        /// Gets and sets whether the entity has changed.
        /// </summary>
        [XmlElement(ElementName = "HasChanges")]
        public bool HasChanges
        {
            get
            {
				return EntityState == EntityState.New || 
					EntityState == EntityState.Deleted || 
					(EntityState == EntityState.Existing && _hasChanges);
            }
            set
            {
				CanWrite();
                _hasChanges = value;
            }
        }

        /// <summary>
        /// Gets and sets the entities EntityState.
        /// </summary>
        [XmlElement(ElementName = "EntityState")]
        public EntityState EntityState
        {
            get
            {
                return _entityState;
            }
            set
            {
				CanWrite();
                _entityState = value;
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

﻿#region License
//  Copyright 2004-2010 Castle Project - http:www.castleproject.org/
//  
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  
//      http:www.apache.org/licenses/LICENSE-2.0
//  
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
// 
#endregion
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship ModelHasClass
	/// Description for Castle.ActiveWriter.ModelHasClass
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelHasClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelHasClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("f9419603-bb7b-40fc-9fea-fcd2e7e1b990")]
	public partial class ModelHasClass : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ModelHasClass domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xf9419603, 0xbb7b, 0x40fc, 0x9f, 0xea, 0xfc, 0xd2, 0xe7, 0xe1, 0xb9, 0x90);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ModelHasClass link in the same Partition as the given Model
		/// </summary>
		/// <param name="source">Model to use as the source of the relationship.</param>
		/// <param name="target">ModelClass to use as the target of the relationship.</param>
		public ModelHasClass(Model source, ModelClass target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ModelHasClass.ModelDomainRoleId, source), new DslModeling::RoleAssignment(ModelHasClass.ClassDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ModelHasClass(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ModelHasClass(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ModelHasClass(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ModelHasClass(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Model domain role code
		
		/// <summary>
		/// Model domain role Id.
		/// </summary>
		public static readonly global::System.Guid ModelDomainRoleId = new global::System.Guid(0x9e22f600, 0x80ad, 0x4883, 0xa3, 0x2f, 0xdf, 0x27, 0x38, 0xee, 0x36, 0x14);
		
		/// <summary>
		/// DomainRole Model
		/// Classes of the model
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelHasClass/Model.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelHasClass/Model.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Classes", PropertyDisplayNameKey="Castle.ActiveWriter.ModelHasClass/Model.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("9e22f600-80ad-4883-a32f-df2738ee3614")]
		public virtual Model Model
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Model)DslModeling::DomainRoleInfo.GetRolePlayer(this, ModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Model of a ModelClass
		/// <summary>
		/// Gets Model.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static Model GetModel(ModelClass element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, ClassDomainRoleId) as Model;
		}
		
		/// <summary>
		/// Sets Model.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetModel(ModelClass element, Model newModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, ClassDomainRoleId, newModel);
		}
		#endregion
		#region Class domain role code
		
		/// <summary>
		/// Class domain role Id.
		/// </summary>
		public static readonly global::System.Guid ClassDomainRoleId = new global::System.Guid(0x91a1db06, 0xcbe8, 0x44b8, 0xa8, 0x27, 0x32, 0x9a, 0x2c, 0xa1, 0x02, 0xc3);
		
		/// <summary>
		/// DomainRole Class
		/// Model of the class
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelHasClass/Class.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelHasClass/Class.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Model", PropertyDisplayNameKey="Castle.ActiveWriter.ModelHasClass/Class.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("91a1db06-cbe8-44b8-a827-329a2ca102c3")]
		public virtual ModelClass Class
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, ClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Classes of a Model
		/// <summary>
		/// Gets a list of Classes.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetClasses(Model element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, ModelDomainRoleId);
		}
		#endregion
		#region Model link accessor
		/// <summary>
		/// Get the list of ModelHasClass links to a Model.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ModelHasClass> GetLinksToClasses ( global::Castle.ActiveWriter.Model modelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasClass>(modelInstance, global::Castle.ActiveWriter.ModelHasClass.ModelDomainRoleId);
		}
		#endregion
		#region Class link accessor
		/// <summary>
		/// Get the ModelHasClass link to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.ModelHasClass GetLinkToModel (global::Castle.ActiveWriter.ModelClass classInstance)
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ModelHasClass> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasClass>(classInstance, global::Castle.ActiveWriter.ModelHasClass.ClassDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Class not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region ModelHasClass instance accessors
		
		/// <summary>
		/// Get any ModelHasClass links between a given Model and a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ModelHasClass> GetLinks( global::Castle.ActiveWriter.Model source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.ModelHasClass> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.ModelHasClass>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ModelHasClass> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasClass>(source, global::Castle.ActiveWriter.ModelHasClass.ModelDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ModelHasClass link in links )
			{
				if ( target.Equals(link.Class) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ModelHasClass link between a given Modeland a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.ModelHasClass GetLink( global::Castle.ActiveWriter.Model source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ModelHasClass> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasClass>(source, global::Castle.ActiveWriter.ModelHasClass.ModelDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ModelHasClass link in links )
			{
				if ( target.Equals(link.Class) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship ManyToOneRelation
	/// Maps a many to one association
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(AllowsDuplicates = true)]
	[DslModeling::DomainObjectId("68ba5474-0696-4988-9e76-1bc8e9eb9de8")]
	public partial class ManyToOneRelation : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ManyToOneRelation domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x68ba5474, 0x0696, 0x4988, 0x9e, 0x76, 0x1b, 0xc8, 0xe9, 0xeb, 0x9d, 0xe8);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ManyToOneRelation link in the same Partition as the given ModelClass
		/// </summary>
		/// <param name="source">ModelClass to use as the source of the relationship.</param>
		/// <param name="target">ModelClass to use as the target of the relationship.</param>
		public ManyToOneRelation(ModelClass source, ModelClass target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ManyToOneRelation.SourceDomainRoleId, source), new DslModeling::RoleAssignment(ManyToOneRelation.TargetDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ManyToOneRelation(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ManyToOneRelation(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ManyToOneRelation(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ManyToOneRelation(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Source domain role code
		
		/// <summary>
		/// Source domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceDomainRoleId = new global::System.Guid(0x8fc70677, 0xe363, 0x4cda, 0xb8, 0x21, 0x17, 0x50, 0x5c, 0xab, 0x2c, 0x14);
		
		/// <summary>
		/// DomainRole Source
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/Source.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/Source.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Targets", PropertyDisplayNameKey="Castle.ActiveWriter.ManyToOneRelation/Source.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("8fc70677-e363-4cda-b821-17505cab2c14")]
		public virtual ModelClass Source
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Sources of a ModelClass
		/// <summary>
		/// Gets a list of Sources.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetSources(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, TargetDomainRoleId);
		}
		#endregion
		#region Target domain role code
		
		/// <summary>
		/// Target domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainRoleId = new global::System.Guid(0x25d422d4, 0x6342, 0x4127, 0x9b, 0x72, 0x33, 0xda, 0x88, 0xdf, 0x08, 0xbe);
		
		/// <summary>
		/// DomainRole Target
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/Target.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/Target.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Sources", PropertyDisplayNameKey="Castle.ActiveWriter.ManyToOneRelation/Target.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("25d422d4-6342-4127-9b72-33da88df08be")]
		public virtual ModelClass Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Targets of a ModelClass
		/// <summary>
		/// Gets a list of Targets.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetTargets(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, SourceDomainRoleId);
		}
		#endregion
		#region TargetCache domain property code
		
		/// <summary>
		/// TargetCache domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCacheDomainPropertyId = new global::System.Guid(0xc3ac9ce5, 0x87b4, 0x48ca, 0xa2, 0x43, 0x26, 0xe0, 0xa2, 0x37, 0xe7, 0xab);
		
		/// <summary>
		/// Storage for TargetCache
		/// </summary>
		private CacheEnum targetCachePropertyStorage = CacheEnum.Undefined;
		
		/// <summary>
		/// Gets or sets the value of TargetCache domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetCache.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetCache.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetCache.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CacheEnum.Undefined)]
		[DslModeling::DomainObjectId("c3ac9ce5-87b4-48ca-a243-26e0a237e7ab")]
		public CacheEnum TargetCache
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCachePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCachePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetCache domain property.
		/// </summary>
		internal sealed partial class TargetCachePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, CacheEnum>
		{
			private TargetCachePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetCache domain property value handler.
			/// </summary>
			public static readonly TargetCachePropertyHandler Instance = new TargetCachePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetCache domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCacheDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CacheEnum GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCachePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, CacheEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CacheEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCachePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetCascade domain property code
		
		/// <summary>
		/// TargetCascade domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCascadeDomainPropertyId = new global::System.Guid(0x55f2f2e3, 0x3183, 0x4b1a, 0xb3, 0xc9, 0x9a, 0x86, 0x4f, 0xb2, 0xe4, 0xae);
		
		/// <summary>
		/// Storage for TargetCascade
		/// </summary>
		private ManyRelationCascadeEnum targetCascadePropertyStorage = ManyRelationCascadeEnum.None;
		
		/// <summary>
		/// Gets or sets the value of TargetCascade domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetCascade.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetCascade.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetCascade.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(ManyRelationCascadeEnum.None)]
		[DslModeling::DomainObjectId("55f2f2e3-3183-4b1a-b3c9-9a864fb2e4ae")]
		public ManyRelationCascadeEnum TargetCascade
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCascadePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCascadePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetCascade domain property.
		/// </summary>
		internal sealed partial class TargetCascadePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, ManyRelationCascadeEnum>
		{
			private TargetCascadePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetCascade domain property value handler.
			/// </summary>
			public static readonly TargetCascadePropertyHandler Instance = new TargetCascadePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetCascade domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCascadeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed ManyRelationCascadeEnum GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCascadePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, ManyRelationCascadeEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				ManyRelationCascadeEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCascadePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetColumnKey domain property code
		
		/// <summary>
		/// TargetColumnKey domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetColumnKeyDomainPropertyId = new global::System.Guid(0xe4d0bfec, 0x46a2, 0x466d, 0xb8, 0xf2, 0x55, 0x45, 0xeb, 0xb1, 0x86, 0x58);
		
		/// <summary>
		/// Storage for TargetColumnKey
		/// </summary>
		private global::System.String targetColumnKeyPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetColumnKey domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetColumnKey.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetColumnKey.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetColumnKey.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("e4d0bfec-46a2-466d-b8f2-5545ebb18658")]
		public global::System.String TargetColumnKey
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetColumnKeyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetColumnKeyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetColumnKey domain property.
		/// </summary>
		internal sealed partial class TargetColumnKeyPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetColumnKeyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetColumnKey domain property value handler.
			/// </summary>
			public static readonly TargetColumnKeyPropertyHandler Instance = new TargetColumnKeyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetColumnKey domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetColumnKeyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetColumnKeyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetColumnKeyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetCustomAccess domain property code
		
		/// <summary>
		/// TargetCustomAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCustomAccessDomainPropertyId = new global::System.Guid(0x76ddf835, 0xfca5, 0x44dc, 0xab, 0xb1, 0xad, 0xc0, 0xc1, 0x56, 0x3d, 0xb4);
		
		/// <summary>
		/// Storage for TargetCustomAccess
		/// </summary>
		private global::System.String targetCustomAccessPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetCustomAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetCustomAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetCustomAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetCustomAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("76ddf835-fca5-44dc-abb1-adc0c1563db4")]
		public global::System.String TargetCustomAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCustomAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCustomAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetCustomAccess domain property.
		/// </summary>
		internal sealed partial class TargetCustomAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetCustomAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetCustomAccess domain property value handler.
			/// </summary>
			public static readonly TargetCustomAccessPropertyHandler Instance = new TargetCustomAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetCustomAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCustomAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCustomAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCustomAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetInverse domain property code
		
		/// <summary>
		/// TargetInverse domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetInverseDomainPropertyId = new global::System.Guid(0x396220b5, 0x9996, 0x4ca6, 0x9c, 0xbb, 0xfc, 0xa1, 0x74, 0x54, 0x07, 0x65);
		
		/// <summary>
		/// Storage for TargetInverse
		/// </summary>
		private global::System.Boolean targetInversePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of TargetInverse domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetInverse.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetInverse.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetInverse.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("396220b5-9996-4ca6-9cbb-fca174540765")]
		public global::System.Boolean TargetInverse
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetInversePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetInversePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetInverse domain property.
		/// </summary>
		internal sealed partial class TargetInversePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private TargetInversePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetInverse domain property value handler.
			/// </summary>
			public static readonly TargetInversePropertyHandler Instance = new TargetInversePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetInverse domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetInverseDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetInversePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetInversePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetLazy domain property code
		
		/// <summary>
		/// TargetLazy domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetLazyDomainPropertyId = new global::System.Guid(0xb99bdbe1, 0x4c3b, 0x4040, 0xaa, 0x1e, 0x4f, 0x0f, 0x1f, 0x08, 0x1b, 0x93);
		
		/// <summary>
		/// Storage for TargetLazy
		/// </summary>
		private global::System.Boolean targetLazyPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of TargetLazy domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetLazy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetLazy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetLazy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("b99bdbe1-4c3b-4040-aa1e-4f0f1f081b93")]
		public global::System.Boolean TargetLazy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetLazyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetLazyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetLazy domain property.
		/// </summary>
		internal sealed partial class TargetLazyPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private TargetLazyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetLazy domain property value handler.
			/// </summary>
			public static readonly TargetLazyPropertyHandler Instance = new TargetLazyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetLazy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetLazyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetLazyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetLazyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetMapType domain property code
		
		/// <summary>
		/// TargetMapType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetMapTypeDomainPropertyId = new global::System.Guid(0x1a4f7b45, 0xa9e0, 0x4489, 0xa7, 0x1e, 0xf2, 0xa8, 0xae, 0xcb, 0xfb, 0x7f);
		
		/// <summary>
		/// Storage for TargetMapType
		/// </summary>
		private global::System.String targetMapTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetMapType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetMapType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetMapType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetMapType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("1a4f7b45-a9e0-4489-a71e-f2a8aecbfb7f")]
		public global::System.String TargetMapType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetMapTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetMapTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetMapType domain property.
		/// </summary>
		internal sealed partial class TargetMapTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetMapTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetMapType domain property value handler.
			/// </summary>
			public static readonly TargetMapTypePropertyHandler Instance = new TargetMapTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetMapType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetMapTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetMapTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetMapTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetOrderBy domain property code
		
		/// <summary>
		/// TargetOrderBy domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetOrderByDomainPropertyId = new global::System.Guid(0xec6503aa, 0xf498, 0x4992, 0xbd, 0x6f, 0xba, 0xa9, 0xfc, 0xc5, 0x68, 0xb3);
		
		/// <summary>
		/// Storage for TargetOrderBy
		/// </summary>
		private global::System.String targetOrderByPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetOrderBy domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetOrderBy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetOrderBy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetOrderBy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ec6503aa-f498-4992-bd6f-baa9fcc568b3")]
		public global::System.String TargetOrderBy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetOrderByPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetOrderByPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetOrderBy domain property.
		/// </summary>
		internal sealed partial class TargetOrderByPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetOrderByPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetOrderBy domain property value handler.
			/// </summary>
			public static readonly TargetOrderByPropertyHandler Instance = new TargetOrderByPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetOrderBy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetOrderByDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetOrderByPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetOrderByPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetRelationType domain property code
		
		/// <summary>
		/// TargetRelationType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetRelationTypeDomainPropertyId = new global::System.Guid(0x8c4ed47e, 0x37dc, 0x4975, 0xb9, 0x96, 0x7c, 0x65, 0x21, 0x94, 0x0b, 0xf2);
		
		/// <summary>
		/// Storage for TargetRelationType
		/// </summary>
		private InheritedRelationType targetRelationTypePropertyStorage = InheritedRelationType.Inherited;
		
		/// <summary>
		/// Gets or sets the value of TargetRelationType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetRelationType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetRelationType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetRelationType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritedRelationType.Inherited)]
		[DslModeling::DomainObjectId("8c4ed47e-37dc-4975-b996-7c6521940bf2")]
		public InheritedRelationType TargetRelationType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetRelationTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetRelationTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetRelationType domain property.
		/// </summary>
		internal sealed partial class TargetRelationTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, InheritedRelationType>
		{
			private TargetRelationTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetRelationType domain property value handler.
			/// </summary>
			public static readonly TargetRelationTypePropertyHandler Instance = new TargetRelationTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetRelationType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetRelationTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritedRelationType GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetRelationTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, InheritedRelationType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritedRelationType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetRelationTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetSchema domain property code
		
		/// <summary>
		/// TargetSchema domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetSchemaDomainPropertyId = new global::System.Guid(0x3da30e35, 0x2a3d, 0x4e5e, 0xab, 0x57, 0x8f, 0x71, 0xaf, 0x79, 0xc4, 0xc4);
		
		/// <summary>
		/// Storage for TargetSchema
		/// </summary>
		private global::System.String targetSchemaPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetSchema domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetSchema.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetSchema.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetSchema.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("3da30e35-2a3d-4e5e-ab57-8f71af79c4c4")]
		public global::System.String TargetSchema
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetSchemaPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetSchemaPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetSchema domain property.
		/// </summary>
		internal sealed partial class TargetSchemaPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetSchemaPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetSchema domain property value handler.
			/// </summary>
			public static readonly TargetSchemaPropertyHandler Instance = new TargetSchemaPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetSchema domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetSchemaDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetSchemaPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetSchemaPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetSort domain property code
		
		/// <summary>
		/// TargetSort domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetSortDomainPropertyId = new global::System.Guid(0xaa0eab75, 0x566c, 0x40a8, 0xae, 0x2c, 0xdd, 0xf1, 0x3e, 0xff, 0xa6, 0x36);
		
		/// <summary>
		/// Storage for TargetSort
		/// </summary>
		private global::System.String targetSortPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetSort domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetSort.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetSort.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetSort.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("aa0eab75-566c-40a8-ae2c-ddf13effa636")]
		public global::System.String TargetSort
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetSortPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetSortPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetSort domain property.
		/// </summary>
		internal sealed partial class TargetSortPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetSortPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetSort domain property value handler.
			/// </summary>
			public static readonly TargetSortPropertyHandler Instance = new TargetSortPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetSort domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetSortDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetSortPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetSortPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetTable domain property code
		
		/// <summary>
		/// TargetTable domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetTableDomainPropertyId = new global::System.Guid(0xdbace6bc, 0x2b15, 0x4b78, 0xa5, 0x7d, 0x95, 0x85, 0x2b, 0x8c, 0xd5, 0x83);
		
		/// <summary>
		/// Storage for TargetTable
		/// </summary>
		private global::System.String targetTablePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetTable domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetTable.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetTable.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetTable.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("dbace6bc-2b15-4b78-a57d-95852b8cd583")]
		public global::System.String TargetTable
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetTablePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetTablePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetTable domain property.
		/// </summary>
		internal sealed partial class TargetTablePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetTablePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetTable domain property value handler.
			/// </summary>
			public static readonly TargetTablePropertyHandler Instance = new TargetTablePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetTable domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetTableDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetTablePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetTablePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetWhere domain property code
		
		/// <summary>
		/// TargetWhere domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetWhereDomainPropertyId = new global::System.Guid(0x2f1e9945, 0x4335, 0x4316, 0xa7, 0x05, 0x3e, 0x27, 0xa0, 0x94, 0x3b, 0x61);
		
		/// <summary>
		/// Storage for TargetWhere
		/// </summary>
		private global::System.String targetWherePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetWhere domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetWhere.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetWhere.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetWhere.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("2f1e9945-4335-4316-a705-3e27a0943b61")]
		public global::System.String TargetWhere
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetWherePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetWherePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetWhere domain property.
		/// </summary>
		internal sealed partial class TargetWherePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetWherePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetWhere domain property value handler.
			/// </summary>
			public static readonly TargetWherePropertyHandler Instance = new TargetWherePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetWhere domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetWhereDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetWherePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetWherePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetDescription domain property code
		
		/// <summary>
		/// TargetDescription domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetDescriptionDomainPropertyId = new global::System.Guid(0xe4a0ff32, 0xb309, 0x439a, 0x94, 0xb5, 0xde, 0x8d, 0x3e, 0xf7, 0xd0, 0xca);
		
		/// <summary>
		/// Storage for TargetDescription
		/// </summary>
		private global::System.String targetDescriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetDescription domain property.
		/// Description of the property. This will appear in a <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetDescription.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetDescription.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetDescription.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("e4a0ff32-b309-439a-94b5-de8d3ef7d0ca")]
		public global::System.String TargetDescription
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetDescriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetDescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetDescription domain property.
		/// </summary>
		internal sealed partial class TargetDescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetDescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetDescription domain property value handler.
			/// </summary>
			public static readonly TargetDescriptionPropertyHandler Instance = new TargetDescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetDescription domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetDescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetDescriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetDescriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetPropertyName domain property code
		
		/// <summary>
		/// TargetPropertyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetPropertyNameDomainPropertyId = new global::System.Guid(0x658c3768, 0x1a8c, 0x442c, 0x8e, 0xbe, 0xdf, 0x02, 0x00, 0x7c, 0xc3, 0xa1);
		
		/// <summary>
		/// Storage for TargetPropertyName
		/// </summary>
		private global::System.String targetPropertyNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetPropertyName domain property.
		/// Name of the property in the generated code. If not supplied, ActiveWriter will
		/// use the source class name in plural form.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("658c3768-1a8c-442c-8ebe-df02007cc3a1")]
		public global::System.String TargetPropertyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetPropertyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetPropertyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetPropertyName domain property.
		/// </summary>
		internal sealed partial class TargetPropertyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetPropertyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetPropertyName domain property value handler.
			/// </summary>
			public static readonly TargetPropertyNamePropertyHandler Instance = new TargetPropertyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetPropertyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetPropertyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetPropertyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetPropertyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetPropertyType domain property code
		
		/// <summary>
		/// TargetPropertyType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetPropertyTypeDomainPropertyId = new global::System.Guid(0xf415a978, 0x5c96, 0x46e1, 0x90, 0x0e, 0x44, 0x33, 0x03, 0xaa, 0x5a, 0x37);
		
		/// <summary>
		/// Storage for TargetPropertyType
		/// </summary>
		private global::System.String targetPropertyTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetPropertyType domain property.
		/// Type of the property. If not supplied, ActiveWriter will use the model's
		/// Collection Inteface by default.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::DomainObjectId("f415a978-5c96-46e1-900e-443303aa5a37")]
		public global::System.String TargetPropertyType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetPropertyTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetPropertyTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetPropertyType domain property.
		/// </summary>
		internal sealed partial class TargetPropertyTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetPropertyTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetPropertyType domain property value handler.
			/// </summary>
			public static readonly TargetPropertyTypePropertyHandler Instance = new TargetPropertyTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetPropertyType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetPropertyTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetPropertyTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetPropertyTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceCascade domain property code
		
		/// <summary>
		/// SourceCascade domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceCascadeDomainPropertyId = new global::System.Guid(0x563916db, 0x4a01, 0x4bd6, 0xb6, 0xb4, 0xaa, 0xb1, 0x5e, 0x39, 0x6f, 0x78);
		
		/// <summary>
		/// Storage for SourceCascade
		/// </summary>
		private CascadeEnum sourceCascadePropertyStorage = CascadeEnum.None;
		
		/// <summary>
		/// Gets or sets the value of SourceCascade domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceCascade.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceCascade.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceCascade.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CascadeEnum.None)]
		[DslModeling::DomainObjectId("563916db-4a01-4bd6-b6b4-aab15e396f78")]
		public CascadeEnum SourceCascade
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceCascadePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceCascadePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceCascade domain property.
		/// </summary>
		internal sealed partial class SourceCascadePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, CascadeEnum>
		{
			private SourceCascadePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceCascade domain property value handler.
			/// </summary>
			public static readonly SourceCascadePropertyHandler Instance = new SourceCascadePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceCascade domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceCascadeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CascadeEnum GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceCascadePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, CascadeEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CascadeEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceCascadePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceColumn domain property code
		
		/// <summary>
		/// SourceColumn domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceColumnDomainPropertyId = new global::System.Guid(0x78d006af, 0x6e94, 0x463b, 0xa5, 0xbf, 0xfb, 0xa6, 0x55, 0x34, 0xf2, 0x72);
		
		/// <summary>
		/// Storage for SourceColumn
		/// </summary>
		private global::System.String sourceColumnPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceColumn domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceColumn.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceColumn.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceColumn.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("78d006af-6e94-463b-a5bf-fba65534f272")]
		public global::System.String SourceColumn
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceColumnPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceColumnPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceColumn domain property.
		/// </summary>
		internal sealed partial class SourceColumnPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private SourceColumnPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceColumn domain property value handler.
			/// </summary>
			public static readonly SourceColumnPropertyHandler Instance = new SourceColumnPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceColumn domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceColumnDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceColumnPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceColumnPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceCustomAccess domain property code
		
		/// <summary>
		/// SourceCustomAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceCustomAccessDomainPropertyId = new global::System.Guid(0xf24290b4, 0x9a78, 0x4bd0, 0xb9, 0xba, 0x4f, 0x79, 0x73, 0x76, 0x83, 0x89);
		
		/// <summary>
		/// Storage for SourceCustomAccess
		/// </summary>
		private global::System.String sourceCustomAccessPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceCustomAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceCustomAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceCustomAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceCustomAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("f24290b4-9a78-4bd0-b9ba-4f7973768389")]
		public global::System.String SourceCustomAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceCustomAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceCustomAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceCustomAccess domain property.
		/// </summary>
		internal sealed partial class SourceCustomAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private SourceCustomAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceCustomAccess domain property value handler.
			/// </summary>
			public static readonly SourceCustomAccessPropertyHandler Instance = new SourceCustomAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceCustomAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceCustomAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceCustomAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceCustomAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceInsert domain property code
		
		/// <summary>
		/// SourceInsert domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceInsertDomainPropertyId = new global::System.Guid(0x69f188c5, 0x6e65, 0x4d3c, 0xad, 0x92, 0x5f, 0x70, 0x6d, 0x79, 0xea, 0xad);
		
		/// <summary>
		/// Storage for SourceInsert
		/// </summary>
		private global::System.Boolean sourceInsertPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of SourceInsert domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceInsert.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceInsert.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceInsert.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("69f188c5-6e65-4d3c-ad92-5f706d79eaad")]
		public global::System.Boolean SourceInsert
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceInsertPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceInsertPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceInsert domain property.
		/// </summary>
		internal sealed partial class SourceInsertPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private SourceInsertPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceInsert domain property value handler.
			/// </summary>
			public static readonly SourceInsertPropertyHandler Instance = new SourceInsertPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceInsert domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceInsertDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceInsertPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceInsertPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceNotNull domain property code
		
		/// <summary>
		/// SourceNotNull domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceNotNullDomainPropertyId = new global::System.Guid(0x12d3226e, 0x3185, 0x44be, 0xaf, 0x32, 0x1e, 0x34, 0x59, 0xca, 0xd8, 0xe9);
		
		/// <summary>
		/// Storage for SourceNotNull
		/// </summary>
		private global::System.Boolean sourceNotNullPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of SourceNotNull domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceNotNull.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceNotNull.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceNotNull.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("12d3226e-3185-44be-af32-1e3459cad8e9")]
		public global::System.Boolean SourceNotNull
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceNotNullPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceNotNullPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceNotNull domain property.
		/// </summary>
		internal sealed partial class SourceNotNullPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private SourceNotNullPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceNotNull domain property value handler.
			/// </summary>
			public static readonly SourceNotNullPropertyHandler Instance = new SourceNotNullPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceNotNull domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceNotNullDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceNotNullPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceNotNullPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceOuterJoin domain property code
		
		/// <summary>
		/// SourceOuterJoin domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceOuterJoinDomainPropertyId = new global::System.Guid(0xd5bd0e29, 0x9032, 0x4775, 0x97, 0x11, 0xdf, 0x5b, 0x24, 0xf9, 0x91, 0x4d);
		
		/// <summary>
		/// Storage for SourceOuterJoin
		/// </summary>
		private OuterJoinEnum sourceOuterJoinPropertyStorage = OuterJoinEnum.Auto;
		
		/// <summary>
		/// Gets or sets the value of SourceOuterJoin domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceOuterJoin.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceOuterJoin.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceOuterJoin.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(OuterJoinEnum.Auto)]
		[DslModeling::DomainObjectId("d5bd0e29-9032-4775-9711-df5b24f9914d")]
		public OuterJoinEnum SourceOuterJoin
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceOuterJoinPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceOuterJoinPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceOuterJoin domain property.
		/// </summary>
		internal sealed partial class SourceOuterJoinPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, OuterJoinEnum>
		{
			private SourceOuterJoinPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceOuterJoin domain property value handler.
			/// </summary>
			public static readonly SourceOuterJoinPropertyHandler Instance = new SourceOuterJoinPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceOuterJoin domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceOuterJoinDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed OuterJoinEnum GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceOuterJoinPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, OuterJoinEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				OuterJoinEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceOuterJoinPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceType domain property code
		
		/// <summary>
		/// SourceType domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceTypeDomainPropertyId = new global::System.Guid(0xd03c165e, 0xb655, 0x4428, 0xa3, 0x68, 0x6a, 0x91, 0x84, 0x80, 0x54, 0x70);
		
		/// <summary>
		/// Storage for SourceType
		/// </summary>
		private global::System.String sourceTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("d03c165e-b655-4428-a368-6a9184805470")]
		public global::System.String SourceType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceType domain property.
		/// </summary>
		internal sealed partial class SourceTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private SourceTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceType domain property value handler.
			/// </summary>
			public static readonly SourceTypePropertyHandler Instance = new SourceTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceUnique domain property code
		
		/// <summary>
		/// SourceUnique domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceUniqueDomainPropertyId = new global::System.Guid(0xc2e055f1, 0x5410, 0x4488, 0x90, 0xcd, 0x27, 0x8a, 0x8a, 0x49, 0x4a, 0xb7);
		
		/// <summary>
		/// Storage for SourceUnique
		/// </summary>
		private global::System.Boolean sourceUniquePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of SourceUnique domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceUnique.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceUnique.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceUnique.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("c2e055f1-5410-4488-90cd-278a8a494ab7")]
		public global::System.Boolean SourceUnique
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceUniquePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceUniquePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceUnique domain property.
		/// </summary>
		internal sealed partial class SourceUniquePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private SourceUniquePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceUnique domain property value handler.
			/// </summary>
			public static readonly SourceUniquePropertyHandler Instance = new SourceUniquePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceUnique domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceUniqueDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceUniquePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceUniquePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceUpdate domain property code
		
		/// <summary>
		/// SourceUpdate domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceUpdateDomainPropertyId = new global::System.Guid(0x328a72d1, 0x69d3, 0x45f5, 0xb6, 0x71, 0x27, 0xb0, 0xb8, 0xce, 0x08, 0xf1);
		
		/// <summary>
		/// Storage for SourceUpdate
		/// </summary>
		private global::System.Boolean sourceUpdatePropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of SourceUpdate domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceUpdate.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceUpdate.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceUpdate.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("328a72d1-69d3-45f5-b671-27b0b8ce08f1")]
		public global::System.Boolean SourceUpdate
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceUpdatePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceUpdatePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceUpdate domain property.
		/// </summary>
		internal sealed partial class SourceUpdatePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private SourceUpdatePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceUpdate domain property value handler.
			/// </summary>
			public static readonly SourceUpdatePropertyHandler Instance = new SourceUpdatePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceUpdate domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceUpdateDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceUpdatePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceUpdatePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceDescription domain property code
		
		/// <summary>
		/// SourceDescription domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceDescriptionDomainPropertyId = new global::System.Guid(0x4090d713, 0x654c, 0x48c3, 0x96, 0x40, 0x73, 0xad, 0x00, 0xdb, 0xc4, 0xb6);
		
		/// <summary>
		/// Storage for SourceDescription
		/// </summary>
		private global::System.String sourceDescriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceDescription domain property.
		/// Description of the property. This will appear in a <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceDescription.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceDescription.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceDescription.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("4090d713-654c-48c3-9640-73ad00dbc4b6")]
		public global::System.String SourceDescription
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceDescriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceDescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceDescription domain property.
		/// </summary>
		internal sealed partial class SourceDescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private SourceDescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceDescription domain property value handler.
			/// </summary>
			public static readonly SourceDescriptionPropertyHandler Instance = new SourceDescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceDescription domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceDescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceDescriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceDescriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetAccess domain property code
		
		/// <summary>
		/// TargetAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetAccessDomainPropertyId = new global::System.Guid(0x05776d07, 0x5fe2, 0x4041, 0x84, 0xfc, 0x8d, 0x0c, 0x1d, 0x3b, 0x21, 0xec);
		
		/// <summary>
		/// Storage for TargetAccess
		/// </summary>
		private InheritablePropertyAccess targetAccessPropertyStorage = InheritablePropertyAccess.Inherit;
		
		/// <summary>
		/// Gets or sets the value of TargetAccess domain property.
		/// The access strategy.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritablePropertyAccess.Inherit)]
		[DslModeling::DomainObjectId("05776d07-5fe2-4041-84fc-8d0c1d3b21ec")]
		public InheritablePropertyAccess TargetAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetAccess domain property.
		/// </summary>
		internal sealed partial class TargetAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, InheritablePropertyAccess>
		{
			private TargetAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetAccess domain property value handler.
			/// </summary>
			public static readonly TargetAccessPropertyHandler Instance = new TargetAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritablePropertyAccess GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, InheritablePropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritablePropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourcePropertyName domain property code
		
		/// <summary>
		/// SourcePropertyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourcePropertyNameDomainPropertyId = new global::System.Guid(0x46603735, 0x0a4c, 0x4811, 0xa6, 0x43, 0x12, 0x58, 0x44, 0xdf, 0x7d, 0x70);
		
		/// <summary>
		/// Storage for SourcePropertyName
		/// </summary>
		private global::System.String sourcePropertyNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourcePropertyName domain property.
		/// Name of the property. If not suplied, ActiveWriter will use target class name.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourcePropertyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourcePropertyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourcePropertyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("46603735-0a4c-4811-a643-125844df7d70")]
		public global::System.String SourcePropertyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourcePropertyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourcePropertyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourcePropertyName domain property.
		/// </summary>
		internal sealed partial class SourcePropertyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private SourcePropertyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourcePropertyName domain property value handler.
			/// </summary>
			public static readonly SourcePropertyNamePropertyHandler Instance = new SourcePropertyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourcePropertyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourcePropertyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourcePropertyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourcePropertyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceNotFoundBehaviour domain property code
		
		/// <summary>
		/// SourceNotFoundBehaviour domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceNotFoundBehaviourDomainPropertyId = new global::System.Guid(0xe9556820, 0xfa84, 0x4921, 0x97, 0xa3, 0xc7, 0xcc, 0x3b, 0x45, 0xd5, 0x39);
		
		/// <summary>
		/// Storage for SourceNotFoundBehaviour
		/// </summary>
		private NotFoundBehaviour sourceNotFoundBehaviourPropertyStorage = NotFoundBehaviour.Default;
		
		/// <summary>
		/// Gets or sets the value of SourceNotFoundBehaviour domain property.
		/// Gets or sets the way broken relations are handled.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceNotFoundBehaviour.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceNotFoundBehaviour.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceNotFoundBehaviour.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(NotFoundBehaviour.Default)]
		[DslModeling::DomainObjectId("e9556820-fa84-4921-97a3-c7cc3b45d539")]
		public NotFoundBehaviour SourceNotFoundBehaviour
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceNotFoundBehaviourPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceNotFoundBehaviourPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceNotFoundBehaviour domain property.
		/// </summary>
		internal sealed partial class SourceNotFoundBehaviourPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, NotFoundBehaviour>
		{
			private SourceNotFoundBehaviourPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceNotFoundBehaviour domain property value handler.
			/// </summary>
			public static readonly SourceNotFoundBehaviourPropertyHandler Instance = new SourceNotFoundBehaviourPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceNotFoundBehaviour domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceNotFoundBehaviourDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NotFoundBehaviour GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceNotFoundBehaviourPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, NotFoundBehaviour newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NotFoundBehaviour oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceNotFoundBehaviourPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetNotFoundBehaviour domain property code
		
		/// <summary>
		/// TargetNotFoundBehaviour domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetNotFoundBehaviourDomainPropertyId = new global::System.Guid(0x91224e05, 0x42d5, 0x4913, 0x96, 0x59, 0xaa, 0x89, 0x96, 0xfb, 0x82, 0x40);
		
		/// <summary>
		/// Storage for TargetNotFoundBehaviour
		/// </summary>
		private NotFoundBehaviour targetNotFoundBehaviourPropertyStorage = NotFoundBehaviour.Default;
		
		/// <summary>
		/// Gets or sets the value of TargetNotFoundBehaviour domain property.
		/// Gets or sets the way broken relations are handled.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetNotFoundBehaviour.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetNotFoundBehaviour.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetNotFoundBehaviour.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(NotFoundBehaviour.Default)]
		[DslModeling::DomainObjectId("91224e05-42d5-4913-9659-aa8996fb8240")]
		public NotFoundBehaviour TargetNotFoundBehaviour
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetNotFoundBehaviourPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetNotFoundBehaviourPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetNotFoundBehaviour domain property.
		/// </summary>
		internal sealed partial class TargetNotFoundBehaviourPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, NotFoundBehaviour>
		{
			private TargetNotFoundBehaviourPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetNotFoundBehaviour domain property value handler.
			/// </summary>
			public static readonly TargetNotFoundBehaviourPropertyHandler Instance = new TargetNotFoundBehaviourPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetNotFoundBehaviour domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetNotFoundBehaviourDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NotFoundBehaviour GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetNotFoundBehaviourPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, NotFoundBehaviour newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NotFoundBehaviour oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetNotFoundBehaviourPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetElement domain property code
		
		/// <summary>
		/// TargetElement domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetElementDomainPropertyId = new global::System.Guid(0x0c3d3bc5, 0xbea7, 0x4146, 0x8a, 0x8e, 0x94, 0x36, 0x26, 0x59, 0x5d, 0x5b);
		
		/// <summary>
		/// Storage for TargetElement
		/// </summary>
		private global::System.String targetElementPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetElement domain property.
		/// Use for simple types.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetElement.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetElement.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetElement.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("0c3d3bc5-bea7-4146-8a8e-943626595d5b")]
		public global::System.String TargetElement
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetElementPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetElementPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetElement domain property.
		/// </summary>
		internal sealed partial class TargetElementPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetElementPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetElement domain property value handler.
			/// </summary>
			public static readonly TargetElementPropertyHandler Instance = new TargetElementPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetElement domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetElementDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetElementPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetElementPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetIndexType domain property code
		
		/// <summary>
		/// TargetIndexType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetIndexTypeDomainPropertyId = new global::System.Guid(0x90d3139c, 0xf9b1, 0x4dd1, 0x8d, 0xb6, 0x7c, 0x85, 0x64, 0xab, 0xb2, 0x13);
		
		/// <summary>
		/// Storage for TargetIndexType
		/// </summary>
		private global::System.String targetIndexTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetIndexType domain property.
		/// Only used with maps.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetIndexType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetIndexType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetIndexType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("90d3139c-f9b1-4dd1-8db6-7c8564abb213")]
		public global::System.String TargetIndexType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetIndexTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetIndexTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetIndexType domain property.
		/// </summary>
		internal sealed partial class TargetIndexTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetIndexTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetIndexType domain property value handler.
			/// </summary>
			public static readonly TargetIndexTypePropertyHandler Instance = new TargetIndexTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetIndexType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetIndexTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetIndexTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetIndexTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetIndex domain property code
		
		/// <summary>
		/// TargetIndex domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetIndexDomainPropertyId = new global::System.Guid(0xefe49545, 0x0679, 0x4e40, 0x96, 0x7e, 0xe8, 0x03, 0x4c, 0x83, 0xf7, 0x0e);
		
		/// <summary>
		/// Storage for TargetIndex
		/// </summary>
		private global::System.String targetIndexPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetIndex domain property.
		/// Only used with maps or list.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetIndex.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetIndex.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetIndex.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("efe49545-0679-4e40-967e-e8034c83f70e")]
		public global::System.String TargetIndex
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetIndexPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetIndexPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetIndex domain property.
		/// </summary>
		internal sealed partial class TargetIndexPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetIndexPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetIndex domain property value handler.
			/// </summary>
			public static readonly TargetIndexPropertyHandler Instance = new TargetIndexPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetIndex domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetIndexDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetIndexPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetIndexPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetFetch domain property code
		
		/// <summary>
		/// TargetFetch domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetFetchDomainPropertyId = new global::System.Guid(0x65a5cad5, 0xdaac, 0x4487, 0xbd, 0xd4, 0x24, 0xba, 0x76, 0x1f, 0x92, 0xb1);
		
		/// <summary>
		/// Storage for TargetFetch
		/// </summary>
		private FetchEnum targetFetchPropertyStorage = FetchEnum.Unspecified;
		
		/// <summary>
		/// Gets or sets the value of TargetFetch domain property.
		/// Description for Castle.ActiveWriter.ManyToOneRelation.Target Fetch
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetFetch.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetFetch.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(FetchEnum.Unspecified)]
		[DslModeling::DomainObjectId("65a5cad5-daac-4487-bdd4-24ba761f92b1")]
		public FetchEnum TargetFetch
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetFetchPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetFetchPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetFetch domain property.
		/// </summary>
		internal sealed partial class TargetFetchPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, FetchEnum>
		{
			private TargetFetchPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetFetch domain property value handler.
			/// </summary>
			public static readonly TargetFetchPropertyHandler Instance = new TargetFetchPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetFetch domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetFetchDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed FetchEnum GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetFetchPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, FetchEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				FetchEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetFetchPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetIUserCollectionType domain property code
		
		/// <summary>
		/// TargetIUserCollectionType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetIUserCollectionTypeDomainPropertyId = new global::System.Guid(0x173770db, 0x04a0, 0x4401, 0xb2, 0xdd, 0x69, 0xe7, 0x0e, 0xdd, 0xa7, 0x34);
		
		/// <summary>
		/// Storage for TargetIUserCollectionType
		/// </summary>
		private global::System.String targetIUserCollectionTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetIUserCollectionType domain property.
		/// User collection type for many side of relationship
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetIUserCollectionType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetIUserCollectionType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetIUserCollectionType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("173770db-04a0-4401-b2dd-69e70edda734")]
		public global::System.String TargetIUserCollectionType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetIUserCollectionTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetIUserCollectionTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetIUserCollectionType domain property.
		/// </summary>
		internal sealed partial class TargetIUserCollectionTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.String>
		{
			private TargetIUserCollectionTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetIUserCollectionType domain property value handler.
			/// </summary>
			public static readonly TargetIUserCollectionTypePropertyHandler Instance = new TargetIUserCollectionTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetIUserCollectionType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetIUserCollectionTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetIUserCollectionTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetIUserCollectionTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetPropertyGenerated domain property code
		
		/// <summary>
		/// TargetPropertyGenerated domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetPropertyGeneratedDomainPropertyId = new global::System.Guid(0xb78081c0, 0x24d3, 0x4367, 0x80, 0x07, 0x6f, 0x5d, 0xa7, 0x3d, 0x41, 0x1c);
		
		/// <summary>
		/// Storage for TargetPropertyGenerated
		/// </summary>
		private global::System.Boolean targetPropertyGeneratedPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of TargetPropertyGenerated domain property.
		/// Description for Castle.ActiveWriter.ManyToOneRelation.Target Property Generated
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyGenerated.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyGenerated.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/TargetPropertyGenerated.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("b78081c0-24d3-4367-8007-6f5da73d411c")]
		public global::System.Boolean TargetPropertyGenerated
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetPropertyGeneratedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetPropertyGeneratedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.TargetPropertyGenerated domain property.
		/// </summary>
		internal sealed partial class TargetPropertyGeneratedPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private TargetPropertyGeneratedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.TargetPropertyGenerated domain property value handler.
			/// </summary>
			public static readonly TargetPropertyGeneratedPropertyHandler Instance = new TargetPropertyGeneratedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.TargetPropertyGenerated domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetPropertyGeneratedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetPropertyGeneratedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetPropertyGeneratedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourcePropertyGenerated domain property code
		
		/// <summary>
		/// SourcePropertyGenerated domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourcePropertyGeneratedDomainPropertyId = new global::System.Guid(0x5a6da19e, 0xae0e, 0x49c5, 0xaf, 0xa1, 0xdf, 0xce, 0x04, 0x33, 0xe4, 0x64);
		
		/// <summary>
		/// Storage for SourcePropertyGenerated
		/// </summary>
		private global::System.Boolean sourcePropertyGeneratedPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of SourcePropertyGenerated domain property.
		/// Description for Castle.ActiveWriter.ManyToOneRelation.Source Property Generated
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourcePropertyGenerated.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourcePropertyGenerated.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourcePropertyGenerated.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("5a6da19e-ae0e-49c5-afa1-dfce0433e464")]
		public global::System.Boolean SourcePropertyGenerated
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourcePropertyGeneratedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourcePropertyGeneratedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourcePropertyGenerated domain property.
		/// </summary>
		internal sealed partial class SourcePropertyGeneratedPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, global::System.Boolean>
		{
			private SourcePropertyGeneratedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourcePropertyGenerated domain property value handler.
			/// </summary>
			public static readonly SourcePropertyGeneratedPropertyHandler Instance = new SourcePropertyGeneratedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourcePropertyGenerated domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourcePropertyGeneratedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourcePropertyGeneratedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourcePropertyGeneratedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceAccess domain property code
		
		/// <summary>
		/// SourceAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceAccessDomainPropertyId = new global::System.Guid(0x06b82c89, 0x9c53, 0x467a, 0x8e, 0x36, 0x90, 0xe8, 0x7b, 0xe1, 0xe5, 0xf3);
		
		/// <summary>
		/// Storage for SourceAccess
		/// </summary>
		private InheritablePropertyAccess sourceAccessPropertyStorage = InheritablePropertyAccess.Inherit;
		
		/// <summary>
		/// Gets or sets the value of SourceAccess domain property.
		/// Description for Castle.ActiveWriter.ManyToOneRelation.Source Access
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToOneRelation/SourceAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToOneRelation/SourceAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToOneRelation/SourceAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritablePropertyAccess.Inherit)]
		[DslModeling::DomainObjectId("06b82c89-9c53-467a-8e36-90e87be1e5f3")]
		public InheritablePropertyAccess SourceAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToOneRelation.SourceAccess domain property.
		/// </summary>
		internal sealed partial class SourceAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToOneRelation, InheritablePropertyAccess>
		{
			private SourceAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToOneRelation.SourceAccess domain property value handler.
			/// </summary>
			public static readonly SourceAccessPropertyHandler Instance = new SourceAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToOneRelation.SourceAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritablePropertyAccess GetValue(ManyToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToOneRelation element, InheritablePropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritablePropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Source link accessor
		/// <summary>
		/// Get the list of ManyToOneRelation links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ManyToOneRelation> GetLinksToTargets ( global::Castle.ActiveWriter.ModelClass sourceInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ManyToOneRelation>(sourceInstance, global::Castle.ActiveWriter.ManyToOneRelation.SourceDomainRoleId);
		}
		#endregion
		#region Target link accessor
		/// <summary>
		/// Get the list of ManyToOneRelation links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ManyToOneRelation> GetLinksToSources ( global::Castle.ActiveWriter.ModelClass targetInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ManyToOneRelation>(targetInstance, global::Castle.ActiveWriter.ManyToOneRelation.TargetDomainRoleId);
		}
		#endregion
		#region ManyToOneRelation instance accessors
		
		/// <summary>
		/// Get any ManyToOneRelation links between a given ModelClass and a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ManyToOneRelation> GetLinks( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.ManyToOneRelation> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.ManyToOneRelation>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ManyToOneRelation> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ManyToOneRelation>(source, global::Castle.ActiveWriter.ManyToOneRelation.SourceDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ManyToOneRelation link in links )
			{
				if ( target.Equals(link.Target) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship ClassHasProperty
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ClassHasProperty.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ClassHasProperty.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("8f270f87-f8f4-4f43-9fe5-13b75748144c")]
	public partial class ClassHasProperty : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ClassHasProperty domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x8f270f87, 0xf8f4, 0x4f43, 0x9f, 0xe5, 0x13, 0xb7, 0x57, 0x48, 0x14, 0x4c);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ClassHasProperty link in the same Partition as the given ModelClass
		/// </summary>
		/// <param name="source">ModelClass to use as the source of the relationship.</param>
		/// <param name="target">ModelProperty to use as the target of the relationship.</param>
		public ClassHasProperty(ModelClass source, ModelProperty target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ClassHasProperty.ModelClassDomainRoleId, source), new DslModeling::RoleAssignment(ClassHasProperty.PropertyDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ClassHasProperty(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ClassHasProperty(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ClassHasProperty(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ClassHasProperty(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region ModelClass domain role code
		
		/// <summary>
		/// ModelClass domain role Id.
		/// </summary>
		public static readonly global::System.Guid ModelClassDomainRoleId = new global::System.Guid(0x8eddf27d, 0xb9d1, 0x4813, 0x94, 0x0e, 0xc3, 0x74, 0x24, 0x81, 0x12, 0xcb);
		
		/// <summary>
		/// DomainRole ModelClass
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ClassHasProperty/ModelClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ClassHasProperty/ModelClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Properties", PropertyDisplayNameKey="Castle.ActiveWriter.ClassHasProperty/ModelClass.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("8eddf27d-b9d1-4813-940e-c374248112cb")]
		public virtual ModelClass ModelClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, ModelClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ModelClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ModelClass of a ModelProperty
		/// <summary>
		/// Gets ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static ModelClass GetModelClass(ModelProperty element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, PropertyDomainRoleId) as ModelClass;
		}
		
		/// <summary>
		/// Sets ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetModelClass(ModelProperty element, ModelClass newModelClass)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, PropertyDomainRoleId, newModelClass);
		}
		#endregion
		#region Property domain role code
		
		/// <summary>
		/// Property domain role Id.
		/// </summary>
		public static readonly global::System.Guid PropertyDomainRoleId = new global::System.Guid(0x2a4fd4f7, 0x6c32, 0x4821, 0x9f, 0x28, 0xf5, 0x96, 0xad, 0x94, 0x23, 0xf0);
		
		/// <summary>
		/// DomainRole Property
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ClassHasProperty/Property.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ClassHasProperty/Property.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "ModelClass", PropertyDisplayNameKey="Castle.ActiveWriter.ClassHasProperty/Property.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroOne)]
		[DslModeling::DomainObjectId("2a4fd4f7-6c32-4821-9f28-f596ad9423f0")]
		public virtual ModelProperty Property
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelProperty)DslModeling::DomainRoleInfo.GetRolePlayer(this, PropertyDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, PropertyDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Properties of a ModelClass
		/// <summary>
		/// Gets a list of Properties.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelProperty> GetProperties(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelProperty>, ModelProperty>(element, ModelClassDomainRoleId);
		}
		#endregion
		#region ModelClass link accessor
		/// <summary>
		/// Get the list of ClassHasProperty links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ClassHasProperty> GetLinksToProperties ( global::Castle.ActiveWriter.ModelClass modelClassInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ClassHasProperty>(modelClassInstance, global::Castle.ActiveWriter.ClassHasProperty.ModelClassDomainRoleId);
		}
		#endregion
		#region Property link accessor
		/// <summary>
		/// Get the ClassHasProperty link to a ModelProperty.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.ClassHasProperty GetLinkToModelClass (global::Castle.ActiveWriter.ModelProperty propertyInstance)
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ClassHasProperty> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ClassHasProperty>(propertyInstance, global::Castle.ActiveWriter.ClassHasProperty.PropertyDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Property not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region ClassHasProperty instance accessors
		
		/// <summary>
		/// Get any ClassHasProperty links between a given ModelClass and a ModelProperty.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ClassHasProperty> GetLinks( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelProperty target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.ClassHasProperty> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.ClassHasProperty>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ClassHasProperty> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ClassHasProperty>(source, global::Castle.ActiveWriter.ClassHasProperty.ModelClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ClassHasProperty link in links )
			{
				if ( target.Equals(link.Property) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ClassHasProperty link between a given ModelClassand a ModelProperty.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.ClassHasProperty GetLink( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelProperty target )
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ClassHasProperty> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ClassHasProperty>(source, global::Castle.ActiveWriter.ClassHasProperty.ModelClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ClassHasProperty link in links )
			{
				if ( target.Equals(link.Property) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship ManyToManyRelation
	/// Maps a many to many association with an association table
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(AllowsDuplicates = true)]
	[DslModeling::DomainObjectId("3facccc2-b82b-4dd9-b414-1a787f87ecd8")]
	public partial class ManyToManyRelation : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ManyToManyRelation domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x3facccc2, 0xb82b, 0x4dd9, 0xb4, 0x14, 0x1a, 0x78, 0x7f, 0x87, 0xec, 0xd8);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ManyToManyRelation link in the same Partition as the given ModelClass
		/// </summary>
		/// <param name="source">ModelClass to use as the source of the relationship.</param>
		/// <param name="target">ModelClass to use as the target of the relationship.</param>
		public ManyToManyRelation(ModelClass source, ModelClass target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ManyToManyRelation.SourceDomainRoleId, source), new DslModeling::RoleAssignment(ManyToManyRelation.TargetDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ManyToManyRelation(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ManyToManyRelation(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ManyToManyRelation(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ManyToManyRelation(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Source domain role code
		
		/// <summary>
		/// Source domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceDomainRoleId = new global::System.Guid(0xa09915cc, 0x6063, 0x4ccb, 0xb9, 0x32, 0x1d, 0xc8, 0x66, 0x0f, 0xc4, 0x7c);
		
		/// <summary>
		/// DomainRole Source
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/Source.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/Source.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "ManyToManyTargets", PropertyDisplayNameKey="Castle.ActiveWriter.ManyToManyRelation/Source.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("a09915cc-6063-4ccb-b932-1dc8660fc47c")]
		public virtual ModelClass Source
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ManyToManySources of a ModelClass
		/// <summary>
		/// Gets a list of ManyToManySources.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetManyToManySources(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, TargetDomainRoleId);
		}
		#endregion
		#region Target domain role code
		
		/// <summary>
		/// Target domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainRoleId = new global::System.Guid(0x2cf13e85, 0x7739, 0x4764, 0x9d, 0x1a, 0xf6, 0x86, 0x80, 0xe9, 0x77, 0xbe);
		
		/// <summary>
		/// DomainRole Target
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/Target.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/Target.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "ManyToManySources", PropertyDisplayNameKey="Castle.ActiveWriter.ManyToManyRelation/Target.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("2cf13e85-7739-4764-9d1a-f68680e977be")]
		public virtual ModelClass Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ManyToManyTargets of a ModelClass
		/// <summary>
		/// Gets a list of ManyToManyTargets.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetManyToManyTargets(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, SourceDomainRoleId);
		}
		#endregion
		#region SourceCache domain property code
		
		/// <summary>
		/// SourceCache domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceCacheDomainPropertyId = new global::System.Guid(0x0edaa292, 0x6e4e, 0x403e, 0x87, 0xf5, 0xc6, 0xe3, 0xb6, 0x5d, 0x37, 0xc7);
		
		/// <summary>
		/// Storage for SourceCache
		/// </summary>
		private CacheEnum sourceCachePropertyStorage = CacheEnum.Undefined;
		
		/// <summary>
		/// Gets or sets the value of SourceCache domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceCache.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceCache.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceCache.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CacheEnum.Undefined)]
		[DslModeling::DomainObjectId("0edaa292-6e4e-403e-87f5-c6e3b65d37c7")]
		public CacheEnum SourceCache
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceCachePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceCachePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceCache domain property.
		/// </summary>
		internal sealed partial class SourceCachePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, CacheEnum>
		{
			private SourceCachePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceCache domain property value handler.
			/// </summary>
			public static readonly SourceCachePropertyHandler Instance = new SourceCachePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceCache domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceCacheDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CacheEnum GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceCachePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, CacheEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CacheEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceCachePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceCascade domain property code
		
		/// <summary>
		/// SourceCascade domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceCascadeDomainPropertyId = new global::System.Guid(0xb1eb524a, 0x89f0, 0x407d, 0xa7, 0xd2, 0xfe, 0x54, 0xe9, 0x2c, 0x09, 0x1e);
		
		/// <summary>
		/// Storage for SourceCascade
		/// </summary>
		private ManyRelationCascadeEnum sourceCascadePropertyStorage = ManyRelationCascadeEnum.None;
		
		/// <summary>
		/// Gets or sets the value of SourceCascade domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceCascade.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceCascade.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceCascade.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(ManyRelationCascadeEnum.None)]
		[DslModeling::DomainObjectId("b1eb524a-89f0-407d-a7d2-fe54e92c091e")]
		public ManyRelationCascadeEnum SourceCascade
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceCascadePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceCascadePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceCascade domain property.
		/// </summary>
		internal sealed partial class SourceCascadePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, ManyRelationCascadeEnum>
		{
			private SourceCascadePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceCascade domain property value handler.
			/// </summary>
			public static readonly SourceCascadePropertyHandler Instance = new SourceCascadePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceCascade domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceCascadeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed ManyRelationCascadeEnum GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceCascadePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, ManyRelationCascadeEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				ManyRelationCascadeEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceCascadePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceColumn domain property code
		
		/// <summary>
		/// SourceColumn domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceColumnDomainPropertyId = new global::System.Guid(0x45f8bd67, 0xd220, 0x4187, 0xa3, 0xc9, 0x0c, 0xf6, 0xba, 0xb3, 0x05, 0x7f);
		
		/// <summary>
		/// Storage for SourceColumn
		/// </summary>
		private global::System.String sourceColumnPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceColumn domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceColumn.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceColumn.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceColumn.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("45f8bd67-d220-4187-a3c9-0cf6bab3057f")]
		public global::System.String SourceColumn
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceColumnPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceColumnPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceColumn domain property.
		/// </summary>
		internal sealed partial class SourceColumnPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceColumnPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceColumn domain property value handler.
			/// </summary>
			public static readonly SourceColumnPropertyHandler Instance = new SourceColumnPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceColumn domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceColumnDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceColumnPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceColumnPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceCustomAccess domain property code
		
		/// <summary>
		/// SourceCustomAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceCustomAccessDomainPropertyId = new global::System.Guid(0x3ccebabd, 0xae79, 0x43a0, 0xbb, 0x64, 0x65, 0xc6, 0x87, 0x80, 0x17, 0x73);
		
		/// <summary>
		/// Storage for SourceCustomAccess
		/// </summary>
		private global::System.String sourceCustomAccessPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceCustomAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceCustomAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceCustomAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceCustomAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("3ccebabd-ae79-43a0-bb64-65c687801773")]
		public global::System.String SourceCustomAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceCustomAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceCustomAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceCustomAccess domain property.
		/// </summary>
		internal sealed partial class SourceCustomAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceCustomAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceCustomAccess domain property value handler.
			/// </summary>
			public static readonly SourceCustomAccessPropertyHandler Instance = new SourceCustomAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceCustomAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceCustomAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceCustomAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceCustomAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceInverse domain property code
		
		/// <summary>
		/// SourceInverse domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceInverseDomainPropertyId = new global::System.Guid(0x1f969dd1, 0x34d3, 0x45f0, 0x9c, 0x0b, 0x99, 0x7e, 0x46, 0x6e, 0x51, 0xac);
		
		/// <summary>
		/// Storage for SourceInverse
		/// </summary>
		private global::System.Boolean sourceInversePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of SourceInverse domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceInverse.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceInverse.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceInverse.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("1f969dd1-34d3-45f0-9c0b-997e466e51ac")]
		public global::System.Boolean SourceInverse
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceInversePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceInversePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceInverse domain property.
		/// </summary>
		internal sealed partial class SourceInversePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.Boolean>
		{
			private SourceInversePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceInverse domain property value handler.
			/// </summary>
			public static readonly SourceInversePropertyHandler Instance = new SourceInversePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceInverse domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceInverseDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceInversePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceInversePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceLazy domain property code
		
		/// <summary>
		/// SourceLazy domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceLazyDomainPropertyId = new global::System.Guid(0x8243d2da, 0x48fc, 0x4c4e, 0xb7, 0x67, 0x54, 0x76, 0x1c, 0x5d, 0x8e, 0xcf);
		
		/// <summary>
		/// Storage for SourceLazy
		/// </summary>
		private global::System.Boolean sourceLazyPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of SourceLazy domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceLazy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceLazy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceLazy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("8243d2da-48fc-4c4e-b767-54761c5d8ecf")]
		public global::System.Boolean SourceLazy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceLazyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceLazyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceLazy domain property.
		/// </summary>
		internal sealed partial class SourceLazyPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.Boolean>
		{
			private SourceLazyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceLazy domain property value handler.
			/// </summary>
			public static readonly SourceLazyPropertyHandler Instance = new SourceLazyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceLazy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceLazyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceLazyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceLazyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceMapType domain property code
		
		/// <summary>
		/// SourceMapType domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceMapTypeDomainPropertyId = new global::System.Guid(0x1bfebb0e, 0xef50, 0x4f1d, 0x8d, 0x31, 0xfc, 0x6c, 0xd8, 0x30, 0x5f, 0x6c);
		
		/// <summary>
		/// Storage for SourceMapType
		/// </summary>
		private global::System.String sourceMapTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceMapType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceMapType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceMapType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceMapType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("1bfebb0e-ef50-4f1d-8d31-fc6cd8305f6c")]
		public global::System.String SourceMapType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceMapTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceMapTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceMapType domain property.
		/// </summary>
		internal sealed partial class SourceMapTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceMapTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceMapType domain property value handler.
			/// </summary>
			public static readonly SourceMapTypePropertyHandler Instance = new SourceMapTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceMapType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceMapTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceMapTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceMapTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceOrderBy domain property code
		
		/// <summary>
		/// SourceOrderBy domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceOrderByDomainPropertyId = new global::System.Guid(0x36f64f63, 0xe9e8, 0x4baf, 0xbd, 0x34, 0x93, 0xa6, 0xa7, 0x14, 0xad, 0x9f);
		
		/// <summary>
		/// Storage for SourceOrderBy
		/// </summary>
		private global::System.String sourceOrderByPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceOrderBy domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceOrderBy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceOrderBy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceOrderBy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("36f64f63-e9e8-4baf-bd34-93a6a714ad9f")]
		public global::System.String SourceOrderBy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceOrderByPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceOrderByPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceOrderBy domain property.
		/// </summary>
		internal sealed partial class SourceOrderByPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceOrderByPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceOrderBy domain property value handler.
			/// </summary>
			public static readonly SourceOrderByPropertyHandler Instance = new SourceOrderByPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceOrderBy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceOrderByDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceOrderByPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceOrderByPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceRelationType domain property code
		
		/// <summary>
		/// SourceRelationType domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceRelationTypeDomainPropertyId = new global::System.Guid(0x1a7ce077, 0xb01a, 0x4e14, 0xba, 0x2e, 0x81, 0xf2, 0x4d, 0x16, 0x45, 0xac);
		
		/// <summary>
		/// Storage for SourceRelationType
		/// </summary>
		private InheritedRelationType sourceRelationTypePropertyStorage = InheritedRelationType.Inherited;
		
		/// <summary>
		/// Gets or sets the value of SourceRelationType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceRelationType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceRelationType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceRelationType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritedRelationType.Inherited)]
		[DslModeling::DomainObjectId("1a7ce077-b01a-4e14-ba2e-81f24d1645ac")]
		public InheritedRelationType SourceRelationType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceRelationTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceRelationTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceRelationType domain property.
		/// </summary>
		internal sealed partial class SourceRelationTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, InheritedRelationType>
		{
			private SourceRelationTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceRelationType domain property value handler.
			/// </summary>
			public static readonly SourceRelationTypePropertyHandler Instance = new SourceRelationTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceRelationType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceRelationTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritedRelationType GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceRelationTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, InheritedRelationType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritedRelationType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceRelationTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Schema domain property code
		
		/// <summary>
		/// Schema domain property Id.
		/// </summary>
		public static readonly global::System.Guid SchemaDomainPropertyId = new global::System.Guid(0xaa9b2d6f, 0x225f, 0x42c5, 0x88, 0x71, 0x05, 0xdf, 0x44, 0x9f, 0xc5, 0x98);
		
		/// <summary>
		/// Storage for Schema
		/// </summary>
		private global::System.String schemaPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Schema domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/Schema.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/Schema.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/Schema.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("aa9b2d6f-225f-42c5-8871-05df449fc598")]
		public global::System.String Schema
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return schemaPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SchemaPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.Schema domain property.
		/// </summary>
		internal sealed partial class SchemaPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SchemaPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.Schema domain property value handler.
			/// </summary>
			public static readonly SchemaPropertyHandler Instance = new SchemaPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.Schema domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SchemaDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.schemaPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.schemaPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceSort domain property code
		
		/// <summary>
		/// SourceSort domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceSortDomainPropertyId = new global::System.Guid(0x8f6bcfce, 0x156a, 0x4224, 0xba, 0xc8, 0x8e, 0xf0, 0xf9, 0x73, 0xa5, 0x6a);
		
		/// <summary>
		/// Storage for SourceSort
		/// </summary>
		private global::System.String sourceSortPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceSort domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceSort.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceSort.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceSort.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("8f6bcfce-156a-4224-bac8-8ef0f973a56a")]
		public global::System.String SourceSort
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceSortPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceSortPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceSort domain property.
		/// </summary>
		internal sealed partial class SourceSortPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceSortPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceSort domain property value handler.
			/// </summary>
			public static readonly SourceSortPropertyHandler Instance = new SourceSortPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceSort domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceSortDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceSortPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceSortPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Table domain property code
		
		/// <summary>
		/// Table domain property Id.
		/// </summary>
		public static readonly global::System.Guid TableDomainPropertyId = new global::System.Guid(0xc0b31c9a, 0xa436, 0x4cc8, 0xbf, 0x42, 0xc2, 0x9f, 0x75, 0xbe, 0x6b, 0xc5);
		
		/// <summary>
		/// Storage for Table
		/// </summary>
		private global::System.String tablePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Table domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/Table.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/Table.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/Table.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("c0b31c9a-a436-4cc8-bf42-c29f75be6bc5")]
		public global::System.String Table
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return tablePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TablePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.Table domain property.
		/// </summary>
		internal sealed partial class TablePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TablePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.Table domain property value handler.
			/// </summary>
			public static readonly TablePropertyHandler Instance = new TablePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.Table domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TableDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.tablePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.tablePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceWhere domain property code
		
		/// <summary>
		/// SourceWhere domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceWhereDomainPropertyId = new global::System.Guid(0xdf150009, 0x69a6, 0x4cc6, 0xb6, 0xa4, 0x96, 0xbe, 0xab, 0xc8, 0x8c, 0x85);
		
		/// <summary>
		/// Storage for SourceWhere
		/// </summary>
		private global::System.String sourceWherePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceWhere domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceWhere.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceWhere.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceWhere.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("df150009-69a6-4cc6-b6a4-96beabc88c85")]
		public global::System.String SourceWhere
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceWherePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceWherePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceWhere domain property.
		/// </summary>
		internal sealed partial class SourceWherePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceWherePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceWhere domain property value handler.
			/// </summary>
			public static readonly SourceWherePropertyHandler Instance = new SourceWherePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceWhere domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceWhereDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceWherePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceWherePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetCache domain property code
		
		/// <summary>
		/// TargetCache domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCacheDomainPropertyId = new global::System.Guid(0xe7614cb3, 0xb408, 0x4170, 0x91, 0xbd, 0x0d, 0x8f, 0xa3, 0x21, 0x3b, 0xe9);
		
		/// <summary>
		/// Storage for TargetCache
		/// </summary>
		private CacheEnum targetCachePropertyStorage = CacheEnum.Undefined;
		
		/// <summary>
		/// Gets or sets the value of TargetCache domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetCache.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetCache.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetCache.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CacheEnum.Undefined)]
		[DslModeling::DomainObjectId("e7614cb3-b408-4170-91bd-0d8fa3213be9")]
		public CacheEnum TargetCache
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCachePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCachePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetCache domain property.
		/// </summary>
		internal sealed partial class TargetCachePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, CacheEnum>
		{
			private TargetCachePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetCache domain property value handler.
			/// </summary>
			public static readonly TargetCachePropertyHandler Instance = new TargetCachePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetCache domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCacheDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CacheEnum GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCachePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, CacheEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CacheEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCachePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetCascade domain property code
		
		/// <summary>
		/// TargetCascade domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCascadeDomainPropertyId = new global::System.Guid(0x79db5e78, 0x57ca, 0x41f6, 0xb4, 0x09, 0xf5, 0x4c, 0x36, 0x92, 0xc7, 0x1b);
		
		/// <summary>
		/// Storage for TargetCascade
		/// </summary>
		private ManyRelationCascadeEnum targetCascadePropertyStorage = ManyRelationCascadeEnum.None;
		
		/// <summary>
		/// Gets or sets the value of TargetCascade domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetCascade.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetCascade.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetCascade.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(ManyRelationCascadeEnum.None)]
		[DslModeling::DomainObjectId("79db5e78-57ca-41f6-b409-f54c3692c71b")]
		public ManyRelationCascadeEnum TargetCascade
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCascadePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCascadePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetCascade domain property.
		/// </summary>
		internal sealed partial class TargetCascadePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, ManyRelationCascadeEnum>
		{
			private TargetCascadePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetCascade domain property value handler.
			/// </summary>
			public static readonly TargetCascadePropertyHandler Instance = new TargetCascadePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetCascade domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCascadeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed ManyRelationCascadeEnum GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCascadePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, ManyRelationCascadeEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				ManyRelationCascadeEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCascadePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetColumn domain property code
		
		/// <summary>
		/// TargetColumn domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetColumnDomainPropertyId = new global::System.Guid(0x6b974a6d, 0x7e61, 0x4920, 0x8c, 0xed, 0x49, 0x0f, 0x4a, 0x59, 0xf5, 0x90);
		
		/// <summary>
		/// Storage for TargetColumn
		/// </summary>
		private global::System.String targetColumnPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetColumn domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetColumn.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetColumn.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetColumn.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("6b974a6d-7e61-4920-8ced-490f4a59f590")]
		public global::System.String TargetColumn
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetColumnPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetColumnPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetColumn domain property.
		/// </summary>
		internal sealed partial class TargetColumnPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetColumnPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetColumn domain property value handler.
			/// </summary>
			public static readonly TargetColumnPropertyHandler Instance = new TargetColumnPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetColumn domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetColumnDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetColumnPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetColumnPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetCustomAccess domain property code
		
		/// <summary>
		/// TargetCustomAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCustomAccessDomainPropertyId = new global::System.Guid(0x3f6c6de8, 0x21b0, 0x4c86, 0x9f, 0x39, 0x5f, 0x0b, 0x4b, 0x3f, 0xf2, 0x4d);
		
		/// <summary>
		/// Storage for TargetCustomAccess
		/// </summary>
		private global::System.String targetCustomAccessPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetCustomAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetCustomAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetCustomAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetCustomAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("3f6c6de8-21b0-4c86-9f39-5f0b4b3ff24d")]
		public global::System.String TargetCustomAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCustomAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCustomAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetCustomAccess domain property.
		/// </summary>
		internal sealed partial class TargetCustomAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetCustomAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetCustomAccess domain property value handler.
			/// </summary>
			public static readonly TargetCustomAccessPropertyHandler Instance = new TargetCustomAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetCustomAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCustomAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCustomAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCustomAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetInverse domain property code
		
		/// <summary>
		/// TargetInverse domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetInverseDomainPropertyId = new global::System.Guid(0x50027d75, 0x155d, 0x481d, 0x90, 0x74, 0xe1, 0x5c, 0x47, 0xa4, 0x2d, 0xf8);
		
		/// <summary>
		/// Storage for TargetInverse
		/// </summary>
		private global::System.Boolean targetInversePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of TargetInverse domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetInverse.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetInverse.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetInverse.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("50027d75-155d-481d-9074-e15c47a42df8")]
		public global::System.Boolean TargetInverse
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetInversePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetInversePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetInverse domain property.
		/// </summary>
		internal sealed partial class TargetInversePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.Boolean>
		{
			private TargetInversePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetInverse domain property value handler.
			/// </summary>
			public static readonly TargetInversePropertyHandler Instance = new TargetInversePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetInverse domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetInverseDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetInversePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetInversePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetLazy domain property code
		
		/// <summary>
		/// TargetLazy domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetLazyDomainPropertyId = new global::System.Guid(0xe9403ad1, 0xf969, 0x4640, 0x84, 0x22, 0xef, 0x4b, 0xa7, 0xd1, 0xb3, 0x4a);
		
		/// <summary>
		/// Storage for TargetLazy
		/// </summary>
		private global::System.Boolean targetLazyPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of TargetLazy domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetLazy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetLazy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetLazy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("e9403ad1-f969-4640-8422-ef4ba7d1b34a")]
		public global::System.Boolean TargetLazy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetLazyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetLazyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetLazy domain property.
		/// </summary>
		internal sealed partial class TargetLazyPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.Boolean>
		{
			private TargetLazyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetLazy domain property value handler.
			/// </summary>
			public static readonly TargetLazyPropertyHandler Instance = new TargetLazyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetLazy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetLazyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetLazyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetLazyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetMapType domain property code
		
		/// <summary>
		/// TargetMapType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetMapTypeDomainPropertyId = new global::System.Guid(0x4b222ca6, 0xb4c7, 0x42b7, 0xa3, 0x57, 0x60, 0xc3, 0xdc, 0x02, 0x56, 0xb1);
		
		/// <summary>
		/// Storage for TargetMapType
		/// </summary>
		private global::System.String targetMapTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetMapType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetMapType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetMapType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetMapType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("4b222ca6-b4c7-42b7-a357-60c3dc0256b1")]
		public global::System.String TargetMapType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetMapTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetMapTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetMapType domain property.
		/// </summary>
		internal sealed partial class TargetMapTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetMapTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetMapType domain property value handler.
			/// </summary>
			public static readonly TargetMapTypePropertyHandler Instance = new TargetMapTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetMapType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetMapTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetMapTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetMapTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetOrderBy domain property code
		
		/// <summary>
		/// TargetOrderBy domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetOrderByDomainPropertyId = new global::System.Guid(0x490b0adb, 0xfb17, 0x44af, 0x88, 0x52, 0x00, 0xf6, 0x22, 0x31, 0xb3, 0x89);
		
		/// <summary>
		/// Storage for TargetOrderBy
		/// </summary>
		private global::System.String targetOrderByPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetOrderBy domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetOrderBy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetOrderBy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetOrderBy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("490b0adb-fb17-44af-8852-00f62231b389")]
		public global::System.String TargetOrderBy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetOrderByPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetOrderByPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetOrderBy domain property.
		/// </summary>
		internal sealed partial class TargetOrderByPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetOrderByPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetOrderBy domain property value handler.
			/// </summary>
			public static readonly TargetOrderByPropertyHandler Instance = new TargetOrderByPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetOrderBy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetOrderByDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetOrderByPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetOrderByPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetRelationType domain property code
		
		/// <summary>
		/// TargetRelationType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetRelationTypeDomainPropertyId = new global::System.Guid(0x913caa46, 0xb08b, 0x45bb, 0xac, 0x6f, 0x6e, 0xf3, 0x94, 0xc5, 0x99, 0x38);
		
		/// <summary>
		/// Storage for TargetRelationType
		/// </summary>
		private InheritedRelationType targetRelationTypePropertyStorage = InheritedRelationType.Inherited;
		
		/// <summary>
		/// Gets or sets the value of TargetRelationType domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetRelationType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetRelationType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetRelationType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritedRelationType.Inherited)]
		[DslModeling::DomainObjectId("913caa46-b08b-45bb-ac6f-6ef394c59938")]
		public InheritedRelationType TargetRelationType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetRelationTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetRelationTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetRelationType domain property.
		/// </summary>
		internal sealed partial class TargetRelationTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, InheritedRelationType>
		{
			private TargetRelationTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetRelationType domain property value handler.
			/// </summary>
			public static readonly TargetRelationTypePropertyHandler Instance = new TargetRelationTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetRelationType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetRelationTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritedRelationType GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetRelationTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, InheritedRelationType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritedRelationType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetRelationTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetSort domain property code
		
		/// <summary>
		/// TargetSort domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetSortDomainPropertyId = new global::System.Guid(0x65664bb5, 0x5639, 0x4405, 0x85, 0xd0, 0x83, 0x7c, 0x8c, 0x56, 0xe1, 0xb8);
		
		/// <summary>
		/// Storage for TargetSort
		/// </summary>
		private global::System.String targetSortPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetSort domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetSort.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetSort.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetSort.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("65664bb5-5639-4405-85d0-837c8c56e1b8")]
		public global::System.String TargetSort
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetSortPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetSortPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetSort domain property.
		/// </summary>
		internal sealed partial class TargetSortPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetSortPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetSort domain property value handler.
			/// </summary>
			public static readonly TargetSortPropertyHandler Instance = new TargetSortPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetSort domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetSortDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetSortPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetSortPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetWhere domain property code
		
		/// <summary>
		/// TargetWhere domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetWhereDomainPropertyId = new global::System.Guid(0xf1a74b56, 0x59f7, 0x4dad, 0xaa, 0xc8, 0xda, 0x5e, 0xb7, 0xf3, 0xfd, 0x15);
		
		/// <summary>
		/// Storage for TargetWhere
		/// </summary>
		private global::System.String targetWherePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetWhere domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetWhere.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetWhere.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetWhere.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("f1a74b56-59f7-4dad-aac8-da5eb7f3fd15")]
		public global::System.String TargetWhere
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetWherePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetWherePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetWhere domain property.
		/// </summary>
		internal sealed partial class TargetWherePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetWherePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetWhere domain property value handler.
			/// </summary>
			public static readonly TargetWherePropertyHandler Instance = new TargetWherePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetWhere domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetWhereDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetWherePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetWherePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceDescription domain property code
		
		/// <summary>
		/// SourceDescription domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceDescriptionDomainPropertyId = new global::System.Guid(0xd8741eea, 0x178b, 0x405f, 0x81, 0x59, 0x76, 0xe8, 0x39, 0xd7, 0x79, 0x70);
		
		/// <summary>
		/// Storage for SourceDescription
		/// </summary>
		private global::System.String sourceDescriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceDescription domain property.
		/// Description of the property. This will appear in a <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceDescription.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceDescription.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceDescription.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("d8741eea-178b-405f-8159-76e839d77970")]
		public global::System.String SourceDescription
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceDescriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceDescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceDescription domain property.
		/// </summary>
		internal sealed partial class SourceDescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceDescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceDescription domain property value handler.
			/// </summary>
			public static readonly SourceDescriptionPropertyHandler Instance = new SourceDescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceDescription domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceDescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceDescriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceDescriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetDescription domain property code
		
		/// <summary>
		/// TargetDescription domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetDescriptionDomainPropertyId = new global::System.Guid(0x7286c00d, 0x568a, 0x41d1, 0x8d, 0x53, 0xfe, 0x67, 0x35, 0x20, 0xae, 0xb9);
		
		/// <summary>
		/// Storage for TargetDescription
		/// </summary>
		private global::System.String targetDescriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetDescription domain property.
		/// Description of the property. This will appear in a <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetDescription.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetDescription.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetDescription.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("7286c00d-568a-41d1-8d53-fe673520aeb9")]
		public global::System.String TargetDescription
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetDescriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetDescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetDescription domain property.
		/// </summary>
		internal sealed partial class TargetDescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetDescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetDescription domain property value handler.
			/// </summary>
			public static readonly TargetDescriptionPropertyHandler Instance = new TargetDescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetDescription domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetDescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetDescriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetDescriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceAccess domain property code
		
		/// <summary>
		/// SourceAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceAccessDomainPropertyId = new global::System.Guid(0x9e857994, 0x04c2, 0x40f0, 0x99, 0xb1, 0xd9, 0x09, 0x62, 0x3a, 0x68, 0x73);
		
		/// <summary>
		/// Storage for SourceAccess
		/// </summary>
		private InheritablePropertyAccess sourceAccessPropertyStorage = InheritablePropertyAccess.Inherit;
		
		/// <summary>
		/// Gets or sets the value of SourceAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritablePropertyAccess.Inherit)]
		[DslModeling::DomainObjectId("9e857994-04c2-40f0-99b1-d909623a6873")]
		public InheritablePropertyAccess SourceAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceAccess domain property.
		/// </summary>
		internal sealed partial class SourceAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, InheritablePropertyAccess>
		{
			private SourceAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceAccess domain property value handler.
			/// </summary>
			public static readonly SourceAccessPropertyHandler Instance = new SourceAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritablePropertyAccess GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, InheritablePropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritablePropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetAccess domain property code
		
		/// <summary>
		/// TargetAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetAccessDomainPropertyId = new global::System.Guid(0x308436c6, 0x0b6c, 0x4887, 0xb5, 0xd4, 0xe1, 0x5c, 0x91, 0x74, 0xf9, 0xcc);
		
		/// <summary>
		/// Storage for TargetAccess
		/// </summary>
		private InheritablePropertyAccess targetAccessPropertyStorage = InheritablePropertyAccess.Inherit;
		
		/// <summary>
		/// Gets or sets the value of TargetAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritablePropertyAccess.Inherit)]
		[DslModeling::DomainObjectId("308436c6-0b6c-4887-b5d4-e15c9174f9cc")]
		public InheritablePropertyAccess TargetAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetAccess domain property.
		/// </summary>
		internal sealed partial class TargetAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, InheritablePropertyAccess>
		{
			private TargetAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetAccess domain property value handler.
			/// </summary>
			public static readonly TargetAccessPropertyHandler Instance = new TargetAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritablePropertyAccess GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, InheritablePropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritablePropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourcePropertyType domain property code
		
		/// <summary>
		/// SourcePropertyType domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourcePropertyTypeDomainPropertyId = new global::System.Guid(0xe5d28e22, 0x22c2, 0x48bb, 0x95, 0x40, 0x8b, 0xe8, 0x51, 0x75, 0x18, 0x18);
		
		/// <summary>
		/// Storage for SourcePropertyType
		/// </summary>
		private global::System.String sourcePropertyTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourcePropertyType domain property.
		/// Type of the property. If not supplied, ActiveWriter will use the model's
		/// Collection Interface by default.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::DomainObjectId("e5d28e22-22c2-48bb-9540-8be851751818")]
		public global::System.String SourcePropertyType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourcePropertyTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourcePropertyTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourcePropertyType domain property.
		/// </summary>
		internal sealed partial class SourcePropertyTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourcePropertyTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourcePropertyType domain property value handler.
			/// </summary>
			public static readonly SourcePropertyTypePropertyHandler Instance = new SourcePropertyTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourcePropertyType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourcePropertyTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourcePropertyTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourcePropertyTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetPropertyType domain property code
		
		/// <summary>
		/// TargetPropertyType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetPropertyTypeDomainPropertyId = new global::System.Guid(0x9a519de5, 0x5dbd, 0x4c8b, 0x91, 0xab, 0x7c, 0x2b, 0xa6, 0x77, 0x56, 0x6a);
		
		/// <summary>
		/// Storage for TargetPropertyType
		/// </summary>
		private global::System.String targetPropertyTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetPropertyType domain property.
		/// Type of the property. If not supplied, ActiveWriter will use the model's
		/// Collection Inteface by default.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue("")]
		[DslModeling::DomainObjectId("9a519de5-5dbd-4c8b-91ab-7c2ba677566a")]
		public global::System.String TargetPropertyType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetPropertyTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetPropertyTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetPropertyType domain property.
		/// </summary>
		internal sealed partial class TargetPropertyTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetPropertyTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetPropertyType domain property value handler.
			/// </summary>
			public static readonly TargetPropertyTypePropertyHandler Instance = new TargetPropertyTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetPropertyType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetPropertyTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetPropertyTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetPropertyTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourcePropertyName domain property code
		
		/// <summary>
		/// SourcePropertyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourcePropertyNameDomainPropertyId = new global::System.Guid(0x894becde, 0xcb4f, 0x4c73, 0xbc, 0xf8, 0x39, 0xa2, 0xcd, 0x83, 0x10, 0x96);
		
		/// <summary>
		/// Storage for SourcePropertyName
		/// </summary>
		private global::System.String sourcePropertyNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourcePropertyName domain property.
		/// Name of the property in the generated code. If not supplied, ActiveWriter will
		/// use the target class name in plural form.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("894becde-cb4f-4c73-bcf8-39a2cd831096")]
		public global::System.String SourcePropertyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourcePropertyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourcePropertyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourcePropertyName domain property.
		/// </summary>
		internal sealed partial class SourcePropertyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourcePropertyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourcePropertyName domain property value handler.
			/// </summary>
			public static readonly SourcePropertyNamePropertyHandler Instance = new SourcePropertyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourcePropertyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourcePropertyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourcePropertyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourcePropertyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetPropertyName domain property code
		
		/// <summary>
		/// TargetPropertyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetPropertyNameDomainPropertyId = new global::System.Guid(0x486cb585, 0xd891, 0x4eb2, 0x97, 0xde, 0x84, 0x6a, 0xea, 0xec, 0x33, 0xe5);
		
		/// <summary>
		/// Storage for TargetPropertyName
		/// </summary>
		private global::System.String targetPropertyNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetPropertyName domain property.
		/// Name of the property in the generated code. If not supplied, ActiveWriter will
		/// use the source class name in plural form.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("486cb585-d891-4eb2-97de-846aeaec33e5")]
		public global::System.String TargetPropertyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetPropertyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetPropertyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetPropertyName domain property.
		/// </summary>
		internal sealed partial class TargetPropertyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetPropertyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetPropertyName domain property value handler.
			/// </summary>
			public static readonly TargetPropertyNamePropertyHandler Instance = new TargetPropertyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetPropertyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetPropertyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetPropertyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetPropertyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetNotFoundBehaviour domain property code
		
		/// <summary>
		/// TargetNotFoundBehaviour domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetNotFoundBehaviourDomainPropertyId = new global::System.Guid(0x29123760, 0x24b6, 0x42d1, 0xa9, 0xb1, 0xfb, 0x8b, 0x1d, 0x08, 0xd1, 0x98);
		
		/// <summary>
		/// Storage for TargetNotFoundBehaviour
		/// </summary>
		private NotFoundBehaviour targetNotFoundBehaviourPropertyStorage = NotFoundBehaviour.Default;
		
		/// <summary>
		/// Gets or sets the value of TargetNotFoundBehaviour domain property.
		/// Gets or sets the way broken relations are handled.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetNotFoundBehaviour.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetNotFoundBehaviour.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetNotFoundBehaviour.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(NotFoundBehaviour.Default)]
		[DslModeling::DomainObjectId("29123760-24b6-42d1-a9b1-fb8b1d08d198")]
		public NotFoundBehaviour TargetNotFoundBehaviour
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetNotFoundBehaviourPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetNotFoundBehaviourPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetNotFoundBehaviour domain property.
		/// </summary>
		internal sealed partial class TargetNotFoundBehaviourPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, NotFoundBehaviour>
		{
			private TargetNotFoundBehaviourPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetNotFoundBehaviour domain property value handler.
			/// </summary>
			public static readonly TargetNotFoundBehaviourPropertyHandler Instance = new TargetNotFoundBehaviourPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetNotFoundBehaviour domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetNotFoundBehaviourDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NotFoundBehaviour GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetNotFoundBehaviourPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, NotFoundBehaviour newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NotFoundBehaviour oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetNotFoundBehaviourPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceNotFoundBehaviour domain property code
		
		/// <summary>
		/// SourceNotFoundBehaviour domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceNotFoundBehaviourDomainPropertyId = new global::System.Guid(0x32c73c34, 0x5d19, 0x4c1c, 0x84, 0x27, 0x91, 0x64, 0x6d, 0x05, 0xfb, 0x53);
		
		/// <summary>
		/// Storage for SourceNotFoundBehaviour
		/// </summary>
		private NotFoundBehaviour sourceNotFoundBehaviourPropertyStorage = NotFoundBehaviour.Default;
		
		/// <summary>
		/// Gets or sets the value of SourceNotFoundBehaviour domain property.
		/// Gets or sets the way broken relations are handled.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceNotFoundBehaviour.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceNotFoundBehaviour.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceNotFoundBehaviour.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(NotFoundBehaviour.Default)]
		[DslModeling::DomainObjectId("32c73c34-5d19-4c1c-8427-91646d05fb53")]
		public NotFoundBehaviour SourceNotFoundBehaviour
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceNotFoundBehaviourPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceNotFoundBehaviourPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceNotFoundBehaviour domain property.
		/// </summary>
		internal sealed partial class SourceNotFoundBehaviourPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, NotFoundBehaviour>
		{
			private SourceNotFoundBehaviourPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceNotFoundBehaviour domain property value handler.
			/// </summary>
			public static readonly SourceNotFoundBehaviourPropertyHandler Instance = new SourceNotFoundBehaviourPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceNotFoundBehaviour domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceNotFoundBehaviourDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NotFoundBehaviour GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceNotFoundBehaviourPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, NotFoundBehaviour newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NotFoundBehaviour oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceNotFoundBehaviourPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceIUserCollectionType domain property code
		
		/// <summary>
		/// SourceIUserCollectionType domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceIUserCollectionTypeDomainPropertyId = new global::System.Guid(0x96fda275, 0xb5d3, 0x48bb, 0xb6, 0x5c, 0x1c, 0x3a, 0x04, 0xd3, 0xcc, 0xb2);
		
		/// <summary>
		/// Storage for SourceIUserCollectionType
		/// </summary>
		private global::System.String sourceIUserCollectionTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceIUserCollectionType domain property.
		/// User collection type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourceIUserCollectionType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourceIUserCollectionType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourceIUserCollectionType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("96fda275-b5d3-48bb-b65c-1c3a04d3ccb2")]
		public global::System.String SourceIUserCollectionType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceIUserCollectionTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceIUserCollectionTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourceIUserCollectionType domain property.
		/// </summary>
		internal sealed partial class SourceIUserCollectionTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private SourceIUserCollectionTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourceIUserCollectionType domain property value handler.
			/// </summary>
			public static readonly SourceIUserCollectionTypePropertyHandler Instance = new SourceIUserCollectionTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourceIUserCollectionType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceIUserCollectionTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceIUserCollectionTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceIUserCollectionTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetIUserCollectionType domain property code
		
		/// <summary>
		/// TargetIUserCollectionType domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetIUserCollectionTypeDomainPropertyId = new global::System.Guid(0xcb5dddc8, 0xa7c2, 0x4fca, 0x94, 0x93, 0x09, 0xd9, 0xf5, 0x04, 0x00, 0x87);
		
		/// <summary>
		/// Storage for TargetIUserCollectionType
		/// </summary>
		private global::System.String targetIUserCollectionTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetIUserCollectionType domain property.
		/// User collection type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetIUserCollectionType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetIUserCollectionType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetIUserCollectionType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("cb5dddc8-a7c2-4fca-9493-09d9f5040087")]
		public global::System.String TargetIUserCollectionType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetIUserCollectionTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetIUserCollectionTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetIUserCollectionType domain property.
		/// </summary>
		internal sealed partial class TargetIUserCollectionTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private TargetIUserCollectionTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetIUserCollectionType domain property value handler.
			/// </summary>
			public static readonly TargetIUserCollectionTypePropertyHandler Instance = new TargetIUserCollectionTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetIUserCollectionType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetIUserCollectionTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetIUserCollectionTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetIUserCollectionTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CollectionIDColumn domain property code
		
		/// <summary>
		/// CollectionIDColumn domain property Id.
		/// </summary>
		public static readonly global::System.Guid CollectionIDColumnDomainPropertyId = new global::System.Guid(0xe0cd5759, 0x5c0c, 0x4000, 0xaa, 0xa8, 0x6a, 0x81, 0xd3, 0x03, 0x76, 0xa0);
		
		/// <summary>
		/// Storage for CollectionIDColumn
		/// </summary>
		private global::System.String collectionIDColumnPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of CollectionIDColumn domain property.
		/// The column name used for the primary key of the many to many link table.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDColumn.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDColumn.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("e0cd5759-5c0c-4000-aaa8-6a81d30376a0")]
		public global::System.String CollectionIDColumn
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return collectionIDColumnPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CollectionIDColumnPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.CollectionIDColumn domain property.
		/// </summary>
		internal sealed partial class CollectionIDColumnPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.String>
		{
			private CollectionIDColumnPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.CollectionIDColumn domain property value handler.
			/// </summary>
			public static readonly CollectionIDColumnPropertyHandler Instance = new CollectionIDColumnPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.CollectionIDColumn domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CollectionIDColumnDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.collectionIDColumnPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.collectionIDColumnPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CollectionIDColumnType domain property code
		
		/// <summary>
		/// CollectionIDColumnType domain property Id.
		/// </summary>
		public static readonly global::System.Guid CollectionIDColumnTypeDomainPropertyId = new global::System.Guid(0xa0a2373a, 0xbad1, 0x487e, 0x83, 0xe6, 0xcf, 0xa2, 0x3a, 0x02, 0xd4, 0xd0);
		
		/// <summary>
		/// Storage for CollectionIDColumnType
		/// </summary>
		private NHibernateType collectionIDColumnTypePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of CollectionIDColumnType domain property.
		/// The type of the column used for the primary key.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDColumnType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDColumnType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDColumnType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("a0a2373a-bad1-487e-83e6-cfa23a02d4d0")]
		public NHibernateType CollectionIDColumnType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return collectionIDColumnTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CollectionIDColumnTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.CollectionIDColumnType domain property.
		/// </summary>
		internal sealed partial class CollectionIDColumnTypePropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, NHibernateType>
		{
			private CollectionIDColumnTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.CollectionIDColumnType domain property value handler.
			/// </summary>
			public static readonly CollectionIDColumnTypePropertyHandler Instance = new CollectionIDColumnTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.CollectionIDColumnType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CollectionIDColumnTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed NHibernateType GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.collectionIDColumnTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, NHibernateType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				NHibernateType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.collectionIDColumnTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region CollectionIDGenerator domain property code
		
		/// <summary>
		/// CollectionIDGenerator domain property Id.
		/// </summary>
		public static readonly global::System.Guid CollectionIDGeneratorDomainPropertyId = new global::System.Guid(0x21f90b70, 0xa02a, 0x436d, 0xa3, 0xc0, 0x86, 0xaa, 0xd9, 0x06, 0x0e, 0x9d);
		
		/// <summary>
		/// Storage for CollectionIDGenerator
		/// </summary>
		private PrimaryKeyType collectionIDGeneratorPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of CollectionIDGenerator domain property.
		/// The generator type for the primary key of the many to many link table.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDGenerator.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDGenerator.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/CollectionIDGenerator.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("21f90b70-a02a-436d-a3c0-86aad9060e9d")]
		public PrimaryKeyType CollectionIDGenerator
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return collectionIDGeneratorPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				CollectionIDGeneratorPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.CollectionIDGenerator domain property.
		/// </summary>
		internal sealed partial class CollectionIDGeneratorPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, PrimaryKeyType>
		{
			private CollectionIDGeneratorPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.CollectionIDGenerator domain property value handler.
			/// </summary>
			public static readonly CollectionIDGeneratorPropertyHandler Instance = new CollectionIDGeneratorPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.CollectionIDGenerator domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return CollectionIDGeneratorDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed PrimaryKeyType GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.collectionIDGeneratorPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, PrimaryKeyType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				PrimaryKeyType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.collectionIDGeneratorPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetPropertyGenerated domain property code
		
		/// <summary>
		/// TargetPropertyGenerated domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetPropertyGeneratedDomainPropertyId = new global::System.Guid(0xfeb33769, 0x96a2, 0x44c6, 0x94, 0xfb, 0x06, 0xae, 0x1e, 0x16, 0x0c, 0x10);
		
		/// <summary>
		/// Storage for TargetPropertyGenerated
		/// </summary>
		private global::System.Boolean targetPropertyGeneratedPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of TargetPropertyGenerated domain property.
		/// Description for Castle.ActiveWriter.ManyToManyRelation.Target Property Generated
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyGenerated.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyGenerated.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/TargetPropertyGenerated.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("feb33769-96a2-44c6-94fb-06ae1e160c10")]
		public global::System.Boolean TargetPropertyGenerated
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetPropertyGeneratedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetPropertyGeneratedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.TargetPropertyGenerated domain property.
		/// </summary>
		internal sealed partial class TargetPropertyGeneratedPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.Boolean>
		{
			private TargetPropertyGeneratedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.TargetPropertyGenerated domain property value handler.
			/// </summary>
			public static readonly TargetPropertyGeneratedPropertyHandler Instance = new TargetPropertyGeneratedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.TargetPropertyGenerated domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetPropertyGeneratedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetPropertyGeneratedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetPropertyGeneratedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourcePropertyGenerated domain property code
		
		/// <summary>
		/// SourcePropertyGenerated domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourcePropertyGeneratedDomainPropertyId = new global::System.Guid(0x1a60bb90, 0xb145, 0x4931, 0xb2, 0xfb, 0x5f, 0x29, 0x88, 0xda, 0x83, 0xfb);
		
		/// <summary>
		/// Storage for SourcePropertyGenerated
		/// </summary>
		private global::System.Boolean sourcePropertyGeneratedPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of SourcePropertyGenerated domain property.
		/// Description for Castle.ActiveWriter.ManyToManyRelation.Source Property Generated
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyGenerated.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyGenerated.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ManyToManyRelation/SourcePropertyGenerated.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("1a60bb90-b145-4931-b2fb-5f2988da83fb")]
		public global::System.Boolean SourcePropertyGenerated
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourcePropertyGeneratedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourcePropertyGeneratedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the ManyToManyRelation.SourcePropertyGenerated domain property.
		/// </summary>
		internal sealed partial class SourcePropertyGeneratedPropertyHandler : DslModeling::DomainPropertyValueHandler<ManyToManyRelation, global::System.Boolean>
		{
			private SourcePropertyGeneratedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the ManyToManyRelation.SourcePropertyGenerated domain property value handler.
			/// </summary>
			public static readonly SourcePropertyGeneratedPropertyHandler Instance = new SourcePropertyGeneratedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the ManyToManyRelation.SourcePropertyGenerated domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourcePropertyGeneratedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(ManyToManyRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourcePropertyGeneratedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(ManyToManyRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourcePropertyGeneratedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Source link accessor
		/// <summary>
		/// Get the list of ManyToManyRelation links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ManyToManyRelation> GetLinksToManyToManyTargets ( global::Castle.ActiveWriter.ModelClass sourceInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ManyToManyRelation>(sourceInstance, global::Castle.ActiveWriter.ManyToManyRelation.SourceDomainRoleId);
		}
		#endregion
		#region Target link accessor
		/// <summary>
		/// Get the list of ManyToManyRelation links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ManyToManyRelation> GetLinksToManyToManySources ( global::Castle.ActiveWriter.ModelClass targetInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ManyToManyRelation>(targetInstance, global::Castle.ActiveWriter.ManyToManyRelation.TargetDomainRoleId);
		}
		#endregion
		#region ManyToManyRelation instance accessors
		
		/// <summary>
		/// Get any ManyToManyRelation links between a given ModelClass and a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ManyToManyRelation> GetLinks( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.ManyToManyRelation> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.ManyToManyRelation>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ManyToManyRelation> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ManyToManyRelation>(source, global::Castle.ActiveWriter.ManyToManyRelation.SourceDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ManyToManyRelation link in links )
			{
				if ( target.Equals(link.Target) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship OneToOneRelation
	/// Associates a foreign table where the current class and the target class share
	/// their primary key.
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("fc147ce4-8aa0-4719-94a9-21179d6cf6a5")]
	public partial class OneToOneRelation : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// OneToOneRelation domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xfc147ce4, 0x8aa0, 0x4719, 0x94, 0xa9, 0x21, 0x17, 0x9d, 0x6c, 0xf6, 0xa5);
	
				
		/// <summary>
		/// Constructor
		/// Creates a OneToOneRelation link in the same Partition as the given ModelClass
		/// </summary>
		/// <param name="source">ModelClass to use as the source of the relationship.</param>
		/// <param name="target">ModelClass to use as the target of the relationship.</param>
		public OneToOneRelation(ModelClass source, ModelClass target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(OneToOneRelation.SourceDomainRoleId, source), new DslModeling::RoleAssignment(OneToOneRelation.TargetDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public OneToOneRelation(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public OneToOneRelation(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public OneToOneRelation(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public OneToOneRelation(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Source domain role code
		
		/// <summary>
		/// Source domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceDomainRoleId = new global::System.Guid(0x7b304a5c, 0xcb3e, 0x4f10, 0xbe, 0x86, 0xc5, 0x2e, 0xee, 0xc9, 0x45, 0xd5);
		
		/// <summary>
		/// DomainRole Source
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/Source.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/Source.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.Browsable(false)]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "OneToOneTarget", PropertyDisplayNameKey="Castle.ActiveWriter.OneToOneRelation/Source.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroOne)]
		[DslModeling::DomainObjectId("7b304a5c-cb3e-4f10-be86-c52eeec945d5")]
		public virtual ModelClass Source
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access OneToOneSources of a ModelClass
		/// <summary>
		/// Gets a list of OneToOneSources.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetOneToOneSources(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, TargetDomainRoleId);
		}
		#endregion
		#region Target domain role code
		
		/// <summary>
		/// Target domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainRoleId = new global::System.Guid(0x24658a8c, 0xda41, 0x491a, 0x8c, 0xad, 0x9c, 0x51, 0x25, 0xcd, 0xd0, 0x6c);
		
		/// <summary>
		/// DomainRole Target
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/Target.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/Target.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "OneToOneSources", PropertyDisplayNameKey="Castle.ActiveWriter.OneToOneRelation/Target.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("24658a8c-da41-491a-8cad-9c5125cdd06c")]
		public virtual ModelClass Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access OneToOneTarget of a ModelClass
		/// <summary>
		/// Gets OneToOneTarget.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static ModelClass GetOneToOneTarget(ModelClass element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, SourceDomainRoleId) as ModelClass;
		}
		
		/// <summary>
		/// Sets OneToOneTarget.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetOneToOneTarget(ModelClass element, ModelClass newTarget)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, SourceDomainRoleId, newTarget);
		}
		#endregion
		#region SourceAccess domain property code
		
		/// <summary>
		/// SourceAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceAccessDomainPropertyId = new global::System.Guid(0x6cab92a3, 0x03e6, 0x41fa, 0x92, 0x6d, 0xf3, 0x3a, 0xfd, 0xbb, 0xbf, 0xcd);
		
		/// <summary>
		/// Storage for SourceAccess
		/// </summary>
		private InheritablePropertyAccess sourceAccessPropertyStorage = InheritablePropertyAccess.Inherit;
		
		/// <summary>
		/// Gets or sets the value of SourceAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/SourceAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/SourceAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/SourceAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritablePropertyAccess.Inherit)]
		[DslModeling::DomainObjectId("6cab92a3-03e6-41fa-926d-f33afdbbbfcd")]
		public InheritablePropertyAccess SourceAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.SourceAccess domain property.
		/// </summary>
		internal sealed partial class SourceAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, InheritablePropertyAccess>
		{
			private SourceAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.SourceAccess domain property value handler.
			/// </summary>
			public static readonly SourceAccessPropertyHandler Instance = new SourceAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.SourceAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritablePropertyAccess GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, InheritablePropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritablePropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceCascade domain property code
		
		/// <summary>
		/// SourceCascade domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceCascadeDomainPropertyId = new global::System.Guid(0x1d99e2db, 0x2ed5, 0x42dc, 0xb8, 0x69, 0xcf, 0xb8, 0x04, 0x1d, 0x97, 0xb5);
		
		/// <summary>
		/// Storage for SourceCascade
		/// </summary>
		private CascadeEnum sourceCascadePropertyStorage = CascadeEnum.None;
		
		/// <summary>
		/// Gets or sets the value of SourceCascade domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/SourceCascade.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/SourceCascade.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/SourceCascade.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CascadeEnum.None)]
		[DslModeling::DomainObjectId("1d99e2db-2ed5-42dc-b869-cfb8041d97b5")]
		public CascadeEnum SourceCascade
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceCascadePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceCascadePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.SourceCascade domain property.
		/// </summary>
		internal sealed partial class SourceCascadePropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, CascadeEnum>
		{
			private SourceCascadePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.SourceCascade domain property value handler.
			/// </summary>
			public static readonly SourceCascadePropertyHandler Instance = new SourceCascadePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.SourceCascade domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceCascadeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CascadeEnum GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceCascadePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, CascadeEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CascadeEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceCascadePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceConstrained domain property code
		
		/// <summary>
		/// SourceConstrained domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceConstrainedDomainPropertyId = new global::System.Guid(0x9266b2c1, 0xd18e, 0x41ae, 0x81, 0x8e, 0xba, 0xff, 0x98, 0xd8, 0x97, 0x24);
		
		/// <summary>
		/// Storage for SourceConstrained
		/// </summary>
		private global::System.Boolean sourceConstrainedPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of SourceConstrained domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/SourceConstrained.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/SourceConstrained.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/SourceConstrained.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("9266b2c1-d18e-41ae-818e-baff98d89724")]
		public global::System.Boolean SourceConstrained
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceConstrainedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceConstrainedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.SourceConstrained domain property.
		/// </summary>
		internal sealed partial class SourceConstrainedPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, global::System.Boolean>
		{
			private SourceConstrainedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.SourceConstrained domain property value handler.
			/// </summary>
			public static readonly SourceConstrainedPropertyHandler Instance = new SourceConstrainedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.SourceConstrained domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceConstrainedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceConstrainedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceConstrainedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceCustomAccess domain property code
		
		/// <summary>
		/// SourceCustomAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceCustomAccessDomainPropertyId = new global::System.Guid(0xb3b9f301, 0xbbbb, 0x4a4e, 0xa9, 0xbc, 0x31, 0x51, 0x1b, 0xa0, 0x3a, 0xb0);
		
		/// <summary>
		/// Storage for SourceCustomAccess
		/// </summary>
		private global::System.String sourceCustomAccessPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceCustomAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/SourceCustomAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/SourceCustomAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/SourceCustomAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("b3b9f301-bbbb-4a4e-a9bc-31511ba03ab0")]
		public global::System.String SourceCustomAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceCustomAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceCustomAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.SourceCustomAccess domain property.
		/// </summary>
		internal sealed partial class SourceCustomAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, global::System.String>
		{
			private SourceCustomAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.SourceCustomAccess domain property value handler.
			/// </summary>
			public static readonly SourceCustomAccessPropertyHandler Instance = new SourceCustomAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.SourceCustomAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceCustomAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceCustomAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceCustomAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceOuterJoin domain property code
		
		/// <summary>
		/// SourceOuterJoin domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceOuterJoinDomainPropertyId = new global::System.Guid(0x5d4c0adf, 0xfbb4, 0x41b1, 0xb6, 0x15, 0x6e, 0x66, 0x90, 0xcc, 0x20, 0xc6);
		
		/// <summary>
		/// Storage for SourceOuterJoin
		/// </summary>
		private OuterJoinEnum sourceOuterJoinPropertyStorage = OuterJoinEnum.Auto;
		
		/// <summary>
		/// Gets or sets the value of SourceOuterJoin domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/SourceOuterJoin.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/SourceOuterJoin.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/SourceOuterJoin.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(OuterJoinEnum.Auto)]
		[DslModeling::DomainObjectId("5d4c0adf-fbb4-41b1-b615-6e6690cc20c6")]
		public OuterJoinEnum SourceOuterJoin
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceOuterJoinPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceOuterJoinPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.SourceOuterJoin domain property.
		/// </summary>
		internal sealed partial class SourceOuterJoinPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, OuterJoinEnum>
		{
			private SourceOuterJoinPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.SourceOuterJoin domain property value handler.
			/// </summary>
			public static readonly SourceOuterJoinPropertyHandler Instance = new SourceOuterJoinPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.SourceOuterJoin domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceOuterJoinDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed OuterJoinEnum GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceOuterJoinPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, OuterJoinEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				OuterJoinEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceOuterJoinPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetAccess domain property code
		
		/// <summary>
		/// TargetAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetAccessDomainPropertyId = new global::System.Guid(0xf51a55ef, 0x21f7, 0x4e22, 0x97, 0x76, 0x14, 0xc0, 0x0c, 0xaf, 0x88, 0x79);
		
		/// <summary>
		/// Storage for TargetAccess
		/// </summary>
		private InheritablePropertyAccess targetAccessPropertyStorage = InheritablePropertyAccess.Inherit;
		
		/// <summary>
		/// Gets or sets the value of TargetAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/TargetAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/TargetAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/TargetAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(InheritablePropertyAccess.Inherit)]
		[DslModeling::DomainObjectId("f51a55ef-21f7-4e22-9776-14c00caf8879")]
		public InheritablePropertyAccess TargetAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.TargetAccess domain property.
		/// </summary>
		internal sealed partial class TargetAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, InheritablePropertyAccess>
		{
			private TargetAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.TargetAccess domain property value handler.
			/// </summary>
			public static readonly TargetAccessPropertyHandler Instance = new TargetAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.TargetAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed InheritablePropertyAccess GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, InheritablePropertyAccess newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				InheritablePropertyAccess oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetCascade domain property code
		
		/// <summary>
		/// TargetCascade domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCascadeDomainPropertyId = new global::System.Guid(0x42102a9d, 0x77ce, 0x437e, 0xab, 0xc7, 0x3c, 0xd5, 0x4e, 0x8a, 0x10, 0x61);
		
		/// <summary>
		/// Storage for TargetCascade
		/// </summary>
		private CascadeEnum targetCascadePropertyStorage = CascadeEnum.None;
		
		/// <summary>
		/// Gets or sets the value of TargetCascade domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/TargetCascade.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/TargetCascade.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/TargetCascade.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(CascadeEnum.None)]
		[DslModeling::DomainObjectId("42102a9d-77ce-437e-abc7-3cd54e8a1061")]
		public CascadeEnum TargetCascade
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCascadePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCascadePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.TargetCascade domain property.
		/// </summary>
		internal sealed partial class TargetCascadePropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, CascadeEnum>
		{
			private TargetCascadePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.TargetCascade domain property value handler.
			/// </summary>
			public static readonly TargetCascadePropertyHandler Instance = new TargetCascadePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.TargetCascade domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCascadeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed CascadeEnum GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCascadePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, CascadeEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				CascadeEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCascadePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetConstrained domain property code
		
		/// <summary>
		/// TargetConstrained domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetConstrainedDomainPropertyId = new global::System.Guid(0xc38a4744, 0xad38, 0x4be2, 0xac, 0xc9, 0x1a, 0x32, 0x33, 0x0f, 0xbe, 0xd0);
		
		/// <summary>
		/// Storage for TargetConstrained
		/// </summary>
		private global::System.Boolean targetConstrainedPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of TargetConstrained domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/TargetConstrained.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/TargetConstrained.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/TargetConstrained.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("c38a4744-ad38-4be2-acc9-1a32330fbed0")]
		public global::System.Boolean TargetConstrained
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetConstrainedPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetConstrainedPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.TargetConstrained domain property.
		/// </summary>
		internal sealed partial class TargetConstrainedPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, global::System.Boolean>
		{
			private TargetConstrainedPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.TargetConstrained domain property value handler.
			/// </summary>
			public static readonly TargetConstrainedPropertyHandler Instance = new TargetConstrainedPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.TargetConstrained domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetConstrainedDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetConstrainedPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetConstrainedPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetCustomAccess domain property code
		
		/// <summary>
		/// TargetCustomAccess domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetCustomAccessDomainPropertyId = new global::System.Guid(0x71644b41, 0x9c91, 0x40ad, 0xb8, 0xf7, 0x83, 0xc9, 0x1d, 0x82, 0x39, 0xcb);
		
		/// <summary>
		/// Storage for TargetCustomAccess
		/// </summary>
		private global::System.String targetCustomAccessPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetCustomAccess domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/TargetCustomAccess.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/TargetCustomAccess.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/TargetCustomAccess.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("71644b41-9c91-40ad-b8f7-83c91d8239cb")]
		public global::System.String TargetCustomAccess
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetCustomAccessPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetCustomAccessPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.TargetCustomAccess domain property.
		/// </summary>
		internal sealed partial class TargetCustomAccessPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, global::System.String>
		{
			private TargetCustomAccessPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.TargetCustomAccess domain property value handler.
			/// </summary>
			public static readonly TargetCustomAccessPropertyHandler Instance = new TargetCustomAccessPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.TargetCustomAccess domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetCustomAccessDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetCustomAccessPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetCustomAccessPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetOuterJoin domain property code
		
		/// <summary>
		/// TargetOuterJoin domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetOuterJoinDomainPropertyId = new global::System.Guid(0x51177b34, 0xf743, 0x4cb8, 0x86, 0x0f, 0xd0, 0xd7, 0xb6, 0xb0, 0x0b, 0xa6);
		
		/// <summary>
		/// Storage for TargetOuterJoin
		/// </summary>
		private OuterJoinEnum targetOuterJoinPropertyStorage = OuterJoinEnum.Auto;
		
		/// <summary>
		/// Gets or sets the value of TargetOuterJoin domain property.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/TargetOuterJoin.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/TargetOuterJoin.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/TargetOuterJoin.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(OuterJoinEnum.Auto)]
		[DslModeling::DomainObjectId("51177b34-f743-4cb8-860f-d0d7b6b00ba6")]
		public OuterJoinEnum TargetOuterJoin
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetOuterJoinPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetOuterJoinPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.TargetOuterJoin domain property.
		/// </summary>
		internal sealed partial class TargetOuterJoinPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, OuterJoinEnum>
		{
			private TargetOuterJoinPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.TargetOuterJoin domain property value handler.
			/// </summary>
			public static readonly TargetOuterJoinPropertyHandler Instance = new TargetOuterJoinPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.TargetOuterJoin domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetOuterJoinDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed OuterJoinEnum GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetOuterJoinPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, OuterJoinEnum newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				OuterJoinEnum oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetOuterJoinPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region SourceDescription domain property code
		
		/// <summary>
		/// SourceDescription domain property Id.
		/// </summary>
		public static readonly global::System.Guid SourceDescriptionDomainPropertyId = new global::System.Guid(0x892bd79a, 0x5ea9, 0x44e9, 0xbf, 0xfa, 0xbd, 0xe7, 0xc1, 0x8c, 0x95, 0x60);
		
		/// <summary>
		/// Storage for SourceDescription
		/// </summary>
		private global::System.String sourceDescriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of SourceDescription domain property.
		/// Description of the property. This will appear in a <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/SourceDescription.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/SourceDescription.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/SourceDescription.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("892bd79a-5ea9-44e9-bffa-bde7c18c9560")]
		public global::System.String SourceDescription
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return sourceDescriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				SourceDescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.SourceDescription domain property.
		/// </summary>
		internal sealed partial class SourceDescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, global::System.String>
		{
			private SourceDescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.SourceDescription domain property value handler.
			/// </summary>
			public static readonly SourceDescriptionPropertyHandler Instance = new SourceDescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.SourceDescription domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return SourceDescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.sourceDescriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.sourceDescriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region TargetDescription domain property code
		
		/// <summary>
		/// TargetDescription domain property Id.
		/// </summary>
		public static readonly global::System.Guid TargetDescriptionDomainPropertyId = new global::System.Guid(0x742dacbc, 0xa8a5, 0x41d1, 0x9f, 0x4a, 0xb5, 0xc3, 0x70, 0x05, 0x79, 0x02);
		
		/// <summary>
		/// Storage for TargetDescription
		/// </summary>
		private global::System.String targetDescriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of TargetDescription domain property.
		/// Description of the property. This will appear in a <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/TargetDescription.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/TargetDescription.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/TargetDescription.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("742dacbc-a8a5-41d1-9f4a-b5c370057902")]
		public global::System.String TargetDescription
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return targetDescriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TargetDescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.TargetDescription domain property.
		/// </summary>
		internal sealed partial class TargetDescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, global::System.String>
		{
			private TargetDescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.TargetDescription domain property value handler.
			/// </summary>
			public static readonly TargetDescriptionPropertyHandler Instance = new TargetDescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.TargetDescription domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TargetDescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.targetDescriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.targetDescriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Lazy domain property code
		
		/// <summary>
		/// Lazy domain property Id.
		/// </summary>
		public static readonly global::System.Guid LazyDomainPropertyId = new global::System.Guid(0x94274ae2, 0xd397, 0x4398, 0xb9, 0x14, 0x50, 0x1e, 0x02, 0xf1, 0xc4, 0x72);
		
		/// <summary>
		/// Storage for Lazy
		/// </summary>
		private global::System.Boolean lazyPropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Lazy domain property.
		/// Will generate BelongsTo on the target end instead of a OneToOne to support lazy.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.OneToOneRelation/Lazy.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.OneToOneRelation/Lazy.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.OneToOneRelation/Lazy.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("94274ae2-d397-4398-b914-501e02f1c472")]
		public global::System.Boolean Lazy
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return lazyPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				LazyPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the OneToOneRelation.Lazy domain property.
		/// </summary>
		internal sealed partial class LazyPropertyHandler : DslModeling::DomainPropertyValueHandler<OneToOneRelation, global::System.Boolean>
		{
			private LazyPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the OneToOneRelation.Lazy domain property value handler.
			/// </summary>
			public static readonly LazyPropertyHandler Instance = new LazyPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the OneToOneRelation.Lazy domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return LazyDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(OneToOneRelation element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.lazyPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(OneToOneRelation element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.lazyPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Source link accessor
		/// <summary>
		/// Get the OneToOneRelation link to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.OneToOneRelation GetLinkToOneToOneTarget (global::Castle.ActiveWriter.ModelClass sourceInstance)
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.OneToOneRelation> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.OneToOneRelation>(sourceInstance, global::Castle.ActiveWriter.OneToOneRelation.SourceDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Source not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region Target link accessor
		/// <summary>
		/// Get the list of OneToOneRelation links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.OneToOneRelation> GetLinksToOneToOneSources ( global::Castle.ActiveWriter.ModelClass targetInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.OneToOneRelation>(targetInstance, global::Castle.ActiveWriter.OneToOneRelation.TargetDomainRoleId);
		}
		#endregion
		#region OneToOneRelation instance accessors
		
		/// <summary>
		/// Get any OneToOneRelation links between a given ModelClass and a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.OneToOneRelation> GetLinks( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.OneToOneRelation> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.OneToOneRelation>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.OneToOneRelation> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.OneToOneRelation>(source, global::Castle.ActiveWriter.OneToOneRelation.SourceDomainRoleId);
			foreach ( global::Castle.ActiveWriter.OneToOneRelation link in links )
			{
				if ( target.Equals(link.Target) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one OneToOneRelation link between a given ModelClassand a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.OneToOneRelation GetLink( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.OneToOneRelation> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.OneToOneRelation>(source, global::Castle.ActiveWriter.OneToOneRelation.SourceDomainRoleId);
			foreach ( global::Castle.ActiveWriter.OneToOneRelation link in links )
			{
				if ( target.Equals(link.Target) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship ModelHasNestedClasses
	/// Description for Castle.ActiveWriter.ModelHasNestedClasses
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelHasNestedClasses.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelHasNestedClasses.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("b52af8b1-d8e4-4df3-9ccc-aed68d8c50f6")]
	public partial class ModelHasNestedClasses : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ModelHasNestedClasses domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xb52af8b1, 0xd8e4, 0x4df3, 0x9c, 0xcc, 0xae, 0xd6, 0x8d, 0x8c, 0x50, 0xf6);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ModelHasNestedClasses link in the same Partition as the given Model
		/// </summary>
		/// <param name="source">Model to use as the source of the relationship.</param>
		/// <param name="target">NestedClass to use as the target of the relationship.</param>
		public ModelHasNestedClasses(Model source, NestedClass target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ModelHasNestedClasses.ModelDomainRoleId, source), new DslModeling::RoleAssignment(ModelHasNestedClasses.NestedClassDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ModelHasNestedClasses(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ModelHasNestedClasses(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ModelHasNestedClasses(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ModelHasNestedClasses(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Model domain role code
		
		/// <summary>
		/// Model domain role Id.
		/// </summary>
		public static readonly global::System.Guid ModelDomainRoleId = new global::System.Guid(0xaa430439, 0x9ab3, 0x4298, 0x96, 0x36, 0x53, 0xd2, 0xf9, 0x77, 0x4d, 0x04);
		
		/// <summary>
		/// DomainRole Model
		/// Description for Castle.ActiveWriter.ModelHasNestedClasses.Model
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelHasNestedClasses/Model.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelHasNestedClasses/Model.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "NestedClasses", PropertyDisplayNameKey="Castle.ActiveWriter.ModelHasNestedClasses/Model.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("aa430439-9ab3-4298-9636-53d2f9774d04")]
		public virtual Model Model
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Model)DslModeling::DomainRoleInfo.GetRolePlayer(this, ModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Model of a NestedClass
		/// <summary>
		/// Gets Model.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static Model GetModel(NestedClass element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, NestedClassDomainRoleId) as Model;
		}
		
		/// <summary>
		/// Sets Model.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetModel(NestedClass element, Model newModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, NestedClassDomainRoleId, newModel);
		}
		#endregion
		#region NestedClass domain role code
		
		/// <summary>
		/// NestedClass domain role Id.
		/// </summary>
		public static readonly global::System.Guid NestedClassDomainRoleId = new global::System.Guid(0x6948fc5c, 0xa899, 0x4a5b, 0x91, 0xa9, 0x96, 0x50, 0xe8, 0xd2, 0x7e, 0x3b);
		
		/// <summary>
		/// DomainRole NestedClass
		/// Description for Castle.ActiveWriter.ModelHasNestedClasses.NestedClass
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.ModelHasNestedClasses/NestedClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.ModelHasNestedClasses/NestedClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Model", PropertyDisplayNameKey="Castle.ActiveWriter.ModelHasNestedClasses/NestedClass.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("6948fc5c-a899-4a5b-91a9-9650e8d27e3b")]
		public virtual NestedClass NestedClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (NestedClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, NestedClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, NestedClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access NestedClasses of a Model
		/// <summary>
		/// Gets a list of NestedClasses.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<NestedClass> GetNestedClasses(Model element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<NestedClass>, NestedClass>(element, ModelDomainRoleId);
		}
		#endregion
		#region Model link accessor
		/// <summary>
		/// Get the list of ModelHasNestedClasses links to a Model.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ModelHasNestedClasses> GetLinksToNestedClasses ( global::Castle.ActiveWriter.Model modelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasNestedClasses>(modelInstance, global::Castle.ActiveWriter.ModelHasNestedClasses.ModelDomainRoleId);
		}
		#endregion
		#region NestedClass link accessor
		/// <summary>
		/// Get the ModelHasNestedClasses link to a NestedClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.ModelHasNestedClasses GetLinkToModel (global::Castle.ActiveWriter.NestedClass nestedClassInstance)
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ModelHasNestedClasses> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasNestedClasses>(nestedClassInstance, global::Castle.ActiveWriter.ModelHasNestedClasses.NestedClassDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of NestedClass not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region ModelHasNestedClasses instance accessors
		
		/// <summary>
		/// Get any ModelHasNestedClasses links between a given Model and a NestedClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.ModelHasNestedClasses> GetLinks( global::Castle.ActiveWriter.Model source, global::Castle.ActiveWriter.NestedClass target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.ModelHasNestedClasses> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.ModelHasNestedClasses>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ModelHasNestedClasses> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasNestedClasses>(source, global::Castle.ActiveWriter.ModelHasNestedClasses.ModelDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ModelHasNestedClasses link in links )
			{
				if ( target.Equals(link.NestedClass) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ModelHasNestedClasses link between a given Modeland a NestedClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.ModelHasNestedClasses GetLink( global::Castle.ActiveWriter.Model source, global::Castle.ActiveWriter.NestedClass target )
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.ModelHasNestedClasses> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.ModelHasNestedClasses>(source, global::Castle.ActiveWriter.ModelHasNestedClasses.ModelDomainRoleId);
			foreach ( global::Castle.ActiveWriter.ModelHasNestedClasses link in links )
			{
				if ( target.Equals(link.NestedClass) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship NestedClassHasProperties
	/// Description for Castle.ActiveWriter.NestedClassHasProperties
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassHasProperties.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassHasProperties.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("43b9347e-1b5e-4727-b8eb-8ce53dfe040d")]
	public partial class NestedClassHasProperties : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// NestedClassHasProperties domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x43b9347e, 0x1b5e, 0x4727, 0xb8, 0xeb, 0x8c, 0xe5, 0x3d, 0xfe, 0x04, 0x0d);
	
				
		/// <summary>
		/// Constructor
		/// Creates a NestedClassHasProperties link in the same Partition as the given NestedClass
		/// </summary>
		/// <param name="source">NestedClass to use as the source of the relationship.</param>
		/// <param name="target">ModelProperty to use as the target of the relationship.</param>
		public NestedClassHasProperties(NestedClass source, ModelProperty target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(NestedClassHasProperties.NestedClassDomainRoleId, source), new DslModeling::RoleAssignment(NestedClassHasProperties.PropertyDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public NestedClassHasProperties(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public NestedClassHasProperties(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public NestedClassHasProperties(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public NestedClassHasProperties(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region NestedClass domain role code
		
		/// <summary>
		/// NestedClass domain role Id.
		/// </summary>
		public static readonly global::System.Guid NestedClassDomainRoleId = new global::System.Guid(0x6180382e, 0xdc27, 0x408f, 0x92, 0x93, 0x48, 0x63, 0xf8, 0x05, 0x4b, 0x67);
		
		/// <summary>
		/// DomainRole NestedClass
		/// Description for Castle.ActiveWriter.NestedClassHasProperties.NestedClass
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassHasProperties/NestedClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassHasProperties/NestedClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Properties", PropertyDisplayNameKey="Castle.ActiveWriter.NestedClassHasProperties/NestedClass.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("6180382e-dc27-408f-9293-4863f8054b67")]
		public virtual NestedClass NestedClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (NestedClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, NestedClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, NestedClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access NestedClass of a ModelProperty
		/// <summary>
		/// Gets NestedClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static NestedClass GetNestedClass(ModelProperty element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, PropertyDomainRoleId) as NestedClass;
		}
		
		/// <summary>
		/// Sets NestedClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetNestedClass(ModelProperty element, NestedClass newNestedClass)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, PropertyDomainRoleId, newNestedClass);
		}
		#endregion
		#region Property domain role code
		
		/// <summary>
		/// Property domain role Id.
		/// </summary>
		public static readonly global::System.Guid PropertyDomainRoleId = new global::System.Guid(0xa679ceaf, 0x60f0, 0x4a92, 0xad, 0x5b, 0x42, 0xab, 0x19, 0x7d, 0xe0, 0xcc);
		
		/// <summary>
		/// DomainRole Property
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassHasProperties/Property.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassHasProperties/Property.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "NestedClass", PropertyDisplayNameKey="Castle.ActiveWriter.NestedClassHasProperties/Property.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroOne)]
		[DslModeling::DomainObjectId("a679ceaf-60f0-4a92-ad5b-42ab197de0cc")]
		public virtual ModelProperty Property
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelProperty)DslModeling::DomainRoleInfo.GetRolePlayer(this, PropertyDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, PropertyDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Properties of a NestedClass
		/// <summary>
		/// Gets a list of Properties.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelProperty> GetProperties(NestedClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelProperty>, ModelProperty>(element, NestedClassDomainRoleId);
		}
		#endregion
		#region NestedClass link accessor
		/// <summary>
		/// Get the list of NestedClassHasProperties links to a NestedClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.NestedClassHasProperties> GetLinksToProperties ( global::Castle.ActiveWriter.NestedClass nestedClassInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassHasProperties>(nestedClassInstance, global::Castle.ActiveWriter.NestedClassHasProperties.NestedClassDomainRoleId);
		}
		#endregion
		#region Property link accessor
		/// <summary>
		/// Get the NestedClassHasProperties link to a ModelProperty.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.NestedClassHasProperties GetLinkToNestedClass (global::Castle.ActiveWriter.ModelProperty propertyInstance)
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.NestedClassHasProperties> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassHasProperties>(propertyInstance, global::Castle.ActiveWriter.NestedClassHasProperties.PropertyDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Property not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region NestedClassHasProperties instance accessors
		
		/// <summary>
		/// Get any NestedClassHasProperties links between a given NestedClass and a ModelProperty.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.NestedClassHasProperties> GetLinks( global::Castle.ActiveWriter.NestedClass source, global::Castle.ActiveWriter.ModelProperty target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.NestedClassHasProperties> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.NestedClassHasProperties>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.NestedClassHasProperties> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassHasProperties>(source, global::Castle.ActiveWriter.NestedClassHasProperties.NestedClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.NestedClassHasProperties link in links )
			{
				if ( target.Equals(link.Property) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one NestedClassHasProperties link between a given NestedClassand a ModelProperty.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.NestedClassHasProperties GetLink( global::Castle.ActiveWriter.NestedClass source, global::Castle.ActiveWriter.ModelProperty target )
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.NestedClassHasProperties> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassHasProperties>(source, global::Castle.ActiveWriter.NestedClassHasProperties.NestedClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.NestedClassHasProperties link in links )
			{
				if ( target.Equals(link.Property) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship NestedClassReferencesModelClasses
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("6d7cfc22-da01-49be-87ae-387c801c09a5")]
	public partial class NestedClassReferencesModelClasses : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// NestedClassReferencesModelClasses domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x6d7cfc22, 0xda01, 0x49be, 0x87, 0xae, 0x38, 0x7c, 0x80, 0x1c, 0x09, 0xa5);
	
				
		/// <summary>
		/// Constructor
		/// Creates a NestedClassReferencesModelClasses link in the same Partition as the given NestedClass
		/// </summary>
		/// <param name="source">NestedClass to use as the source of the relationship.</param>
		/// <param name="target">ModelClass to use as the target of the relationship.</param>
		public NestedClassReferencesModelClasses(NestedClass source, ModelClass target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(NestedClassReferencesModelClasses.NestedClassDomainRoleId, source), new DslModeling::RoleAssignment(NestedClassReferencesModelClasses.ModelClassDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public NestedClassReferencesModelClasses(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public NestedClassReferencesModelClasses(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public NestedClassReferencesModelClasses(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public NestedClassReferencesModelClasses(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region NestedClass domain role code
		
		/// <summary>
		/// NestedClass domain role Id.
		/// </summary>
		public static readonly global::System.Guid NestedClassDomainRoleId = new global::System.Guid(0x9afdc90c, 0xc59b, 0x4a9e, 0x84, 0x8d, 0x7c, 0x82, 0xae, 0xd6, 0xcc, 0x3d);
		
		/// <summary>
		/// DomainRole NestedClass
		/// Description for
		/// Castle.ActiveWriter.NestedClassReferencesModelClasses.NestedClass
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/NestedClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/NestedClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "ModelClasses", PropertyDisplayNameKey="Castle.ActiveWriter.NestedClassReferencesModelClasses/NestedClass.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("9afdc90c-c59b-4a9e-848d-7c82aed6cc3d")]
		public virtual NestedClass NestedClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (NestedClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, NestedClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, NestedClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access NestedClasses of a ModelClass
		/// <summary>
		/// Gets a list of NestedClasses.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<NestedClass> GetNestedClasses(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<NestedClass>, NestedClass>(element, ModelClassDomainRoleId);
		}
		#endregion
		#region ModelClass domain role code
		
		/// <summary>
		/// ModelClass domain role Id.
		/// </summary>
		public static readonly global::System.Guid ModelClassDomainRoleId = new global::System.Guid(0xc8a74401, 0x0517, 0x4a83, 0xb7, 0x99, 0x8c, 0x64, 0xc2, 0x6a, 0xf5, 0xa3);
		
		/// <summary>
		/// DomainRole ModelClass
		/// Description for Castle.ActiveWriter.NestedClassReferencesModelClasses.ModelClass
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/ModelClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/ModelClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "NestedClasses", PropertyDisplayNameKey="Castle.ActiveWriter.NestedClassReferencesModelClasses/ModelClass.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("c8a74401-0517-4a83-b799-8c64c26af5a3")]
		public virtual ModelClass ModelClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, ModelClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ModelClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ModelClasses of a NestedClass
		/// <summary>
		/// Gets a list of ModelClasses.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetModelClasses(NestedClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, NestedClassDomainRoleId);
		}
		#endregion
		#region MapType domain property code
		
		/// <summary>
		/// MapType domain property Id.
		/// </summary>
		public static readonly global::System.Guid MapTypeDomainPropertyId = new global::System.Guid(0xf223ecda, 0x896f, 0x4951, 0xa5, 0x8d, 0xf4, 0x5b, 0x16, 0xc1, 0xf0, 0xbb);
		
		/// <summary>
		/// Storage for MapType
		/// </summary>
		private global::System.String mapTypePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of MapType domain property.
		/// Allows one to reference a different type than the property type
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/MapType.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/MapType.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/MapType.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("f223ecda-896f-4951-a58d-f45b16c1f0bb")]
		public global::System.String MapType
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return mapTypePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				MapTypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClassReferencesModelClasses.MapType domain property.
		/// </summary>
		internal sealed partial class MapTypePropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClassReferencesModelClasses, global::System.String>
		{
			private MapTypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClassReferencesModelClasses.MapType domain property value handler.
			/// </summary>
			public static readonly MapTypePropertyHandler Instance = new MapTypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClassReferencesModelClasses.MapType domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return MapTypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(NestedClassReferencesModelClasses element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.mapTypePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClassReferencesModelClasses element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.mapTypePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Insert domain property code
		
		/// <summary>
		/// Insert domain property Id.
		/// </summary>
		public static readonly global::System.Guid InsertDomainPropertyId = new global::System.Guid(0x1f2d4b58, 0x7b2f, 0x4aff, 0xbe, 0xa9, 0x0b, 0xcf, 0xb5, 0x0b, 0x1a, 0x01);
		
		/// <summary>
		/// Storage for Insert
		/// </summary>
		private global::System.Boolean insertPropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of Insert domain property.
		/// Set to false to ignore this nested component when updating entities of this
		/// ActiveRecord class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Insert.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Insert.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Insert.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("1f2d4b58-7b2f-4aff-bea9-0bcfb50b1a01")]
		public global::System.Boolean Insert
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return insertPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				InsertPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClassReferencesModelClasses.Insert domain property.
		/// </summary>
		internal sealed partial class InsertPropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClassReferencesModelClasses, global::System.Boolean>
		{
			private InsertPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClassReferencesModelClasses.Insert domain property value handler.
			/// </summary>
			public static readonly InsertPropertyHandler Instance = new InsertPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClassReferencesModelClasses.Insert domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return InsertDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(NestedClassReferencesModelClasses element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.insertPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClassReferencesModelClasses element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.insertPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Update domain property code
		
		/// <summary>
		/// Update domain property Id.
		/// </summary>
		public static readonly global::System.Guid UpdateDomainPropertyId = new global::System.Guid(0xce949210, 0x8ff3, 0x45ab, 0xb8, 0xf9, 0xdf, 0x65, 0xba, 0x4b, 0x40, 0xef);
		
		/// <summary>
		/// Storage for Update
		/// </summary>
		private global::System.Boolean updatePropertyStorage = true;
		
		/// <summary>
		/// Gets or sets the value of Update domain property.
		/// Description for Castle.ActiveWriter.NestedClassReferencesModelClasses.Update
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Update.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Update.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Update.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[global::System.ComponentModel.DefaultValue(true)]
		[DslModeling::DomainObjectId("ce949210-8ff3-45ab-b8f9-df65ba4b40ef")]
		public global::System.Boolean Update
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return updatePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				UpdatePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClassReferencesModelClasses.Update domain property.
		/// </summary>
		internal sealed partial class UpdatePropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClassReferencesModelClasses, global::System.Boolean>
		{
			private UpdatePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClassReferencesModelClasses.Update domain property value handler.
			/// </summary>
			public static readonly UpdatePropertyHandler Instance = new UpdatePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClassReferencesModelClasses.Update domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return UpdateDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.Boolean GetValue(NestedClassReferencesModelClasses element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.updatePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClassReferencesModelClasses element, global::System.Boolean newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.Boolean oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.updatePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region ColumnPrefix domain property code
		
		/// <summary>
		/// ColumnPrefix domain property Id.
		/// </summary>
		public static readonly global::System.Guid ColumnPrefixDomainPropertyId = new global::System.Guid(0x3e791122, 0x9269, 0x440a, 0xab, 0x27, 0x35, 0xa3, 0x7e, 0x3b, 0xe3, 0x63);
		
		/// <summary>
		/// Storage for ColumnPrefix
		/// </summary>
		private global::System.String columnPrefixPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of ColumnPrefix domain property.
		/// Set to false to ignore this nested component when inserting entities of this
		/// ActiveRecord class.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/ColumnPrefix.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/ColumnPrefix.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/ColumnPrefix.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("3e791122-9269-440a-ab27-35a37e3be363")]
		public global::System.String ColumnPrefix
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return columnPrefixPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				ColumnPrefixPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClassReferencesModelClasses.ColumnPrefix domain property.
		/// </summary>
		internal sealed partial class ColumnPrefixPropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClassReferencesModelClasses, global::System.String>
		{
			private ColumnPrefixPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClassReferencesModelClasses.ColumnPrefix domain property value handler.
			/// </summary>
			public static readonly ColumnPrefixPropertyHandler Instance = new ColumnPrefixPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClassReferencesModelClasses.ColumnPrefix domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return ColumnPrefixDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(NestedClassReferencesModelClasses element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.columnPrefixPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClassReferencesModelClasses element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.columnPrefixPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region Description domain property code
		
		/// <summary>
		/// Description domain property Id.
		/// </summary>
		public static readonly global::System.Guid DescriptionDomainPropertyId = new global::System.Guid(0x9010a202, 0x2aaf, 0x4c97, 0xbd, 0x0f, 0x87, 0xd4, 0x81, 0x98, 0xdb, 0xc6);
		
		/// <summary>
		/// Storage for Description
		/// </summary>
		private global::System.String descriptionPropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Description domain property.
		/// Description for nested property on the model class. This will appear in a
		/// <summary> Xml comment.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Description.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Description.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/Description.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("9010a202-2aaf-4c97-bd0f-87d48198dbc6")]
		public global::System.String Description
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return descriptionPropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DescriptionPropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClassReferencesModelClasses.Description domain property.
		/// </summary>
		internal sealed partial class DescriptionPropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClassReferencesModelClasses, global::System.String>
		{
			private DescriptionPropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClassReferencesModelClasses.Description domain property value handler.
			/// </summary>
			public static readonly DescriptionPropertyHandler Instance = new DescriptionPropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClassReferencesModelClasses.Description domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return DescriptionDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(NestedClassReferencesModelClasses element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.descriptionPropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClassReferencesModelClasses element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.descriptionPropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region PropertyName domain property code
		
		/// <summary>
		/// PropertyName domain property Id.
		/// </summary>
		public static readonly global::System.Guid PropertyNameDomainPropertyId = new global::System.Guid(0xec25892d, 0x150f, 0x4a9a, 0x87, 0x4b, 0x7f, 0x80, 0xe9, 0x7a, 0x21, 0x35);
		
		/// <summary>
		/// Storage for PropertyName
		/// </summary>
		private global::System.String propertyNamePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of PropertyName domain property.
		/// Name of the property on the nesting class. If not suplied, ActiveWriter will use
		/// nested class' name.
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/PropertyName.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/PropertyName.Category", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.NestedClassReferencesModelClasses/PropertyName.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ec25892d-150f-4a9a-874b-7f80e97a2135")]
		public global::System.String PropertyName
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return propertyNamePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				PropertyNamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NestedClassReferencesModelClasses.PropertyName domain property.
		/// </summary>
		internal sealed partial class PropertyNamePropertyHandler : DslModeling::DomainPropertyValueHandler<NestedClassReferencesModelClasses, global::System.String>
		{
			private PropertyNamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NestedClassReferencesModelClasses.PropertyName domain property value handler.
			/// </summary>
			public static readonly PropertyNamePropertyHandler Instance = new PropertyNamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NestedClassReferencesModelClasses.PropertyName domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return PropertyNameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(NestedClassReferencesModelClasses element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.propertyNamePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NestedClassReferencesModelClasses element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.propertyNamePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region NestedClass link accessor
		/// <summary>
		/// Get the list of NestedClassReferencesModelClasses links to a NestedClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.NestedClassReferencesModelClasses> GetLinksToModelClasses ( global::Castle.ActiveWriter.NestedClass nestedClassInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassReferencesModelClasses>(nestedClassInstance, global::Castle.ActiveWriter.NestedClassReferencesModelClasses.NestedClassDomainRoleId);
		}
		#endregion
		#region ModelClass link accessor
		/// <summary>
		/// Get the list of NestedClassReferencesModelClasses links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.NestedClassReferencesModelClasses> GetLinksToNestedClasses ( global::Castle.ActiveWriter.ModelClass modelClassInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassReferencesModelClasses>(modelClassInstance, global::Castle.ActiveWriter.NestedClassReferencesModelClasses.ModelClassDomainRoleId);
		}
		#endregion
		#region NestedClassReferencesModelClasses instance accessors
		
		/// <summary>
		/// Get any NestedClassReferencesModelClasses links between a given NestedClass and a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.NestedClassReferencesModelClasses> GetLinks( global::Castle.ActiveWriter.NestedClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.NestedClassReferencesModelClasses> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.NestedClassReferencesModelClasses>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.NestedClassReferencesModelClasses> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassReferencesModelClasses>(source, global::Castle.ActiveWriter.NestedClassReferencesModelClasses.NestedClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.NestedClassReferencesModelClasses link in links )
			{
				if ( target.Equals(link.ModelClass) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one NestedClassReferencesModelClasses link between a given NestedClassand a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.NestedClassReferencesModelClasses GetLink( global::Castle.ActiveWriter.NestedClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.NestedClassReferencesModelClasses> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.NestedClassReferencesModelClasses>(source, global::Castle.ActiveWriter.NestedClassReferencesModelClasses.NestedClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.NestedClassReferencesModelClasses link in links )
			{
				if ( target.Equals(link.ModelClass) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainRelationship InheritanceRelation
	/// Indicates that a class inherits from another class.
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.InheritanceRelation.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritanceRelation.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("91bc9e95-6a4c-467b-9e05-19d77f3f5c6e")]
	public partial class InheritanceRelation : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// InheritanceRelation domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x91bc9e95, 0x6a4c, 0x467b, 0x9e, 0x05, 0x19, 0xd7, 0x7f, 0x3f, 0x5c, 0x6e);
	
				
		/// <summary>
		/// Constructor
		/// Creates a InheritanceRelation link in the same Partition as the given ModelClass
		/// </summary>
		/// <param name="source">ModelClass to use as the source of the relationship.</param>
		/// <param name="target">ModelClass to use as the target of the relationship.</param>
		public InheritanceRelation(ModelClass source, ModelClass target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(InheritanceRelation.SourceModelClassDomainRoleId, source), new DslModeling::RoleAssignment(InheritanceRelation.TargetModelClassDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public InheritanceRelation(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public InheritanceRelation(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public InheritanceRelation(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public InheritanceRelation(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region SourceModelClass domain role code
		
		/// <summary>
		/// SourceModelClass domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceModelClassDomainRoleId = new global::System.Guid(0x041227b3, 0x4da3, 0x4472, 0x90, 0x9b, 0x98, 0x0e, 0xe5, 0xac, 0x16, 0x3a);
		
		/// <summary>
		/// DomainRole SourceModelClass
		/// Description for Castle.ActiveWriter.InheritanceRelation.SourceModelClass
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.InheritanceRelation/SourceModelClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritanceRelation/SourceModelClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "TargetModelClasses", PropertyDisplayNameKey="Castle.ActiveWriter.InheritanceRelation/SourceModelClass.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("041227b3-4da3-4472-909b-980ee5ac163a")]
		public virtual ModelClass SourceModelClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceModelClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceModelClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access SourceModelClasses of a ModelClass
		/// <summary>
		/// Gets a list of SourceModelClasses.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetSourceModelClasses(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, TargetModelClassDomainRoleId);
		}
		#endregion
		#region TargetModelClass domain role code
		
		/// <summary>
		/// TargetModelClass domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetModelClassDomainRoleId = new global::System.Guid(0xa8f24912, 0x537a, 0x480a, 0x96, 0x5e, 0x7c, 0x0a, 0xa9, 0xc8, 0x8d, 0x19);
		
		/// <summary>
		/// DomainRole TargetModelClass
		/// Description for Castle.ActiveWriter.InheritanceRelation.TargetModelClass
		/// </summary>
		[DslDesign::DisplayNameResource("Castle.ActiveWriter.InheritanceRelation/TargetModelClass.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Castle.ActiveWriter.InheritanceRelation/TargetModelClass.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "SourceModelClasses", PropertyDisplayNameKey="Castle.ActiveWriter.InheritanceRelation/TargetModelClass.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("a8f24912-537a-480a-965e-7c0aa9c88d19")]
		public virtual ModelClass TargetModelClass
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ModelClass)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetModelClassDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetModelClassDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access TargetModelClasses of a ModelClass
		/// <summary>
		/// Gets a list of TargetModelClasses.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ModelClass> GetTargetModelClasses(ModelClass element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ModelClass>, ModelClass>(element, SourceModelClassDomainRoleId);
		}
		#endregion
		#region SourceModelClass link accessor
		/// <summary>
		/// Get the list of InheritanceRelation links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.InheritanceRelation> GetLinksToTargetModelClasses ( global::Castle.ActiveWriter.ModelClass sourceModelClassInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.InheritanceRelation>(sourceModelClassInstance, global::Castle.ActiveWriter.InheritanceRelation.SourceModelClassDomainRoleId);
		}
		#endregion
		#region TargetModelClass link accessor
		/// <summary>
		/// Get the list of InheritanceRelation links to a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.InheritanceRelation> GetLinksToSourceModelClasses ( global::Castle.ActiveWriter.ModelClass targetModelClassInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.InheritanceRelation>(targetModelClassInstance, global::Castle.ActiveWriter.InheritanceRelation.TargetModelClassDomainRoleId);
		}
		#endregion
		#region InheritanceRelation instance accessors
		
		/// <summary>
		/// Get any InheritanceRelation links between a given ModelClass and a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Castle.ActiveWriter.InheritanceRelation> GetLinks( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.List<global::Castle.ActiveWriter.InheritanceRelation> outLinks = new global::System.Collections.Generic.List<global::Castle.ActiveWriter.InheritanceRelation>();
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.InheritanceRelation> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.InheritanceRelation>(source, global::Castle.ActiveWriter.InheritanceRelation.SourceModelClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.InheritanceRelation link in links )
			{
				if ( target.Equals(link.TargetModelClass) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one InheritanceRelation link between a given ModelClassand a ModelClass.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Castle.ActiveWriter.InheritanceRelation GetLink( global::Castle.ActiveWriter.ModelClass source, global::Castle.ActiveWriter.ModelClass target )
		{
			global::System.Collections.Generic.IList<global::Castle.ActiveWriter.InheritanceRelation> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Castle.ActiveWriter.InheritanceRelation>(source, global::Castle.ActiveWriter.InheritanceRelation.SourceModelClassDomainRoleId);
			foreach ( global::Castle.ActiveWriter.InheritanceRelation link in links )
			{
				if ( target.Equals(link.TargetModelClass) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}

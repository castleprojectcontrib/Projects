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
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

[module: global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Scope = "type", Target = "Castle.ActiveWriter.ActiveRecordMapping")]

namespace Castle.ActiveWriter
{
	/// <summary>
	/// DomainClass ActiveRecordMapping
	/// </summary>
	[DslDesign::DisplayNameResource("Castle.ActiveWriter.ActiveRecordMapping.DisplayName", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Castle.ActiveWriter.ActiveRecordMapping.Description", typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel), "Castle.ActiveWriter.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Castle.ActiveWriter.ActiveWriterDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("d25f93b4-c78e-4d22-9d48-ce498e8c1e58")]
	public partial class ActiveRecordMapping : DslDiagrams::Diagram
	{
		#region Diagram boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		#endregion
		#region Toolbox filters
		private static global::System.ComponentModel.ToolboxItemFilterAttribute[] toolboxFilters = new global::System.ComponentModel.ToolboxItemFilterAttribute[] {
					new global::System.ComponentModel.ToolboxItemFilterAttribute(global::Castle.ActiveWriter.ActiveWriterToolboxHelperBase.ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) };
		
		/// <summary>
		/// Toolbox item filter attributes for this diagram.
		/// </summary>
		public override global::System.Collections.ICollection TargetToolboxItemFilterAttributes
		{
			get
			{
				return toolboxFilters;
			}
		}
		#endregion
		#region Auto-placement
		/// <summary>
		/// Indicate that child shapes should added through view fixup should be placed automatically.
		/// </summary>
		public override bool ShouldAutoPlaceChildShapes
		{
			get
			{
				return true;
			}
		}
		#endregion
		#region Compartment support
		/// <summary>
		/// Whether compartment items change events are subscribed to.
		/// </summary>
		private bool subscribedCompartmentItemsEvents;
		
		/// <summary>
		/// Subscribe to events fired when compartment items changes.
		/// </summary>
		public void SubscribeCompartmentItemsEvents()
		{
			if (!subscribedCompartmentItemsEvents && Store != null)
			{
				subscribedCompartmentItemsEvents = true;
				Store.EventManagerDirectory.ElementAdded.Add(new global::System.EventHandler<DslModeling::ElementAddedEventArgs>(CompartmentItemAdded));
				Store.EventManagerDirectory.ElementDeleted.Add(new global::System.EventHandler<DslModeling::ElementDeletedEventArgs>(CompartmentItemDeleted));
				Store.EventManagerDirectory.ElementPropertyChanged.Add(new global::System.EventHandler<DslModeling::ElementPropertyChangedEventArgs>(CompartmentItemPropertyChanged));
				Store.EventManagerDirectory.RolePlayerChanged.Add(new global::System.EventHandler<DslModeling::RolePlayerChangedEventArgs>(CompartmentItemRolePlayerChanged));
				Store.EventManagerDirectory.RolePlayerOrderChanged.Add(new global::System.EventHandler<DslModeling::RolePlayerOrderChangedEventArgs>(CompartmentItemRolePlayerOrderChanged));
			}
		}
		
		/// <summary>
		/// Unsubscribe to events fired when compartment items changes.
		/// </summary>
		public void UnsubscribeCompartmentItemsEvents()
		{
			if (subscribedCompartmentItemsEvents)
			{
				Store.EventManagerDirectory.ElementAdded.Remove(new global::System.EventHandler<DslModeling::ElementAddedEventArgs>(CompartmentItemAdded));
				Store.EventManagerDirectory.ElementDeleted.Remove(new global::System.EventHandler<DslModeling::ElementDeletedEventArgs>(CompartmentItemDeleted));
				Store.EventManagerDirectory.ElementPropertyChanged.Remove(new global::System.EventHandler<DslModeling::ElementPropertyChangedEventArgs>(CompartmentItemPropertyChanged));
				Store.EventManagerDirectory.RolePlayerChanged.Remove(new global::System.EventHandler<DslModeling::RolePlayerChangedEventArgs>(CompartmentItemRolePlayerChanged));
				Store.EventManagerDirectory.RolePlayerOrderChanged.Remove(new global::System.EventHandler<DslModeling::RolePlayerOrderChangedEventArgs>(CompartmentItemRolePlayerOrderChanged));
				subscribedCompartmentItemsEvents = false;
			}
		}
		
		#region Event handlers
		/// <summary>
		/// Event for element added.
		/// </summary>
		private void CompartmentItemAdded(object sender, DslModeling::ElementAddedEventArgs e)
		{
			CompartmentItemAddRule.ElementAdded(e, true /* repaint only */);
		}
		/// <summary>
		/// Event for element deleted.
		/// </summary>
		private void CompartmentItemDeleted(object sender, DslModeling::ElementDeletedEventArgs e)
		{
			CompartmentItemDeleteRule.ElementDeleted(e, true /* repaint only */);
		}
		/// <summary>
		/// Event for element property changed.
		/// </summary>
		private void CompartmentItemPropertyChanged(object sender, DslModeling::ElementPropertyChangedEventArgs e)
		{
			CompartmentItemChangeRule.ElementPropertyChanged(e, true /* repaint only */);
		}
		/// <summary>
		/// Event for role-player changed.
		/// </summary>
		private void CompartmentItemRolePlayerChanged(object sender, DslModeling::RolePlayerChangedEventArgs e)
		{
			CompartmentItemRolePlayerChangeRule.RolePlayerChanged(e, true /* repaint only */);
		}
		/// <summary>
		/// Event for role-player order changed.
		/// </summary>
		private void CompartmentItemRolePlayerOrderChanged(object sender, DslModeling::RolePlayerOrderChangedEventArgs e)
		{
			CompartmentItemRolePlayerPositionChangeRule.RolePlayerPositionChanged(e, true /* repaint only */);
		}
		#endregion
		#endregion
		#region Shape mapping
		/// <summary>
		/// Called during view fixup to ask the parent whether a shape should be created for the given child element.
		/// </summary>
		/// <remarks>
		/// Always return true, since we assume there is only one diagram per model file for DSL scenarios.
		/// </remarks>
		protected override bool ShouldAddShapeForElement(DslModeling::ModelElement element)
		{
			return true;
		}
		
		/// <summary>
		/// Called during view fixup to configure the given child element, after it has been created.
		/// </summary>
		/// <remarks>
		/// Custom code for choosing the shapes attached to either end of a connector is called from here.
		/// </remarks>
		protected override void OnChildConfiguring(DslDiagrams::ShapeElement child, bool createdDuringViewFixup)
		{
			DslDiagrams::NodeShape sourceShape;
			DslDiagrams::NodeShape targetShape;
			DslDiagrams::BinaryLinkShape connector = child as DslDiagrams::BinaryLinkShape;
			if(connector == null)
			{
				base.OnChildConfiguring(child, createdDuringViewFixup);
				return;
			}
			GetSourceAndTargetForConnector(connector, out sourceShape, out targetShape);
			
			global::System.Diagnostics.Debug.Assert(sourceShape != null && targetShape != null, "Unable to find source and target shapes for connector.");
			connector.Connect(sourceShape, targetShape);
		}
		
		/// <summary>
		/// helper method to find the shapes for either end of a connector, including calling the user's custom code
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		internal void GetSourceAndTargetForConnector(DslDiagrams::BinaryLinkShape connector, out DslDiagrams::NodeShape sourceShape, out DslDiagrams::NodeShape targetShape)
		{
			sourceShape = null;
			targetShape = null;
			
			if (sourceShape == null || targetShape == null)
			{
				DslDiagrams::NodeShape[] endShapes = GetEndShapesForConnector(connector);
				if(sourceShape == null)
				{
					sourceShape = endShapes[0];
				}
				if(targetShape == null)
				{
					targetShape = endShapes[1];
				}
			}
		}
		
		/// <summary>
		/// Helper method to find shapes for either end of a connector by looking for shapes associated with either end of the relationship mapped to the connector.
		/// </summary>
		private DslDiagrams::NodeShape[] GetEndShapesForConnector(DslDiagrams::BinaryLinkShape connector)
		{
			DslModeling::ElementLink link = connector.ModelElement as DslModeling::ElementLink;
			DslDiagrams::NodeShape sourceShape = null, targetShape = null;
			if (link != null)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<DslModeling::ModelElement> linkedElements = link.LinkedElements;
				if (linkedElements.Count == 2)
				{
					DslDiagrams::Diagram currentDiagram = Diagram;
					DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> presentationElements = DslDiagrams::PresentationViewsSubject.GetPresentation(linkedElements[0]);
					foreach (DslDiagrams::PresentationElement presentationElement in presentationElements)
					{
						DslDiagrams::NodeShape shape = presentationElement as DslDiagrams::NodeShape;
						if (shape != null && shape.Diagram == currentDiagram)
						{
							sourceShape = shape;
							break;
						}
					}
					
					presentationElements = DslDiagrams::PresentationViewsSubject.GetPresentation(linkedElements[1]);
					foreach (DslDiagrams::PresentationElement presentationElement in presentationElements)
					{
						DslDiagrams::NodeShape shape = presentationElement as DslDiagrams::NodeShape;
						if (shape != null && shape.Diagram == currentDiagram)
						{
							targetShape = shape;
							break;
						}
					}
		
				}
			}
			
			return new DslDiagrams::NodeShape[] { sourceShape, targetShape };
		}
		
		/// <summary>
		/// Creates a new shape for the given model element as part of view fixup
		/// </summary>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Justification = "Generated code.")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling", Justification = "Generated code.")]
		protected override DslDiagrams::ShapeElement CreateChildShape(DslModeling::ModelElement element)
		{
			if(element is global::Castle.ActiveWriter.ModelClass)
			{
				global::Castle.ActiveWriter.ClassShape newShape = new global::Castle.ActiveWriter.ClassShape(Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			if(element is global::Castle.ActiveWriter.NestedClass)
			{
				global::Castle.ActiveWriter.NestedClassShape newShape = new global::Castle.ActiveWriter.NestedClassShape(Partition);
				if(newShape != null) newShape.Size = newShape.DefaultSize; // set default shape size
				return newShape;
			}
			if(element is global::Castle.ActiveWriter.ManyToOneRelation)
			{
				global::Castle.ActiveWriter.ManyToOneConnector newShape = new global::Castle.ActiveWriter.ManyToOneConnector(Partition);
				return newShape;
			}
			if(element is global::Castle.ActiveWriter.ManyToManyRelation)
			{
				global::Castle.ActiveWriter.ManyToManyConnector newShape = new global::Castle.ActiveWriter.ManyToManyConnector(Partition);
				return newShape;
			}
			if(element is global::Castle.ActiveWriter.OneToOneRelation)
			{
				global::Castle.ActiveWriter.OneToOneConnector newShape = new global::Castle.ActiveWriter.OneToOneConnector(Partition);
				return newShape;
			}
			if(element is global::Castle.ActiveWriter.NestedClassReferencesModelClasses)
			{
				global::Castle.ActiveWriter.NestedConnector newShape = new global::Castle.ActiveWriter.NestedConnector(Partition);
				return newShape;
			}
			if(element is global::Castle.ActiveWriter.InheritanceRelation)
			{
				global::Castle.ActiveWriter.InheritanceConnector newShape = new global::Castle.ActiveWriter.InheritanceConnector(Partition);
				return newShape;
			}
			return base.CreateChildShape(element);
		}
		#endregion
		#region Decorator mapping
		/// <summary>
		/// Initialize shape decorator mappings.  This is done here rather than in individual shapes because decorator maps
		/// are defined per diagram type rather than per shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
			global::Castle.ActiveWriter.ClassShape.DecoratorsInitialized += ClassShapeDecoratorMap.OnDecoratorsInitialized;
			global::Castle.ActiveWriter.NestedClassShape.DecoratorsInitialized += NestedClassShapeDecoratorMap.OnDecoratorsInitialized;
		}
		
		/// <summary>
		/// Class containing decorator path traversal methods for ClassShape.
		/// </summary>
		internal static partial class ClassShapeDecoratorMap
		{
			/// <summary>
			/// Event handler called when decorator initialization is complete for ClassShape.  Adds decorator mappings for this shape or connector.
			/// </summary>
			public static void OnDecoratorsInitialized(object sender, global::System.EventArgs e)
			{
				DslDiagrams::ShapeElement shape = (DslDiagrams::ShapeElement)sender;
				DslDiagrams::AssociatedPropertyInfo propertyInfo;
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::Castle.ActiveWriter.NamedElement.NameDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Name").AssociateValueWith(shape.Store, propertyInfo);
		
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::Castle.ActiveWriter.ModelClass.HasKeyPropertyDomainPropertyId);
				propertyInfo.FilteringValues.Add("True");
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Key").AssociateVisibilityWith(shape.Store, propertyInfo);
		
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::Castle.ActiveWriter.ModelClass.IsValidatorSetDomainPropertyId);
				propertyInfo.FilteringValues.Add("True");
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Validation").AssociateVisibilityWith(shape.Store, propertyInfo);
			}
		}
		
		/// <summary>
		/// Class containing decorator path traversal methods for NestedClassShape.
		/// </summary>
		internal static partial class NestedClassShapeDecoratorMap
		{
			/// <summary>
			/// Event handler called when decorator initialization is complete for NestedClassShape.  Adds decorator mappings for this shape or connector.
			/// </summary>
			public static void OnDecoratorsInitialized(object sender, global::System.EventArgs e)
			{
				DslDiagrams::ShapeElement shape = (DslDiagrams::ShapeElement)sender;
				DslDiagrams::AssociatedPropertyInfo propertyInfo;
				
				propertyInfo = new DslDiagrams::AssociatedPropertyInfo(global::Castle.ActiveWriter.NamedElement.NameDomainPropertyId);
				DslDiagrams::ShapeElement.FindDecorator(shape.Decorators, "Name").AssociateValueWith(shape.Store, propertyInfo);
			}
		}
		
		#endregion
		
		#region Connect actions
		private bool changingMouseAction;
		private global::Castle.ActiveWriter.ManyToOneRelationshipConnectAction manyToOneRelationshipConnectAction;
		private global::Castle.ActiveWriter.ManyToManyRelationshipConnectAction manyToManyRelationshipConnectAction;
		private global::Castle.ActiveWriter.OneToOneRelationshipConnectAction oneToOneRelationshipConnectAction;
		private global::Castle.ActiveWriter.NestedRelationshipConnectAction nestedRelationshipConnectAction;
		private global::Castle.ActiveWriter.InheritanceRelationshipConnectAction inheritanceRelationshipConnectAction;
		/// <summary>
		/// Virtual method to provide a filter when to select the mouse action
		/// </summary>
		/// <param name="activeView">Currently active view</param>
		/// <param name="filter">filter string used to filter the toolbox items</param>
		protected virtual bool SelectedToolboxItemSupportsFilterString(DslDiagrams::DiagramView activeView, string filter)
		{
			return activeView.SelectedToolboxItemSupportsFilterString(filter);
		}
		/// <summary>
		/// Override to provide the right mouse action when trying
		/// to create links on the diagram
		/// </summary>
		/// <param name="pointArgs"></param>
		public override void OnViewMouseEnter(DslDiagrams::DiagramPointEventArgs pointArgs)
		{
			if (pointArgs  == null) throw new global::System.ArgumentNullException("pointArgs");
		
			DslDiagrams::DiagramView activeView = ActiveDiagramView;
			if(activeView != null)
			{
				DslDiagrams::MouseAction action = null;
				if (SelectedToolboxItemSupportsFilterString(activeView, global::Castle.ActiveWriter.ActiveWriterToolboxHelper.ManyToOneRelationshipFilterString))
				{
					if (manyToOneRelationshipConnectAction == null)
					{
						manyToOneRelationshipConnectAction = new global::Castle.ActiveWriter.ManyToOneRelationshipConnectAction(this);
						manyToOneRelationshipConnectAction.MouseActionDeactivated += new DslDiagrams::MouseAction.MouseActionDeactivatedEventHandler(OnConnectActionDeactivated);
					}
					action = manyToOneRelationshipConnectAction;
				} 
				else if (SelectedToolboxItemSupportsFilterString(activeView, global::Castle.ActiveWriter.ActiveWriterToolboxHelper.ManyToManyRelationshipFilterString))
				{
					if (manyToManyRelationshipConnectAction == null)
					{
						manyToManyRelationshipConnectAction = new global::Castle.ActiveWriter.ManyToManyRelationshipConnectAction(this);
						manyToManyRelationshipConnectAction.MouseActionDeactivated += new DslDiagrams::MouseAction.MouseActionDeactivatedEventHandler(OnConnectActionDeactivated);
					}
					action = manyToManyRelationshipConnectAction;
				} 
				else if (SelectedToolboxItemSupportsFilterString(activeView, global::Castle.ActiveWriter.ActiveWriterToolboxHelper.OneToOneRelationshipFilterString))
				{
					if (oneToOneRelationshipConnectAction == null)
					{
						oneToOneRelationshipConnectAction = new global::Castle.ActiveWriter.OneToOneRelationshipConnectAction(this);
						oneToOneRelationshipConnectAction.MouseActionDeactivated += new DslDiagrams::MouseAction.MouseActionDeactivatedEventHandler(OnConnectActionDeactivated);
					}
					action = oneToOneRelationshipConnectAction;
				} 
				else if (SelectedToolboxItemSupportsFilterString(activeView, global::Castle.ActiveWriter.ActiveWriterToolboxHelper.NestedRelationshipFilterString))
				{
					if (nestedRelationshipConnectAction == null)
					{
						nestedRelationshipConnectAction = new global::Castle.ActiveWriter.NestedRelationshipConnectAction(this);
						nestedRelationshipConnectAction.MouseActionDeactivated += new DslDiagrams::MouseAction.MouseActionDeactivatedEventHandler(OnConnectActionDeactivated);
					}
					action = nestedRelationshipConnectAction;
				} 
				else if (SelectedToolboxItemSupportsFilterString(activeView, global::Castle.ActiveWriter.ActiveWriterToolboxHelper.InheritanceRelationshipFilterString))
				{
					if (inheritanceRelationshipConnectAction == null)
					{
						inheritanceRelationshipConnectAction = new global::Castle.ActiveWriter.InheritanceRelationshipConnectAction(this);
						inheritanceRelationshipConnectAction.MouseActionDeactivated += new DslDiagrams::MouseAction.MouseActionDeactivatedEventHandler(OnConnectActionDeactivated);
					}
					action = inheritanceRelationshipConnectAction;
				} 
				else
				{
					action = null;
				}
				
				if (pointArgs.DiagramClientView.ActiveMouseAction != action)
				{
					try
					{
						changingMouseAction = true;
						pointArgs.DiagramClientView.ActiveMouseAction = action;
					}
					finally
					{
						changingMouseAction = false;
					}
				}
			}
		}
		
		/// <summary>
		/// Snap toolbox selection back to regular pointer after using a custom connect action.
		/// </summary>
		private void OnConnectActionDeactivated(object sender, DslDiagrams::DiagramEventArgs e)
		{
			OnMouseActionDeactivated();
		}
		
		/// <summary>
		/// Overridable method to manage the mouse deactivation. The default implementation snap stoolbox selection back to regular pointer 
		/// after using a custom connect action.
		/// </summary>
		protected virtual void OnMouseActionDeactivated()
		{
			DslDiagrams::DiagramView activeView = ActiveDiagramView;
		
			if (activeView != null && activeView.Toolbox != null)
			{
				// If we're not changing mouse action due to changing toolbox selection change,
				// reset toolbox selection.
				if (!changingMouseAction)
				{
					activeView.Toolbox.SelectedToolboxItemUsed();
				}
			}
		}
		#endregion
		
		/// <summary>
		/// Dispose of connect actions.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			try
			{
				if(disposing)
				{
					if(manyToOneRelationshipConnectAction != null)
					{
						manyToOneRelationshipConnectAction.Dispose();
						manyToOneRelationshipConnectAction = null;
					}
					if(manyToManyRelationshipConnectAction != null)
					{
						manyToManyRelationshipConnectAction.Dispose();
						manyToManyRelationshipConnectAction = null;
					}
					if(oneToOneRelationshipConnectAction != null)
					{
						oneToOneRelationshipConnectAction.Dispose();
						oneToOneRelationshipConnectAction = null;
					}
					if(nestedRelationshipConnectAction != null)
					{
						nestedRelationshipConnectAction.Dispose();
						nestedRelationshipConnectAction = null;
					}
					if(inheritanceRelationshipConnectAction != null)
					{
						inheritanceRelationshipConnectAction.Dispose();
						inheritanceRelationshipConnectAction = null;
					}
					UnsubscribeCompartmentItemsEvents();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		#region Constructors, domain class Id
	
		/// <summary>
		/// ActiveRecordMapping domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xd25f93b4, 0xc78e, 0x4d22, 0x9d, 0x48, 0xce, 0x49, 0x8e, 0x8c, 0x1e, 0x58);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ActiveRecordMapping(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public ActiveRecordMapping(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace Castle.ActiveWriter
{
	
		/// <summary>
		/// Double derived implementation for the rule that initiates view fixup when an element that has an associated shape is added to the model.
		/// This now enables the DSL author to everride the SkipFixUp() method 
		/// </summary>
		internal partial class FixUpDiagramBase : DslModeling::AddRule
		{
			protected virtual bool SkipFixup(DslModeling::ModelElement childElement)
			{
				return childElement.IsDeleted;
			}
		}
	
		/// <summary>
		/// Rule that initiates view fixup when an element that has an associated shape is added to the model. 
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ModelClass), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.NestedClass), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddShapeParentExistRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.NestedClassReferencesModelClasses), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.InheritanceRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.OneToOneRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ManyToOneRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ManyToManyRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		internal sealed partial class FixUpDiagram : FixUpDiagramBase
		{
			[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
			public override void ElementAdded(DslModeling::ElementAddedEventArgs e)
			{
				if(e == null) throw new global::System.ArgumentNullException("e");
			
				DslModeling::ModelElement childElement = e.ModelElement;
				if (SkipFixup(childElement))
					return;
				DslModeling::ModelElement parentElement;
				if(childElement is DslModeling::ElementLink)
				{
					parentElement = GetParentForRelationship((DslModeling::ElementLink)childElement);
				} else
				if(childElement is global::Castle.ActiveWriter.ModelClass)
				{
					parentElement = GetParentForModelClass((global::Castle.ActiveWriter.ModelClass)childElement);
				} else
				if(childElement is global::Castle.ActiveWriter.NestedClass)
				{
					parentElement = GetParentForNestedClass((global::Castle.ActiveWriter.NestedClass)childElement);
				} else
				{
					parentElement = null;
				}
				
				if(parentElement != null)
				{
					DslDiagrams::Diagram.FixUpDiagram(parentElement, childElement);
				}
			}
			public static global::Castle.ActiveWriter.Model GetParentForModelClass( global::Castle.ActiveWriter.ModelClass root )
			{
				// Segments 0 and 1
				global::Castle.ActiveWriter.Model result = root.Model;
				if ( result == null ) return null;
				return result;
			}
			public static global::Castle.ActiveWriter.Model GetParentForNestedClass( global::Castle.ActiveWriter.NestedClass root )
			{
				// Segments 0 and 1
				global::Castle.ActiveWriter.Model result = root.Model;
				if ( result == null ) return null;
				return result;
			}
			private static DslModeling::ModelElement GetParentForRelationship(DslModeling::ElementLink elementLink)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<DslModeling::ModelElement> linkedElements = elementLink.LinkedElements;
	
				if (linkedElements.Count == 2)
				{
					DslDiagrams::ShapeElement sourceShape = linkedElements[0] as DslDiagrams::ShapeElement;
					DslDiagrams::ShapeElement targetShape = linkedElements[1] as DslDiagrams::ShapeElement;
	
					if(sourceShape == null)
					{
						DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> presentationElements = DslDiagrams::PresentationViewsSubject.GetPresentation(linkedElements[0]);
						foreach (DslDiagrams::PresentationElement presentationElement in presentationElements)
						{
							DslDiagrams::ShapeElement shape = presentationElement as DslDiagrams::ShapeElement;
							if (shape != null)
							{
								sourceShape = shape;
								break;
							}
						}
					}
					
					if(targetShape == null)
					{
						DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> presentationElements = DslDiagrams::PresentationViewsSubject.GetPresentation(linkedElements[1]);
						foreach (DslDiagrams::PresentationElement presentationElement in presentationElements)
						{
							DslDiagrams::ShapeElement shape = presentationElement as DslDiagrams::ShapeElement;
							if (shape != null)
							{
								targetShape = shape;
								break;
							}
						}
					}
					
					if(sourceShape == null || targetShape == null)
					{
						global::System.Diagnostics.Debug.Fail("Unable to find source and/or target shape for view fixup.");
						return null;
					}
	
					DslDiagrams::ShapeElement sourceParent = sourceShape.ParentShape;
					DslDiagrams::ShapeElement targetParent = targetShape.ParentShape;
	
					while (sourceParent != targetParent && sourceParent != null)
					{
						DslDiagrams::ShapeElement curParent = targetParent;
						while (sourceParent != curParent && curParent != null)
						{
							curParent = curParent.ParentShape;
						}
	
						if(sourceParent == curParent)
						{
							break;
						}
						else
						{
							sourceParent = sourceParent.ParentShape;
						}
					}
	
					while (sourceParent != null)
					{
						// ensure that the parent can parent connectors (i.e., a diagram or a swimlane).
						if(sourceParent is DslDiagrams::Diagram || sourceParent is DslDiagrams::SwimlaneShape)
						{
							break;
						}
						else
						{
							sourceParent = sourceParent.ParentShape;
						}
					}
	
					global::System.Diagnostics.Debug.Assert(sourceParent != null && sourceParent.ModelElement != null, "Unable to find common parent for view fixup.");
					return sourceParent.ModelElement;
				}
	
				return null;
			}
		}
		
		/// <summary>
		/// Rule to update compartments when an item is added to the list
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ClassHasProperty), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.NestedClassHasProperties), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemAddRule : DslModeling::AddRule
		{
			/// <summary>
			/// Called when an element is added. 
			/// </summary>
			/// <param name="e"></param>
			public override void ElementAdded(DslModeling::ElementAddedEventArgs e)
			{
				ElementAdded(e, false);
			}
	
			internal static void ElementAdded(DslModeling::ElementAddedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if (e.ModelElement.IsDeleted)
					return;
				if(e.ModelElement is global::Castle.ActiveWriter.ClassHasProperty)
				{
					global::System.Collections.IEnumerable elements = GetModelClassForClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.ClassHasProperty)e.ModelElement);
					UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.ClassShape), "Properties", repaintOnly);
				}
				if(e.ModelElement is global::Castle.ActiveWriter.NestedClassHasProperties)
				{
					global::System.Collections.IEnumerable elements = GetNestedClassForNestedClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.NestedClassHasProperties)e.ModelElement);
					UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.NestedClassShape), "Properties", repaintOnly);
				}
			}
			
			#region static DomainPath traversal methods to get the list of compartments to update
			internal static global::System.Collections.ICollection GetModelClassForClassShapePropertiesFromLastLink(global::Castle.ActiveWriter.ClassHasProperty root)
			{
				// Segment 0
				global::Castle.ActiveWriter.ModelClass result = root.ModelClass;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			internal static global::System.Collections.ICollection GetModelClassForClassShapeProperties(global::Castle.ActiveWriter.ModelProperty root)
			{
				// Segments 1 and 0
				global::Castle.ActiveWriter.ModelClass result = root.ModelClass;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			internal static global::System.Collections.ICollection GetNestedClassForNestedClassShapePropertiesFromLastLink(global::Castle.ActiveWriter.NestedClassHasProperties root)
			{
				// Segment 0
				global::Castle.ActiveWriter.NestedClass result = root.NestedClass;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			internal static global::System.Collections.ICollection GetNestedClassForNestedClassShapeProperties(global::Castle.ActiveWriter.ModelProperty root)
			{
				// Segments 1 and 0
				global::Castle.ActiveWriter.NestedClass result = root.NestedClass;
				if ( result == null ) return new DslModeling::ModelElement[0];
				return new DslModeling::ModelElement[] {result};
			}
			#endregion
	
			#region helper method to update compartments 
			/// <summary>
			/// Updates the compartments for the shapes associated to the given list of model elements
			/// </summary>
			/// <param name="elements">List of model elements</param>
			/// <param name="shapeType">The type of shape that needs updating</param>
			/// <param name="compartmentName">The name of the compartment to update</param>
			/// <param name="repaintOnly">If true, the method will only invalidate the shape for a repaint, without re-initializing the shape.</param>
			internal static void UpdateCompartments(global::System.Collections.IEnumerable elements, global::System.Type shapeType, string compartmentName, bool repaintOnly)
			{
				foreach (DslModeling::ModelElement element in elements)
				{
					DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> pels = DslDiagrams::PresentationViewsSubject.GetPresentation(element);
					foreach (DslDiagrams::PresentationElement pel in pels)
					{
						DslDiagrams::CompartmentShape compartmentShape = pel as DslDiagrams::CompartmentShape;
						if (compartmentShape != null && shapeType.IsAssignableFrom(compartmentShape.GetType()))
						{
							if (repaintOnly)
							{
								compartmentShape.Invalidate();
							}
							else
							{
								foreach(DslDiagrams::CompartmentMapping mapping in compartmentShape.GetCompartmentMappings())
								{
									if(mapping.CompartmentId==compartmentName)
									{
										mapping.InitializeCompartmentShape(compartmentShape);
										break;
									}
								}
							}
						}
					}
				}
			}
			#endregion
		}
		
		/// <summary>
		/// Rule to update compartments when an items is removed from the list
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ClassHasProperty), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.NestedClassHasProperties), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemDeleteRule : DslModeling::DeleteRule
		{
			/// <summary>
			/// Called when an element is deleted
			/// </summary>
			/// <param name="e"></param>
			public override void ElementDeleted(DslModeling::ElementDeletedEventArgs e)
			{
				ElementDeleted(e, false);
			}
			
			internal static void ElementDeleted(DslModeling::ElementDeletedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(e.ModelElement is global::Castle.ActiveWriter.ClassHasProperty)
				{
					global::System.Collections.ICollection elements = CompartmentItemAddRule.GetModelClassForClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.ClassHasProperty)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.ClassShape), "Properties", repaintOnly);
				}
				if(e.ModelElement is global::Castle.ActiveWriter.NestedClassHasProperties)
				{
					global::System.Collections.ICollection elements = CompartmentItemAddRule.GetNestedClassForNestedClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.NestedClassHasProperties)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.NestedClassShape), "Properties", repaintOnly);
				}
			}
		}
		
		/// <summary>
		/// Rule to update compartments when the property on an item being displayed changes.
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ModelProperty), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemChangeRule : DslModeling::ChangeRule 
		{
			/// <summary>
			/// Called when an element is changed
			/// </summary>
			/// <param name="e"></param>
			public override void ElementPropertyChanged(DslModeling::ElementPropertyChangedEventArgs e)
			{
				ElementPropertyChanged(e, false);
			}
			
			internal static void ElementPropertyChanged(DslModeling::ElementPropertyChangedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(e.ModelElement is global::Castle.ActiveWriter.ModelProperty && e.DomainProperty.Id == global::Castle.ActiveWriter.ModelProperty.NameDomainPropertyId)
				{
					global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetModelClassForClassShapeProperties((global::Castle.ActiveWriter.ModelProperty)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.ClassShape), "Properties", repaintOnly);
				}
				if(e.ModelElement is global::Castle.ActiveWriter.ModelProperty && e.DomainProperty.Id == global::Castle.ActiveWriter.ModelProperty.NameDomainPropertyId)
				{
					global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetNestedClassForNestedClassShapeProperties((global::Castle.ActiveWriter.ModelProperty)e.ModelElement);
					CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.NestedClassShape), "Properties", repaintOnly);
				}
			}
		}
		
		/// <summary>
		/// Rule to update compartments when a roleplayer change happens
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ClassHasProperty), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.NestedClassHasProperties), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemRolePlayerChangeRule : DslModeling::RolePlayerChangeRule 
		{
			/// <summary>
			/// Called when the roleplayer on a link changes.
			/// </summary>
			/// <param name="e"></param>
			public override void RolePlayerChanged(DslModeling::RolePlayerChangedEventArgs e)
			{
				RolePlayerChanged(e, false);
			}
			
			internal static void RolePlayerChanged(DslModeling::RolePlayerChangedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(typeof(global::Castle.ActiveWriter.ClassHasProperty).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(e.DomainRole.IsSource)
					{
						//global::System.Collections.IEnumerable oldElements = CompartmentItemAddRule.GetModelClassForClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.ModelProperty)e.OldRolePlayer);
						//foreach(DslModeling::ModelElement element in oldElements)
						//{
						//	DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> pels = DslDiagrams::PresentationViewsSubject.GetPresentation(element);
						//	foreach(DslDiagrams::PresentationElement pel in pels)
						//	{
						//		global::Castle.ActiveWriter.ClassShape compartmentShape = pel as global::Castle.ActiveWriter.ClassShape;
						//		if(compartmentShape != null)
						//		{
						//			compartmentShape.GetCompartmentMappings()[0].InitializeCompartmentShape(compartmentShape);
						//		}
						//	}
						//}
						
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetModelClassForClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.ClassHasProperty)e.ElementLink);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.ClassShape), "Properties", repaintOnly);
					}
					else 
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetModelClassForClassShapeProperties((global::Castle.ActiveWriter.ModelProperty)e.NewRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.ClassShape), "Properties", repaintOnly);
					}
				}
				if(typeof(global::Castle.ActiveWriter.NestedClassHasProperties).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(e.DomainRole.IsSource)
					{
						//global::System.Collections.IEnumerable oldElements = CompartmentItemAddRule.GetNestedClassForNestedClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.ModelProperty)e.OldRolePlayer);
						//foreach(DslModeling::ModelElement element in oldElements)
						//{
						//	DslModeling::LinkedElementCollection<DslDiagrams::PresentationElement> pels = DslDiagrams::PresentationViewsSubject.GetPresentation(element);
						//	foreach(DslDiagrams::PresentationElement pel in pels)
						//	{
						//		global::Castle.ActiveWriter.NestedClassShape compartmentShape = pel as global::Castle.ActiveWriter.NestedClassShape;
						//		if(compartmentShape != null)
						//		{
						//			compartmentShape.GetCompartmentMappings()[0].InitializeCompartmentShape(compartmentShape);
						//		}
						//	}
						//}
						
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetNestedClassForNestedClassShapePropertiesFromLastLink((global::Castle.ActiveWriter.NestedClassHasProperties)e.ElementLink);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.NestedClassShape), "Properties", repaintOnly);
					}
					else 
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetNestedClassForNestedClassShapeProperties((global::Castle.ActiveWriter.ModelProperty)e.NewRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.NestedClassShape), "Properties", repaintOnly);
					}
				}
			}
		}
	
		/// <summary>
		/// Rule to update compartments when the order of items in the list changes.
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ClassHasProperty), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.NestedClassHasProperties), FireTime=DslModeling::TimeToFire.TopLevelCommit, InitiallyDisabled=true)]
		internal sealed class CompartmentItemRolePlayerPositionChangeRule : DslModeling::RolePlayerPositionChangeRule 
		{
			/// <summary>
			/// Called when the order of a roleplayer in a relationship changes
			/// </summary>
			/// <param name="e"></param>
			public override void RolePlayerPositionChanged(DslModeling::RolePlayerOrderChangedEventArgs e)
			{
				RolePlayerPositionChanged(e, false);
			}
			
			internal static void RolePlayerPositionChanged(DslModeling::RolePlayerOrderChangedEventArgs e, bool repaintOnly)
			{
				if(e==null) throw new global::System.ArgumentNullException("e");
				if(typeof(global::Castle.ActiveWriter.ClassHasProperty).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(!e.CounterpartDomainRole.IsSource)
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetModelClassForClassShapeProperties((global::Castle.ActiveWriter.ModelProperty)e.CounterpartRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.ClassShape), "Properties", repaintOnly);
					}
				}
				if(typeof(global::Castle.ActiveWriter.NestedClassHasProperties).IsAssignableFrom(e.DomainRelationship.ImplementationClass))
				{
					if(!e.CounterpartDomainRole.IsSource)
					{
						global::System.Collections.IEnumerable elements = CompartmentItemAddRule.GetNestedClassForNestedClassShapeProperties((global::Castle.ActiveWriter.ModelProperty)e.CounterpartRolePlayer);
						CompartmentItemAddRule.UpdateCompartments(elements, typeof(global::Castle.ActiveWriter.NestedClassShape), "Properties", repaintOnly);
					}
				}
			}
		}
	
		/// <summary>
		/// Reroute a connector when the role players of its underlying relationship change
		/// </summary>
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ManyToOneRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.ManyToManyRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.OneToOneRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.NestedClassReferencesModelClasses), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		[DslModeling::RuleOn(typeof(global::Castle.ActiveWriter.InheritanceRelation), FireTime = DslModeling::TimeToFire.TopLevelCommit, Priority = DslDiagrams::DiagramFixupConstants.AddConnectionRulePriority, InitiallyDisabled=true)]
		internal sealed class ConnectorRolePlayerChanged : DslModeling::RolePlayerChangeRule
		{
			/// <summary>
			/// Reroute a connector when the role players of its underlying relationship change
			/// </summary>
			public override void RolePlayerChanged(DslModeling::RolePlayerChangedEventArgs e)
			{
				if (e == null) throw new global::System.ArgumentNullException("e");
	
				global::System.Collections.ObjectModel.ReadOnlyCollection<DslDiagrams::PresentationViewsSubject> connectorLinks = DslDiagrams::PresentationViewsSubject.GetLinksToPresentation(e.ElementLink);
				foreach (DslDiagrams::PresentationViewsSubject connectorLink in connectorLinks)
				{
					// Fix up any binary link shapes attached to the element link.
					DslDiagrams::BinaryLinkShape linkShape = connectorLink.Presentation as DslDiagrams::BinaryLinkShape;
					if (linkShape != null)
					{
						global::Castle.ActiveWriter.ActiveRecordMapping diagram = linkShape.Diagram as global::Castle.ActiveWriter.ActiveRecordMapping;
						if (diagram != null)
						{
							if (e.NewRolePlayer != null)
							{
								DslDiagrams::NodeShape fromShape;
								DslDiagrams::NodeShape toShape;
								diagram.GetSourceAndTargetForConnector(linkShape, out fromShape, out toShape);
								if (fromShape != null && toShape != null)
								{
									if (!object.Equals(fromShape, linkShape.FromShape))
									{
										linkShape.FromShape = fromShape;
									}
									if (!object.Equals(linkShape.ToShape, toShape))
									{
										linkShape.ToShape = toShape;
									}
								}
								else
								{
									// delete the connector if we cannot find an appropriate target shape.
									linkShape.Delete();
								}
							}
							else
							{
								// delete the connector if the new role player is null.
								linkShape.Delete();
							}
						}
					}
				}
			}
		}
	}

//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using System;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.FSharp;
namespace JetBrains.ReSharper.Psi.FSharp.Impl.Tree {
  internal abstract partial class TypeDefinitionStub : JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpCompositeElement, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDefinitionNode, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDefinition {
    public const short FSHARP_TYPE= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_TYPE;
    public const short TYPE_DECLARATION= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.LAST + 2;
    public const short FSHARP_AND= JetBrains.ReSharper.Psi.FSharp.Impl.Tree.FSharpChildRole.FSHARP_AND;
    public TypeDefinitionStub() : base() {
    }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType {
      get { return JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_DEFINITION; }
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.ElementVisitor visitor) {
      visitor.VisitTypeDefinition(this);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.ElementVisitor<TContext,TReturn> visitor, TContext context) {
      return visitor.VisitTypeDefinition(this, context);
    }
    public override void Accept(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor visitor) {
      visitor.VisitTypeDefinitionNode(this);
    }
    public override void Accept<TContext>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext> visitor, TContext context) {
      visitor.VisitTypeDefinitionNode(this, context);
    }
    public override TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.FSharp.TreeNodeVisitor<TContext, TReturn> visitor, TContext context) {
      return visitor.VisitTypeDefinitionNode(this, context);
    }
    private static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short> CHILD_ROLES = new JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeDictionary<short>(
      new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>[]
      {
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_TYPE, FSHARP_TYPE),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.ElementType.TYPE_DECLARATION, TYPE_DECLARATION),
        new System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType, short>(JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_AND, FSHARP_AND),
      }
    );
    public override short GetChildRole (JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) {
      return CHILD_ROLES[child.NodeType];
    }
    public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.ITokenNode> AndKeyword {
      get { return FindListOfChildrenByRole<JetBrains.ReSharper.Psi.ITokenNode>(FSHARP_AND); }
    }
    public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration> TypeDeclarations {
      get { return FindListOfChildrenByRole<JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration>(TYPE_DECLARATION); }
    }
    public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode> TypeDeclarationsNode {
      get { return FindListOfChildrenByRole<JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode>(TYPE_DECLARATION); }
    }
    public virtual JetBrains.ReSharper.Psi.ITokenNode TypeKeyword {
      get { return (JetBrains.ReSharper.Psi.ITokenNode) FindChildByRole(FSHARP_TYPE); }
    }
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration AddTypeDeclarationBefore (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration param, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration anchor)
    {
      throw new NotImplementedException ("AddTypeDeclarationBefore");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddBefore = null;
        $rule
        return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration)result;
      }
    }
    */
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode AddTypeDeclarationsNodeBefore (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode param, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode anchor)
    {
      throw new NotImplementedException ("AddTypeDeclarationsNodeBefore");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddBefore = null;
        $rule
        return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode)result;
      }
    }
    */
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration AddTypeDeclarationAfter (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration param, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration anchor)
    {
      throw new NotImplementedException ("AddTypeDeclarationAfter");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddAfter = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration)result;
        } else {
          current = next;
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration)result;
        } else {
          current = next;
        }
        while (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_AND) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration)result;
          } else {
            current = next;
          }
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration)result;
          } else {
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration)result;
      }
    }
    */
    /*
    public virtual JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode AddTypeDeclarationsNodeAfter (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode param, JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode anchor)
    {
      throw new NotImplementedException ("AddTypeDeclarationsNodeAfter");
      using (Shell.WriteLockCookie.Create ())
      {
        TreeElement current = null, next, result = null;
        TreeElement childToAddAfter = null;
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode)result;
        } else {
          current = next;
        }
        next = GetNextFilteredChild (current);
        if (next == null) {
          return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode)result;
        } else {
          current = next;
        }
        while (current.NodeType == JetBrains.ReSharper.Psi.FSharp.Impl.Tree.TokenType.KEYWORD_AND) {
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode)result;
          } else {
            current = next;
          }
          next = GetNextFilteredChild (current);
          if (next == null) {
            return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode)result;
          } else {
            current = next;
          }
        }
        return (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode)result;
      }
    }
    */
    /*
    public virtual void RemoveTypeDeclaration (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclaration param)
    {
      throw new NotImplementedException ("RemoveTypeDeclaration");
    }
    */
    /*
    public virtual void RemoveTypeDeclarationsNode (JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDeclarationNode param)
    {
      throw new NotImplementedException ("RemoveTypeDeclarationsNode");
    }
    */
    JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDefinitionNode JetBrains.ReSharper.Psi.FSharp.Tree.ITypeDefinition.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IDefinitionNode JetBrains.ReSharper.Psi.FSharp.Tree.IDefinition.ToTreeNode() { return this; }
    JetBrains.ReSharper.Psi.FSharp.ISpecificationNode JetBrains.ReSharper.Psi.FSharp.ISpecification.ToTreeNode() { return this; }
    public override string ToString() {
      return "ITypeDefinition";
    }
  }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.FSharp {
  public partial interface ICreationWithOverridingMethodsExpressionNode : JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode,JetBrains.ReSharper.Psi.FSharp.ICreationWithOverridingMethodsExpression {
    JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.ITokenNode> AndKeyword { get; }
    JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode> BindingSchemesNode { get; }
    JetBrains.ReSharper.Psi.FSharp.ICreationExpressionNode CreationExpressionNode { get; }
    JetBrains.ReSharper.Psi.ITokenNode LBrace { get; }
    JetBrains.ReSharper.Psi.ITokenNode RBrace { get; }
    JetBrains.ReSharper.Psi.ITokenNode WithKeyword { get; }
    JetBrains.ReSharper.Psi.FSharp.ICreationExpressionNode SetCreationExpressionNode (JetBrains.ReSharper.Psi.FSharp.ICreationExpressionNode param);
    JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode AddBindingSchemesNodeBefore (JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode param, JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode anchor);
    JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode AddBindingSchemesNodeAfter (JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode param, JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode anchor);
    void RemoveBindingSchemesNode (JetBrains.ReSharper.Psi.FSharp.IBindingSchemeNode param);
  }
}
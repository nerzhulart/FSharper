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
  public partial interface IMultipleMatchingNode : JetBrains.ReSharper.Psi.FSharp.Tree.IFSharpTreeNode,JetBrains.ReSharper.Psi.FSharp.Tree.IMultipleMatching {
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode ConditionNode { get; }
    JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode> ParametersNode { get; }
    JetBrains.ReSharper.Psi.ITokenNode RArrow { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode TargetNode { get; }
    JetBrains.ReSharper.Psi.ITokenNode WhenKeyword { get; }
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetConditionNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode SetTargetNode (JetBrains.ReSharper.Psi.FSharp.Tree.IExpressionNode param);
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode AddParametersNodeBefore (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param, JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode anchor);
    JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode AddParametersNodeAfter (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param, JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode anchor);
    void RemoveParametersNode (JetBrains.ReSharper.Psi.FSharp.Tree.IPatternNode param);
  }
}
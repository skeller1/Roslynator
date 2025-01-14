# SyntaxExtensions\.ToSeparatedSyntaxList Method

[Home](../../../../README.md)

**Containing Type**: [SyntaxExtensions](../README.md)

**Assembly**: Roslynator\.CSharp\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ToSeparatedSyntaxList\<TNode\>(IEnumerable\<SyntaxNodeOrToken\>)](#3594200340) | Creates a separated list of syntax nodes from a sequence of nodes and tokens\. |
| [ToSeparatedSyntaxList\<TNode\>(IEnumerable\<TNode\>)](#2814099200) | Creates a separated list of syntax nodes from a sequence of nodes\. |

<a id="3594200340"></a>

## ToSeparatedSyntaxList\<TNode\>\(IEnumerable\<SyntaxNodeOrToken\>\) 

  
Creates a separated list of syntax nodes from a sequence of nodes and tokens\.

```csharp
public static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> ToSeparatedSyntaxList<TNode>(this System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNodeOrToken> nodesAndTokens) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**nodesAndTokens** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SyntaxNodeOrToken](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxnodeortoken)\>

### Returns

[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode\>

<a id="2814099200"></a>

## ToSeparatedSyntaxList\<TNode\>\(IEnumerable\<TNode\>\) 

  
Creates a separated list of syntax nodes from a sequence of nodes\.

```csharp
public static Microsoft.CodeAnalysis.SeparatedSyntaxList<TNode> ToSeparatedSyntaxList<TNode>(this System.Collections.Generic.IEnumerable<TNode> nodes) where TNode : Microsoft.CodeAnalysis.SyntaxNode
```

### Type Parameters

**TNode**

### Parameters

**nodes** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<TNode\>

### Returns

[SeparatedSyntaxList](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.separatedsyntaxlist-1)\<TNode\>


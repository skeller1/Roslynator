# WorkspaceExtensions\.ReplaceTriviaAsync Method

[Home](../../../README.md)

**Containing Type**: [WorkspaceExtensions](../README.md)

**Assembly**: Roslynator\.Workspaces\.Core\.dll

## Overloads

| Method | Summary |
| ------ | ------- |
| [ReplaceTriviaAsync(Document, SyntaxTrivia, IEnumerable\<SyntaxTrivia\>, CancellationToken)](#3069294243) | Creates a new document with the specified old trivia replaced with a new trivia\. |
| [ReplaceTriviaAsync(Document, SyntaxTrivia, SyntaxTrivia, CancellationToken)](#4172355089) | Creates a new document with the specified old trivia replaced with a new trivia\. |

<a id="3069294243"></a>

## ReplaceTriviaAsync\(Document, SyntaxTrivia, IEnumerable\<SyntaxTrivia\>, CancellationToken\) 

  
Creates a new document with the specified old trivia replaced with a new trivia\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> ReplaceTriviaAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxTrivia oldTrivia, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTrivia> newTrivia, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &ensp; [Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**oldTrivia** &ensp; [SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**newTrivia** &ensp; [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)\<[SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)\>

**cancellationToken** &ensp; [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)\>

<a id="4172355089"></a>

## ReplaceTriviaAsync\(Document, SyntaxTrivia, SyntaxTrivia, CancellationToken\) 

  
Creates a new document with the specified old trivia replaced with a new trivia\.

```csharp
public static System.Threading.Tasks.Task<Microsoft.CodeAnalysis.Document> ReplaceTriviaAsync(this Microsoft.CodeAnalysis.Document document, Microsoft.CodeAnalysis.SyntaxTrivia oldTrivia, Microsoft.CodeAnalysis.SyntaxTrivia newTrivia, System.Threading.CancellationToken cancellationToken = default)
```

### Parameters

**document** &ensp; [Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)

**oldTrivia** &ensp; [SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**newTrivia** &ensp; [SyntaxTrivia](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.syntaxtrivia)

**cancellationToken** &ensp; [CancellationToken](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)

### Returns

[Task](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)\<[Document](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.document)\>


﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using Roslynator.CSharp.Refactorings;

namespace Roslynator.CSharp.DiagnosticAnalyzers
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class ConditionalExpressionDiagnosticAnalyzer : BaseDiagnosticAnalyzer
    {
        public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
        {
            get
            {
                return ImmutableArray.Create(
                    DiagnosticDescriptors.ParenthesizeConditionInConditionalExpression,
                    DiagnosticDescriptors.UseCoalesceExpressionInsteadOfConditionalExpression,
                    DiagnosticDescriptors.SimplifyConditionalExpression);
            }
        }

        public override void Initialize(AnalysisContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.RegisterSyntaxNodeAction(f => AnalyzeConditionalExpression(f), SyntaxKind.ConditionalExpression);
        }

        private void AnalyzeConditionalExpression(SyntaxNodeAnalysisContext context)
        {
            if (GeneratedCodeAnalyzer?.IsGeneratedCode(context) == true)
                return;

            var conditionalExpression = (ConditionalExpressionSyntax)context.Node;

            ParenthesizeConditionInConditionalExpressionRefactoring.Analyze(context, conditionalExpression);

            UseCoalesceExpressionInsteadOfConditionalExpressionRefactoring.Analyze(context, conditionalExpression);

            SimplifyConditionalExpressionRefactoring.Analyze(context, conditionalExpression);
        }
    }
}

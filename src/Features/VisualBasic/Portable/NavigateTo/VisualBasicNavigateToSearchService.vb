﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Composition
Imports Microsoft.CodeAnalysis.Host.Mef
Imports Microsoft.CodeAnalysis.NavigateTo

Namespace Microsoft.CodeAnalysis.VisualBasic.NavigateTo
    <ExportLanguageService(GetType(INavigateToSearchService_RemoveInterfaceAboveAndRenameThisAfterInternalsVisibleToUsersUpdate), LanguageNames.VisualBasic), [Shared]>
    Friend Class VisualBasicNavigateToSearchService
        Inherits AbstractNavigateToSearchService

        <ImportingConstructor>
        Public Sub New()
        End Sub
    End Class
End Namespace

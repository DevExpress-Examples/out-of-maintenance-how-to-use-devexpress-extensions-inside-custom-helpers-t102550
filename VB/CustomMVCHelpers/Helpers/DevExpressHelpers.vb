Imports Microsoft.VisualBasic
Imports DevExpress.Web.Mvc
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web.Mvc

Namespace CustomMVCHelpers.Helpers
	Public Module DevExpressHelpers             
        <System.Runtime.CompilerServices.Extension> _
        Public Function GridHelper(ByVal helper As HtmlHelper, ByVal name As String, ByVal ModelType As Type, ByVal ControllerName As String) As MvcHtmlString

            Dim PropertiesArray = ModelType.GetProperties()
            Dim g = New GridViewSettings() With {.Name = name, .KeyFieldName = PropertiesArray.Where(Function(pr) pr.GetCustomAttributes(GetType(KeyAttribute), True) IsNot Nothing).FirstOrDefault().Name, .CallbackRouteValues = New With {Key .Controller = ControllerName, Key .Action = name & "Partial"}}
            g.CommandColumn.Visible = False
            ' for demonstration purposes
            g.SettingsEditing.UpdateRowRouteValues = New With {Key .Controller = ControllerName, Key .Action = name & "UpdatePartial"}
            g.SettingsEditing.DeleteRowRouteValues = New With {Key .Controller = ControllerName, Key .Action = name & "DeletePartial"}
            g.SettingsEditing.AddNewRowRouteValues = New With {Key .Controller = ControllerName, Key .Action = name & "InsertPartial"}
            g.Settings.ShowFilterRow = True
            g.Settings.ShowGroupPanel = True
            For Each item In PropertiesArray
                Dim c = g.Columns.Add(item.Name)
                If c.FieldName = g.KeyFieldName Then
                    c.EditFormSettings.Visible = DevExpress.Utils.DefaultBoolean.False
                End If
            Next item
            CType(New GridViewExtension(g, helper.ViewContext), GridViewExtension).Bind(helper.ViewData.Model).Render()

            Return MvcHtmlString.Empty
        End Function
		
		
	End Module
End Namespace

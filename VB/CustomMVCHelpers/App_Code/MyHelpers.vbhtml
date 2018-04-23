@Imports DevExpress.Web.Mvc
@Imports System.Web.Mvc
@Imports System.Web.Mvc.Html
@Imports DevExpress.Web.Mvc.UI

@Helper LayoutHelper (ByVal container As DevExpress.Web.ASPxGridView.GridViewDataItemTemplateContainer)        
    @<table class="templateTable">
        <tr>
            <td>@Code
                Dim outputStringBuilder = New System.Text.StringBuilder()
                Dim ls As New LabelSettings()
                ls.Name = "Label" & container.VisibleIndex
                Dim value As Boolean = CBool(DataBinder.Eval(container.DataItem, "ModelState"))
                ls.Text = value.ToString()

                Using writer = New StringWriter(outputStringBuilder)
                    Dim viewContext = New ViewContext With {.Writer = writer}
                    Dim Extension = New LabelExtension(ls, viewContext)

                    Extension.Render()
				@(New MvcHtmlString(outputStringBuilder.ToString()))
                End Using
            End Code</td>
            <td>
                @CODE                     
                    outputStringBuilder = New System.Text.StringBuilder()
                    Dim im As New ImageEditSettings()

                    im.Name = "im" & container.VisibleIndex
                    im.Properties.EmptyImage.IconID = If(value = True, "actions_apply_16x16", "actions_cancel_16x16")
                    im.Properties.ImageAlign = System.Web.UI.WebControls.ImageAlign.Bottom

                    Using writer = New StringWriter(outputStringBuilder)
                        Dim viewContext = New ViewContext With {.Writer = writer}
                        Dim imageExtension = New ImageEditExtension(im, viewContext)

                        imageExtension.Render()
					@(New MvcHtmlString(outputStringBuilder.ToString()))
                    End Using
                END CODE
            </td>
        </tr>
    </table> 
End Helper

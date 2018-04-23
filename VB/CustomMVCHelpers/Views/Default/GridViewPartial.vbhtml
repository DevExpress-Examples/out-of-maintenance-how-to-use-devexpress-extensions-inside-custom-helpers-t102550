@CODE
    ViewBag.Title = "GridViewPartial"
END CODE
@Html.DevExpress().GridView(Sub(settings)
                                settings.Name = "grid"
                                settings.CallbackRouteValues = New With {Key .Action = "GridViewPartial", Key .Controller = "Default"}
 
                                settings.Columns.Add("ModelID")
                                settings.Columns.Add("ModelName")
                                settings.Columns.Add("ModelDate")
                                settings.Columns.Add(Sub(column)
                                                         column.FieldName = "ModelState"
                                                         column.ColumnType = MVCxGridViewColumnType.CheckBox
                                                         column.SetDataItemTemplateContent(Sub(content)
                                                                                               ViewContext.Writer.Write(MyHelpers.LayoutHelper(content).ToHtmlString())
                                                                                           End Sub)
                                                     End Sub)
                            End Sub).Bind(Model).GetHtml()
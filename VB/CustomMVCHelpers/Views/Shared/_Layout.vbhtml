<!DOCTYPE html>

<html>
<head>
    <title>@ViewBag.Title</title>

    <script src="@Url.Content("~/Scripts/jquery-1.6.2.min.js")" type="text/javascript"></script>
    @Html.DevExpress().GetStyleSheets(New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors}, 
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView})


    @Html.DevExpress().GetScripts(New Script With {.ExtensionSuite = ExtensionSuite.GridView}, 
      New Script With {.ExtensionSuite = ExtensionSuite.Editors})
</head>

<body>
    @RenderBody()
</body>
</html>

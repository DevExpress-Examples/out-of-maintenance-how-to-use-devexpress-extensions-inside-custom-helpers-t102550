@CODE
    ViewBag.Title = "GridViewPartial"
End Code

@Imports MVCxGridViewDataBinding.Models

@Html.GridHelper("GridView", GetType(MyModel), "Home")
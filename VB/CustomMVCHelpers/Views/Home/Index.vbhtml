@Code
    ViewBag.Title = "How to use DevExpress extensions inside custom helpers"
End Code
<style>
    .templateTable {
        border-collapse: collapse;
        width: 100%;
    }
        .templateTable  td {
            border: solid 1px #C2D4DA;
            padding: 6px;
            text-align: center;
        }
</style>
<div style='background-color:yellow'>
    <h2>GridView created in a static helper:</h2>
@Html.Action("GridViewPartial")
</div>
<h2>GridView with DataItemTemplate created in a razor helper:</h2>

@Html.Action("GridViewPartial", "Default")


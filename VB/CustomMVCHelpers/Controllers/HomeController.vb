Imports Microsoft.VisualBasic
Imports MVCxGridViewDataBinding.Models
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Mvc

Namespace CustomMVCHelpers.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function GridViewPartial() As ActionResult
			Dim model = MyModel.GetModelList()
			Return PartialView(model)
        End Function
	End Class
End Namespace

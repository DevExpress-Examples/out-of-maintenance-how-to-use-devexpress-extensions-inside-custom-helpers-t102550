Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace CustomMVCHelpers
	Public Class MvcApplication
		Inherits System.Web.HttpApplication
		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()

			WebApiConfig.Register(GlobalConfiguration.Configuration)
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
			RouteConfig.RegisterRoutes(RouteTable.Routes)
			AuthConfig.RegisterAuth()
			ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()
		End Sub
	End Class
End Namespace

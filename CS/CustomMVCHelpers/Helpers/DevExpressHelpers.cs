using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace CustomMVCHelpers.Helpers
{
    public static class DevExpressHelpers
    {
        public static MvcHtmlString GridHelper(this HtmlHelper helper, string name, Type ModelType, string ControllerName)
        {
           
            var PropertiesArray = ModelType.GetProperties();
            var g = new GridViewSettings()
            { Name = name,
                KeyFieldName = PropertiesArray.Where(pr => pr.GetCustomAttributes(typeof(KeyAttribute), true) != null).FirstOrDefault().Name,
                CallbackRouteValues = new
            { Controller = ControllerName, Action = name + "Partial" } };
            // for demonstration purposes
            g.CommandColumn.Visible = false;          
            g.SettingsEditing.UpdateRowRouteValues = new
            { Controller = ControllerName, Action = name + "UpdatePartial" };
            g.SettingsEditing.DeleteRowRouteValues = new
            { Controller = ControllerName, Action = name + "DeletePartial" };
            g.SettingsEditing.AddNewRowRouteValues = new
            { Controller = ControllerName, Action = name + "InsertPartial" };
            g.Settings.ShowFilterRow = true;
            g.Settings.ShowGroupPanel = true;
            foreach (var item in PropertiesArray)
            {
                var c =  g.Columns.Add(item.Name);
                if (c.FieldName == g.KeyFieldName)
                {
                    c.EditFormSettings.Visible =  DevExpress.Utils.DefaultBoolean.False;
                }             
            }
            new GridViewExtension(g, helper.ViewContext).Bind(helper.ViewData.Model).Render();          
            return MvcHtmlString.Empty;
        }
       
    }
}

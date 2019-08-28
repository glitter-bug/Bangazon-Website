using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bangazon.Areas.Identity.Pages.Account.Manage
{
    public static class ManageNavPages
    {
        public static string Index => "Index";

        public static string ChangePassword => "ChangePassword";

        public static string ExternalLogins => "ExternalLogins";

        public static string PersonalData => "PersonalData";

        public static string OrderHistory => "OrderHistory";
        public static string OrderDetails => "OrderDetails";
        public static string PaymentType => "PaymentType";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);

        public static string ExternalLoginsNavClass(ViewContext viewContext) => PageNavClass(viewContext, ExternalLogins);

        public static string PersonalDataNavClass(ViewContext viewContext) => PageNavClass(viewContext, PersonalData);

        public static string OrderHistoryNavClass(ViewContext viewContext) => PageNavClass(viewContext, OrderHistory);
        public static string OrderDetailsNavClass(ViewContext viewContext) => PageNavClass(viewContext, OrderDetails);
        public static string PaymentTypeNavClass(ViewContext viewContext) => PageNavClass(viewContext, PaymentType);

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
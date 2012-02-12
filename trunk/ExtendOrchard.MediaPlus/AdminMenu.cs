using Orchard.Localization;
using Orchard.Security;
using Orchard.UI.Navigation;
using Orchard.Core.Navigation;

namespace ExtendOrchard.MediaPlus
{
    public class AdminMenu : INavigationProvider
    {
        public Localizer T { get; set; }
        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.AddImageSet("media")
                .Add(T("Media+"), "6",
                    menu => menu.Add(T("Media+"), "0", item => item.Action("Index", "Admin", new { area = "ExtendOrchard.MediaPlus" })
                        .Permission(StandardPermissions.SiteOwner)));
        }
    }
}
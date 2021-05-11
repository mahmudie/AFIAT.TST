using Abp.Application.Navigation;
using Abp.Authorization;
using Abp.Localization;
using AFIAT.TST.Authorization;

namespace AFIAT.TST.Web.Areas.Area.Startup
{
    public class AreaNavigationProvider : NavigationProvider
    {
        public const string MenuName = "App";

        public override void SetNavigation(INavigationProviderContext context)
        {
            var menu = context.Manager.Menus[MenuName] = new MenuDefinition(MenuName, new FixedLocalizableString("Main Menu"));

            menu
                .AddItem(new MenuItemDefinition(
                        AreaPageNames.Host.Dashboard,
                        L("Dashboard"),
                        url: "Area/HostDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                    AreaPageNames.Host.Tenants,
                    L("Tenants"),
                    url: "Area/Tenants",
                    icon: "flaticon-list-3",
                    permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenants)
                    )
                ).AddItem(new MenuItemDefinition(
                        AreaPageNames.Host.Editions,
                        L("Editions"),
                        url: "Area/Editions",
                        icon: "flaticon-app",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Editions)
                    )
                ).AddItem(new MenuItemDefinition(
                        AreaPageNames.Tenant.Dashboard,
                        L("Dashboard"),
                        url: "Area/TenantDashboard",
                        icon: "flaticon-line-graph",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Tenant_Dashboard)
                    )
                ).AddItem(new MenuItemDefinition(
                        AreaPageNames.Common.Administration,
                        L("Administration"),
                        icon: "flaticon-interface-8"
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.OrganizationUnits,
                            L("OrganizationUnits"),
                            url: "Area/OrganizationUnits",
                            icon: "flaticon-map",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_OrganizationUnits)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.Roles,
                            L("Roles"),
                            url: "Area/Roles",
                            icon: "flaticon-suitcase",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Roles)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.Users,
                            L("Users"),
                            url: "Area/Users",
                            icon: "flaticon-users",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Users)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.Languages,
                            L("Languages"),
                            url: "Area/Languages",
                            icon: "flaticon-tabs",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Languages)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.AuditLogs,
                            L("AuditLogs"),
                            url: "Area/AuditLogs",
                            icon: "flaticon-folder-1",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_AuditLogs)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Host.Maintenance,
                            L("Maintenance"),
                            url: "Area/Maintenance",
                            icon: "flaticon-lock",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Maintenance)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Tenant.SubscriptionManagement,
                            L("Subscription"),
                            url: "Area/SubscriptionManagement",
                            icon: "flaticon-refresh",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.UiCustomization,
                            L("VisualSettings"),
                            url: "Area/UiCustomization",
                            icon: "flaticon-medical",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_UiCustomization)
                        )
                    ).AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.WebhookSubscriptions,
                            L("WebhookSubscriptions"),
                            url: "Area/WebhookSubscription",
                            icon: "flaticon2-world",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_WebhookSubscription)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AreaPageNames.Common.DynamicProperties,
                            L("DynamicProperties"),
                            url: "Area/DynamicProperty",
                            icon: "flaticon-interface-8",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_DynamicProperties)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AreaPageNames.Host.Settings,
                            L("Settings"),
                            url: "Area/HostSettings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Host_Settings)
                        )
                    )
                    .AddItem(new MenuItemDefinition(
                            AreaPageNames.Tenant.Settings,
                            L("Settings"),
                            url: "Area/Settings",
                            icon: "flaticon-settings",
                            permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_Administration_Tenant_Settings)
                        )
                    )
                ).AddItem(new MenuItemDefinition(
                        AreaPageNames.Common.DemoUiComponents,
                        L("DemoUiComponents"),
                        url: "Area/DemoUiComponents",
                        icon: "flaticon-shapes",
                        permissionDependency: new SimplePermissionDependency(AppPermissions.Pages_DemoUiComponents)
                    )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, TSTConsts.LocalizationSourceName);
        }
    }
}

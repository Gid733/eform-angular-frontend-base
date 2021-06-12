﻿namespace Microting.EformAngularFrontendBase.Infrastructure.Const
{
    using System.Collections.Generic;
    using eFormApi.BasePn.Infrastructure.Consts;
    using eFormApi.BasePn.Infrastructure.Models.Application.NavigationMenu;

    public static class RightMenuStorage
    {
        public static List<PluginMenuItemModel> GetRightMenu()
        {
            return new List<PluginMenuItemModel>()
            {
                new PluginMenuItemModel
                {
                    E2EId = "sign-out-dropdown",
                    Name = "user",
                    Type = MenuItemTypeEnum.Dropdown,
                    Link = "",
                    Position = 0,
                    ChildItems = new List<PluginMenuItemModel>()
                    {
                        new PluginMenuItemModel
                        {
                            E2EId = "user-management-menu",
                            Name = "User Management",
                            Type = MenuItemTypeEnum.Link,
                            Link = "/account-management/users",
                            Position = 0,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                DefaultLink = "/account-management/users",
                                E2EId = "user-management-menu",
                                Permissions = new List<PluginMenuTemplatePermissionModel>
                                {
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Read,
                                        PermissionName = "Read",
                                        PermissionTypeName = "User management",
                                    },
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Create,
                                        PermissionName = "Create",
                                        PermissionTypeName = "User management",
                                    },
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Delete,
                                        PermissionName = "Delete",
                                        PermissionTypeName = "User management",
                                    },
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Update,
                                        PermissionName = "Update",
                                        PermissionTypeName = "User management",
                                    }
                                }
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new PluginMenuTranslationModel
                                {
                                    Name = "User Management",
                                    LocaleName = LocaleNames.English,
                                    Language = LanguageNames.English,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Brugeradministration",
                                    LocaleName = LocaleNames.Danish,
                                    Language = LanguageNames.Danish,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Benutzerverwaltung",
                                    LocaleName = LocaleNames.German,
                                    Language = LanguageNames.German,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Керування користувачами",
                                    LocaleName = LocaleNames.Ukrainian,
                                    Language = LanguageNames.Ukrainian,
                                }
                            }
                        },
                        new PluginMenuItemModel
                        {
                            Name = "Menu Editor",
                            Link = "/advanced/navigation-menu",
                            E2EId = "menu-editor",
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                DefaultLink = "/advanced/navigation-menu",
                                E2EId = "menu-editor",
                                Name = "Menu Editor",
                                Permissions = new List<PluginMenuTemplatePermissionModel>
                                {
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Read,
                                        PermissionName = "Read",
                                        PermissionTypeName = "User management",
                                    },
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Create,
                                        PermissionName = "Create",
                                        PermissionTypeName = "User management",
                                    },
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Delete,
                                        PermissionName = "Delete",
                                        PermissionTypeName = "User management",
                                    },
                                    new PluginMenuTemplatePermissionModel
                                    {
                                        ClaimName = AuthConsts.EformClaims.UserManagementClaims.Update,
                                        PermissionName = "Update",
                                        PermissionTypeName = "User management",
                                    }
                                }
                            },
                            Type = MenuItemTypeEnum.Link,
                            Position = 1,
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new PluginMenuTranslationModel
                                {
                                    Name = "Menu Editor",
                                    Language = LanguageNames.English,
                                    LocaleName = LocaleNames.English,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Menu Editor",
                                    Language = LanguageNames.Danish,
                                    LocaleName = LocaleNames.Danish,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Menü-Editor",
                                    Language = LanguageNames.German,
                                    LocaleName = LocaleNames.German,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Редактор меню",
                                    Language = LanguageNames.Ukrainian,
                                    LocaleName = LocaleNames.Ukrainian,
                                }
                            }
                        },
                        new PluginMenuItemModel
                        {
                            E2EId = "settings",
                            Name = "Settings",
                            Type = MenuItemTypeEnum.Link,
                            Link = "/account-management/settings",
                            Position = 2,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                DefaultLink = "/account-management/settings",
                                E2EId = "settings",
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new PluginMenuTranslationModel
                                {
                                    Name = "Settings",
                                    LocaleName = LocaleNames.English,
                                    Language = LanguageNames.English,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Indstillinger",
                                    LocaleName = LocaleNames.Danish,
                                    Language = LanguageNames.Danish,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Einstellungen",
                                    LocaleName = LocaleNames.German,
                                    Language = LanguageNames.German,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Налаштування",
                                    LocaleName = LocaleNames.Ukrainian,
                                    Language = LanguageNames.Ukrainian,
                                }
                            }
                        },
                        new PluginMenuItemModel
                        {
                            E2EId = "security",
                            Name = "Security",
                            Type = MenuItemTypeEnum.Link,
                            Link = "/security",
                            Position = 3,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                DefaultLink = "/security",
                                E2EId = "security",
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new PluginMenuTranslationModel
                                {
                                    Name = "Security",
                                    LocaleName = LocaleNames.English,
                                    Language = LanguageNames.English,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Sikkerhed",
                                    LocaleName = LocaleNames.Danish,
                                    Language = LanguageNames.Danish,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Sicherheit",
                                    LocaleName = LocaleNames.German,
                                    Language = LanguageNames.German,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Безпека",
                                    LocaleName = LocaleNames.Ukrainian,
                                    Language = LanguageNames.Ukrainian,
                                }
                            }
                        },
                        new PluginMenuItemModel
                        {
                            E2EId = "change-password",
                            Name = "Change password",
                            Type = MenuItemTypeEnum.Link,
                            Link = "/account-management/change-password",
                            Position = 4,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                DefaultLink = "/account-management/change-password",
                                E2EId = "change-password",
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new PluginMenuTranslationModel
                                {
                                    Name = "Change password",
                                    LocaleName = LocaleNames.English,
                                    Language = LanguageNames.English,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Skift adgangskode",
                                    LocaleName = LocaleNames.Danish,
                                    Language = LanguageNames.Danish,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Passwort ändern",
                                    LocaleName = LocaleNames.German,
                                    Language = LanguageNames.German,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Змінити пароль",
                                    LocaleName = LocaleNames.Ukrainian,
                                    Language = LanguageNames.Ukrainian,
                                }
                            }
                        },
                        new PluginMenuItemModel
                        {
                            E2EId = "sign-out",
                            Name = "Logout",
                            Type = MenuItemTypeEnum.Link,
                            Link = "/auth/sign-out",
                            Position = 5,
                            MenuTemplate = new PluginMenuTemplateModel
                            {
                                DefaultLink = "/auth/sign-out",
                                E2EId = "sign-out",
                            },
                            Translations = new List<PluginMenuTranslationModel>
                            {
                                new PluginMenuTranslationModel
                                {
                                    Name = "Logout",
                                    LocaleName = LocaleNames.English,
                                    Language = LanguageNames.English,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Log ud",
                                    LocaleName = LocaleNames.Danish,
                                    Language = LanguageNames.Danish,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Abmelden",
                                    LocaleName = LocaleNames.German,
                                    Language = LanguageNames.German,
                                },
                                new PluginMenuTranslationModel
                                {
                                    Name = "Вихід із системи",
                                    LocaleName = LocaleNames.Ukrainian,
                                    Language = LanguageNames.Ukrainian,
                                }
                            }
                        },
                    }
                },
            };
        }
    }
}

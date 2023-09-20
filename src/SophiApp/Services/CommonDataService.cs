﻿// <copyright file="CommonDataService.cs" company="Team Sophia">
// Copyright (c) Team Sophia. All rights reserved.
// </copyright>

namespace SophiApp.Services
{
    using System.Reflection;
    using Microsoft.UI.Input;
    using SophiApp.Contracts.Services;

    /// <inheritdoc/>
    public class CommonDataService : ICommonDataService
    {
        /// <summary>
        /// Gets discord text.
        /// </summary>
        public const string DiscordText = "Discord";

        /// <summary>
        /// Gets github text.
        /// </summary>
        public const string GitHubText = "GitHub";

        /// <summary>
        /// Gets telegram text.
        /// </summary>
        public const string TelegramText = "Telegram";

        /// <summary>
        /// Gets app discord link.
        /// </summary>
        public const string DiscordLink = "https://discord.gg/sSryhaEv79";

        /// <summary>
        /// Gets app github link.
        /// </summary>
        public const string GitHubLink = "https://github.com/Sophia-Community/SophiApp";

        /// <summary>
        /// Gets app telegram link.
        /// </summary>
        public const string TelegramLink = "https://t.me/sophia_chat";

        /// <summary>
        /// Gets app project manager name.
        /// </summary>
        public const string ProjectManagerName = "Dmitry \"farag\" Nefedov";

        /// <summary>
        /// Gets app developer name.
        /// </summary>
        public const string DeveloperName = "Dmitry \"Inestic\" Demin";

        /// <summary>
        /// Gets app UX developer name.
        /// </summary>
        public const string UXDeveloperName = "Vladimir Nameless";

        /// <summary>
        /// Gets app UI developer name.
        /// </summary>
        public const string UIDeveloperName = "Yaroslav Posmitiukh";

        /// <summary>
        /// Gets app animation developer name.
        /// </summary>
        public const string AnimationDeveloperName = "Maxim Nechiporenko";

        /// <summary>
        /// Gets app tester name.
        /// </summary>
        public const string AppTesterName = "Eugene \"lowlif3\" Zabronsky";

#pragma warning disable S1075 // URIs should not be hardcoded
        /// <summary>
        /// Gets app project manager url.
        /// </summary>
        public const string ProjectManagerUrl = "https://github.com/farag2";

        /// <summary>
        /// Gets app developer url.
        /// </summary>
        public const string DeveloperUrl = "https://github.com/Inestic";

        /// <summary>
        /// Gets app UX developer url.
        /// </summary>
        public const string UXDeveloperUrl = "https://www.linkedin.com/in/vladimir-palii-132745a1";

        /// <summary>
        /// Gets app UI developer url.
        /// </summary>
        public const string UIDeveloperUrl = "https://www.linkedin.com/in/artenjoyers";

        /// <summary>
        /// Gets app UI developer url.
        /// </summary>
        public const string AnimationDeveloperUrl = "https://linktr.ee/crowmax";

        /// <summary>
        /// Gets app tester url.
        /// </summary>
        public const string AppTesterUrl = "https://github.com/lowl1f3";
#pragma warning restore S1075 // URIs should not be hardcoded

        private static InputCursor userCursor = InputSystemCursor.Create(InputSystemCursorShape.Arrow);
        private readonly AssemblyName assembly = Assembly.GetExecutingAssembly().GetName();

        /// <summary>
        /// Gets or sets app user cursor.
        /// </summary>
        public static InputCursor UserCursor
        {
            get => userCursor;
            set
            {
                if (userCursor != value)
                {
                    userCursor = value;
                }
            }
        }

        /// <summary>
        /// Gets url hovering cursor.
        /// </summary>
        public static InputCursor UrlCursor { get; } = InputSystemCursor.Create(InputSystemCursorShape.Hand);

        /// <inheritdoc/>
        public string GetBuildName() => "Daria";

        /// <inheritdoc/>
        public string GetDelimiter() => "|";

        /// <inheritdoc/>
        public string GetFullName() => $"{assembly.Name} {assembly.Version!.Major}.{assembly.Version.Minor}.{assembly.Version.Build}";

        /// <inheritdoc/>
        public string GetVersionName() => "Community α";
    }
}
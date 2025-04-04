﻿
using System.Diagnostics.CodeAnalysis;
using Dalamud.Game;
using Dalamud.Game.ClientState.Objects;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using SimpleTweaksPlugin.Utility;

namespace SimpleTweaksPlugin; 

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
public class Service {
    [PluginService] public static IDalamudPluginInterface PluginInterface { get; private set; }
    [PluginService] public static IChatGui Chat { get; private set; }
    [PluginService] public static IClientState ClientState { get; private set; }
    [PluginService] public static ICommandManager Commands { get; private set; }
    [PluginService] public static ICondition Condition { get; private set; }
    [PluginService] public static IDataManager Data { get; private set; }
    [PluginService] public static IFramework Framework { get; private set; }
    [PluginService] public static IGameGui GameGui { get; private set; }
    [PluginService] public static IKeyState KeyState { get; private set; }
    [PluginService] public static IObjectTable Objects { get; private set; }
    [PluginService] public static ISigScanner SigScanner { get; private set; }
    [PluginService] public static ITargetManager Targets { get; private set; }
    [PluginService] public static IToastGui Toasts { get; private set; }
    [PluginService] public static IGameConfig GameConfig { get; private set; }
    [PluginService] public static ITextureProvider TextureProvider { get; private set; }
    [PluginService] public static ITextureSubstitutionProvider TextureSubstitutionProvider { get; private set; }
    [PluginService] public static ITextureReadbackProvider TextureReadbackProvider { get; private set; }
    [PluginService] public static IAddonLifecycle AddonLifecycle { get; private set; }
    [PluginService] public static IDtrBar DtrBar { get; private set; }
    [PluginService] public static IDutyState DutyState { get; private set; }
    [PluginService] public static INotificationManager NotificationManager { get; private set; }
    [PluginService] public static IContextMenu ContextMenu { get; private set; }
    [PluginService] public static INamePlateGui NamePlateGui { get; private set; }

    public static NativeKeyState NativeKeyState { get; } = new();

    public static void Dispose() {
        NativeKeyState.Dispose();
    }
}
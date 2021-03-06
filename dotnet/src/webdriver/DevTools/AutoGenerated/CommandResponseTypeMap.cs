namespace OpenQA.Selenium.DevTools
{
    using System;
    using System.Collections.Generic;

    public static class CommandResponseTypeMap
    {
        private readonly static IDictionary<Type, Type> s_commandResponseTypeDictionary;

        static CommandResponseTypeMap()
        {
            s_commandResponseTypeDictionary = new Dictionary<Type, Type>()
            {
                { typeof(Browser.GrantPermissionsCommandSettings), typeof(Browser.GrantPermissionsCommandResponse) },
                { typeof(Browser.ResetPermissionsCommandSettings), typeof(Browser.ResetPermissionsCommandResponse) },
                { typeof(Browser.CloseCommandSettings), typeof(Browser.CloseCommandResponse) },
                { typeof(Browser.CrashCommandSettings), typeof(Browser.CrashCommandResponse) },
                { typeof(Browser.CrashGpuProcessCommandSettings), typeof(Browser.CrashGpuProcessCommandResponse) },
                { typeof(Browser.GetVersionCommandSettings), typeof(Browser.GetVersionCommandResponse) },
                { typeof(Browser.GetBrowserCommandLineCommandSettings), typeof(Browser.GetBrowserCommandLineCommandResponse) },
                { typeof(Browser.GetHistogramsCommandSettings), typeof(Browser.GetHistogramsCommandResponse) },
                { typeof(Browser.GetHistogramCommandSettings), typeof(Browser.GetHistogramCommandResponse) },
                { typeof(Browser.GetWindowBoundsCommandSettings), typeof(Browser.GetWindowBoundsCommandResponse) },
                { typeof(Browser.GetWindowForTargetCommandSettings), typeof(Browser.GetWindowForTargetCommandResponse) },
                { typeof(Browser.SetWindowBoundsCommandSettings), typeof(Browser.SetWindowBoundsCommandResponse) },
                { typeof(Browser.SetDockTileCommandSettings), typeof(Browser.SetDockTileCommandResponse) },
                { typeof(DOM.CollectClassNamesFromSubtreeCommandSettings), typeof(DOM.CollectClassNamesFromSubtreeCommandResponse) },
                { typeof(DOM.CopyToCommandSettings), typeof(DOM.CopyToCommandResponse) },
                { typeof(DOM.DescribeNodeCommandSettings), typeof(DOM.DescribeNodeCommandResponse) },
                { typeof(DOM.DisableCommandSettings), typeof(DOM.DisableCommandResponse) },
                { typeof(DOM.DiscardSearchResultsCommandSettings), typeof(DOM.DiscardSearchResultsCommandResponse) },
                { typeof(DOM.EnableCommandSettings), typeof(DOM.EnableCommandResponse) },
                { typeof(DOM.FocusCommandSettings), typeof(DOM.FocusCommandResponse) },
                { typeof(DOM.GetAttributesCommandSettings), typeof(DOM.GetAttributesCommandResponse) },
                { typeof(DOM.GetBoxModelCommandSettings), typeof(DOM.GetBoxModelCommandResponse) },
                { typeof(DOM.GetContentQuadsCommandSettings), typeof(DOM.GetContentQuadsCommandResponse) },
                { typeof(DOM.GetDocumentCommandSettings), typeof(DOM.GetDocumentCommandResponse) },
                { typeof(DOM.GetFlattenedDocumentCommandSettings), typeof(DOM.GetFlattenedDocumentCommandResponse) },
                { typeof(DOM.GetNodeForLocationCommandSettings), typeof(DOM.GetNodeForLocationCommandResponse) },
                { typeof(DOM.GetOuterHTMLCommandSettings), typeof(DOM.GetOuterHTMLCommandResponse) },
                { typeof(DOM.GetRelayoutBoundaryCommandSettings), typeof(DOM.GetRelayoutBoundaryCommandResponse) },
                { typeof(DOM.GetSearchResultsCommandSettings), typeof(DOM.GetSearchResultsCommandResponse) },
                { typeof(DOM.HideHighlightCommandSettings), typeof(DOM.HideHighlightCommandResponse) },
                { typeof(DOM.HighlightNodeCommandSettings), typeof(DOM.HighlightNodeCommandResponse) },
                { typeof(DOM.HighlightRectCommandSettings), typeof(DOM.HighlightRectCommandResponse) },
                { typeof(DOM.MarkUndoableStateCommandSettings), typeof(DOM.MarkUndoableStateCommandResponse) },
                { typeof(DOM.MoveToCommandSettings), typeof(DOM.MoveToCommandResponse) },
                { typeof(DOM.PerformSearchCommandSettings), typeof(DOM.PerformSearchCommandResponse) },
                { typeof(DOM.PushNodeByPathToFrontendCommandSettings), typeof(DOM.PushNodeByPathToFrontendCommandResponse) },
                { typeof(DOM.PushNodesByBackendIdsToFrontendCommandSettings), typeof(DOM.PushNodesByBackendIdsToFrontendCommandResponse) },
                { typeof(DOM.QuerySelectorCommandSettings), typeof(DOM.QuerySelectorCommandResponse) },
                { typeof(DOM.QuerySelectorAllCommandSettings), typeof(DOM.QuerySelectorAllCommandResponse) },
                { typeof(DOM.RedoCommandSettings), typeof(DOM.RedoCommandResponse) },
                { typeof(DOM.RemoveAttributeCommandSettings), typeof(DOM.RemoveAttributeCommandResponse) },
                { typeof(DOM.RemoveNodeCommandSettings), typeof(DOM.RemoveNodeCommandResponse) },
                { typeof(DOM.RequestChildNodesCommandSettings), typeof(DOM.RequestChildNodesCommandResponse) },
                { typeof(DOM.RequestNodeCommandSettings), typeof(DOM.RequestNodeCommandResponse) },
                { typeof(DOM.ResolveNodeCommandSettings), typeof(DOM.ResolveNodeCommandResponse) },
                { typeof(DOM.SetAttributeValueCommandSettings), typeof(DOM.SetAttributeValueCommandResponse) },
                { typeof(DOM.SetAttributesAsTextCommandSettings), typeof(DOM.SetAttributesAsTextCommandResponse) },
                { typeof(DOM.SetFileInputFilesCommandSettings), typeof(DOM.SetFileInputFilesCommandResponse) },
                { typeof(DOM.GetFileInfoCommandSettings), typeof(DOM.GetFileInfoCommandResponse) },
                { typeof(DOM.SetInspectedNodeCommandSettings), typeof(DOM.SetInspectedNodeCommandResponse) },
                { typeof(DOM.SetNodeNameCommandSettings), typeof(DOM.SetNodeNameCommandResponse) },
                { typeof(DOM.SetNodeValueCommandSettings), typeof(DOM.SetNodeValueCommandResponse) },
                { typeof(DOM.SetOuterHTMLCommandSettings), typeof(DOM.SetOuterHTMLCommandResponse) },
                { typeof(DOM.UndoCommandSettings), typeof(DOM.UndoCommandResponse) },
                { typeof(DOM.GetFrameOwnerCommandSettings), typeof(DOM.GetFrameOwnerCommandResponse) },
                { typeof(DOMDebugger.GetEventListenersCommandSettings), typeof(DOMDebugger.GetEventListenersCommandResponse) },
                { typeof(DOMDebugger.RemoveDOMBreakpointCommandSettings), typeof(DOMDebugger.RemoveDOMBreakpointCommandResponse) },
                { typeof(DOMDebugger.RemoveEventListenerBreakpointCommandSettings), typeof(DOMDebugger.RemoveEventListenerBreakpointCommandResponse) },
                { typeof(DOMDebugger.RemoveInstrumentationBreakpointCommandSettings), typeof(DOMDebugger.RemoveInstrumentationBreakpointCommandResponse) },
                { typeof(DOMDebugger.RemoveXHRBreakpointCommandSettings), typeof(DOMDebugger.RemoveXHRBreakpointCommandResponse) },
                { typeof(DOMDebugger.SetDOMBreakpointCommandSettings), typeof(DOMDebugger.SetDOMBreakpointCommandResponse) },
                { typeof(DOMDebugger.SetEventListenerBreakpointCommandSettings), typeof(DOMDebugger.SetEventListenerBreakpointCommandResponse) },
                { typeof(DOMDebugger.SetInstrumentationBreakpointCommandSettings), typeof(DOMDebugger.SetInstrumentationBreakpointCommandResponse) },
                { typeof(DOMDebugger.SetXHRBreakpointCommandSettings), typeof(DOMDebugger.SetXHRBreakpointCommandResponse) },
                { typeof(Emulation.CanEmulateCommandSettings), typeof(Emulation.CanEmulateCommandResponse) },
                { typeof(Emulation.ClearDeviceMetricsOverrideCommandSettings), typeof(Emulation.ClearDeviceMetricsOverrideCommandResponse) },
                { typeof(Emulation.ClearGeolocationOverrideCommandSettings), typeof(Emulation.ClearGeolocationOverrideCommandResponse) },
                { typeof(Emulation.ResetPageScaleFactorCommandSettings), typeof(Emulation.ResetPageScaleFactorCommandResponse) },
                { typeof(Emulation.SetFocusEmulationEnabledCommandSettings), typeof(Emulation.SetFocusEmulationEnabledCommandResponse) },
                { typeof(Emulation.SetCPUThrottlingRateCommandSettings), typeof(Emulation.SetCPUThrottlingRateCommandResponse) },
                { typeof(Emulation.SetDefaultBackgroundColorOverrideCommandSettings), typeof(Emulation.SetDefaultBackgroundColorOverrideCommandResponse) },
                { typeof(Emulation.SetDeviceMetricsOverrideCommandSettings), typeof(Emulation.SetDeviceMetricsOverrideCommandResponse) },
                { typeof(Emulation.SetScrollbarsHiddenCommandSettings), typeof(Emulation.SetScrollbarsHiddenCommandResponse) },
                { typeof(Emulation.SetDocumentCookieDisabledCommandSettings), typeof(Emulation.SetDocumentCookieDisabledCommandResponse) },
                { typeof(Emulation.SetEmitTouchEventsForMouseCommandSettings), typeof(Emulation.SetEmitTouchEventsForMouseCommandResponse) },
                { typeof(Emulation.SetEmulatedMediaCommandSettings), typeof(Emulation.SetEmulatedMediaCommandResponse) },
                { typeof(Emulation.SetGeolocationOverrideCommandSettings), typeof(Emulation.SetGeolocationOverrideCommandResponse) },
                { typeof(Emulation.SetNavigatorOverridesCommandSettings), typeof(Emulation.SetNavigatorOverridesCommandResponse) },
                { typeof(Emulation.SetPageScaleFactorCommandSettings), typeof(Emulation.SetPageScaleFactorCommandResponse) },
                { typeof(Emulation.SetScriptExecutionDisabledCommandSettings), typeof(Emulation.SetScriptExecutionDisabledCommandResponse) },
                { typeof(Emulation.SetTouchEmulationEnabledCommandSettings), typeof(Emulation.SetTouchEmulationEnabledCommandResponse) },
                { typeof(Emulation.SetVirtualTimePolicyCommandSettings), typeof(Emulation.SetVirtualTimePolicyCommandResponse) },
                { typeof(Emulation.SetVisibleSizeCommandSettings), typeof(Emulation.SetVisibleSizeCommandResponse) },
                { typeof(Emulation.SetUserAgentOverrideCommandSettings), typeof(Emulation.SetUserAgentOverrideCommandResponse) },
                { typeof(IO.CloseCommandSettings), typeof(IO.CloseCommandResponse) },
                { typeof(IO.ReadCommandSettings), typeof(IO.ReadCommandResponse) },
                { typeof(IO.ResolveBlobCommandSettings), typeof(IO.ResolveBlobCommandResponse) },
                { typeof(Input.DispatchKeyEventCommandSettings), typeof(Input.DispatchKeyEventCommandResponse) },
                { typeof(Input.InsertTextCommandSettings), typeof(Input.InsertTextCommandResponse) },
                { typeof(Input.DispatchMouseEventCommandSettings), typeof(Input.DispatchMouseEventCommandResponse) },
                { typeof(Input.DispatchTouchEventCommandSettings), typeof(Input.DispatchTouchEventCommandResponse) },
                { typeof(Input.EmulateTouchFromMouseEventCommandSettings), typeof(Input.EmulateTouchFromMouseEventCommandResponse) },
                { typeof(Input.SetIgnoreInputEventsCommandSettings), typeof(Input.SetIgnoreInputEventsCommandResponse) },
                { typeof(Input.SynthesizePinchGestureCommandSettings), typeof(Input.SynthesizePinchGestureCommandResponse) },
                { typeof(Input.SynthesizeScrollGestureCommandSettings), typeof(Input.SynthesizeScrollGestureCommandResponse) },
                { typeof(Input.SynthesizeTapGestureCommandSettings), typeof(Input.SynthesizeTapGestureCommandResponse) },
                { typeof(Log.ClearCommandSettings), typeof(Log.ClearCommandResponse) },
                { typeof(Log.DisableCommandSettings), typeof(Log.DisableCommandResponse) },
                { typeof(Log.EnableCommandSettings), typeof(Log.EnableCommandResponse) },
                { typeof(Log.StartViolationsReportCommandSettings), typeof(Log.StartViolationsReportCommandResponse) },
                { typeof(Log.StopViolationsReportCommandSettings), typeof(Log.StopViolationsReportCommandResponse) },
                { typeof(Network.CanClearBrowserCacheCommandSettings), typeof(Network.CanClearBrowserCacheCommandResponse) },
                { typeof(Network.CanClearBrowserCookiesCommandSettings), typeof(Network.CanClearBrowserCookiesCommandResponse) },
                { typeof(Network.CanEmulateNetworkConditionsCommandSettings), typeof(Network.CanEmulateNetworkConditionsCommandResponse) },
                { typeof(Network.ClearBrowserCacheCommandSettings), typeof(Network.ClearBrowserCacheCommandResponse) },
                { typeof(Network.ClearBrowserCookiesCommandSettings), typeof(Network.ClearBrowserCookiesCommandResponse) },
                { typeof(Network.ContinueInterceptedRequestCommandSettings), typeof(Network.ContinueInterceptedRequestCommandResponse) },
                { typeof(Network.DeleteCookiesCommandSettings), typeof(Network.DeleteCookiesCommandResponse) },
                { typeof(Network.DisableCommandSettings), typeof(Network.DisableCommandResponse) },
                { typeof(Network.EmulateNetworkConditionsCommandSettings), typeof(Network.EmulateNetworkConditionsCommandResponse) },
                { typeof(Network.EnableCommandSettings), typeof(Network.EnableCommandResponse) },
                { typeof(Network.GetAllCookiesCommandSettings), typeof(Network.GetAllCookiesCommandResponse) },
                { typeof(Network.GetCertificateCommandSettings), typeof(Network.GetCertificateCommandResponse) },
                { typeof(Network.GetCookiesCommandSettings), typeof(Network.GetCookiesCommandResponse) },
                { typeof(Network.GetResponseBodyCommandSettings), typeof(Network.GetResponseBodyCommandResponse) },
                { typeof(Network.GetRequestPostDataCommandSettings), typeof(Network.GetRequestPostDataCommandResponse) },
                { typeof(Network.GetResponseBodyForInterceptionCommandSettings), typeof(Network.GetResponseBodyForInterceptionCommandResponse) },
                { typeof(Network.TakeResponseBodyForInterceptionAsStreamCommandSettings), typeof(Network.TakeResponseBodyForInterceptionAsStreamCommandResponse) },
                { typeof(Network.ReplayXHRCommandSettings), typeof(Network.ReplayXHRCommandResponse) },
                { typeof(Network.SearchInResponseBodyCommandSettings), typeof(Network.SearchInResponseBodyCommandResponse) },
                { typeof(Network.SetBlockedURLsCommandSettings), typeof(Network.SetBlockedURLsCommandResponse) },
                { typeof(Network.SetBypassServiceWorkerCommandSettings), typeof(Network.SetBypassServiceWorkerCommandResponse) },
                { typeof(Network.SetCacheDisabledCommandSettings), typeof(Network.SetCacheDisabledCommandResponse) },
                { typeof(Network.SetCookieCommandSettings), typeof(Network.SetCookieCommandResponse) },
                { typeof(Network.SetCookiesCommandSettings), typeof(Network.SetCookiesCommandResponse) },
                { typeof(Network.SetDataSizeLimitsForTestCommandSettings), typeof(Network.SetDataSizeLimitsForTestCommandResponse) },
                { typeof(Network.SetExtraHTTPHeadersCommandSettings), typeof(Network.SetExtraHTTPHeadersCommandResponse) },
                { typeof(Network.SetRequestInterceptionCommandSettings), typeof(Network.SetRequestInterceptionCommandResponse) },
                { typeof(Network.SetUserAgentOverrideCommandSettings), typeof(Network.SetUserAgentOverrideCommandResponse) },
                { typeof(Page.AddScriptToEvaluateOnLoadCommandSettings), typeof(Page.AddScriptToEvaluateOnLoadCommandResponse) },
                { typeof(Page.AddScriptToEvaluateOnNewDocumentCommandSettings), typeof(Page.AddScriptToEvaluateOnNewDocumentCommandResponse) },
                { typeof(Page.BringToFrontCommandSettings), typeof(Page.BringToFrontCommandResponse) },
                { typeof(Page.CaptureScreenshotCommandSettings), typeof(Page.CaptureScreenshotCommandResponse) },
                { typeof(Page.CaptureSnapshotCommandSettings), typeof(Page.CaptureSnapshotCommandResponse) },
                { typeof(Page.ClearDeviceMetricsOverrideCommandSettings), typeof(Page.ClearDeviceMetricsOverrideCommandResponse) },
                { typeof(Page.ClearDeviceOrientationOverrideCommandSettings), typeof(Page.ClearDeviceOrientationOverrideCommandResponse) },
                { typeof(Page.ClearGeolocationOverrideCommandSettings), typeof(Page.ClearGeolocationOverrideCommandResponse) },
                { typeof(Page.CreateIsolatedWorldCommandSettings), typeof(Page.CreateIsolatedWorldCommandResponse) },
                { typeof(Page.DeleteCookieCommandSettings), typeof(Page.DeleteCookieCommandResponse) },
                { typeof(Page.DisableCommandSettings), typeof(Page.DisableCommandResponse) },
                { typeof(Page.EnableCommandSettings), typeof(Page.EnableCommandResponse) },
                { typeof(Page.GetAppManifestCommandSettings), typeof(Page.GetAppManifestCommandResponse) },
                { typeof(Page.GetInstallabilityErrorsCommandSettings), typeof(Page.GetInstallabilityErrorsCommandResponse) },
                { typeof(Page.GetCookiesCommandSettings), typeof(Page.GetCookiesCommandResponse) },
                { typeof(Page.GetFrameTreeCommandSettings), typeof(Page.GetFrameTreeCommandResponse) },
                { typeof(Page.GetLayoutMetricsCommandSettings), typeof(Page.GetLayoutMetricsCommandResponse) },
                { typeof(Page.GetNavigationHistoryCommandSettings), typeof(Page.GetNavigationHistoryCommandResponse) },
                { typeof(Page.ResetNavigationHistoryCommandSettings), typeof(Page.ResetNavigationHistoryCommandResponse) },
                { typeof(Page.GetResourceContentCommandSettings), typeof(Page.GetResourceContentCommandResponse) },
                { typeof(Page.GetResourceTreeCommandSettings), typeof(Page.GetResourceTreeCommandResponse) },
                { typeof(Page.HandleJavaScriptDialogCommandSettings), typeof(Page.HandleJavaScriptDialogCommandResponse) },
                { typeof(Page.NavigateCommandSettings), typeof(Page.NavigateCommandResponse) },
                { typeof(Page.NavigateToHistoryEntryCommandSettings), typeof(Page.NavigateToHistoryEntryCommandResponse) },
                { typeof(Page.PrintToPDFCommandSettings), typeof(Page.PrintToPDFCommandResponse) },
                { typeof(Page.ReloadCommandSettings), typeof(Page.ReloadCommandResponse) },
                { typeof(Page.RemoveScriptToEvaluateOnLoadCommandSettings), typeof(Page.RemoveScriptToEvaluateOnLoadCommandResponse) },
                { typeof(Page.RemoveScriptToEvaluateOnNewDocumentCommandSettings), typeof(Page.RemoveScriptToEvaluateOnNewDocumentCommandResponse) },
                { typeof(Page.ScreencastFrameAckCommandSettings), typeof(Page.ScreencastFrameAckCommandResponse) },
                { typeof(Page.SearchInResourceCommandSettings), typeof(Page.SearchInResourceCommandResponse) },
                { typeof(Page.SetAdBlockingEnabledCommandSettings), typeof(Page.SetAdBlockingEnabledCommandResponse) },
                { typeof(Page.SetBypassCSPCommandSettings), typeof(Page.SetBypassCSPCommandResponse) },
                { typeof(Page.SetDeviceMetricsOverrideCommandSettings), typeof(Page.SetDeviceMetricsOverrideCommandResponse) },
                { typeof(Page.SetDeviceOrientationOverrideCommandSettings), typeof(Page.SetDeviceOrientationOverrideCommandResponse) },
                { typeof(Page.SetFontFamiliesCommandSettings), typeof(Page.SetFontFamiliesCommandResponse) },
                { typeof(Page.SetFontSizesCommandSettings), typeof(Page.SetFontSizesCommandResponse) },
                { typeof(Page.SetDocumentContentCommandSettings), typeof(Page.SetDocumentContentCommandResponse) },
                { typeof(Page.SetDownloadBehaviorCommandSettings), typeof(Page.SetDownloadBehaviorCommandResponse) },
                { typeof(Page.SetGeolocationOverrideCommandSettings), typeof(Page.SetGeolocationOverrideCommandResponse) },
                { typeof(Page.SetLifecycleEventsEnabledCommandSettings), typeof(Page.SetLifecycleEventsEnabledCommandResponse) },
                { typeof(Page.SetTouchEmulationEnabledCommandSettings), typeof(Page.SetTouchEmulationEnabledCommandResponse) },
                { typeof(Page.StartScreencastCommandSettings), typeof(Page.StartScreencastCommandResponse) },
                { typeof(Page.StopLoadingCommandSettings), typeof(Page.StopLoadingCommandResponse) },
                { typeof(Page.CrashCommandSettings), typeof(Page.CrashCommandResponse) },
                { typeof(Page.CloseCommandSettings), typeof(Page.CloseCommandResponse) },
                { typeof(Page.SetWebLifecycleStateCommandSettings), typeof(Page.SetWebLifecycleStateCommandResponse) },
                { typeof(Page.StopScreencastCommandSettings), typeof(Page.StopScreencastCommandResponse) },
                { typeof(Page.SetProduceCompilationCacheCommandSettings), typeof(Page.SetProduceCompilationCacheCommandResponse) },
                { typeof(Page.AddCompilationCacheCommandSettings), typeof(Page.AddCompilationCacheCommandResponse) },
                { typeof(Page.ClearCompilationCacheCommandSettings), typeof(Page.ClearCompilationCacheCommandResponse) },
                { typeof(Page.GenerateTestReportCommandSettings), typeof(Page.GenerateTestReportCommandResponse) },
                { typeof(Page.WaitForDebuggerCommandSettings), typeof(Page.WaitForDebuggerCommandResponse) },
                { typeof(Performance.DisableCommandSettings), typeof(Performance.DisableCommandResponse) },
                { typeof(Performance.EnableCommandSettings), typeof(Performance.EnableCommandResponse) },
                { typeof(Performance.SetTimeDomainCommandSettings), typeof(Performance.SetTimeDomainCommandResponse) },
                { typeof(Performance.GetMetricsCommandSettings), typeof(Performance.GetMetricsCommandResponse) },
                { typeof(Security.DisableCommandSettings), typeof(Security.DisableCommandResponse) },
                { typeof(Security.EnableCommandSettings), typeof(Security.EnableCommandResponse) },
                { typeof(Security.SetIgnoreCertificateErrorsCommandSettings), typeof(Security.SetIgnoreCertificateErrorsCommandResponse) },
                { typeof(Security.HandleCertificateErrorCommandSettings), typeof(Security.HandleCertificateErrorCommandResponse) },
                { typeof(Security.SetOverrideCertificateErrorsCommandSettings), typeof(Security.SetOverrideCertificateErrorsCommandResponse) },
                { typeof(Target.ActivateTargetCommandSettings), typeof(Target.ActivateTargetCommandResponse) },
                { typeof(Target.AttachToTargetCommandSettings), typeof(Target.AttachToTargetCommandResponse) },
                { typeof(Target.AttachToBrowserTargetCommandSettings), typeof(Target.AttachToBrowserTargetCommandResponse) },
                { typeof(Target.CloseTargetCommandSettings), typeof(Target.CloseTargetCommandResponse) },
                { typeof(Target.ExposeDevToolsProtocolCommandSettings), typeof(Target.ExposeDevToolsProtocolCommandResponse) },
                { typeof(Target.CreateBrowserContextCommandSettings), typeof(Target.CreateBrowserContextCommandResponse) },
                { typeof(Target.GetBrowserContextsCommandSettings), typeof(Target.GetBrowserContextsCommandResponse) },
                { typeof(Target.CreateTargetCommandSettings), typeof(Target.CreateTargetCommandResponse) },
                { typeof(Target.DetachFromTargetCommandSettings), typeof(Target.DetachFromTargetCommandResponse) },
                { typeof(Target.DisposeBrowserContextCommandSettings), typeof(Target.DisposeBrowserContextCommandResponse) },
                { typeof(Target.GetTargetInfoCommandSettings), typeof(Target.GetTargetInfoCommandResponse) },
                { typeof(Target.GetTargetsCommandSettings), typeof(Target.GetTargetsCommandResponse) },
                { typeof(Target.SendMessageToTargetCommandSettings), typeof(Target.SendMessageToTargetCommandResponse) },
                { typeof(Target.SetAutoAttachCommandSettings), typeof(Target.SetAutoAttachCommandResponse) },
                { typeof(Target.SetDiscoverTargetsCommandSettings), typeof(Target.SetDiscoverTargetsCommandResponse) },
                { typeof(Target.SetRemoteLocationsCommandSettings), typeof(Target.SetRemoteLocationsCommandResponse) },
                { typeof(Console.ClearMessagesCommandSettings), typeof(Console.ClearMessagesCommandResponse) },
                { typeof(Console.DisableCommandSettings), typeof(Console.DisableCommandResponse) },
                { typeof(Console.EnableCommandSettings), typeof(Console.EnableCommandResponse) },
                { typeof(Debugger.ContinueToLocationCommandSettings), typeof(Debugger.ContinueToLocationCommandResponse) },
                { typeof(Debugger.DisableCommandSettings), typeof(Debugger.DisableCommandResponse) },
                { typeof(Debugger.EnableCommandSettings), typeof(Debugger.EnableCommandResponse) },
                { typeof(Debugger.EvaluateOnCallFrameCommandSettings), typeof(Debugger.EvaluateOnCallFrameCommandResponse) },
                { typeof(Debugger.GetPossibleBreakpointsCommandSettings), typeof(Debugger.GetPossibleBreakpointsCommandResponse) },
                { typeof(Debugger.GetScriptSourceCommandSettings), typeof(Debugger.GetScriptSourceCommandResponse) },
                { typeof(Debugger.GetStackTraceCommandSettings), typeof(Debugger.GetStackTraceCommandResponse) },
                { typeof(Debugger.PauseCommandSettings), typeof(Debugger.PauseCommandResponse) },
                { typeof(Debugger.PauseOnAsyncCallCommandSettings), typeof(Debugger.PauseOnAsyncCallCommandResponse) },
                { typeof(Debugger.RemoveBreakpointCommandSettings), typeof(Debugger.RemoveBreakpointCommandResponse) },
                { typeof(Debugger.RestartFrameCommandSettings), typeof(Debugger.RestartFrameCommandResponse) },
                { typeof(Debugger.ResumeCommandSettings), typeof(Debugger.ResumeCommandResponse) },
                { typeof(Debugger.SearchInContentCommandSettings), typeof(Debugger.SearchInContentCommandResponse) },
                { typeof(Debugger.SetAsyncCallStackDepthCommandSettings), typeof(Debugger.SetAsyncCallStackDepthCommandResponse) },
                { typeof(Debugger.SetBlackboxPatternsCommandSettings), typeof(Debugger.SetBlackboxPatternsCommandResponse) },
                { typeof(Debugger.SetBlackboxedRangesCommandSettings), typeof(Debugger.SetBlackboxedRangesCommandResponse) },
                { typeof(Debugger.SetBreakpointCommandSettings), typeof(Debugger.SetBreakpointCommandResponse) },
                { typeof(Debugger.SetBreakpointByUrlCommandSettings), typeof(Debugger.SetBreakpointByUrlCommandResponse) },
                { typeof(Debugger.SetBreakpointOnFunctionCallCommandSettings), typeof(Debugger.SetBreakpointOnFunctionCallCommandResponse) },
                { typeof(Debugger.SetBreakpointsActiveCommandSettings), typeof(Debugger.SetBreakpointsActiveCommandResponse) },
                { typeof(Debugger.SetPauseOnExceptionsCommandSettings), typeof(Debugger.SetPauseOnExceptionsCommandResponse) },
                { typeof(Debugger.SetReturnValueCommandSettings), typeof(Debugger.SetReturnValueCommandResponse) },
                { typeof(Debugger.SetScriptSourceCommandSettings), typeof(Debugger.SetScriptSourceCommandResponse) },
                { typeof(Debugger.SetSkipAllPausesCommandSettings), typeof(Debugger.SetSkipAllPausesCommandResponse) },
                { typeof(Debugger.SetVariableValueCommandSettings), typeof(Debugger.SetVariableValueCommandResponse) },
                { typeof(Debugger.StepIntoCommandSettings), typeof(Debugger.StepIntoCommandResponse) },
                { typeof(Debugger.StepOutCommandSettings), typeof(Debugger.StepOutCommandResponse) },
                { typeof(Debugger.StepOverCommandSettings), typeof(Debugger.StepOverCommandResponse) },
                { typeof(Profiler.DisableCommandSettings), typeof(Profiler.DisableCommandResponse) },
                { typeof(Profiler.EnableCommandSettings), typeof(Profiler.EnableCommandResponse) },
                { typeof(Profiler.GetBestEffortCoverageCommandSettings), typeof(Profiler.GetBestEffortCoverageCommandResponse) },
                { typeof(Profiler.SetSamplingIntervalCommandSettings), typeof(Profiler.SetSamplingIntervalCommandResponse) },
                { typeof(Profiler.StartCommandSettings), typeof(Profiler.StartCommandResponse) },
                { typeof(Profiler.StartPreciseCoverageCommandSettings), typeof(Profiler.StartPreciseCoverageCommandResponse) },
                { typeof(Profiler.StartTypeProfileCommandSettings), typeof(Profiler.StartTypeProfileCommandResponse) },
                { typeof(Profiler.StopCommandSettings), typeof(Profiler.StopCommandResponse) },
                { typeof(Profiler.StopPreciseCoverageCommandSettings), typeof(Profiler.StopPreciseCoverageCommandResponse) },
                { typeof(Profiler.StopTypeProfileCommandSettings), typeof(Profiler.StopTypeProfileCommandResponse) },
                { typeof(Profiler.TakePreciseCoverageCommandSettings), typeof(Profiler.TakePreciseCoverageCommandResponse) },
                { typeof(Profiler.TakeTypeProfileCommandSettings), typeof(Profiler.TakeTypeProfileCommandResponse) },
                { typeof(Runtime.AwaitPromiseCommandSettings), typeof(Runtime.AwaitPromiseCommandResponse) },
                { typeof(Runtime.CallFunctionOnCommandSettings), typeof(Runtime.CallFunctionOnCommandResponse) },
                { typeof(Runtime.CompileScriptCommandSettings), typeof(Runtime.CompileScriptCommandResponse) },
                { typeof(Runtime.DisableCommandSettings), typeof(Runtime.DisableCommandResponse) },
                { typeof(Runtime.DiscardConsoleEntriesCommandSettings), typeof(Runtime.DiscardConsoleEntriesCommandResponse) },
                { typeof(Runtime.EnableCommandSettings), typeof(Runtime.EnableCommandResponse) },
                { typeof(Runtime.EvaluateCommandSettings), typeof(Runtime.EvaluateCommandResponse) },
                { typeof(Runtime.GetIsolateIdCommandSettings), typeof(Runtime.GetIsolateIdCommandResponse) },
                { typeof(Runtime.GetHeapUsageCommandSettings), typeof(Runtime.GetHeapUsageCommandResponse) },
                { typeof(Runtime.GetPropertiesCommandSettings), typeof(Runtime.GetPropertiesCommandResponse) },
                { typeof(Runtime.GlobalLexicalScopeNamesCommandSettings), typeof(Runtime.GlobalLexicalScopeNamesCommandResponse) },
                { typeof(Runtime.QueryObjectsCommandSettings), typeof(Runtime.QueryObjectsCommandResponse) },
                { typeof(Runtime.ReleaseObjectCommandSettings), typeof(Runtime.ReleaseObjectCommandResponse) },
                { typeof(Runtime.ReleaseObjectGroupCommandSettings), typeof(Runtime.ReleaseObjectGroupCommandResponse) },
                { typeof(Runtime.RunIfWaitingForDebuggerCommandSettings), typeof(Runtime.RunIfWaitingForDebuggerCommandResponse) },
                { typeof(Runtime.RunScriptCommandSettings), typeof(Runtime.RunScriptCommandResponse) },
                { typeof(Runtime.SetAsyncCallStackDepthCommandSettings), typeof(Runtime.SetAsyncCallStackDepthCommandResponse) },
                { typeof(Runtime.SetCustomObjectFormatterEnabledCommandSettings), typeof(Runtime.SetCustomObjectFormatterEnabledCommandResponse) },
                { typeof(Runtime.SetMaxCallStackSizeToCaptureCommandSettings), typeof(Runtime.SetMaxCallStackSizeToCaptureCommandResponse) },
                { typeof(Runtime.TerminateExecutionCommandSettings), typeof(Runtime.TerminateExecutionCommandResponse) },
                { typeof(Runtime.AddBindingCommandSettings), typeof(Runtime.AddBindingCommandResponse) },
                { typeof(Runtime.RemoveBindingCommandSettings), typeof(Runtime.RemoveBindingCommandResponse) },
                { typeof(Schema.GetDomainsCommandSettings), typeof(Schema.GetDomainsCommandResponse) },
            };
        }

        /// <summary>
        /// Gets the command response type corresponding to the specified command type
        /// </summary>
        public static bool TryGetCommandResponseType<T>(out Type commandResponseType)
            where T : ICommand
        {
            return s_commandResponseTypeDictionary.TryGetValue(typeof(T), out commandResponseType);
        }
    }
}
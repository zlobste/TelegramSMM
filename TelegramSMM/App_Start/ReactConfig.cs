using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;
using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(TelegramSMM.ReactConfig), "Configure")]

namespace TelegramSMM
{
	public static class ReactConfig
	{
		public static void Configure()
		{
            // Регистрация движка V8
            JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
            JsEngineSwitcher.Current.EngineFactories.AddV8();
        }
	}
}
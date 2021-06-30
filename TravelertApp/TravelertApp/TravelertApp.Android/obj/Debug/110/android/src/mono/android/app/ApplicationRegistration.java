package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("MainApplication, TravelertApp.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc642fa45b318a392027.MainApplication.class, crc642fa45b318a392027.MainApplication.__md_methods);
		
	}
}

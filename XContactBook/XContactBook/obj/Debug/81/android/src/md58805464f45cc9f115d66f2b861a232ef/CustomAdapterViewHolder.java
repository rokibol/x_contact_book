package md58805464f45cc9f115d66f2b861a232ef;


public class CustomAdapterViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XContactBook.CustomAdapterViewHolder, XContactBook", CustomAdapterViewHolder.class, __md_methods);
	}


	public CustomAdapterViewHolder ()
	{
		super ();
		if (getClass () == CustomAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("XContactBook.CustomAdapterViewHolder, XContactBook", "", this, new java.lang.Object[] {  });
	}

	public CustomAdapterViewHolder (android.view.View p0)
	{
		super ();
		if (getClass () == CustomAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("XContactBook.CustomAdapterViewHolder, XContactBook", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

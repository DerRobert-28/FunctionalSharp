namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer1<T>(T v);

	public static class Consumer1_ {

		public static void accept<T>(this Consumer1<T> c, T v) => c.Invoke(v);
		
		public static Consumer1<T> accept<T>(this Consumer1<T> c) => v => c.Invoke(v);

	}

}

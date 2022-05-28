namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer2<T1, T2>(T1 v1, T2 v2);

	public static class Consumer2_ {

		public static void accept<T1, T2>(this Consumer2<T1, T2> c, T1 v1, T2 v2) => c.Invoke(v1, v2);

		public static Consumer1<T2> accept<T1, T2>(this Consumer2<T1, T2> c, T1 v1) => v2 => c.accept(v1, v2);
		
		public static Consumer2<T1, T2> accept<T1, T2>(this Consumer2<T1, T2> c) => c;

	}

}

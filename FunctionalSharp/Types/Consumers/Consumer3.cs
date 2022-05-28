namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer3<T1, T2, T3>(T1 v1, T2 v2, T3 v3);

	public static class Consumer3_ {

		public static void accept<T1, T2, T3>(this Consumer3<T1, T2, T3> c, T1 v1, T2 v2, T3 v3) => c.Invoke(v1, v2, v3);

		public static Consumer1<T3> accept<T1, T2, T3>(this Consumer3<T1, T2, T3> c, T1 v1, T2 v2) => v3 => c.accept(v1, v2, v3);
		
		public static Consumer2<T2, T3> accept<T1, T2, T3>(this Consumer3<T1, T2, T3> c, T1 v1) => (v2, v3) => c.accept(v1, v2, v3);

		public static Consumer3<T1, T2, T3> accept<T1, T2, T3>(this Consumer3<T1, T2, T3> c) => c;

	}

}

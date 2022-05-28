namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer5<T1, T2, T3, T4, T5>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5);
	
	public static class Consumer5_ {

		public static void accept<T1, T2, T3, T4, T5>(this Consumer5<T1, T2, T3, T4, T5> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) => c.Invoke(v1, v2, v3, v4, v5);
		
		public static Consumer1<T5> accept<T1, T2, T3, T4, T5>(this Consumer5<T1, T2, T3, T4, T5> c, T1 v1, T2 v2, T3 v3, T4 v4) => v5 => c.accept(v1, v2, v3, v4, v5);

		public static Consumer2<T4, T5> accept<T1, T2, T3, T4, T5>(this Consumer5<T1, T2, T3, T4, T5> c, T1 v1, T2 v2, T3 v3) => (v4, v5) => c.accept(v1, v2, v3, v4, v5);

		public static Consumer3<T3, T4, T5> accept<T1, T2, T3, T4, T5>(this Consumer5<T1, T2, T3, T4, T5> c, T1 v1, T2 v2) => (v3, v4, v5) => c.accept(v1, v2, v3, v4, v5);

		public static Consumer4<T2, T3, T4, T5> accept<T1, T2, T3, T4, T5>(this Consumer5<T1, T2, T3, T4, T5> c, T1 v1) => (v2, v3, v4, v5) => c.accept(v1, v2, v3, v4, v5);

		public static Consumer5<T1, T2, T3, T4, T5> accept<T1, T2, T3, T4, T5>(this Consumer5<T1, T2, T3, T4, T5> c) => c;

	}

}
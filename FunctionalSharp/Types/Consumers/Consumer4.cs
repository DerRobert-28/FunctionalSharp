namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer4<T1, T2, T3, T4>(T1 v1, T2 v2, T3 v3, T4 v4);

	public static class Consumer4_ {

		public static void accept<T1, T2, T3, T4>(this Consumer4<T1, T2, T3, T4> c, T1 v1, T2 v2, T3 v3, T4 v4) => c.Invoke(v1, v2, v3, v4);

		public static Consumer1<T4> accept<T1, T2, T3, T4>(this Consumer4<T1, T2, T3, T4> c, T1 v1, T2 v2, T3 v3) => v4 => c.accept(v1, v2, v3, v4);

		public static Consumer2<T3, T4> accept<T1, T2, T3, T4>(this Consumer4<T1, T2, T3, T4> c, T1 v1, T2 v2) => (v3, v4) => c.accept(v1, v2, v3, v4);

		public static Consumer3<T2, T3, T4> accept<T1, T2, T3, T4>(this Consumer4<T1, T2, T3, T4> c, T1 v1) => (v2, v3, v4) => c.accept(v1, v2, v3, v4);

		public static Consumer4<T1, T2, T3, T4> accept<T1, T2, T3, T4>(this Consumer4<T1, T2, T3, T4> c) => c;

	}

}

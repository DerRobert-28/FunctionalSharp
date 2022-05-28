namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer6<T1, T2, T3, T4, T5, T6>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6);

	public static class Consumer6_ {

		public static void accept<T1, T2, T3, T4, T5, T6>(this Consumer6<T1, T2, T3, T4, T5, T6> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6) => c.Invoke(v1, v2, v3, v4, v5, v6);

		public static Consumer1<T6> accept<T1, T2, T3, T4, T5, T6>(this Consumer6<T1, T2, T3, T4, T5, T6> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) => v6 => c.Invoke(v1, v2, v3, v4, v5, v6);

		public static Consumer2<T5, T6> accept<T1, T2, T3, T4, T5, T6>(this Consumer6<T1, T2, T3, T4, T5, T6> c, T1 v1, T2 v2, T3 v3, T4 v4) => (v5, v6) => c.Invoke(v1, v2, v3, v4, v5, v6);

		public static Consumer3<T4, T5, T6> accept<T1, T2, T3, T4, T5, T6>(this Consumer6<T1, T2, T3, T4, T5, T6> c, T1 v1, T2 v2, T3 v3) => (v4, v5, v6) => c.Invoke(v1, v2, v3, v4, v5, v6);

		public static Consumer4<T3, T4, T5, T6> accept<T1, T2, T3, T4, T5, T6>(this Consumer6<T1, T2, T3, T4, T5, T6> c, T1 v1, T2 v2) => (v3, v4, v5, v6) => c.Invoke(v1, v2, v3, v4, v5, v6);

		public static Consumer5<T2, T3, T4, T5, T6> accept<T1, T2, T3, T4, T5, T6>(this Consumer6<T1, T2, T3, T4, T5, T6> c, T1 v1) => (v2, v3, v4, v5, v6) => c.Invoke(v1, v2, v3, v4, v5, v6);

		public static Consumer6<T1, T2, T3, T4, T5, T6> accept<T1, T2, T3, T4, T5, T6>(this Consumer6<T1, T2, T3, T4, T5, T6> c) => c;

	}

}

namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer8<T1, T2, T3, T4, T5, T6, T7, T8>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8);

	public static class Consumer8_ {

		public static void accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer1<T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7) => v8 => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer2<T7, T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6) => (v7, v8) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer3<T6, T7, T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) => (v6, v7, v8) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer4<T5, T6, T7, T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1, T2 v2, T3 v3, T4 v4) => (v5, v6, v7, v8) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer5<T4, T5, T6, T7, T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1, T2 v2, T3 v3) => (v4, v5, v6, v7, v8) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer6<T3, T4, T5, T6, T7, T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1, T2 v2) => (v3, v4, v5, v6, v7, v8) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer7<T2, T3, T4, T5, T6, T7, T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c, T1 v1) => (v2, v3, v4, v5, v6, v7, v8) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8);

		public static Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> accept<T1, T2, T3, T4, T5, T6, T7, T8>(this Consumer8<T1, T2, T3, T4, T5, T6, T7, T8> c) => c;

	}

}

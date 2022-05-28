namespace DerRobert.FunctionalSharp.Types.Consumers {

	public delegate void Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9);

	public static class Consumer9_ {

		public static void accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer1<T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8) => v9 => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer2<T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7) => (v8, v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer3<T7, T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6) => (v7, v8, v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer4<T6, T7, T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) => (v6, v7, v8, v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer5<T5, T6, T7, T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2, T3 v3, T4 v4) => (v5, v6, v7, v8, v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer6<T4, T5, T6, T7, T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2, T3 v3) => (v4, v5, v6, v7, v8, v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer7<T3, T4, T5, T6, T7, T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1, T2 v2) => (v3, v4, v5, v6, v7, v8, v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer8<T2, T3, T4, T5, T6, T7, T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c, T1 v1) => (v2, v3, v4, v5, v6, v7, v8, v9) => c.Invoke(v1, v2, v3, v4, v5, v6, v7, v8, v9);

		public static Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> accept<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Consumer9<T1, T2, T3, T4, T5, T6, T7, T8, T9> c) => c;

	}

}

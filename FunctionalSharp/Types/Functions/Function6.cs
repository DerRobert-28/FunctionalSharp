namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function6<T1, T2, T3, T4, T5, T6, R>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6);

	public static class Function6_ {

		public static R apply<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6) => f.Invoke(a1, a2, a3, a4, a5, a6);
		public static Function1<T6, R> apply<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5) => a6 => f.apply(a1, a2, a3, a4, a5, a6);
		public static Function2<T5, T6, R> apply<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f, T1 a1, T2 a2, T3 a3, T4 a4) => (a5, a6) => f.apply(a1, a2, a3, a4, a5, a6);
		public static Function3<T4, T5, T6, R> apply<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f, T1 a1, T2 a2, T3 a3) => (a4, a5, a6) => f.apply(a1, a2, a3, a4, a5, a6);
		public static Function4<T3, T4, T5, T6, R> apply<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f, T1 a1, T2 a2) => (a3, a4, a5, a6) => f.apply(a1, a2, a3, a4, a5, a6);
		public static Function5<T2, T3, T4, T5, T6, R> apply<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f, T1 a1) => (a2, a3, a4, a5, a6) => f.apply(a1, a2, a3, a4, a5, a6);
		public static Function6<T1, T2, T3, T4, T5, T6, R> apply<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f) => f;

		public static int arity<T1, T2, T3, T4, T5, T6, R>(this Function6<T1, T2, T3, T4, T5, T6, R> f) => 6;

	}

}

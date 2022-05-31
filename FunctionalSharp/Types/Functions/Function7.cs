namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function7<T1, T2, T3, T4, T5, T6, T7, R>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7);

	public static class Function7_ {

		public static R apply<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7) => f.Invoke(a1, a2, a3, a4, a5, a6, a7);
		public static Function1<T7, R> apply<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6) => a7 => f.apply(a1, a2, a3, a4, a5, a6, a7);
		public static Function2<T6, T7, R> apply<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5) => (a6, a7) => f.apply(a1, a2, a3, a4, a5, a6, a7);
		public static Function3<T5, T6, T7, R> apply<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f, T1 a1, T2 a2, T3 a3, T4 a4) => (a5, a6, a7) => f.apply(a1, a2, a3, a4, a5, a6, a7);
		public static Function4<T4, T5, T6, T7, R> apply<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f, T1 a1, T2 a2, T3 a3) => (a4, a5, a6, a7) => f.apply(a1, a2, a3, a4, a5, a6, a7);
		public static Function5<T3, T4, T5, T6, T7, R> apply<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f, T1 a1, T2 a2) => (a3, a4, a5, a6, a7) => f.apply(a1, a2, a3, a4, a5, a6, a7);
		public static Function6<T2, T3, T4, T5, T6, T7, R> apply<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f, T1 a1) => (a2, a3, a4, a5, a6, a7) => f.apply(a1, a2, a3, a4, a5, a6, a7);

		public static int arity<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f) => 7;

		public static Function7<T1, T2, T3, T4, T5, T6, T7, R> identity<T1, T2, T3, T4, T5, T6, T7, R>(this Function7<T1, T2, T3, T4, T5, T6, T7, R> f) => f;

	}

}

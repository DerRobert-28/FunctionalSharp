namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function8<T1, T2, T3, T4, T5, T6, T7, T8, R>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8);

	public static class Function8_ {
	
		public static R apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8) => f.Invoke(a1, a2, a3, a4, a5, a6, a7, a8);
		public static Function1<T8, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7) => a8 => f.apply(a1, a2, a3, a4, a5, a6, a7, a8);
		public static Function2<T7, T8, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6) => (a7, a8) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8);
		public static Function3<T6, T7, T8, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5) => (a6, a7, a8) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8);
		public static Function4<T5, T6, T7, T8, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1, T2 a2, T3 a3, T4 a4) => (a5, a6, a7, a8) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8);
		public static Function5<T4, T5, T6, T7, T8, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1, T2 a2, T3 a3) => (a4, a5, a6, a7, a8) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8);
		public static Function6<T3, T4, T5, T6, T7, T8, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1, T2 a2) => (a3, a4, a5, a6, a7, a8) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8);
		public static Function7<T2, T3, T4, T5, T6, T7, T8, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f, T1 a1) => (a2, a3, a4, a5, a6, a7, a8) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8);

		public static int arity<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f) => 8;

		public static Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> identity<T1, T2, T3, T4, T5, T6, T7, T8, R>(this Function8<T1, T2, T3, T4, T5, T6, T7, T8, R> f) => f;

	}

}

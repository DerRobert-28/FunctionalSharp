namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9);

	public static class Function9_ {

		public static R apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8, T9 a9) => f.Invoke(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function1<T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7, T8 a8) => a9 => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function2<T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6, T7 a7) => (a8, a9) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function3<T7, T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5, T6 a6) => (a7, a8, a9) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function4<T6, T7, T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2, T3 a3, T4 a4, T5 a5) => (a6, a7, a8, a9) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function5<T5, T6, T7, T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2, T3 a3, T4 a4) => (a5, a6, a7, a8, a9) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function6<T4, T5, T6, T7, T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2, T3 a3) => (a4, a5, a6, a7, a8, a9) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function7<T3, T4, T5, T6, T7, T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1, T2 a2) => (a3, a4, a5, a6, a7, a8, a9) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function8<T2, T3, T4, T5, T6, T7, T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f, T1 a1) => (a2, a3, a4, a5, a6, a7, a8, a9) => f.apply(a1, a2, a3, a4, a5, a6, a7, a8, a9);
		public static Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> apply<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f) => f;

		public static int arity<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(this Function9<T1, T2, T3, T4, T5, T6, T7, T8, T9, R> f) => 9;

	}

}

namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function4<T1, T2, T3, T4, R>(T1 a1, T2 a2, T3 a3, T4 a4);

	public static class Function4_ {

		public static R apply<T1, T2, T3, T4, R>(this Function4<T1, T2, T3, T4, R> f, T1 a1, T2 a2, T3 a3, T4 a4) => f.Invoke(a1, a2, a3, a4);
		public static Function1<T4, R> apply<T1, T2, T3, T4, R>(this Function4<T1, T2, T3, T4, R> f, T1 a1, T2 a2, T3 a3) => a4 => f.apply(a1, a2, a3, a4);
		public static Function2<T3, T4, R> apply<T1, T2, T3, T4, R>(this Function4<T1, T2, T3, T4, R> f, T1 a1, T2 a2) => (a3, a4) => f.apply(a1, a2, a3, a4);
		public static Function3<T2, T3, T4, R> apply<T1, T2, T3, T4, R>(this Function4<T1, T2, T3, T4, R> f, T1 a1) => (a2, a3, a4) => f.apply(a1, a2, a3, a4);
		public static Function4<T1, T2, T3, T4, R> apply<T1, T2, T3, T4, R>(this Function4<T1, T2, T3, T4, R> f) => f;

		public static int arity<T1, T2, T3, T4, R>(this Function4<T1, T2, T3, T4, R> f) => 4;

	}

}

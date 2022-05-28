namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function3<T1, T2, T3, R>(T1 a1, T2 a2, T3 a3);

	public static class Function3_ {

		public static R apply<T1, T2, T3, R>(this Function3<T1, T2, T3, R> f, T1 a1, T2 a2, T3 a3) => f.Invoke(a1, a2, a3);
		public static Function1<T3, R> apply<T1, T2, T3, R>(this Function3<T1, T2, T3, R> f, T1 a1, T2 a2) => a3 => f.apply(a1, a2, a3);
		public static Function2<T2, T3, R> apply<T1, T2, T3, R>(this Function3<T1, T2, T3, R> f, T1 a1) => (a2, a3) => f.apply(a1, a2, a3);
		public static Function3<T1, T2, T3, R> apply<T1, T2, T3, R>(this Function3<T1, T2, T3, R> f) => f;

		public static int arity<T1, T2, T3, R>(this Function3<T1, T2, T3, R> f) => 3;

	}

}

namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function2<T1, T2, R>(T1 a1, T2 a2);

	public static class Function2_ {

		public static R apply<T1, T2, R>(this Function2<T1, T2, R> f, T1 a1, T2 a2) => f.Invoke(a1, a2);
		public static Function1<T2, R> apply<T1, T2, R>(this Function2<T1, T2, R> f, T1 a1) => a2 => f.apply(a1, a2);
		public static Function2<T1, T2, R> apply<T1, T2, R>(this Function2<T1, T2, R> f) => f;

		public static int arity<T1, T2, R>(this Function2<T1, T2, R> f) => 2;

	}

}

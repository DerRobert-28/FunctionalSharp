namespace DerRobert.FunctionalSharp.Types.Functions {

	public delegate R Function0<R>();

	public static class Function0_ {

		public static R apply<R>(this Function0<R> f) => f.Invoke();

		public static int arity<R>(this Function0<R> f) => 0;

		public static Function0<R> identity<R>(this Function0<R> f) => f;

	}

}

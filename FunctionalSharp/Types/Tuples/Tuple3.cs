namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;


	public class Tuple3 {
		public static Tuple3<T1, T2, T3> of<T1, T2, T3>(T1 t1, T2 t2, T3 t3) => Tuple3<T1, T2, T3>.of(t1, t2, t3);
	}


	public class Tuple3<T1, T2, T3>: ITuple, ITuple3<T1, T2, T3> {

		private readonly T1 t1;
		private readonly T2 t2;
		private readonly T3 t3;

		public static Tuple3<T1, T2, T3> of(T1 t1, T2 t2, T3 t3) => new Tuple3<T1, T2, T3>(t1, t2, t3);

		public override int arity() => 3;

		public T1 _1 => t1;
		public T2 _2 => t2;
		public T3 _3 => t3;

		private Tuple3(T1 t1, T2 t2, T3 t3) {
			this.t1 = t1;
			this.t2 = t2;
			this.t3 = t3;
		}

	}

}

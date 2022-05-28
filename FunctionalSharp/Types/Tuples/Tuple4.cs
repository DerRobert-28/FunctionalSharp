namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;


	public class Tuple4 {
		public static Tuple4<T1, T2, T3, T4> of<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4) => Tuple4<T1, T2, T3, T4>.of(t1, t2, t3, t4);
	}


	public class Tuple4<T1, T2, T3, T4>: ITuple, ITuple4<T1, T2, T3, T4> {

		private readonly T1 t1;
		private readonly T2 t2;
		private readonly T3 t3;
		private readonly T4 t4;

		public static Tuple4<T1, T2, T3, T4> of(T1 t1, T2 t2, T3 t3, T4 t4) => new Tuple4<T1, T2, T3, T4>(t1, t2, t3, t4);

		public override int arity() => 4;

		public T1 _1 => t1;
		public T2 _2 => t2;
		public T3 _3 => t3;
		public T4 _4 => t4;

		private Tuple4(T1 t1, T2 t2, T3 t3, T4 t4) {
			this.t1 = t1;
			this.t2 = t2;
			this.t3 = t3;
			this.t4 = t4;
		}

	}

}

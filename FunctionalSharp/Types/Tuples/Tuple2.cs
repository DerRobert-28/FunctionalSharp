namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;


	public class Tuple2 {
		public static Tuple2<T1, T2> of<T1, T2>(T1 t1, T2 t2) => Tuple2<T1, T2>.of(t1, t2);
	}


	public class Tuple2<T1, T2>: ITuple, ITuple2<T1, T2> {

		private readonly T1 t1;
		private readonly T2 t2;

		public static Tuple2<T1, T2> of(T1 t1, T2 t2) => new Tuple2<T1, T2>(t1, t2);

		public override int arity() => 2;

		public T1 _1 => t1;
		public T2 _2 => t2;

		private Tuple2(T1 t1, T2 t2) {
			this.t1 = t1;
			this.t2 = t2;
		}

	}

}

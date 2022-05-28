namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;


	public class Tuple6 {
		public static Tuple6<T1, T2, T3, T4, T5, T6> of<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => Tuple6<T1, T2, T3, T4, T5, T6>.of(t1, t2, t3, t4, t5, t6);
	}


	public class Tuple6<T1, T2, T3, T4, T5, T6>: ITuple, ITuple6<T1, T2, T3, T4, T5, T6> {

		private readonly T1 t1;
		private readonly T2 t2;
		private readonly T3 t3;
		private readonly T4 t4;
		private readonly T5 t5;
		private readonly T6 t6;

		public static Tuple6<T1, T2, T3, T4, T5, T6> of(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => new Tuple6<T1, T2, T3, T4, T5, T6>(t1, t2, t3, t4, t5, t6);

		public override int arity() => 6;

		public T1 _1 => t1;
		public T2 _2 => t2;
		public T3 _3 => t3;
		public T4 _4 => t4;
		public T5 _5 => t5;
		public T6 _6 => t6;

		private Tuple6(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) {
			this.t1 = t1;
			this.t2 = t2;
			this.t3 = t3;
			this.t4 = t4;
			this.t5 = t5;
			this.t6 = t6;
		}

	}

}

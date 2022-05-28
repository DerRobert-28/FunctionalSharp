namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;


	public class Tuple8 {
		public static Tuple8<T1, T2, T3, T4, T5, T6, T7, T8> of<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => Tuple8<T1, T2, T3, T4, T5, T6, T7, T8>.of(t1, t2, t3, t4, t5, t6, t7, t8);
	}


	public class Tuple8<T1, T2, T3, T4, T5, T6, T7, T8>: ITuple, ITuple8<T1, T2, T3, T4, T5, T6, T7, T8> {

		private readonly T1 t1;
		private readonly T2 t2;
		private readonly T3 t3;
		private readonly T4 t4;
		private readonly T5 t5;
		private readonly T6 t6;
		private readonly T7 t7;
		private readonly T8 t8;

		public static Tuple8<T1, T2, T3, T4, T5, T6, T7, T8> of(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => new Tuple8<T1, T2, T3, T4, T5, T6, T7, T8>(t1, t2, t3, t4, t5, t6, t7, t8);

		public override int arity() => 8;

		public T1 _1 => t1;
		public T2 _2 => t2;
		public T3 _3 => t3;
		public T4 _4 => t4;
		public T5 _5 => t5;
		public T6 _6 => t6;
		public T7 _7 => t7;
		public T8 _8 => t8;

		private Tuple8(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) {
			this.t1 = t1;
			this.t2 = t2;
			this.t3 = t3;
			this.t4 = t4;
			this.t5 = t5;
			this.t6 = t6;
			this.t7 = t7;
			this.t8 = t8;
		}

	}

}

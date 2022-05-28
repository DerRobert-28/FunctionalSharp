namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;
	

	public class Tuple1 {
		public static Tuple1<T1> of<T1>(T1 t1) => Tuple1<T1>.of(t1);
	}


	public class Tuple1<T1>: ITuple, ITuple1<T1> {

		private readonly T1 t1;
		
		public static Tuple1<T1> of(T1 t1) => new Tuple1<T1>(t1);
		
		public override int arity() => 2;
		
		public T1 _1 => t1;

		private Tuple1(T1 t1) => this.t1 = t1;

	}

}

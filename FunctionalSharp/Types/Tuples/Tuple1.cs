namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;
	

	public class Tuple1 {
		public static Tuple1<T> of<T>(T t) => Tuple1<T>.of(t);
	}


	public class Tuple1<T>: ITuple, ITuple1<T> {

		private readonly T t;
		
		public static Tuple1<T> of(T t) => new Tuple1<T>(t);
		
		public override int arity() => 1;
		
		public T _1 => t;

		private Tuple1(T t) => this.t = t;

	}

}

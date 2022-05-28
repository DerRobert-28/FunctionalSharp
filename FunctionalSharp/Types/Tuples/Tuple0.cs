namespace DerRobert.FunctionalSharp.Types.Tuples {

	using DerRobert.FunctionalSharp.Interfaces;

	//
	public class Tuple0: ITuple, ITuple0 {
	
		public static Tuple0 of() => new Tuple0();

		public override int arity() => 0;

		private Tuple0() {}

	}

}

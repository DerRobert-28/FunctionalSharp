namespace DerRobert.FunctionalSharp.Interfaces {

	public abstract class ITuple {
		public int MAX_ARITY => 9;
		public abstract int arity();
	}

	public interface ITuple0 {}

	public interface ITuple1<T> {
		T _1 { get; }
	}
	
	public interface ITuple2<T1, T2>: ITuple1<T1> {
		T2 _2 { get; }
	}
	
	public interface ITuple3<T1, T2, T3>: ITuple2<T1, T2> {
		T3 _3 { get; }
	}
	
	public interface ITuple4<T1, T2, T3, T4>: ITuple3<T1, T2, T3> {
		T4 _4 { get; }
	}
	
	public interface ITuple5<T1, T2, T3, T4, T5>: ITuple4<T1, T2, T3, T4> {
		T5 _5 { get; }
	}
	
	public interface ITuple6<T1, T2, T3, T4, T5, T6>: ITuple5<T1, T2, T3, T4, T5> {
		T6 _6 { get; }
	}
	
	public interface ITuple7<T1, T2, T3, T4, T5, T6, T7>: ITuple6<T1, T2, T3, T4, T5, T6> {
		T7 _7 { get; }
	}
	
	public interface ITuple8<T1, T2, T3, T4, T5, T6, T7, T8>: ITuple7<T1, T2, T3, T4, T5, T6, T7> {
		T8 _8 { get; }
	}
	
	public interface ITuple9<T1, T2, T3, T4, T5, T6, T7, T8, T9>: ITuple8<T1, T2, T3, T4, T5, T6, T7, T8> {
		T9 _9 { get; }
	}

}

namespace DerRobert.FunctionalSharp.Utils {

	public abstract class LanguageCandy<T> where T: LanguageCandy<T> {
		
		public T and => (T)this;
		public T having => (T)this;
		public T with => (T)this;

	}

}
 
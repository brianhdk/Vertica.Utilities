namespace Vertica.Utilities_v4.Eventing
{
	public class ValueChangedEventArgs<T> : ValueEventArgs<T>, IOldValueEventArgs<T>
	{
		public ValueChangedEventArgs(T value, T oldValue) : base(value)
		{
			OldValue = oldValue;
		}

		public T OldValue { get; private set; }
	}
}
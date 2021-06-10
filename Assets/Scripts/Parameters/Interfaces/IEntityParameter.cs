namespace Parameters.Interfaces
{
	public interface IEntityParameter
	{
	}

	public interface IEntityParameter<T> : IEntityParameter
	{
		T Value { get; set; }
	}
}
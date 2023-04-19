namespace ElectrumGames.Core.Input
{
    public interface IInput
    {
        public float VerticalDirection { get; }
        public float HorizontalDirection { get; }

        void Init();
        void Update(float deltaTime);
    }
}
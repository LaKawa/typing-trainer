namespace TypingTrainer.Core.Interfaces;

public interface ITextSource
{
    string Id { get; }
    string Title { get; }

    Task<string> GetTextAsync();
}
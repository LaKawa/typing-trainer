namespace TypingTrainer.Core.Interfaces;

public interface ITextExtractor
{
    Task<ITextSource> LoadAsync(string path);
}
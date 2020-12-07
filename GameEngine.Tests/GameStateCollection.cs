using Xunit;

namespace GameEngine.Tests
{
    // Create a "fixture" that allows other test to share the GameState collection of data
    // Use [Collection("GameState collection"] in tests that need to share the data
    
    [CollectionDefinition("GameState collection")]
    public class GameStateCollection : ICollectionFixture<GameStateFixture> {}
}

using Games.Specflow.Models;
using Games.Specflow.Repository;
using System;
using TechTalk.SpecFlow;

namespace Games.Specflow.Tests.StepDefinitions
{
    [Binding]
    public class GameCreationStepDefinitions
    {
        private Game _game;
        private readonly IGameRepository _gameRepository;

        public GameCreationStepDefinitions(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [Given(@"a game object")]
        public void GivenAGameObject()
        {
            _game = new Game(Guid.NewGuid().ToString(), "Diablo IV", "Description here", DateTime.Now, "Blizzard");
        }

        [When("Add new game called")]
        public async Task WhenAddNewGameCalled()
        {
            await _gameRepository.CreateAsync(_game);

            await Task.Delay(TimeSpan.FromSeconds(5));
        }

        [Then("create a new game in the InMemory Database")]
        public async void ThenCreateANewGameInMemoryDatabase()
        {
            var game = await _gameRepository.GetByIdAsync(_game.Id);

            Assert.Equal(game, _game);
        }
    }
}

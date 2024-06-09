using Item.Application.Queries;
using Item.Infrastructure.Repositories;
using Moq;
using Xunit;

namespace Item.Tests
{
    public class GetItemQueryHandlerTests
    {
        [Fact]
        public async Task Handle_Should_Return_Items()
        {
            //Arrange
            MockData mockData = new MockData();
            var mockItemRepo = new Mock<IItemRepository>();
            mockItemRepo.Setup(x => x.GetItemsAsync())
                .ReturnsAsync(mockData.GetItems());

            // Act
            var repo = new GetItemsQueryHandler(mockItemRepo.Object);
            var request = new GetItemsQuery();
            var results = await repo.Handle(request, CancellationToken.None);

            // Assert
            Assert.NotNull(results);
            Assert.Equal(mockData.GetItems().Count(), results.Count());
            mockItemRepo.Verify(x => x.GetItemsAsync(), Times.Once());
        }
    }
}

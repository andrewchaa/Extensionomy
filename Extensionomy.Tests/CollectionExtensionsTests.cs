using System.Collections.Generic;
using Machine.Specifications;

namespace Extensionomy.Tests
{
    [Subject(typeof(CollectionExtensions))]
    public class CollectionExtensionsTests
    {
        private static IList<string> _collection;

        Establish context = () =>
        {
            _collection = new List<string>();
        };

        It should_be_empty = () => _collection.IsEmpty().ShouldBeTrue();
    };
}

// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base.responses.page
{
    /// <summary>
    ///     Links connected to page response.
    /// </summary>
    public class PageLinks<T>
    {
        public PageLinks(Link<Page<T>> next, Link<Page<T>> prev, Link<Page<T>> self)
        {
            Next = next;
            Prev = prev;
            Self = self;
        }

        public Link<Page<T>> Next { get; }

        public Link<Page<T>> Prev { get; }

        public Link<Page<T>> Self { get; }
    }
}

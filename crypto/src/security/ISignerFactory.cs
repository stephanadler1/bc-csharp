using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Security
{
    /// <summary>
    /// An extensible factory class that allows do overwrite or replace <see cref="ISigner"/>
    /// implementations.
    /// </summary>
    public interface ISignerFactory
    {
        ISigner GetSigner(string algorithm);
    }
}

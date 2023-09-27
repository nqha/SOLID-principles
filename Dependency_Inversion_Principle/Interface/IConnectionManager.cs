using Open_Close_Principle.Interface;

namespace Dependency_Inversion_Principle.Interface
{
    public interface IConnectionManager
    {
        public void DoConnection(IConnection connection);
    }
}

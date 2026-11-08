using ObjectPool.Interface;
using ObjectPool.Model;
using ObjectPool.Pool;

namespace ObjectPool;

public static class Program
{
    public static readonly IPool<Player> Pool = new StackPool();
    public static void Main()
    {
        Player p1 = Pool.Rent()
                        .SetName("P1")
                        .SetHP(1000)
                        .SetMP(10);
        Player p2 = Pool.Rent()
                        .SetName("P2")
                        .SetHP(1000)
                        .SetMP(10);

        // 작업

        Pool.Return(p1);
        Pool.Return(p2);
        return;
    }
}
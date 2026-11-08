using System.Collections.Concurrent;
using ObjectPool.Interface;
using ObjectPool.Model;

namespace ObjectPool.Pool;

public class QueuePool: IPool<Player>
{
    private ConcurrentQueue<Player> _playerPool = new();
    private int _lastId = 0;
    public QueuePool()
    {
        for(int i = 0; i < 50; i++) _playerPool.Enqueue(new(_lastId++, string.Empty, 100, 0));
    }

    public Player Rent()
    {
        if(_playerPool.TryDequeue(out var result))
        {
            return result;
        }
        else
        {
            return new(_lastId++, string.Empty, 100, 0);
        }
    }

    public void Return(Player returnPlayer)
    {
        if(_playerPool.Any((player) => player.Id == returnPlayer.Id)) return;
        _playerPool.Enqueue(returnPlayer);
    }
}
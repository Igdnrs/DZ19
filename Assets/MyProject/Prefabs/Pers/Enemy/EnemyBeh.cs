public abstract class EnemyBeh
{
    protected Enemy agent;
    public EnemyBeh(Enemy agent)
    {
        this.agent = agent;
    }
    abstract public void Enter();
    abstract public void Exit();
    abstract public void Update();
}

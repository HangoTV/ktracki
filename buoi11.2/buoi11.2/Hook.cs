namespace buoi11._2;

public class Hook
{
    private int _speed;
    private bool _isThrowing;

    public HookState state
    {
        get;
        private set;
        //private set : tuc la chi dc thay doi trang thai
    }
    public int speed
    {
        get{return _speed;}
        set
        {
            _speed = value;
        }
    }

    public bool isThrowing
    {
        get
        {
            return _isThrowing;
        }
        set{
            _isThrowing = value;
        }
    }

    public void Throw()
    {
        IsThrowing = true;
    }

    public bool IsThrowing { get; set; }

    public void pull()
    {
        isThrowing = false;
    }
}
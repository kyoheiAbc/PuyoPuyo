using UnityEngine;
public class Combo
{
    private int combo;
    private I end = new I();


    public Combo()
    {
        this.Reset();
    }

    public void Update(int i)
    {
        this.end.Update();

        if (this.end.i > 180)
        {
            this.Reset();
            return;
        }

        if (this.combo > 0 && i == -1)
        {
            this.end.Start();
        }
        if (i != -1)
        {
            this.combo += i;
            if (i > 0)
            {
                this.end.i = 0;
            }
        }
    }
    public void Reset()
    {
        this.end.i = 0;
        this.combo = 0;
    }

    public int GetCombo()
    {
        return this.combo;
    }



}
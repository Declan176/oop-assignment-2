internal class die
{
    public int die_result;

    random rnd = new random;

    public int roll()
    {
        die_result = rnd.next(1,7);
        return die_value;
    }
}

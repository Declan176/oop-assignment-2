internal class game
{
    int value1;
    int value2;
    int value3;
    int value4;
    int value5;
    int total;
    int p1_running_total;
    int p2_running_total;
    string confirm;

    die die1 = new die();
    die die2 = new die();
    die die3 = new die();
    die die4 = new die();
    die die5 = new die();

    public void sevens_out()
    {
        while true
        {
            value1 = die1.roll;
            value2 = die2.roll;
            total = value1 + value2;
            if(total = 7)
            {
                p1_running_total = p1_running_total + total;
                break
            }
            else if(value1 = value2)
            {
                total = total * 2;
            }
            p1_running_total = p1_running_total + total;

        }
        return p1_running_total

    }



    

}
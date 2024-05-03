game run_game = new game();
testing test = new testing();

testing.test();

string confirm;
while true
{
    run_game.sevens_out();
    console.writeline("your final score is " + run_game.p1_running_total + "would you liek to play again?");
    confirm = console.readline();
    if(confirm = "no")
    {
        break;
    }
}

int Distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int count = 0;
int friend = 2;
int time = 0;



do 
{
    if(friend == 1)
    {
        time = Distance/(FirstFriendSpeed + dogSpeed);
        friend = 2;
        Distance = Distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
        count = count + 1; 
    }

    else
    {
        time = Distance/(SecondFriendSpeed + dogSpeed); 
        friend = 1;
        Distance = Distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
        count = count + 1; 
    }
} 
while(Distance > 10);
Console.Write(count); 

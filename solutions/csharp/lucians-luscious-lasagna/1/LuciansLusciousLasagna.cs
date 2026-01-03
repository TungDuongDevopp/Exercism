class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven ){
        return ExpectedMinutesInOven() - minutesInOven ;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int prepareMinute){
        return 2*prepareMinute;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int prepareMinute,int minutesInOven){
        return PreparationTimeInMinutes(prepareMinute) + minutesInOven;
    }
}

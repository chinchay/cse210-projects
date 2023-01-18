public class Job {
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    
    public Job(){

    }

    public void Display(){
        // Software Engineer (Microsoft) 2019-2022
        // Console.WriteLine( _jobTitle + " (" + _company + ") " + _startYear + "-" + _endYear );
        Console.WriteLine( $"{_jobTitle} ({_company}) {_startYear}-{_endYear}" );
        
        
    }
}
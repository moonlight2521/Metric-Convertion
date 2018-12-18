using System;

public class Metric
{
    // private string meter;
    // private string centermeter;
    private double value = 3.28084;
    private int feet = 0;
    private double inches = 0;
    // private double d = 0;
    // Constructor that takes no arguments
    public Metric()
    {
        meter = "1";
        centermeter = "1";
    }

    // Constructor that takes two argument:
    public Metric(string m, string c)
    {
        this.meter = m;
        this.centermeter = c;
    }
    public void convert(){
        string add = meter+"."+centermeter;
        double aTemp = (double.Parse(add) * value);
        feet = (int)(aTemp);
        double temp = ((aTemp) - Math.Truncate((aTemp))) / 0.08833; 
        // inches = (int)temp + (int)(Double.Parse(centermeter) / value);
        inches = (int)temp;
        // inches = (double.Parse(centermeter) * value) /10;
        // d = feet + inches;
    }

    // Auto-implemented readonly property:
    public string meter { get; }
    public string centermeter { get; }

 
    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        // return feet +"." + inches;
        return feet+" feets " +inches+ " inches";
    }
}

public class Weight
{
    private double value = 2.205;
    private double pound = 0;

    // Constructor that takes no arguments
    public Weight()
    {
        kGram = "1";
    }

    // Constructor that takes two argument:
    public Weight(string m)
    {
        this.kGram = m;
    }
    public void wegihtConvert(){
        pound = (double.Parse(kGram) * value);
    }

    // Auto-implemented readonly property:
    public string kGram { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
      return pound + "";
    }
}
    class TestProgram{
        // public static string mInput, cInput;

        public static int n = 0;
        public static bool flag = true;
        static void Main(){
            // while(n < 3){
                string pick, mInput, cInput = "";
            //     Console.WriteLine("This program convert meters and centermeters to feets and feets and inches: ");
            //     Console.Write("Enter meters: ");
            //     mInput = Console.ReadLine();
            //     Console.Write("Enter centermeters: ");
            //     cInput = Console.ReadLine();
            //     var obj = new Metric(mInput,cInput);
            //     obj.convert();
            //     Console.WriteLine("you inputed "+mInput+" meters "+ cInput +" centermeters which is converted into "+ obj);
            //     Console.WriteLine("");
            //     n++;           
            // }

        // Console.WriteLine("This program kilgram to pounds: ");
        // Console.Write("Enter kilgram: ");
        // mInput = Console.ReadLine();
        // var weightObj = new Weight(mInput);
        // weightObj.wegihtConvert();
        // Console.WriteLine(weightObj);
            while(flag == true){
                Console.WriteLine("This program convert metric system press: ");
                Console.WriteLine("press 1 for distantce conversion ");
                Console.WriteLine("press 2 for weight conversion");
                Console.WriteLine("press any other key to quit. ");

                pick = Console.ReadLine();
                if(pick == "1"){
                    Console.Write("Enter meters: ");
                    mInput = Console.ReadLine();
                    Console.Write("Enter centermeters: ");
                    cInput = Console.ReadLine();
                    var obj = new Metric(mInput,cInput);
                    obj.convert();
                    Console.WriteLine("you inputed "+mInput+" meters "+ cInput +" centermeters which is converted into "+ obj);
                    Console.WriteLine("");
                } else if ( pick == "2"){
                    Console.WriteLine("This program kilgram to pounds: ");
                    Console.Write("Enter kilgram: ");
                    mInput = Console.ReadLine();
                    var weightObj = new Weight(mInput);
                    weightObj.wegihtConvert();
                    Console.WriteLine("you inputed "+mInput+" kilgram which is converted into " + weightObj +" pounds");
                    Console.WriteLine("");

                }else{
                    flag = false;
                }
            }

        }
    }

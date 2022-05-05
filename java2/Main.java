import java.util.Scanner;
public class Main {
    public static void main(String[]args){

     Scanner myObj = new Scanner(System.in);

        System.out.println("What would you like to do today?");
       
        String answer = myObj.nextLine();

        System.out.println("What you want to do: " + answer);
        System.out.println("How was your day on a scale of 1 -10");
        int goodday = myObj.nextInt();
        System.out.println("How has your week been on a scale of 1-10?");
        int goodweek = myObj.nextInt();
        int overall = goodday + goodweek;
        System.out.println("your week has been a " + overall);
    }
}

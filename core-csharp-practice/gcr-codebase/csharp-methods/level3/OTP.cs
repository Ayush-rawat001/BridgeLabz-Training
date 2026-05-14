using System;

class OTP{
    static void Main(){
        int[] otp = new int[10];
        for (int i = 0; i < 10; i++){
            otp[i] = GenerateOTP();
            Console.WriteLine(otp[i]);
        }
        Console.WriteLine(AreotpUnique(otp));
    }

    
    public static int GenerateOTP(){
        Random rnd = new Random();
        int otp = rnd.Next(100000, 1000000); 
        return otp;
    }

    public static bool AreotpUnique(int[] otp){
        for (int i = 0; i < otp.Length; i++){
            for (int j = i + 1; j < otp.Length; j++){
                if (otp[i] == otp[j])
                    return false;
            }
        }
        return true;
    }
}

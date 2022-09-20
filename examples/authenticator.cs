using System;  
using System.Text;  
using System.Security.Cryptography; 

public static class Authenticator {
    // NICManager authenticator 9/20/2022

    public static string getHash(string inputString) {
        return newHash(inputString);
    }

    // newHash is isolated so that it can be modified to other encryption algorithms if desired.
    private static string newHash(string inputString) {  
 
        using (SHA256 sha256Hash = SHA256.Create()) {

            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(inputString));  
            StringBuilder hash = new StringBuilder();  
            
            for (int i = 0; i < bytes.Length; i++) {  
                hash.Append(bytes[i].ToString("x2"));  
            }

            return hash.ToString();  
        }  
    }
}

public class GeneratorExample {
    
    public static void Main(string[] args) {
        string password = Authenticator.getHash("MyNewPassword123");
        Console.WriteLine(password);
    }
}
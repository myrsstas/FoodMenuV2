﻿/*
 * Άσκηση 3.8:
Τροποποιήστε την εφαρμογή φαγητού ως εξής:
Όταν ο χρήστης επιλέγει ένα φαγητό, η εφαρμογή πρέπει να το “προετοιμάσει”. 
Οπότε και θα πρέπει να περάσει ένα διάστημα μέχρι να βγάλει το μήνυμα 
“Your {selection} is ready.” (όπου {selection} το επιλεγμένο από τον χρήστη φαγητό). 
Αυτό το διάστημα ορίστε το στα 10 δευτερόλεπτα.
Μέχρι την προετοιμασία του φαγητού, ο χρήστης θα έχει τη δυνατότητα να ακυρώσει 
την προετοιμασία, πληκτρολογώντας τη λέξη “cancel”.
Σε περίπτωση που ο χρήστης ακυρώσει την παραγγελία του, η εφαρμογή θα πρέπει να 
δείξει το κατάλληλο μήνυμα και μετά να ξαναδείξει το μενού στον χρήστη.
 */


namespace Exercise3._8_Myrsini_Stasinou;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to our Menu v.2!");
        FoodMenuService.ShowMenu();
        
    }
}
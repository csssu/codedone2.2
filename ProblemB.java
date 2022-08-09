/**
 * @file ProblemTwo.java
 * @author amir aghazadeh (cssu.ama@gmail.com)
 * @brief count letters
 * @version 0.1.0
 * @date 2022-08-01
 * @id 2code2
 *
 * @copyright Copyright (c) 2022
 *
 */

import java.util.Scanner;

public class ProblemTwo {
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);

    // get input
    // ورودی رو بخون
    String alphabets = scanner.nextLine();

    char[] chars = "abcdefghijklmnopqrstuvwxyz".toCharArray();

    // Add one to the value of the counter for each letter that was entered out of
    // 26 letters
    // به ازای هر حرفی که از 26 حرف، ورودی داشت یکی به مقدار کانتر (شمارنده) اضافه
    // کن
    int counter = 0;
    for (int i = 0; i < 26; i++) {
      if (alphabets.contains(String.valueOf(chars[i])))
        counter++;
    }

    // print value of counter
    // مقدار کانتر رو چاپ کن
    System.out.println(counter);

    scanner.close();
  }
}
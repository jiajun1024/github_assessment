import java.util.Scanner;
import java.util.Arrays;

class LargestGap{
public static void main(String[] args)
  {
    int[] arraysNumber = {9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5};

    System.out.printf("\nGet array: " + Arrays.toString(arraysNumber) + "\n");
    
    Arrays.sort(arraysNumber);
    System.out.printf("After sorting get: " + Arrays.toString(arraysNumber) + "\n");

    int result = largestValue(arraysNumber);
    System.out.printf("\nLargest gap between sorted elements of the array: " + result);
  }

  public static int largestValue(int[] arraysNumber) 
  {
    Arrays.sort(arraysNumber);
    int max_value = 0;
    
    for (int index = 0; index < arraysNumber.length -1 ; index++) 
    {
      max_value = Math.max(arraysNumber[index + 1] - arraysNumber[index], max_value);
    }
    return max_value;
  }
}
using System.Text;

public static class Functions
{
    public static void SelectionSort(int[] arr)
    {
        int minPos = 0;
        int temp = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            minPos = i;
            for (int j = i + 1; j < arr.Length; j++) { 
                if( arr[j] < arr[minPos])
                {
                    minPos = j;
                }
                
            }
            temp = arr[minPos];
            arr[minPos] = arr[i];
            arr[i] = temp;
        }
    }

    public static void InsertionSort(int[] arr)
    {
        int temp = 0;
        int pos = 0;
        for(int i = 1; i < arr.Length; i++)
        {
            temp = arr[i];
            pos = i;
            while (pos > 0 && arr[pos - 1] > temp) 
            {
                arr[pos] = arr[pos - 1];
                pos--;
            }
            arr[pos] = temp;
        }
    }

    public static string MergeStrings(string s1, string s2)
    {
        int minLen = Math.Min(s1.Length, s2.Length);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < minLen; i++)
        {
            sb.Append(s1[i]);
            sb.Append(s2[i]);
        }
        if (s1.Length == s2.Length) return sb.ToString();
        else if (s1.Length < s2.Length) sb.Append(s2.Substring(minLen));
        else sb.Append(s1.Substring(minLen));
        return sb.ToString();
    }

    public static string PrintArray(int[] arr)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("[ ");
        foreach (int i in arr) { sb.Append(i + " "); }
        sb.Append("]");
        return sb.ToString();
    }
}

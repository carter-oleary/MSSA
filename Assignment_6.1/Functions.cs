public static class Functions
{
    public static string SearchHouse(SingleLinkedListNode<House> node, int num)
    {
        while (node != null)
        {
            if (node.Val.HouseNumber == num) return node.Val.ToString();
            node = node.next;
        }
        return "That house does not exist in the list";
    }

    public static void MoveZeros(int[] arr)
    {
        int numZeros = 0;
        int pointer = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                numZeros++;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] != 0)
            {
                arr[pointer] = arr[i];
                pointer++;
            }
            if (i >= arr.Length - numZeros) arr[i] = 0;
        }

    }
}


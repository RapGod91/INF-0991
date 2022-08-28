internal class Program {
    private static void Main (string[] args) {
        int[] numBinary = new int[3];

        for (int i = 1; i < 4; i++) {
            Console.WriteLine ("Type the " + i + "º binary: ");
            numBinary[i] = Convert.ToInt32 (Console.ReadLine ());
        }

        foreach (int position in numBinary) {
            Console.WriteLine (position);
        }

    }


}
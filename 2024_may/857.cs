public double MincostToHireWorkers(int[] quality, int[] wage, int k) 
    {
        var n = quality.Length;
        var q1 = new PriorityQueue<(int, int), double>();

        for(int i = 0; i < n; i++)
        {
            q1.Enqueue((quality[i], wage[i]), (1.0 * wage[i]) / quality[i]);
        }

        var result = double.MaxValue;
        var sum = 0.0;
        var q2 = new PriorityQueue<double, double>();
        
        while(q1.Count > 0)
        {
            var (ql, wg) = q1.Dequeue();
            var r = wg / (1.0 * ql);

            sum += ql;

            q2.Enqueue(-ql, -ql);

            if (q2.Count > k)
            {
                sum += q2.Dequeue();
            }

            if (q2.Count == k)
            {
                result = Math.Min(result, sum * r);
            }
        }

        return result;
    }
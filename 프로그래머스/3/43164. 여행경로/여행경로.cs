using System;
using System.Collections.Generic;
public class Solution
{
    Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
    List<string> answer = null;
    int ticketCount;

    public string[] solution(string[,] tickets)
    {
        ticketCount = tickets.GetLength(0);

        for (int i = 0; i < tickets.GetLength(0); i++)
        {
            if (graph.ContainsKey(tickets[i, 0]))
            { graph[tickets[i, 0]].Add(tickets[i, 1]); }
            else
            {
                graph.Add(tickets[i, 0], new List<string>());
                graph[tickets[i, 0]].Add(tickets[i, 1]);
            }
        }
        foreach (var dest in graph.Values)
            dest.Sort();

        List<string> path = new List<string> { "ICN" };
        DFS("ICN", path);

        return answer.ToArray();
    }
    void DFS(string str, List<string> path)
    {
        if (path.Count == ticketCount + 1)
        {
            answer = new List<string>(path);
            return;
        }

        if (!graph.ContainsKey(str))
            return;

        var destinations = graph[str];

        for (int i = 0; i < destinations.Count; i++)
        {
            if (destinations[i] == null) continue;

            string next = destinations[i];
            destinations[i] = null;
            path.Add(next);

            DFS(next, path);

            path.RemoveAt(path.Count - 1);
            destinations[i] = next;

            if (answer != null) return;
        }
    }
}
namespace Scripts.Services;
using System.Collections.Generic;

public static class EnvironmentExtras{

     static Dictionary<string, List<float>> myDictionary = new Dictionary<string, List<float>>()
        {
            { "key1", new List<float> { 1.1f, 2.2f, 3.3f } },
            { "key2", new List<float> { 4.4f, 5.5f } },
            { "key3", new List<float>() } // Empty list
        };

    static Dictionary<String, List<double>> timeRanges = new Dictionary<string, List<double>>() {
        {"dawn", new List<double> { 5.40, 9.3 }}, {"late_morning", new List<double> { 9.31, 12} }, 
        {"mid_day",new List<double> { 12.01, 14.30}}, {"late_afternoon",new List<double> { 14.31, 17}},
         {"dusk", new List<double> { 17.01, 17}}, {"evening", new List<double> {17.1, 21}},
        {"night", new List<double> { 21.01, 0.4}}, {"mid_night", new List<double> { .41, 5.39}}};

}
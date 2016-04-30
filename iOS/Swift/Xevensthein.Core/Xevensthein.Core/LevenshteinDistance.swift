//
//  LevenshteinDistance.swift
//  Xevensthein.Core
//
//  Created by Antonio Feregrino Bolaños on 4/29/16.
//  Copyright © 2016 That C# guy. All rights reserved.
//

import Foundation

public class LevenshteinDistance {
    
    public static func compute(s : String, t: String) -> Int {
        let n = s.characters.count;
        let m = t.characters.count;
        
        var d = [[Int]](count: n+1, repeatedValue: [Int](count: m+1, repeatedValue: 0));
        
        // Step 1
        if (n == 0)
        {
            return m;
        }
        
        if (m == 0)
        {
            return n;
        }
        
        // Step 2
        for i in 0...n{
            d[i][0] = i;
        }
        for j in 0...m{
            d[0][j] = j;
        }
        
        
        for i in 1...n{
            // Step 4
            for j in 1...m{
                // Step 5
                let cost = (t[t.startIndex.advancedBy(j - 1)] == s[s.startIndex.advancedBy(i - 1)]) ? 0 : 1;
                
                // Step 6
                let a = min(d[i - 1][j] + 1, d[i][j - 1] + 1);
                d[i][j] = min(a, d[i - 1][j - 1] + cost);
            }
        }
        
        // Step 7
        return d[n][m];
    }
}
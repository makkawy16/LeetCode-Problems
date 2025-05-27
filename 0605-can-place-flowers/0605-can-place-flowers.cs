public class Solution {
    
        public bool CanPlaceFlowers(int[] flowerbed, int n) {
        for (int i = 0 ; i<flowerbed.Length ; i++){
            if(flowerbed[i] == 0 ){
                bool leftIsEmpty = (i == 0) || (flowerbed[i-1] == 0);
                bool reightIsEmpty = (i ==flowerbed.Length-1) || (flowerbed[i+1] == 0);
                    if (n == 0) {
                        return true; 
                    }
                if(leftIsEmpty&&reightIsEmpty){
                    flowerbed[i] = 1;
                    n--;
                }
                 
            }
        }
        return n <= 0;
    }
}
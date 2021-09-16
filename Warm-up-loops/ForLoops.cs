using System;
using System.Collections.Generic;
using System.Text;

namespace Warm_up_loops
{
    public class ForLoop
    {
        /// <summary>
        /// Return lowest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns lowest number in array.  If array is empty, returns null</returns>
        public int? GetLowest(int[] arr)
        {
            if (arr.Length == 0) return null;

            var minNumber = arr[0];

            for(var i = 1; i < arr.Length; i++)
            {
                if (minNumber >= arr[i]) minNumber = arr[i];
            }

            return minNumber;
        }

        /// <summary>
        /// Return highest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns highest number in array.  If array is empty, returns null</returns>
        public int? GetHighest(int[] arr)
        {
            if (arr.Length == 0) return null;

            var maxNumber = arr[0];

            for (var i = 1; i < arr.Length; i++)
            {
                if (maxNumber < arr[i]) maxNumber = arr[i];
            }

            return maxNumber;

        }

        /// <summary>
        /// Return highest number in jagged array
        /// </summary>
        /// <param name="arr">System.Int32[][]</param>
        /// <returns>Returns highest number in array.  If there are no numbers provided, returns null</returns>
        public int? GetHighest(int[][] arr)
        {
            if (arr == null) return null;
            if (arr.Length == 0) return null;


            int? maxNumber = null;

            for (var i = 0; i < arr.Length; i++)
            {
               /* if (arr[i].Length == 0) return null;*/

                //maxNumber = arr[0][0];

                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (maxNumber == null) maxNumber = arr[i][j];
                    if (maxNumber < arr[i][j]) 
                        maxNumber = arr[i][j];
                } 
            }
            return maxNumber;
        }

    }
}

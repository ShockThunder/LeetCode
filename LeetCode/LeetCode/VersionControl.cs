namespace LeetCode
{
    public class VersionControl
    {
        public int Solution(int n)
        {
            if (n == 1)
                return 1;
            
            var startIndex = 0;
            var endIndex = n;
            var checkIndex = endIndex / 2;

            while (true)
            {
                if (IsBadVersion(checkIndex))
                {
                    if (!IsBadVersion(checkIndex - 1))
                        return checkIndex;

                    endIndex = checkIndex;
                }
                else
                {
                    if (IsBadVersion(checkIndex + 1))
                        return checkIndex + 1;
                    
                    startIndex = checkIndex;
                }
                
                checkIndex = (endIndex - startIndex) / 2 + startIndex;
            }
        }

        private bool IsBadVersion(int version)
        {
            return true;
        }
    }
}
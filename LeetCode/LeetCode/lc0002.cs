using System.Net;
using System.Numerics;
using System.Text;

namespace LeetCode.LeetCode
{

    /*    
    You are given two non - empty linked lists representing two non - negative integers.The digits are stored in reverse order, and each of their nodes contains a single digit.Add the two numbers and return the sum as a linked list.
    You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    Input: l1 = [2,4,3], l2 = [5,6,4]
    Output: [7,0,8]
    Explanation: 342 + 465 = 807.
    Example 2:

    Input: l1 = [0], l2 = [0]
    Output: [0]
    Example 3:

    Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
    Output: [8,9,9,9,0,0,0,1]


    Constraints:

    The number of nodes in each linked list is in the range [1, 100].
    0 <= Node.val <= 9
    It is guaranteed that the list represents a number that does not have leading zeros.
     */
    public class lc0002 : Solutions
    {
        public override void Solution()
        { 
            var foo = AddTwoNumbers(new ListNode(2, new ListNode(4, new ListNode(3))), new ListNode(5, new ListNode(6, new ListNode(4))));
            var boo = AddTwoNumbers(new ListNode(0), new ListNode(0));
            var doo = AddTwoNumbers(new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))))), new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))));
            var coo = AddTwoNumbers(new ListNode(9), new ListNode(1, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))))))));
        }

        // 1ms
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Węzeł-atrapa (dummy) ułatwia budowanie nowej listy —
            // dzięki niemu nie musimy osobno obsługiwać "pierwszego" węzła wyniku.
            ListNode dummy = new ListNode(0);

            // current wskazuje na "ogon" (ostatni dodany węzeł) budowanej listy wynikowej.
            // Na start wskazuje na dummy.
            ListNode current = dummy;

            // carry przechowuje "przeniesienie" z dodawania (0 albo 1),
            // np. gdy 7 + 8 = 15, to 5 zostaje jako cyfra, a 1 idzie dalej jako carry.
            int carry = 0;

            // Pętla trwa dopóki są jeszcze cyfry w l1 LUB w l2, LUB został carry do dodania
            // (ten ostatni warunek jest potrzebny np. gdy 999 + 1 = 1000 — dodatkowa cyfra na końcu).
            while (l1 != null || l2 != null || carry != 0)
            {

                // Zaczynamy sumę od ewentualnego przeniesienia z poprzedniej iteracji.
                int sum = carry;

                // Jeśli l1 ma jeszcze węzeł, dodajemy jego wartość do sumy
                // i przechodzimy do kolejnego węzła l1.
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }

                // To samo dla l2.
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                // Jeśli sum >= 10, to carry = 1 (przenosimy "dziesiątkę" dalej).
                // Jeśli sum < 10, to carry = 0.
                carry = sum / 10;

                // Cyfra, którą faktycznie zapisujemy w wynikowym węźle
                // (reszta z dzielenia przez 10, czyli "ostatnia cyfra" sumy).
                int digit = sum % 10;

                // Tworzymy nowy węzeł z obliczoną cyfrą i podpinamy go
                // jako .next aktualnego ogona listy (current).
                current.next = new ListNode(digit);

                // Przesuwamy current na nowo utworzony węzeł —
                // to on staje się teraz nowym "ogonem" listy.
                current = current.next;
            }

            // dummy.next to pierwszy PRAWDZIWY węzeł wyniku
            // (dummy sam nigdy się nie przesuwał, więc cały czas "patrzy" na początek listy).
            return dummy.next;
        }
  

        // 28 ms
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    String l1String = "";
        //    String l2String = "";
        //    for (int i = 0; l1 != null || l2 != null; i++)
        //    {
        //        if(l1 != null)
        //        {
        //            l1String = l1String + l1.val;
        //            l1 = l1.next;
        //        }
        //        if(l2 != null)
        //        {
        //            l2String = l2String + l2.val;
        //            l2 = l2.next;
        //        }
        //    }
        //    var revl1 = BigInteger.Parse(l1String.Reverse().ToArray());
        //    var revl2 = BigInteger.Parse(l2String.Reverse().ToArray());
        //    var sum = (revl1 + revl2).ToString().Reverse().Select(c=>c - '0').ToArray();
        //    var head = new ListNode();
        //    var tail = head;
        //    for (int i = 0; i < sum.Length; i++)
        //    {
        //        tail.val = sum[i];
        //        if (i < sum.Length - 1)
        //        {
        //            tail.next = new ListNode();
        //            tail = tail.next;
        //        }
        //    }
        //    return head;
        //}


        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}

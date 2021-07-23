public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
       ListNode salida = new ListNode();
        SumDosNumeros(l1,l2,salida,0);
        return salida;
    }
    
    public void SumDosNumeros(ListNode l1, ListNode l2, ListNode salida, int acarreo) {
     int suma = 0; 
        if (l1 != null)
        {
            suma += l1.val;
        }
        if (l2 != null)
        {
            suma += l2.val;
        }
        suma += acarreo; 
        acarreo = (suma - (suma % 10))/10;
        salida.val = suma%10;
        if (l1?.next == null && l2?.next == null)
        {
            if(acarreo != 0)
            {
                salida.next = new ListNode();
                salida.next.val = acarreo; 
            }
            return;
        }
        salida.next = new ListNode();
        SumDosNumeros(l1?.next, l2?.next, salida?.next, acarreo);
  
    }
}

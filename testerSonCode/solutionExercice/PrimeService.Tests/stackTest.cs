using Xunit;
using Stack_class;

namespace Stack_Value_Tests
{
    public class StackTest {
        public int[] a = {1,2,3,4,5};
        public int[] b = {6, 7, 8};
     //   public MyStack stackone = MyStack();
        public MyStack stacktwo = MyStack(a, b);



        // Commence mes tests pour la premiere methode font_a et front_b
        // objectif de test, tester les front avec ma chaine vide et ma chaine pleine
        [Fact] 
        public void front_a_test_chaineVide(int firstValue, int secondValue) {
       //     int retFrontA = stackone.front_a();
     //       int retFrontB = stackone.front_b();


            //Assert.Equal(retFrontA, 0);

        }

        [Theory] 
        [InlineData(1)]
        public void front_a_test_chaineInit(int firstValue) {
            int retFrontAStackTwo = stacktwo.front_A();

            Assert.Equal(retFrontAStackTwo, firstValue);
        }

        [Theory] 
        [InlineData(6)]
        public void front_b_test_chaineInit(int Value) {
            int retFrontBStackTwo = stacktwo.front_b();

            Asert.Equal(retFrontBStackTwo, secondValue);
        }


    }

}
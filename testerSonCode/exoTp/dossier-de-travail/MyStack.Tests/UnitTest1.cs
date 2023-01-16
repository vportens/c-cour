using Xunit;
using exo;

namespace Tests_exo {

    public class UnitTest1
    {
        [Fact]
        public void TestlistVide()
        {
            MyStack mystack = new MyStack();
            Assert.Equal(0, mystack.front_a());
            Assert.Equal(0, mystack.front_b());
        }



        // je veux test mon front a
        // pour faire plusieurs tests sur j'ai besoin besoin de plusieurs stack a tester
        // donc j'ai besoin d'initialiser plusieurs stack (une stack par test)

        // j'ai besoin : 
        // des deux listes de mystack a l'initialisation : donc 2 tableaux
        // d'un resultat pour comparer la valeur de retour de front_a

        // donc j'ai besoin dans chaqu'un de mes tests 2 tableaux et une valeur de retour

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] {}, 1 )] // 2 tableaux, un avec des element (les premiers pour tester ma stackA), un vide (car aucune operation sur stackB) , et un resultat (le premiere element de stack A)
        [InlineData(new int[] { 4, 2, 3 }, new int[] {}, 4)] // meme processe
        [InlineData(new int[] {9, 10, 4, 2, 3 }, new int[] {}, 9)]
        [InlineData(new int[] {}, new int[] {}, 0)] // test avec lst vide
        public void TestFrontA(int [] lst1, int [] lst2, int ret1) {  // lst1, lst2, ret1 corresponde aux valeur respective dans InlineData
            MyStack mystack = new MyStack(lst1, lst2);  // j'inite ma stack avec les deux tableaux
            Assert.Equal(ret1, mystack.front_a()); // je compare front_a de ma stack avec le resultat attendu
        }


        // meme besoin pour frontB que pour frontA

        [Theory]
        [InlineData(new int[] {}, new int[] { 4, 5, 6 }, 4)] // 1er tableau vide car aucune operation sur la stackA, 2 eme tableau avec des elements (les premiers pour tester ma stackB), et un resultat (le premiere element de stack B)
        [InlineData(new int[] {}, new int[] { 8, 5, 6 }, 8)]
        [InlineData(new int[] {}, new int[] {12, 4, 8, 5, 6 }, 12)]
        [InlineData(new int[] {}, new int[] {}, 0)] // test avec lst vide
        public void TestFrontB(int [] lst1, int [] lst2, int ret2) {
            MyStack mystack = new MyStack(lst1, lst2); // meme chose que pour FrontA
            Assert.Equal(ret2, mystack.front_b());
        }



        // meme besoin pour back_a que pour front_a
        // on veux tester si on a bien le dernier element de la liste 
        // donc je dois initialiser une MyStack avec 2 tableaux, et comparer le retour de backA
        // Besoin pour cette operation : 2 tableaux, une valeur du type du retour de backA (int)

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] {}, 3)] // 1er element pour stackA , 1er element de la liste 2
        [InlineData(new int[] { 4, 2, 3 }, new int[] {}, 3)]
        [InlineData(new int[] {9, 10, 4, 2, 3 }, new int[] {}, 3)]
        [InlineData(new int[] {}, new int[] {}, 0)] // test avec lst vide
 
        public void TestBack_a(int [] lst1, int [] lst2, int ret1) {
            MyStack mystack = new MyStack(lst1, lst2);
            Assert.Equal(ret1, mystack.back_a());
        }
        

        // meme besoin que pour BackA mais cette fois operation sur stackB
        // Besoin pour cette operation : 2 tableaux, une valeur du type du retour de backB (int)

        [Theory]
        [InlineData(new int[] {}, new int[] { 4, 5, 6 }, 6)] // 1er element pour stackA , 1er element de la liste 2
        [InlineData(new int[] {}, new int[] { 8, 5, 6 }, 6)]
        [InlineData(new int[] {}, new int[] {12, 4, 8, 5, 9 }, 9)]
        [InlineData(new int[] {}, new int[] {}, 0)] // test avec lst vide
 
        public void TestBack_b(int [] lst1, int [] lst2, int ret2) {
            MyStack mystack = new MyStack(lst1, lst2);
            Assert.Equal(ret2, mystack.back_b());
        }

        // sa va swap les 2 premieres valeurs de la listA, donc 
        // j'ai besoin d'init MyStack pour pouvoir operer dessus,
        // j'ai besoin de comparer ma nouvelle listA avec une listA attendu apres l'operation
        // donc j'ai besoin de 2 tableaux(initialisation de MyStack), et d'un tableau (comparer la nouvelle list apres swap)
        [Theory]
        [InlineData(new int[] {1, 2, 3}, new int [] {}, new int [] {2, 1 , 3})]  // test classique
        [InlineData(new int[] {}, new int [] {}, new int [] {})] // test avec lst vide
        [InlineData(new int[] {4}, new int [] {}, new int [] {4})] // test avec lst de 1 element
        [InlineData(new int[] {9, 1, 2, 7, 8, 3}, new int [] {}, new int [] {1, 9, 2, 7, 8, 3})]
        public void TestSwap(int [] lst1, int [] lst2, int [] ret) {
            MyStack mystack = new MyStack(lst1, lst2);
            mystack.sa();
            Assert.Equal(ret, mystack.showList_a());
        }

        // meme chose que pour sa
        [Theory]
        [InlineData(new int[] {}, new int [] {1, 2, 3}, new int [] {2, 1 , 3})]  // test classique
        [InlineData(new int[] {}, new int [] {}, new int [] {})] // test avec lst vide
        [InlineData(new int[] {}, new int [] {4}, new int [] {4})] // test avec lst de 1 element
        [InlineData(new int[] {}, new int [] {9, 1, 2, 7, 8, 3}, new int [] {1, 9, 2, 7, 8, 3})]
        public void TestSwapB(int [] lst1, int [] lst2, int [] ret) {
            MyStack mystack = new MyStack(lst1, lst2);
            mystack.sb();
            Assert.Equal(ret, mystack.showList_b());
        }


        // je test pa 
        // pour cela, j'ai besoin d'init MyStack (ce qui necessite 2 tableaux)
        // j'ai besoin de comparer les 2 listes apres l'operation, comparaison faite avec 2 tableaux
        [Theory]
        [InlineData(new int[] {1, 2, 3}, new int [] {4, 5, 6}, new int [] { 2, 3}, new int [] {1, 4, 5, 6})]  // test classique
        [InlineData(new int[] {}, new int [] {4, 5, 6}, new int [] {}, new int [] {4, 5, 6})] // test avec lst vide de depart dc il ne se passe rien
        [InlineData(new int[] {1}, new int [] {4, 5, 6}, new int [] {}, new int [] {1, 4, 5, 6})] // test avec 1 element dans ma list
        [InlineData(new int[] {1, 3, 4}, new int [] {}, new int [] {3,4}, new int [] {1})] 
        public void testPa(int [] lst1, int [] lst2, int [] ret1, int [] ret2) {
            MyStack mystack = new MyStack(lst1, lst2);
            mystack.pa();
            Assert.Equal(ret1, mystack.showList_a()); // premier test ou je compare le retour de la premiere list avec le resultat attendu de celle=-ci
            Assert.Equal(ret2, mystack.showList_b()); // je continue mes verification avec la second list, voir s'il a bien recu le nouvelle elements en tete de lists
        }

        // faire la meme chose pour pb



        // test ra


    }
}
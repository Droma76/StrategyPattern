Introduction
Strategy pattern can be categorized as behavioral design pattern and is one of my favorite patterns just because it is simple and powerful. It can be considered in a kind of scenario where your object would perform a common action and that too selecting from various options available.

Background
Let’s understand the widely accepted definition of strategy pattern which you can find from various resources on net. “Strategy pattern defines a family of algorithms, encapsulates each one of them and makes them interchangeable.” Confused with the definition? let’s try to break it in three parts:-

1) Family of Algorithms- The definition says that the pattern defines the family of algorithms- it means we have functionality (in these algorithms) which will do the same common thing for our object, but in different ways.

2) Encapsulate each one of them- The pattern would force you to place your algorithms in different classes (encapsulate them). Doing so would help us in selecting the appropriate algorithm for our object.

3) Make them interchangeable- The beauty with strategy pattern is we can select at run time which algorithm we should apply to our object and can replace them with one another

Using the code
Let’s go through an example which would use the strategy pattern and would make everything clear. Suppose you have to write an application which could sort different types of objects, that means it can sort the scholar numbers of students in the university, the ticket numbers of railway passengers or even more the names of all people residing in a county.

The problem seems to be very simple and involves just one thing for all of them i.e. sorting. Now let’s try to recollect from our school days when our professors were teaching us algorithm designs. We were taught that the complexity of different sorting algorithms is a relative term- meaning it is based on the number and type of elements to be sorted. Not going into anymore algorithm science, suppose we have formulated (be it correct or wrong) that quick sort would be good for sorting names of county residents, the merge sort would be suitable for scholar numbers (ints/doubles) and heap sort would be best for sorting the railway passengers. This is the optimum scenario where we can apply the strategy pattern. We will be encapsulating all our algorithms and would select at runtime that which one we would be using. Have a look at the code below(In C# and can be applied in similar way to any oops supporting language) which would tell you how we are implementing strategy.





What a beauty! Our ISortingStrategy object would decide which algorithm to call. The great thing is suppose we realize that one of our algorithm is flawed we simply need to change the sorting algorithm reference in GetSortingOption method and in doing so we need not to change anything in the client code ( i.e the Program class). We can even decide the algorithm at runtime. Suppose during the peak hours when the number of railway passengers increase we can have another customized algorithm (say HugeDataSorting) in place. Based on the number of passengers the ISortingStrategy object would keep changing the reference to HeapSort or HugeDataSorting.

Points of Interest
Having learned strategy pattern think of applying this at places where you feel your objects needs to perform a similar action but that action has difference in the way it is being performed. Closing this with another practical example. Think of applying this pattern for a discounting system, which calculates a discount for different customers. So this system would decide at run time which discounting method to call based on type of customer.


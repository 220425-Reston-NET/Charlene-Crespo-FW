repeat="true"

sum=0

while [ "$repeat" == "true" ]
do

        echo "Welcome to My Repair Shop"
        echo "Press 1 to enter list"
        echo "Enter 2 to exit"
        read answer

if [ "$answer" == "1" ]
then
       while [ "$repeat" == "true" ]
       do
       echo "Please choose an option"
       echo "1. Phones"
       echo "2. Tablets"
       echo "3. Laptops"
       echo "4. TVs"
       echo "5. Game Console"
       echo "6. Checkout"
       read Option
       if [ "$Option" == "1" ]
       then
             echo "Phones: 100"
             sum=$(($sum+100))


       elif [ "$Option" == "2" ]
       then

             echo "Tablets: 120"
             sum=$(($sum+120))

       elif [ "$Option" == "3" ]
       then

             echo "Laptops: 160"
             sum=$(($sum+160))

       elif [ "$Option" == "4" ]
       then

             echo "TVs: 200"
             sum=$(($sum+200))

       elif [ "Option" == "5" ]
       then

             echo "Game Console: 250"
             sum=$(($sum+250))

       elif [ "Option" == "6" ]
       then
            echo "Your total is $(($1+$2+$3+$4+$5))"
            repeat="true"

else
      echo "Choose valid answer"

fi
done

elif [ "$answer" == "2" ]
then

        repeat="false"
else

       echo "Please try again"

fi

done


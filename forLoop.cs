#include <iostream>
#include <cstdio>
using namespace std;
  
  const char *numbers[] = {"one","two","three","four","five","six","seven","eight",     "nine"}; //array

int main() {
    // Complete the code.
    int a;
    int b;
    cin >> a;
    cin >> b;
    while(b >= a ){ //check for 1-9
        if((a >= 1) && (a <= 9))
            cout << numbers[a-1] << endl;
        else{
            if( (a % 2) == 0)
                cout << "even" << endl; //check for even
            else
                cout << "odd" << endl;   //check for odd       
        }
        ++a;
    }
    return 0;   
}

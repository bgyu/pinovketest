// Compile:
// clang++ -g -fPIC -shared -o libexample.so example.cpp
#include <iostream>

extern "C" {
	void example_function() {
		std::cout << "This is a function from c++" << std::endl;
	}
}

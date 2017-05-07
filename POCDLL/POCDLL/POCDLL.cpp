// POCDLL.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <iostream>
#include "MathFuncs.h"
#include <stdexcept>

using namespace std;

namespace MathFuncs
{
	double Sum(double a, double b)
	{
		return a + b;
	}

	double Subtract(double a, double b)
	{
		return a - b;
	}

	double Multiply(double a, double b)
	{
		return a * b;
	}

	double Divide(double a, double b)
	{
		if (b == 0)
		{
			throw new invalid_argument("b cannot be zero!");
		}

		return a / b;
	}
}

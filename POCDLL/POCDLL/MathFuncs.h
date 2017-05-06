#pragma once
namespace MathFuncs
{
	// Returns a + b
	extern "C" __declspec(dllexport) double Calc(double a, double b);

	// Returns a - b
	extern "C" __declspec(dllexport) double Subtract(double a, double b);

	// Returns a * b
	extern "C" __declspec(dllexport) double Multiply(double a, double b);

	// Returns a / b
	// Throws DivideByZeroException if b is 0
	extern "C" __declspec(dllexport) double Divide(double a, double b);
}
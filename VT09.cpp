#include<bits/stdc++.h>
using namespace std;
bool snt(int n){
	for(int i=2;i<=sqrt(n);i++)
		if(n%i==0) return 0;
	return (n>=2);
}
int  main(){
	int n;
	cin>>n;
	int a[n];
	set<int> s;
	for(int i=0;i<n;i++)
		cin>>a[i];
	for(int i=0;i<n-1;i++)
		for(int j=i+1;j<n;j++)
		if(a[i]>a[j]) swap(a[i],a[j]);	
	for(int i=0;i<n;i++)
		s.insert(a[i]);
	for (auto x :s ){
		if(snt(x) && (s.find(x)!=s.end())) cout<<x<<" ";
		if(snt(x) && (s.find(x)==s.end())) cout<<x;
	}



	return 0;
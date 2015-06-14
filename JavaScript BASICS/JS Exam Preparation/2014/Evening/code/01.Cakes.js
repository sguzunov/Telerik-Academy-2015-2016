function solve(params) {
   var s = parseInt(params[0]), c1 = parseInt(params[1]), c2 = parseInt(params[2]), c3 =parseInt(params[3]);
   var max=0;

   for(var i=0;i<s;i+=1){ // c1
   		for(var j=0;j<s;j+=1){  //c2
   			for(var k=0;k<s;k+=1){  //c3
   				var sum=i*c1+j*c2+k*c3;
   				if(sum<=s){
   					if(max<sum){
   						max=sum;
   					}
   				}
   			}
   		}
   }

   return max;
}


var test1=['110','13','15','17'],
test2=['20','11','200','300'],
test3=['110','19','29','39',];

console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));

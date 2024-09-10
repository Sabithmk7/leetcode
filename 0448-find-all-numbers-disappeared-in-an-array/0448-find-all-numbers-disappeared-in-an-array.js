/**
 * @param {number[]} nums
 * @return {number[]}
 */
var findDisappearedNumbers = function(nums) {
 p=[]
 n=nums.length
  pp =new Set(nums)
  for(i=1;i<=n;i++){
     
    
     if(!pp.has(i)){
         p.push(i)
     }
    
  }
  
  return p
};
/**
 * @param {number} x
 * @return {number}
 */
var mySqrt = function(x) {
    for(i=0;i<=x;i++){
        if(i*i>=x){
            if(i*i==x){
                return i
            }else{
                return i-1
            }
        }
    }
};
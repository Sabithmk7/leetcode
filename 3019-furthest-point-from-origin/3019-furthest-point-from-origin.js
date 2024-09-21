/**
 * @param {string} moves
 * @return {number}
 */
var furthestDistanceFromOrigin = function(moves) {
    let c=0;
    let n=0;
    let m=0;
    for(i=0;i<moves.length;i++){
        if(moves[i]==='L'){
            m++
        }else if(moves[i]==='R'){
            n++
        }else{
            c++
        }
    }
    return Math.abs(m-n)+c
};
/**
 * @param {string} s
 * @return {string}
 */
var toLowerCase = function(s) {
    let result="";
    for(char of s){
        let code=char.charCodeAt(0);
        if(code>=65&&code<=90){
            result+=String.fromCharCode(code+32);
        }else{
            result+=char
        }
    }
    return result;
};
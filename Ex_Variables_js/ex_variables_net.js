//Fase 1
var nom='Francisco';
var cognom1='Gil';
var cognom2='Mayo';
var dia=22;
var mes=9;
var any=1974;
console.log(nom + ", " + cognom1 + " " + cognom2);
console.log(dia + "/" + mes + "/" + any);
console.log();
//Fase 2

const anno=1948;
var periodo=4;
var suma=0;
var cantBisiesto = Math.floor((1974-1948)/periodo);
console.log("Entre " + anno + " y 1974 hay " + cantBisiesto + " años bisiestos");
console.log();

//Fase 3
var biAnno=false;
var resto;
var fraseBisiesto,fraseNoBisiesto;
for (var i=anno+1;i<=1974;i++){
    resto=(i-anno)%periodo;
    biAnno=resto==0;
    if (biAnno) {
        fraseBisiesto="El año " + i + " es bisiesto."
        console.log(fraseBisiesto);
    }
    else{
        fraseNoBisiesto="El año " + i + "  no es bisiesto."
        console.log(fraseNoBisiesto);
    }
}
console.log();
var nomTotal=nom + " " + cognom1 + " " + cognom2;
var dataTotal = "22/09/1974";
console.log("Mi nombre es " +  nomTotal);
console.log("Nací el día " + dataTotal);
if (biAnno)
    console.log(fraseBisiesto);
else
    console.log(fraseNoBisiesto);

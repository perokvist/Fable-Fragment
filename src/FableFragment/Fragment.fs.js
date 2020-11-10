import { createAtom } from "./.fable/fable-library.3.0.0-nagareyama-rc-002/Util.js";

export const window$ = window;

export const myButton = createAtom((() => {
    let objectArg;
    const clo1 = (objectArg = window$.document, (arg00) => objectArg.getElementById(arg00));
    return clo1("myBtn");
})());

myButton().textContent = "changed";


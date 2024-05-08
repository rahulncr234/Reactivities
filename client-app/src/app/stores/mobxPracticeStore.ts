import {makeObservable, makeAutoObservable, observable, action, autorun, reaction} from 'mobx';

export default class PracticeStore {

    counter = 1
    counter2 = 1;

    constructor(){
        makeAutoObservable(this);
        autorun(() => {
            console.log("autorun is running");
        })
        reaction(() => this.counter2 , () => {
            console.log("Reaction is running", this.counter2);
        })
    }

    setCounter = () => {
        this.counter++;
    }

    setCounter2 = () => {
        this.counter2++;
    }
}
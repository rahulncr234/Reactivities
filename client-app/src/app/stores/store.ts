import ActivityStore from "./activityStore";
import PracticeStore from "./mobxPracticeStore";
import {createContext, useContext} from "react";

interface Store {
    activityStore: ActivityStore
    practiceStore: PracticeStore
}

export const store: Store = {
    activityStore: new ActivityStore(),
    practiceStore: new PracticeStore()
}

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}
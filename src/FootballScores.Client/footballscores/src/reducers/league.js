import { ACTION_TYPES } from "../actions/league";
const initialState = {
    list: []
}

export const league = (state =initialState, action) =>{
    switch (action.type) {
        case ACTION_TYPES.FETCH_ALL:
            return {
                ...state,
                list: [...action.payload]
            }

        default:
            return state
    }
}
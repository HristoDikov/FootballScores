import api from "./api";

export const  ACTION_TYPES = {
    FETCH_ALL: 'FETCH_ALL',

}

export const fetchAll = () => dispatch => {
    api.league()
    .fetchAll()
    .then(
        response => {
            console.log(response);
            dispatch({
                type: ACTION_TYPES.FETCH_ALL,
                payload: response.data
            })
        }
    ).catch(err => console.log(err));
       
}

import axios from "axios"

const baseUrl = "https://localhost:44363/"

export default {

    league(url = baseUrl + 'league/list'){
        return {
            fetchAll : () => axios.get(url)
        }
    }
}
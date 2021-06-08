import React, {useState, useEffect} from "react";
import {connect} from "react-redux";
import * as actions from "../actions/league";

const Leagues = (props) => {
    // const [x, setX] = useState(0)
    // setX(5)

    useEffect(() => {
props.fetchAllLeagues()
    }, [])


    return (<div> from Leagues</div>)
}

const mapStateToProps = state => ({
        LeagueList: state.league.list
    });


const mapActionToProps = {
    fetchAllLeagues: actions.fetchAll
}


export default connect(mapStateToProps, mapActionToProps)(Leagues);

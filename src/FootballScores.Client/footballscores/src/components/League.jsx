import React, { Component } from "react";
import Fixture from "./Fixture";

class League extends Component {
  render() {
    const {
      league: { fixtures, leagueId, leagueName },
    } = this.props;
    return (
      <div className="league" id={leagueId}>
        <div className="league-header">
          <span className="league-name">{leagueName}</span>
        </div>
        {fixtures.map((fixture) => (
          <Fixture key={fixture.id} fixture={fixture}></Fixture>
        ))}
      </div>
    );
  }
}

export default League;

import React, { Component } from "react";

class Fixture extends Component {
  render() {
    const {
      fixture: { gameDate, referee, venue, hostTeamName, score, awayTeamName },
    } = this.props;
    return (
      <div className="game">
        <div className="game-time">{`${gameDate}`}</div>
        <div className="game-referee">{`${referee}`}</div>
        <div className="game-venue">{`${venue}`}</div>
        <div className="teams-score">
          <div className="home-team inline-b">{hostTeamName}</div>
          <div className="score inline-b">{score}</div>
          <div className="away-team inline-b">{awayTeamName}</div>
        </div>
      </div>
    );
  }
}

export default Fixture;

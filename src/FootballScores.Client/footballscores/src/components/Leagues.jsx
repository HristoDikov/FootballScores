import React, { Component } from "react";
import League from "./League";

class Leagues extends Component {
  render() {
    const { leagues } = this.props;

    return (
      <div>
        {leagues.map((l) => (
          <League key={l.id} league={l}></League>
        ))}
      </div>
    );
  }
}

export default Leagues;

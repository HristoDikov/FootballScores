import "./App.css";
import React from "react";
import { Component } from "react";
import axios from "axios";
import Leagues from "./components/Leagues";

class App extends Component {
  state = {
    leagues: [],
  };

  componentDidMount() {
    const response = axios.get(`https://localhost:44363/League/List`);
    response.then((res) => {
      const leagues = res.data;
      this.setState({
        leagues: leagues,
      });
    });
  }

  render() {
    return (
      <React.Fragment>
        <main className="container">
          <Leagues leagues={this.state.leagues} />
        </main>
      </React.Fragment>
    );
  }
}

export default App;

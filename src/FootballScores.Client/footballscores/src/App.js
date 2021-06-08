import './App.css';
import {store} from "./actions/store"
import {Provider} from "react-redux";
import Leagues from './components/Leagues';
import { Container } from "@material-ui/core"

function App() {
  return (
    <Provider store={store}>
      <Container maxWidth="lg"></Container>
<Leagues></Leagues>
    </Provider>
  );
}

export default App;

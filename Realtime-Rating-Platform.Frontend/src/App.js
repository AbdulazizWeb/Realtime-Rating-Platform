import React from "react";
import MainUI from './containers/MainUI/MainUI';
import LoginPage from './Components/LoginPage/LoginPage'
import './App.scss'
import {
  Routes,
  Route
} from "react-router-dom";
import AddPage from './Components/AddPage/AddPage';
import HomePage from './Components/HomePage/HomePage';
import SignupPage from "./Components/SignUpPage/SignupPage";

function App() {
const [auth, setAuth] = React.useState(false);
if(auth) {
  return (
    <MainUI>
      <Routes>
        <Route path="/add" element={<AddPage/>} />
        <Route  path="/" element={<HomePage/>} />
      </Routes>
    </MainUI>
  )
} else {
  return (
    <Routes>
        <Route exact path="/" element={<LoginPage setAuth={setAuth}/>} />
        <Route exact path="/signup" element={<SignupPage/>} />
        
      </Routes>
  )
}
}

export default App;

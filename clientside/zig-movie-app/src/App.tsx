import React from "react";
import "./App.css";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import Home from "./views/Home";
import DetailsView from "./views/Details";

const App: React.FC = () => {
  return (
    <Router>
      <Routes>
        <Route path="/movies/:id" element={<DetailsView />} />
        <Route path="/" element={<Home />} />
      </Routes>
    </Router>
  );
};

export default App;

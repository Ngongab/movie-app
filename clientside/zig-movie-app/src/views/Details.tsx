import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import axios from "axios";
import DetailsComponent from "../components/DetailsComponent";

const url = "https://localhost:5001/api/";

const DetailsView: React.FC = () => {
  const [movie, setMovie] = useState<any>({});

  const { id } = useParams();

  useEffect(() => {
    fetchMovie();
    console.log(`Movie Id -----> ${id}`);
  }, []);

  const fetchMovie = () => {
    axios.get(url + id).then((res) => {
      setMovie(res.data);
      console.log(`Response -------> ${res.data}`);
    });
    console.log(`URL ------> ${url}`);
  };

  return (
    <div>
      <DetailsComponent key={movie.id} {...movie}/>
    </div>
  );
};

export default DetailsView;

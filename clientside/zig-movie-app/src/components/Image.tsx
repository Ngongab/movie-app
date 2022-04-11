import React from "react";
import Image from "react-bootstrap/Image";
import "../App.css";

const imagesrc = "https://image.tmdb.org/t/p/original/";

interface Props {
  title: string;
  poster_path: string;
  vote_average: string;
  id: number;
}

const MovieImage = ({ id, title, poster_path, vote_average }: Props) => {
  return (
    <div>
      <Image
        key={id}
        className="image"
        src={imagesrc + poster_path}
        alt={title}
        rounded
      />
      
      <div className="movie-info">
        <h3>{title}</h3>
        <span>{vote_average}</span>
      </div>
    </div>
  );
};

export default MovieImage;

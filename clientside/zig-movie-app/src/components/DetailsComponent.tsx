import React from "react";
import Image from "react-bootstrap/Image";
import "../App.css";

const imagesrc = "https://image.tmdb.org/t/p/original/";

interface Props {
  title: string;
  poster_path: string;
  vote_average: string;
  original_language: string;
  release_date: string;
  homepage: string;
  runtime: string;
  genres: string;
  overview: string;
  status: string;
  tagline: string;
  id: number;
}

const DetailsComponent = ({
  id,
  title,
  poster_path,
  vote_average,
  original_language,
  release_date,
  homepage,
  runtime,
  overview,
  status,
  tagline,
}: Props) => {
  return (
    <div className="Container">
      <Image
        className="cover-image"
        key={id}
        src={imagesrc + poster_path}
        alt={title}
      />
      <div className="info-column">
        <span className="movie-name">
          Movie:{" "}
          <a className="link" href={`${homepage}`}>
            <span>{title}</span>
          </a>
        </span>
        <span className="movie-detail-info">
          Rating: <span>{vote_average}</span>
        </span>
        <span className="movie-detail-info">
          Language: <span>{original_language}</span>
        </span>
        <span className="movie-detail-info">
          Website: <span>{homepage}</span>
        </span>
        <span className="movie-detail-info">
          Released: <span>{release_date}</span>
        </span>
        <span className="movie-detail-info">
          Runtime: <span>{runtime}</span>
        </span>
        <span className="movie-detail-info">
          Status: <span>{status}</span>
        </span>
        <span className="movie-detail-info">
          Tagline: <span>{tagline}</span>
        </span>
        <span className="movie-detail-info">
          Plot: <span>{overview}</span>
        </span>
      </div>
    </div>
  );
};

export default DetailsComponent;

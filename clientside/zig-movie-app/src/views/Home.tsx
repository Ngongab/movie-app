import React, { useState, useEffect } from "react";
import "../App.css";
import axios from "axios";
import MovieImage from "../components/Image";
import Search from "../components/Search";
import { Link } from "react-router-dom";

const url = "https://localhost:5001/api/popular";
const searchUrl = "https://localhost:5001/api/search/?query=";

const Home: React.FC = () => {
  const [movies, setMovies] = useState<any[]>([]);
  const [searchMovie, setSearchMovie] = useState<string>("");

  const handleSearch = (e: React.FormEvent) => {
    e.preventDefault();

    axios.get(searchUrl + searchMovie).then((res) => {
      setMovies(res.data.results);
      console.log(res.data.results);
    });
    console.log(`URL ----> ${searchUrl}`);
  };

  useEffect(() => {
    fetchMovies();
  }, []);

  const fetchMovies = () => {
    axios.get(url).then((res) => {
      setMovies(res.data.results);
      console.log(`Response -------> ${res.data.results}`);
    });

    console.log(`URL ----> ${url}`);
  };
  return (
    <div className="Home">
      <header className="heading">
        <h1>The Zig Movie App</h1>
      </header>
      <Search
        searchMovie={searchMovie}
        setSearchMovie={setSearchMovie}
        handleSearch={handleSearch}
      />
      <section className="movie-container">
        {movies.map((movie) => (
          <Link className="link" to={`/movies/${movie.id}`}>
            <MovieImage key={movie.id} {...movie} />
          </Link>
        ))}
      </section>
    </div>
  );
};

export default Home;

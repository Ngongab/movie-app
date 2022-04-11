import React from "react";
import "../App.css";

interface props {
  searchMovie: string;
  setSearchMovie: React.Dispatch<React.SetStateAction<string>>;
  handleSearch: (e: React.FormEvent) => void;
}

const Search: React.FC<props> = ({
  searchMovie,
  setSearchMovie,
  handleSearch,
}) => {
  return (
    <form
      className="search"
      onSubmit={(e) => {
        handleSearch(e);
      }}
    >
      <input
        type="text"
        placeholder="Search movie"

        value={searchMovie}
        onChange={(e) => setSearchMovie(e.target.value)}
        className="search__box"
      />
      <button type="submit" className="search_submit">
        Search
      </button>
    </form>
  );
};

export default Search;

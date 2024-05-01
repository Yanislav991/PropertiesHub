import Footer from "./components/Footer";
import MainJumbotron from "./components/MainJumbotron";
import NavBar from "./components/NavBar";
import SearchBar from "./components/SearchBar";

export default function Home() {
  return (
    <main>
        <SearchBar />
        <MainJumbotron />
    </main>
  );
}

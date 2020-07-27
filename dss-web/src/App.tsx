import React from "react";
import "./App.scss";
import { Navbar } from "./components";
import { Sidebar } from "./components";
import { Content } from "./components";

function App() {
    return (
        <div className="App">
            <div
                id="main-wrapper"
                data-theme="light"
                data-layout="vertical"
                data-navbarbg="skin6"
                data-sidebartype="full"
                data-sidebar-position="fixed"
                data-header-position="fixed"
                data-boxed-layout="full"
            >
                <Navbar />
                <Sidebar />
                <Content />
            </div>
        </div>
    );
}

export default App;

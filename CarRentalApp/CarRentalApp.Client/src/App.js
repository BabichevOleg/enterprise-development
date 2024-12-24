import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import CarCreate from './components/CarCreate';
import CarDelete from './components/CarDelete';
import CarList from './components/CarList';
import CarUpdate from './components/CarUpdate';


function App() {
    return (
        <Router>
            <div>
                <h1 className="text-center">Car Client</h1>
                <Routes>
                    <Route path="/" element={<CarList />} />
                    <Route path="/car/create" element={<CarCreate />} />
                    <Route path="/car/update/:id" element={<CarUpdate />} />
                    <Route path="/car/delete/:id" element={<CarDelete />} />
                </Routes>
            </div>
        </Router>
    );
}

export default App;
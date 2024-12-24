import React, { useEffect, useState } from 'react';
import { Link } from 'react-router-dom';
import api from '../api/api';
import CarDelete from './CarDelete';

const CarList = () => {
    const [cars, setCars] = useState([]);
    const [message, setMessage] = useState('');

    const handleDeleteSuccess = (id) => {
        setCars(cars.filter((cars) => cars.id !== id));
    };

    useEffect(() => {
        const fetchCars = async () => {
            try {
                const response = await api.get('/car');
                setCars(response.data);
            } catch (error) {
                console.error('Error fetching cars:', error);
                setMessage('Failed to fetch cars.');
                setTimeout(() => setMessage(''), 3000);
            }
        };
        fetchCars();
    }, []);

    return (
        <div className="container mt-5">
            <h2>Car List</h2>
            {message && (
                <div className={`alert ${message.includes('Failed') ? 'alert-danger' : 'alert-success'}`} role="alert">
                    {message}
                </div>
            )}
            <Link to="/car/create" className="btn btn-success mb-3">Create New Car</Link>
            <ul className="list-group">
                {cars.length > 0 ? (
                    cars.map((car) => (
                        <li key={car.id} className="list-group-item d-flex justify-content-between align-items-center">
                            <div>
                                <p><strong>Number:</strong> {car.Number}</p>
                                <p><strong>Model</strong>: {car.Model}</p>
                                <p><strong>Color</strong>: {car.Color}</p>
                            </div>
                            <div>
                                <Link to={`/car/update/${car.id}`} className="btn btn-warning btn-sm me-2">Update</Link>
                                <CarDelete id={car.id} onDeleteSuccess={handleDeleteSuccess} />
                            </div>
                        </li>
                    ))
                ) : (
                    <li className="list-group-item">No car found</li>
                )}
            </ul>
        </div>
    );
}

export default CarList;
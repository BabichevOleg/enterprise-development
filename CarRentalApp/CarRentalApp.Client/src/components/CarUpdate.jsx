import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import api from '../api/api';

const CarUpdate = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    const [number, setNumber] = useState('');
    const [model, setModel] = useState('');
    const [color, setColor] = useState('');
    const [message, setMessage] = useState('');
    const [error, setError] = useState(null);

    useEffect(() => {
        const fetchCar = async () => {
            try {
                const response = await api.get(`/api/Car/${id}`);
                setNumber(response.data.number);
                setModel(response.data.model);
                setColor(response.data.color);
            } catch (error) {
                console.error('Error fetching car:', error);
                setError('Car not found');
            }
        };

        fetchCar();
    }, [id]);

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            await api.put(`/api/Car/${id}`, { number, model, color });
            setMessage('Car updated successfully!');
            setTimeout(() => {
                navigate('/');
            }, 1000);
        } catch (error) {
            console.error('Error updating car:', error);
            setMessage('Failed to update car.');
        }
    };

    return (
        <div className="container mt-5">
            <h2>Update car</h2>
            {message && (
                <div className={`alert ${message.includes('Failed') ? 'alert-danger' : 'alert-success'}`} role="alert">
                    {message}
                </div>
            )}
            {error && (
                <div className="alert alert-danger" role="alert">
                    {error}
                </div>
            )}
            {!error && (
                <form onSubmit={handleSubmit}>
                    <div className="mb-3">
                        <label htmlFor="number" className="form-label">Number:</label>
                        <input
                            type="text"
                            className="form-control"
                            id="number"
                            value={number}
                            onChange={(e) => setNumber(e.target.value)}
                            required
                        />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="model" className="form-label">Model:</label>
                        <input
                            type="text"
                            className="form-control"
                            id="model"
                            value={model}
                            onChange={(e) => setModel(e.target.value)}
                            required
                        />
                    </div>
                    <div className="mb-3">
                        <label htmlFor="color" className="form-label">Color:</label>
                        <input
                            type="text"
                            className="form-control"
                            id="color"
                            value={color}
                            onChange={(e) => setColor(e.target.value)}
                            required
                        />
                    </div>
                    <button type="submit" className="btn btn-primary">Update car</button>
                </form>
            )}
        </div>
    );
};

export default CarUpdate;
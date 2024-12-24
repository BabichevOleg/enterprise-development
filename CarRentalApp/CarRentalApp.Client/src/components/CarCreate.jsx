import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import api from '../api/api';

const CarCreate = () => {
    const [number, setNumber] = useState('');
    const [model, setModel] = useState('');
    const [color, setColor] = useState('');
    const [message, setMessage] = useState('');
    const navigate = useNavigate();

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            await api.post('/car', { number, model, color });
            setMessage('Car created successfully!');
            setTimeout(() => {
                navigate('/');
            }, 1000);
        } catch (error) {
            console.error('Error creating car:', error);
            setMessage(`Failed to create car: ${error.response?.data || error.message}`);
        }
    };

    return (
        <div className="container mt-5">
            <h2>Create car</h2>
            {message && (
                <div className={`alert ${message.includes('Failed') ? 'alert-danger' : 'alert-success'}`} role="alert">
                    {message}
                </div>
            )}
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
                
                <button type="submit" className="btn btn-primary">Create</button>
            </form>
        </div>
    );
}

export default CarCreate;
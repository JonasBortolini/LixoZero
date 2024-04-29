import React from 'react';
import ReactDOM from 'react-dom/client';
import './styles/resets.css';
import './styles/index.css';
import Rotas from './routes/Rotas';

const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <Rotas />
  </React.StrictMode>
);


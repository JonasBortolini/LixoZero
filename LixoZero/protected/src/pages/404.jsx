import React from 'react';
import '../styles/404.css'

function NotFound() {
    return <div className='error'>
        <div className='display'>
            <h1>Ops, página não econtrada</h1>
            <p>404</p>
        </div>
        <div class="button">
            <a href="/">Ir para Ecopontos</a>
        </div>
    </div>;
}

export default NotFound;

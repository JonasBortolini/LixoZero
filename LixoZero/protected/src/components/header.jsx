import React from 'react';
import logo from '../assets/logo.png';
import '../styles/header.css';

function Header() {
    return <header>
        <nav className='menu'>
            <div className="logo">
                <img src={logo} alt="Logo Caxias Lixo Zero" />
            </div>
            <ul className='pages'>
                <li>
                    <a href="/ecopontos" className="page-name">Ecopontos</a>
                </li>
                <li>
                    <a href="/educacional" className="page-name">Educacional</a>
                </li>
                <li>
                    <a className="page-name cms">Área restrita</a>
                </li>
            </ul>
        </nav>
    </header>;
}

export default Header;

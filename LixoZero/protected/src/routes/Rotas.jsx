import React from 'react';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import Ecopontos from '../pages/ecopontos';
import Educacional from '../pages/educacional';
import NotFound from '../pages/404';
import Header from '../components/header';
// import Footer from '../components/footer';

function Rotas() {
  return ( <>
    <Header />
    <Router>
      <Routes>
        <Route path="/" element={<Navigate to="/ecopontos" />} />
        <Route path="/ecopontos" element={<Ecopontos />} />
        <Route path="/educacional" element={<Educacional />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </Router>
    {/* <Footer /> */}
  </>
  );
}

export default Rotas;
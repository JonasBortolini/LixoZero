import React, { useState } from 'react';
import { GoogleMap, Marker, InfoWindow, LoadScript } from '@react-google-maps/api';

const Map = ({ ecopontos }) => {
    const mapStyles = {
        height: '400px',
        width: '100%'
    };

    const [defaultCenter, setDefaultCenter] = useState({lat: -29.1655, lng: -51.1796});

    const [selectedEcoponto, setSelectedEcoponto] = useState(null);

    const handleMarkerClick = (ecoponto) => {
        setSelectedEcoponto(ecoponto);
        setDefaultCenter({ lat: ecoponto.latitude, lng: ecoponto.longitude });
    };

    const handleCloseInfoWindow = () => {
        setSelectedEcoponto(null);
        setDefaultCenter({ lat: -29.1655, lng: -51.1796 });
    };

    return (
        <LoadScript googleMapsApiKey="AIzaSyAi4te69FZCGNs8J2qp-yK1jAeRrOh4j-s">
            <GoogleMap mapContainerStyle={mapStyles}
                zoom={13}
                center={defaultCenter}
            >
            {ecopontos.map(ecoponto => (
                <Marker key={ecoponto.id}
                    position={{ lat: ecoponto.latitude, lng: ecoponto.longitude }}
                    onClick={() => handleMarkerClick(ecoponto)}
                    clickable={true}
                />
            ))}
            {selectedEcoponto && (
                <InfoWindow
                    position={{ lat: selectedEcoponto.latitude, lng: selectedEcoponto.longitude }}
                    onCloseClick={handleCloseInfoWindow}
                    options={{
                        maxWidth: 300,
                        pixelOffset: new window.google.maps.Size(0, -30), // Ajuste a posição do InfoWindow em relação ao marcador
                        boxStyle: {
                            borderRadius: '8px',
                            boxShadow: '0 2px 4px rgba(0, 0, 0, 0.3)',
                            padding: '10px'
                        },
                        closeBoxURL: '', // Para remover o botão de fechar padrão
                        closeBoxMargin: '8px 8px 0 0'
                    }}>
                    <div className='infos'>
                        <h3>{selectedEcoponto.nome}</h3>
                        <p>Endereço: {selectedEcoponto.endereco}</p>
                        <p>Horário de Funcionamento: {selectedEcoponto.horarioFuncionamento}</p>
                    </div>
                </InfoWindow>
            )}
            </GoogleMap>
        </LoadScript>
    );
}

export default Map;

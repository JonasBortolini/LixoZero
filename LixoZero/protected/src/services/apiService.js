export const getEcopontos = async () => {
    try {
        const response = await fetch('http://localhost:5230/EcoPonto/ObterTodos', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        return await response.json();
    } catch (error) {
        console.error('Error fetching ecopontos:', error);
        throw error;
    }
};

export const getResiduos = async () => {
    try {
        const response = await fetch('http://localhost:5230/Residuo/ObterTodos', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        return await response.json();
    } catch (error) {
        console.error('Error fetching residuos:', error);
        throw error;
    }
};

export const getPublicacoes = async () => {
    try {
        const response = await fetch('http://localhost:5230/Publicacao/ObterTodos', {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        return await response.json();
    } catch (error) {
        console.error('Error fetching publications:', error);
        throw error;
    }
};

export const getPublicacaoById = async (id) => {
    try {
        const response = await fetch(`http://localhost:5230/Publicacao/${id}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }
        return await response.json();
    } catch (error) {
        console.error('Error fetching publication by id:', error);
        throw error;
    }
};


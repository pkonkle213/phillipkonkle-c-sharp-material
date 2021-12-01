import axios from 'axios'; // Grab axios from the installed node_modules

export default {

    getAllBugs() { // Returns a promise
        return axios.get('/bugs'); // Does a GET request to baseURL + /bugs
    },

    getBug(id) {
        return axios.get('/bugs/' + id) // GET bugs/42
    },

    addBug(newBug) {
        // Equivalent of request.AddJsonBody
        return axios.post('/bugs', newBug); // newBug is our request body
    },

    updateBug(bug) {
        return axios.put('/bugs', bug); 
    },

    deleteBug(id) {
        return axios.delete('/bugs/' + id);
    }

}
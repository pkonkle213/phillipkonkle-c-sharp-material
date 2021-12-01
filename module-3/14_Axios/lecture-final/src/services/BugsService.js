import Axios from 'axios';

// Create our Axios instance
const options = {
    baseURL: 'https://bugslist.azurewebsites.net/'
    };

// Client is what lets me make requests via Axios
const client = Axios.create(options); 

// This is the thing that gets imported from other files
export default {
    getAllBugs() {
        // Returns a Promise
        return client.get('bugs'); // No Body
    },
    getBugById(id) {
        //return client.get('bugs/' + id);
        return client.get(`bugs/${id}`); // No Body
    },
    addNewBug(bug) {
        // Include JSON for bug in the request body and do a POST
        return client.post('bugs', bug);
    },
    updateBug(updatedBug) {
        return client.put('bugs', updatedBug);
    },
    // In a sane world we'd call this deleteBug or similar ;-)
    killAndSquashBug(id) {
        return client.delete(`bugs/${id}`); // No Body
    }
}
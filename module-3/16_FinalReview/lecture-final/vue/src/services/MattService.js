import axios from 'axios';

export default {

    getAllSayings() {
        return axios.get('/mattisms');
    },

    addSaying(mattism) {
        return axios.post('/mattisms', mattism);
    }

}

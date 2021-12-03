import axios from 'axios';

export default {

    getAllSayings() {
        return axios.get('/mattisms');
    }

}

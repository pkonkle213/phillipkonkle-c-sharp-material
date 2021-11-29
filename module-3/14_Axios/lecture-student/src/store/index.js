import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  strict: true,
  state: {
    bugs: [
      {
        id: 1,
        title: 'Help, a bug is in the elevator!',
        description: 'Oh no! It\'s getting closer! Please help me!!!',
        priority: 4,
        isOpen: true,
        resolution: ''
      },
      {
        id: 2,
        title: 'Bug found in computer mainframe',
        description: 'A moth found its way into the mainframe and shorted out the computer',
        priority: 3,
        isOpen: false,
        resolution: 'Removed moth. Rebooted computer.'
      }
    ],
    nextId: 3,
  },
  mutations: {
    ADD_BUG(state, payload) {
      payload.id = state.nextId;
      state.bugs.push(payload);
      state.nextId += 1;
    },
    UPDATE_BUG(state, payload) {
      let index = state.bugs.findIndex(bug => bug.id === payload.id);

      if (index >= 0) {
        state.bugs.splice(index, 1, payload);
      }
    },
    DELETE_BUG(state, id) {
      let index = state.bugs.findIndex(bug => bug.id === id);

      if (index >= 0) {
        state.bugs.splice(index, 1);
      }
    }
  },
})

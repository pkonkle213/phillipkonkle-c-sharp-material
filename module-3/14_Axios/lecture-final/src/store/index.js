import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  strict: true,
  state: {
    bugs: [],
    nextId: 3,
  },
  mutations: {
    BUGS_LOADED(state, bugs) {
      state.bugs = bugs;
    },
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

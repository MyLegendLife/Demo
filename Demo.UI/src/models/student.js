import { getMineData, getUsersData } from '../services/student';

//request('/api/user/getstudents');

export default {
  namespace: 'student',

  state: {
    mineData: [],
    users: [],
  },

  effects: {
    *getData(_, { call, put }) {
      const response = yield call(getMineData);
      yield put({
        type: 'myGet',
        payload: response,
      });
    },
    *getUsers(_, { call, put }) {
      const response = yield call(getUsersData);
      yield put({
        type: 'users',
        payload: response,
      });
    },
  },

  reducers: {
    myGet(state, action) {
      return {
        // ...state,
        // ...payload
        mineData: action.payload,
      };
    },
    users(state, action) {
      return {
        state,
        // ...payload
        users: action.payload,
      };
    },
  },
};

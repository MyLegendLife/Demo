import { getMineData, getUsers } from '../services/student';

//request('/api/user/getstudents');

export default {
  namespace: 'student',

  state: {
    mineData: [],
    //users:[]
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
      const response = yield call(getUsers);
      yield put({
        type: 'getUsers',
        payload: response,
      });
    },
  },

  reducers: {
    myGet(state, { payload }) {
      return {
        // ...state,
        // ...payload
        mineData: payload,
      };
    },
    getUsers(state, { payload }) {
      return {
        // ...state,
        // ...payload
        users: payload,
      };
    },
  },
};

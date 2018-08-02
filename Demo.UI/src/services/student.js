import request from '../utils/request';

export async function getMineData() {
  return request('/api/user/getstudents');
}

export async function getUsersData() {
  return request('/api/user/getUsers');
}

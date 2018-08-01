import request from '../utils/request';

export async function getMineData() {
  return request('/api/user/getstudents');
}

export async function getUsers() {
  return request('/api/user/getUsers');
}

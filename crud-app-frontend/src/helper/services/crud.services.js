import apiClient from '../apiClient';

const fetchInstructors = () => apiClient.get('/instructor');

const addInstructors = (data) => apiClient.post('/instructor', data);

const updateInstructor = (data) => apiClient.put('/instructor', data);

// 

export default {
  fetchInstructors,
  addInstructors,
  updateInstructor,
};

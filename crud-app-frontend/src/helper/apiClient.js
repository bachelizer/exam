import axios from 'axios';

axios.defaults.headers.common['Access-Control-Allow-Origin'] = 'http://localhost:8081';

const data = (parsedUrl) => {
  if (parsedUrl === 'http://localhost:8081') {
    return 'http://localhost:5000';
  }
  return null;
};

export default axios.create({
  baseURL: data(window.location.origin),
  headers: {
    'Content-Type': 'application/json',
  },
});

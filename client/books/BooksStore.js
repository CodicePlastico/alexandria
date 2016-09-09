import axios from 'axios'
import promise from 'promise'

module.exports = {
	getAll: function() {
		const p = new Promise(function(res, rej) {
			axios.get('/api/book').then(function(response) {
				console.log(response);
				res(response.data);
			}).catch(function(error) {
				console.log(error);
				rej(error.message);
			});
		});
		return p;
	}
};
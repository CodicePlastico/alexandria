import React from 'react'
import Hello from './Hello'
import BooksStore from './books/BooksStore'
import Book from './books/Book'

module.exports = React.createClass({
	getInitialState: function() {
		return { books: [] };
	},
	componentDidMount: function() {
		const self = this;
		BooksStore.getAll().then(function(data) {
			console.log('Data', data)
			self.setState({ books: data });
		}).catch(function(errorMessage) {
			console.log('Error message', errorMessage)
		});
	},
    render: function() {
        return <div>
        	<Hello to="World" />
        	{this.state.books.map(book => <Book book={book} />)}
        </div>;
    }
});
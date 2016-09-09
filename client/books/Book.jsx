import React from 'react'

module.exports = React.createClass({
	render: function() {
		return <li key={this.props.book.id}>{this.props.book.id} - {this.props.book.title}</li>
	}
})
import React from 'react'

module.exports = React.createClass({
    render: function() {
        return (<span>Hello, {this.props.to || 'World'}!!!!</span>);
    }
})
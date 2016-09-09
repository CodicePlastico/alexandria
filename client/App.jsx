import React from 'react';
import ReactDOM from 'react-dom';

const Hello = React.createClass({
    render: function() {
        return (<span>Hello, {this.props.to || 'World'}!!!!</span>);
    }
});


console.log('Rendering into', document.getElementById('alexandria-app-root'));
ReactDOM.render(<Hello to="World" />, document.getElementById('alexandria-app-root'));

console.log('Rendering done');
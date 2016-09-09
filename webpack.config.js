/// <binding ProjectOpened='Watch - Development' />
module.exports = {
	entry: ["./client/App.jsx"],
	output: {
		filename: "st/dist/alexandria.js"
	},
	module: {
		loaders: [{
			test: /\.jsx?$/,
			exclude: /node_modules/,
			loader: 'babel-loader',
			query: {
				presets: ['react', 'es2015']
			}
		}]
	},
	resolve: {
		extensions: ['', '.js', '.es6', '.jsx']
	}
}